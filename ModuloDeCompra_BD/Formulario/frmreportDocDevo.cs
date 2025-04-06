using Microsoft.Reporting.WinForms;
using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class frmreportDocDevo : Form
    {
        public string ID_RTV; 

        public frmreportDocDevo()
        {
            InitializeComponent();
        }

        private void frmreportDocDevo_Load(object sender, EventArgs e)
        {
            try
            {

                if (!string.IsNullOrEmpty(ID_RTV))
                {
                    string queryProveedor = @"SELECT p.Nombre_Proveedor, p.Correo 
                                       FROM RTV_Header rtv
                                       INNER JOIN Proveedores p ON rtv.ID_Proveedor = p.ID_Proveedor
                                       WHERE rtv.ID_RTV = @ID_RTV";

                    SqlParameter param = new SqlParameter("@ID_RTV", SqlDbType.Int);
                    param.Value = Convert.ToInt32(ID_RTV);

                    DataTable datosProv = CsComandosSql.RetornaDatosConParametro(queryProveedor, param);
                    if (datosProv.Rows.Count > 0)
                    {
                        txtDestinatario.Text = datosProv.Rows[0]["Correo"].ToString();
                    }
                }


                string sentenciaEmp = "SELECT Correo FROM Empresa WHERE ID_Empresa = 1";
                DataTable datosEmp = CsComandosSql.RetornaDatos(sentenciaEmp);
                if (datosEmp.Rows.Count > 0)
                {
                    txtCuentaEnvio.Text = datosEmp.Rows[0]["Correo"].ToString();
                }


                if (string.IsNullOrEmpty(ID_RTV))
                {
                    var dt = CsComandosSql.RetornaDatos("SELECT TOP 1 ID_RTV FROM RTV_Header ORDER BY ID_RTV DESC");
                    if (dt?.Rows.Count > 0)
                    {
                        ID_RTV = dt.Rows[0]["ID_RTV"]?.ToString();
                    }

                    if (string.IsNullOrEmpty(ID_RTV))
                    {
                        MessageBox.Show("No se encontraron devoluciones registradas", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                }

                ConfigurarReporte();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inicializar el formulario: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void ConfigurarReporte()
        {
            try
            {
                // 1. Limpiar datos previos
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "ModuloDeCompra_BD.Reporte.rpt_DocumentoDevo.rdlc";

                // Verificar que el recurso del reporte existe
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "ModuloDeCompra_BD.Reporte.rpt_DocumentoDevo.rdlc";

                if (!assembly.GetManifestResourceNames().Contains(resourceName))
                {
                    throw new Exception($"El recurso embebido '{resourceName}' no se encontró.");
                }

                // 2. Configurar parámetro
                ReportParameter parametro = new ReportParameter("ID_RTV", ID_RTV);
                reportViewer1.LocalReport.SetParameters(parametro);

                // 3. Obtener y combinar datos
                DataTable datosCombinados = ObtenerDatosCombinados();

                if (datosCombinados.Rows.Count == 0)
                {
                    throw new Exception("No se encontraron datos para la devolución especificada");
                }

                // 4. Configurar DataSource único
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsDocDEV", datosCombinados));

                // 5. Configurar visualización
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                // 6. Refrescar reporte
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al configurar el reporte: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ObtenerDatosCombinados()
        {
            // Obtener datos principales
            DataTable datosDevolucion = ObtenerDatosDevolucion();

            // Obtener totales
            DataTable datosTotales = ObtenerTotalesDevolucion();

            // Crear nueva tabla combinada
            DataTable datosCombinados = datosDevolucion.Clone();

            // Agregar columnas para los totales
            datosCombinados.Columns.Add("TotalProductos", typeof(decimal));
            datosCombinados.Columns.Add("TotalServicios", typeof(decimal));
            datosCombinados.Columns.Add("TotalGeneral", typeof(decimal));

            // Copiar datos principales
            foreach (DataRow row in datosDevolucion.Rows)
            {
                DataRow newRow = datosCombinados.NewRow();

                // Copiar valores de datosDevolucion
                foreach (DataColumn col in datosDevolucion.Columns)
                {
                    newRow[col.ColumnName] = row[col.ColumnName];
                }

                // Agregar valores de totales (solo en la primera fila)
                if (datosCombinados.Rows.Count == 0 && datosTotales.Rows.Count > 0)
                {
                    newRow["TotalProductos"] = datosTotales.Rows[0]["TotalProductos"];
                    newRow["TotalServicios"] = datosTotales.Rows[0]["TotalServicios"];
                    newRow["TotalGeneral"] = datosTotales.Rows[0]["TotalGeneral"];
                }

                datosCombinados.Rows.Add(newRow);
            }

            // Si no hay filas, agregar una con los totales
            if (datosCombinados.Rows.Count == 0 && datosTotales.Rows.Count > 0)
            {
                DataRow newRow = datosCombinados.NewRow();
                newRow["TotalProductos"] = datosTotales.Rows[0]["TotalProductos"];
                newRow["TotalServicios"] = datosTotales.Rows[0]["TotalServicios"];
                newRow["TotalGeneral"] = datosTotales.Rows[0]["TotalGeneral"];
                datosCombinados.Rows.Add(newRow);
            }

            return datosCombinados;
        }
        private DataTable ObtenerDatosDevolucion()
        {
            string query = @"SELECT 
            e.Nombre_Empresa,
            e.RUC AS RUC_Empresa,
            e.Direccion AS Direccion_Empresa,
            e.Telefono AS Telefono_Empresa,
            e.Correo AS Correo_Empresa,
            e.Logo_Empresa,
            p.Nombre_Proveedor,
            p.NroDocumento AS RUC_Proveedor,
            p.Direccion AS Direccion_Proveedor,
            p.NroTelefono AS Telefono_Proveedor,
            p.Correo AS Correo_Proveedor,
            rtv.ID_RTV,
            rtv.Fecha_RTV,
            rtv.Motivo,
            rd.ID_RTVDetails,
            rd.Cantidad,
            COALESCE(pr.NomProducto, sv.Nom_Servicio) AS Descripcion,
            CAST(COALESCE(pr.Costo, sv.Costo) AS DECIMAL(10,2)) AS Costo_Unitario,
            CAST(rd.Cantidad * COALESCE(pr.Costo, sv.Costo) AS DECIMAL(10,2)) AS Total_Linea,
            CASE 
                WHEN rd.ID_Producto IS NOT NULL THEN 'Producto'
                WHEN rd.ID_Servicio IS NOT NULL THEN 'Servicio'
            END AS Tipo_Item
        FROM RTV_Header rtv
        INNER JOIN Proveedores p ON rtv.ID_Proveedor = p.ID_Proveedor
        INNER JOIN RTV_Details rd ON rtv.ID_RTV = rd.ID_RTV
        LEFT JOIN Producto pr ON rd.ID_Producto = pr.ID_Producto
        LEFT JOIN Servicio sv ON rd.ID_Servicio = sv.ID_Servicio
        CROSS JOIN Empresa e
        WHERE rtv.ID_RTV = @ID_RTV";

            SqlParameter param = new SqlParameter("@ID_RTV", SqlDbType.Int);
            param.Value = Convert.ToInt32(ID_RTV);

            return CsComandosSql.RetornaDatosConParametro(query, param);
        }

        private DataTable ObtenerTotalesDevolucion()
        {
            string query = @"SELECT 
            CAST(SUM(CASE WHEN rd.ID_Producto IS NOT NULL THEN rd.Cantidad * COALESCE(pr.Costo, 0) ELSE 0 END) AS DECIMAL(10,2)) AS TotalProductos,
            CAST(SUM(CASE WHEN rd.ID_Servicio IS NOT NULL THEN rd.Cantidad * COALESCE(sv.Costo, 0) ELSE 0 END) AS DECIMAL(10,2)) AS TotalServicios,
            CAST(SUM(rd.Cantidad * COALESCE(pr.Costo, sv.Costo, 0)) AS DECIMAL(10,2)) AS TotalGeneral
        FROM RTV_Details rd
        LEFT JOIN Producto pr ON rd.ID_Producto = pr.ID_Producto
        LEFT JOIN Servicio sv ON rd.ID_Servicio = sv.ID_Servicio
        WHERE rd.ID_RTV = @ID_RTV";

            SqlParameter param = new SqlParameter("@ID_RTV", SqlDbType.Int);
            param.Value = Convert.ToInt32(ID_RTV);

            return CsComandosSql.RetornaDatosConParametro(query, param);
        }

        private void btnEnviarDoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCuentaEnvio.Text) || string.IsNullOrEmpty(txtDestinatario.Text))
            {
                MessageBox.Show("Por favor complete los campos de correo electrónico", "Advertencia",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string pdfPath = GuardarPDFConDialogo();

                if (string.IsNullOrEmpty(pdfPath))
                {
                    MessageBox.Show("Operación cancelada por el usuario", "Información",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                CsEmail objCorreo = new CsEmail("smtp.gmail.com", 587, true, txtCuentaEnvio.Text, "arcu tgpr psrq zqga", "BIG DATA");
                objCorreo.PARA = txtDestinatario.Text;
                objCorreo.ASUNTO = string.IsNullOrEmpty(txtAsunto.Text) ?
                    $"Devolución a Proveedor {ID_RTV}" : txtAsunto.Text;
                objCorreo.CUERPO = string.IsNullOrEmpty(txtCuerpo.Text) ?
                    $"Adjunto encontrará el documento de Devolución a Proveedor {ID_RTV}." : txtCuerpo.Text;
                objCorreo.ADJUNTO = pdfPath;

                Cursor.Current = Cursors.WaitCursor;

                if (objCorreo.Enviar())
                {
                    MessageBox.Show("Documento guardado y enviado correctamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("El documento se guardó pero no se pudo enviar el correo", "Advertencia",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar documento: {ex.Message}\n\nStack Trace:\n{ex.StackTrace}",
                               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private string GuardarPDFConDialogo()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FileName = $"DevolucionProveedor_{ID_RTV}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            saveFileDialog.DefaultExt = ".pdf";
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string deviceInfo = @"<DeviceInfo>
                    <OutputFormat>PDF</OutputFormat>
                    <HumanReadablePDF>True</HumanReadablePDF>
                    <EmbedFonts>None</EmbedFonts>
                </DeviceInfo>";

                    Warning[] warnings;
                    string[] streamids;
                    string mimeType;
                    string encoding;
                    string extension;

                    byte[] bytes = reportViewer1.LocalReport.Render(
                        "PDF",
                        deviceInfo,
                        out mimeType,
                        out encoding,
                        out extension,
                        out streamids,
                        out warnings);

                    File.WriteAllBytes(saveFileDialog.FileName, bytes);
                    return saveFileDialog.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar PDF: {ex.Message}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
            }

            return null;
        }
    }
}
