using Microsoft.Reporting.WinForms;
using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class frmreportDocOCR : Form
    {
        public string DocProveedor;
        public string IDOrden;

        public frmreportDocOCR()
        {
            InitializeComponent();
        }

        private void frmreportDocOCR_Load(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(DocProveedor))
                {
                    string sentencia = $"SELECT Correo FROM Proveedores WHERE Nombre_Proveedor = '{DocProveedor}'";
                    DataTable datos = CsComandosSql.RetornaDatos(sentencia);
                    if (datos.Rows.Count > 0)
                    {
                        txtDestinatario.Text = datos.Rows[0]["Correo"].ToString();
                    }
                }

                string sentenciaEmp = "SELECT Correo FROM Empresa WHERE ID_Empresa = 1";
                DataTable datosEmp = CsComandosSql.RetornaDatos(sentenciaEmp);
                if (datosEmp.Rows.Count > 0)
                {
                    txtCuentaEnvio.Text = datosEmp.Rows[0]["Correo"].ToString();
                }

                if (string.IsNullOrEmpty(IDOrden))
                {
                    var dt = CsComandosSql.RetornaDatos("SELECT TOP 1 ID_Orden FROM Orden_Compra ORDER BY ID_Orden DESC");
                    if (dt?.Rows.Count > 0)
                    {
                        IDOrden = dt.Rows[0]["ID_Orden"]?.ToString();
                    }

                    if (string.IsNullOrEmpty(IDOrden))
                    {
                        MessageBox.Show("No se encontraron órdenes de compra", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Close();
                        return;
                    }
                }
                txtAsunto.Text = $"Documento de Orden de Compra: {IDOrden}";
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
                reportViewer1.LocalReport.ReportEmbeddedResource = "ModuloDeCompra_BD.Reporte.rpt_DocumentoOCR.rdlc";

                // Verificar que el recurso del reporte existe
                var assembly = Assembly.GetExecutingAssembly();
                var resourceName = "ModuloDeCompra_BD.Reporte.rpt_DocumentoOCR.rdlc";

                if (!assembly.GetManifestResourceNames().Contains(resourceName))
                {
                    throw new Exception($"El recurso embebido '{resourceName}' no se encontró. Verifique:\n" +
                                      "1. Que el reporte esté en la carpeta 'Reporte'\n" +
                                      "2. Que la propiedad 'Build Action' del archivo .rdlc esté como 'Embedded Resource'\n" +
                                      "3. Que el namespace sea correcto");
                }

                // 2. Configurar parámetros
                List<ReportParameter> parametros = new List<ReportParameter>();
                parametros.Add(new ReportParameter("ID_Orden", IDOrden));

                // Verificar que los parámetros existen en el reporte
                var parametrosReporte = reportViewer1.LocalReport.GetParameters();
                foreach (var param in parametros)
                {
                    if (!parametrosReporte.Any(p => p.Name == param.Name))
                    {
                        throw new Exception($"El parámetro '{param.Name}' no existe en el reporte");
                    }
                }

                reportViewer1.LocalReport.SetParameters(parametros);

                // 3. Obtener datos
                DataTable datosOrden = ObtenerDatosOrden();
                DataTable datosTotales = ObtenerDatosTotales();

                if (datosOrden.Rows.Count == 0)
                {
                    throw new Exception("No se encontraron datos para la orden especificada");
                }

                // 4. Configurar DataSources
                // Verificar nombres de DataSources en el reporte
                var dataSources = reportViewer1.LocalReport.GetDataSourceNames();
                if (!dataSources.Contains("dsDocOCR"))
                {
                    throw new Exception("El DataSource 'dsDocOCR' no existe en el reporte");
                }

                if (!dataSources.Contains("dsTotales"))
                {
                    throw new Exception("El DataSource 'dsTotales' no existe en el reporte");
                }

                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsDocOCR", datosOrden));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsTotales", datosTotales));

                // 5. Configurar visualización
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;

                // Forzar actualización completa
                reportViewer1.LocalReport.Refresh();
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                string errorDetails = $"Error al configurar el reporte:\n{ex.Message}";

                if (ex.InnerException != null)
                {
                    errorDetails += $"\n\nDetalles adicionales:\n{ex.InnerException.Message}";
                }

                MessageBox.Show(errorDetails, "Error en el Reporte",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);

                Debug.WriteLine($"ERROR EN REPORTE: {errorDetails}\nStack Trace: {ex.StackTrace}");
            }
        }

        private DataTable ObtenerDatosOrden()
        {
            try
            {
                string query = @"SELECT 
                oc.ID_Orden,
                oc.Fecha_Orden,
                oc.Fecha_Limite,
                DATEDIFF(day, oc.Fecha_Orden, oc.Fecha_Limite) AS DiasPlazo,
                p.NroDocumento AS rucProvComp, 
                p.Nombre_Proveedor AS nombProvOrdCom,
                p.Direccion AS dircProvComp, 
                p.Correo AS emailProvComp,
                p.NroTelefono AS telProvComp, 
                sol.Nombre + ' ' + sol.Apellido AS nomperSolOrdCom,
                depSol.Nombre_Departamento AS AreaSolicitante,
                r.MotivoRequisicion AS MotivoSolicitud,
                u.Nombre + ' ' + u.Apellido AS nomperAutOrdCom,
                d.Nombre_Departamento AS AreaAutorizante,
                e.Nombre_Empresa, 
                e.RUC,
                e.Direccion, 
                e.Telefono, 
                e.Correo, 
                e.Logo_Empresa,
                det.ID_Detail, 
                det.Cantidad AS cantOrdComDet,
                COALESCE(pr.NomProducto, sv.Nom_Servicio) AS descOrdComDet,
                CAST(COALESCE(det.Costo, pr.Costo, sv.Costo) AS DECIMAL(10,2)) AS UnitOrdComDet,
                CAST(det.Cantidad * COALESCE(det.Costo, pr.Costo, sv.Costo) AS DECIMAL(10,2)) AS varOrdComDet,
                CAST(det.Descuento AS DECIMAL(10,2)) AS Descuento,
                CASE 
                    WHEN det.ID_Producto IS NOT NULL THEN 'Producto'
                    WHEN det.ID_Servicio IS NOT NULL THEN 'Servicio'
                END AS TipoItem
            FROM Orden_Compra oc
            INNER JOIN Proveedores p ON oc.ID_Proveedor = p.ID_Proveedor
            INNER JOIN Usuario u ON oc.ID_Usuario = u.ID_Usuario
            INNER JOIN Departamento d ON u.ID_Depa = d.ID_Depa
            LEFT JOIN Requisicion r ON oc.ID_REQUI = r.ID_Requisicion
            LEFT JOIN Usuario sol ON r.ID_Usuario = sol.ID_Usuario
            LEFT JOIN Departamento depSol ON sol.ID_Depa = depSol.ID_Depa
            INNER JOIN Detalle_Orden det ON oc.ID_Orden = det.ID_Orden
            LEFT JOIN Producto pr ON det.ID_Producto = pr.ID_Producto
            LEFT JOIN Servicio sv ON det.ID_Servicio = sv.ID_Servicio
            CROSS JOIN Empresa e
            WHERE oc.ID_Orden = @ID_Orden";

                SqlParameter param = new SqlParameter("@ID_Orden", SqlDbType.Int);
                param.Value = Convert.ToInt32(IDOrden);

                return CsComandosSql.RetornaDatosConParametro(query, param);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener datos de la orden: {ex.Message}", ex);
            }
        }

        private DataTable ObtenerDatosTotales()
        {
            try
            {
                string query = @"SELECT 
                CAST(SUM(CASE WHEN det.ID_Producto IS NOT NULL THEN det.Cantidad * COALESCE(det.Costo, pr.Costo) ELSE 0 END) AS DECIMAL(10,2)) AS subtotalProductos,
                CAST(SUM(CASE WHEN det.ID_Servicio IS NOT NULL THEN det.Cantidad * COALESCE(det.Costo, sv.Costo) ELSE 0 END) AS DECIMAL(10,2)) AS subtotalServicios,
                CAST(SUM(det.Cantidad * COALESCE(det.Costo, pr.Costo, sv.Costo)) AS DECIMAL(10,2)) AS subtOrdCom,
                CAST(ISNULL(SUM(det.Descuento), 0) AS DECIMAL(10,2)) AS valdescOrdCom,
                CAST(SUM(CASE WHEN det.ID_Producto IS NOT NULL THEN det.Cantidad * COALESCE(det.Costo, pr.Costo) * 0.15 ELSE 0 END) AS DECIMAL(10,2)) AS valIVAOrdCom,
                CAST(SUM(det.Cantidad * COALESCE(det.Costo, pr.Costo, sv.Costo) * 1.15) - ISNULL(SUM(det.Descuento), 0) AS DECIMAL(10,2)) AS totalOrdCom
            FROM Detalle_Orden det
            LEFT JOIN Producto pr ON det.ID_Producto = pr.ID_Producto
            LEFT JOIN Servicio sv ON det.ID_Servicio = sv.ID_Servicio
            WHERE det.ID_Orden = @ID_Orden";

                SqlParameter param = new SqlParameter("@ID_Orden", SqlDbType.Int);
                param.Value = Convert.ToInt32(IDOrden);

                return CsComandosSql.RetornaDatosConParametro(query, param);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al obtener totales de la orden: {ex.Message}", ex);
            }
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
                // 1. Mostrar diálogo para guardar el PDF
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
                    $"Orden de Compra por Requisición {IDOrden}" : txtAsunto.Text;
                objCorreo.CUERPO = string.IsNullOrEmpty(txtCuerpo.Text) ?
                    $"Adjunto encontrará la Orden de Compra por Requisición {IDOrden}." : txtCuerpo.Text;
                objCorreo.ADJUNTO = pdfPath;

                // Mostrar progreso
                Cursor.Current = Cursors.WaitCursor;

                if (objCorreo.Enviar())
                {
                    MessageBox.Show("Documento guardado y enviado correctamente", "Éxito",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAsunto.Text = string.Empty;
                    txtCuerpo.Text = string.Empty;
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
            saveFileDialog.FileName = $"OrdenCompraRequisicion_{IDOrden}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
            saveFileDialog.DefaultExt = ".pdf";
            saveFileDialog.AddExtension = true;

            // Sugerir la carpeta de Descargas por defecto
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads\\";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Configuración para evitar el error de renderización
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

                    // Guardar el PDF en la ubicación seleccionada
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

            return null; // Usuario canceló la operación
        }
    }
}
