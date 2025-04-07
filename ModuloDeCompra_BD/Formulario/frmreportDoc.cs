using Microsoft.Reporting.WinForms;
using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class frmreportDoc : Form
    {
        public string DocProveedor;
        public string IDOrden;

        public frmreportDoc()
        {
            InitializeComponent();
        }

        private void frmreportDoc_Load(object sender, EventArgs e)
        {

            string nombreProveedor = DocProveedor;
            string sentencia = $"select Correo from Proveedores where Nombre_Proveedor = '{nombreProveedor}'";
            DataTable datos = CsComandosSql.RetornaDatos(sentencia);
            if (datos.Rows.Count > 0)
            {
                txtDestinatario.Text = datos.Rows[0]["Correo"].ToString();
            }

            string sentenciaEmp = $"select Correo from Empresa where ID_Empresa = 1";
            DataTable datosEmp = CsComandosSql.RetornaDatos(sentenciaEmp);
            if (datosEmp.Rows.Count > 0)
            {
                txtCuentaEnvio.Text = datosEmp.Rows[0]["Correo"].ToString();
            }

            if (string.IsNullOrEmpty(IDOrden))
            {
                var dt = CsComandosSql.RetornaDatos("SELECT TOP 1 ID_Orden FROM Orden_Compra ORDER BY ID_Orden DESC");
                IDOrden = dt?.Rows[0]?["ID_Orden"]?.ToString();

                if (string.IsNullOrEmpty(IDOrden))
                {
                    MessageBox.Show("No se encontraron órdenes de compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }
            txtAsunto.Text = $"Documento de Orden de Compra: {IDOrden}";
            ConfigurarReporte();
            FormatearReporte();
        }
       
        private void ConfigurarReporte()
        {
            try
            {
                // 1. Limpiar datos previos
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "ModuloDeCompra_BD.Reporte.rpt_DocumentoOCD.rdlc";

                // 2. Configurar parámetro
                ReportParameter parametro = new ReportParameter("ID_Orden", IDOrden);
                reportViewer1.LocalReport.SetParameters(parametro);

                // 3. Obtener datos para los DataSets
                DataTable datosOrden = ObtenerDatosOrden();
                DataTable datosTotales = ObtenerDatosTotales();

                // 4. Configurar las fuentes de datos
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsDocOCD", datosOrden));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsTotalesOCD", datosTotales));

                // 5. Refrescar el reporte
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el reporte: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormatearReporte()
        {
            // Asegurar que los totales se muestren con 2 decimales
            foreach (ReportParameterInfo param in reportViewer1.LocalReport.GetParameters())
            {
                if (param.Name == "valIVAOrdCom" || param.Name == "totalOrdCom" ||
                    param.Name == "subtotalProductos" || param.Name == "subtotalServicios")
                {
                    reportViewer1.LocalReport.SetParameters(new ReportParameter(param.Name,
                        string.Format("{0:#,##0.00}", param.Values.FirstOrDefault())));
                }
            }

            reportViewer1.RefreshReport();
        }

        private DataTable ObtenerDatosOrden()
        {
            string query = @"SELECT oc.ID_Orden, oc.Fecha_Orden, oc.Fecha_Limite, DATEDIFF(day, oc.Fecha_Orden, oc.Fecha_Limite) AS DiasPlazo,
        p.NroDocumento AS rucProvComp, p.Nombre_Proveedor AS nombProvOrdCom, p.Direccion AS dircProvComp, p.Correo AS emailProvComp,
        p.NroTelefono AS telProvComp, u.Nombre + ' ' + u.Apellido AS nomperSolOrdCom, d.Nombre_Departamento AS AreaSolicitante, 
        e.Nombre_Empresa, e.RUC, e.Direccion, e.Telefono, e.Correo, e.Logo_Empresa, det.ID_Detail, det.Cantidad AS cantOrdComDet,
        COALESCE(pr.NomProducto, sv.Nom_Servicio) AS descOrdComDet, CAST(COALESCE(det.Costo, pr.Costo, sv.Costo) AS DECIMAL(10,2)) AS UnitOrdComDet,
        CAST(det.Cantidad * COALESCE(det.Costo, pr.Costo, sv.Costo) AS DECIMAL(10,2)) AS varOrdComDet, CAST(det.Descuento AS DECIMAL(10,2)) AS Descuento,
        CASE 
            WHEN det.ID_Producto IS NOT NULL THEN 'Producto'
            WHEN det.ID_Servicio IS NOT NULL THEN 'Servicio'
        END AS TipoItem
        FROM Orden_Compra oc
        INNER JOIN Proveedores p ON oc.ID_Proveedor = p.ID_Proveedor
        INNER JOIN Usuario u ON oc.ID_Usuario = u.ID_Usuario
        INNER JOIN Departamento d ON u.ID_Depa = d.ID_Depa
        INNER JOIN Detalle_Orden det ON oc.ID_Orden = det.ID_Orden
        LEFT JOIN Producto pr ON det.ID_Producto = pr.ID_Producto
        LEFT JOIN Servicio sv ON det.ID_Servicio = sv.ID_Servicio
        CROSS JOIN Empresa e
        WHERE oc.ID_Orden = @IDOrden";

            SqlParameter param = new SqlParameter("@IDOrden", SqlDbType.Int);
            param.Value = Convert.ToInt32(IDOrden);

            return CsComandosSql.RetornaDatosConParametro(query, param);
        }
        private DataTable ObtenerDatosTotales()
        {
            string query = @"SELECT 
    CAST(SUM(CASE WHEN det.ID_Servicio IS NOT NULL THEN det.Cantidad * COALESCE(det.Costo, sv.Costo) ELSE 0 END) AS DECIMAL(10,2)) AS subtotalServicios,
    CAST(SUM(CASE WHEN det.ID_Producto IS NOT NULL THEN det.Cantidad * COALESCE(det.Costo, pr.Costo) ELSE 0 END) AS DECIMAL(10,2)) AS subtotalProductos,
    CAST(SUM(det.Cantidad * COALESCE(det.Costo, pr.Costo, sv.Costo)) AS DECIMAL(10,2)) AS subtOrdCom,
    CAST(ISNULL(SUM(det.Descuento), 0) AS DECIMAL(10,2)) AS valdescOrdCom,
    CAST(SUM(CASE WHEN det.ID_Producto IS NOT NULL THEN det.Cantidad * COALESCE(det.Costo, pr.Costo) * 0.15 ELSE 0 END) AS DECIMAL(10,2)) AS valIVAOrdCom,
    CAST(SUM(CASE WHEN det.ID_Producto IS NOT NULL THEN det.Cantidad * COALESCE(det.Costo, pr.Costo) * 1.15 ELSE det.Cantidad * COALESCE(det.Costo, sv.Costo) END) - ISNULL(SUM(det.Descuento), 0) AS DECIMAL(10,2)) AS totalOrdCom
FROM Detalle_Orden det
LEFT JOIN Producto pr ON det.ID_Producto = pr.ID_Producto
LEFT JOIN Servicio sv ON det.ID_Servicio = sv.ID_Servicio
WHERE det.ID_Orden = @IDOrden";

            SqlParameter param = new SqlParameter("@IDOrden", SqlDbType.Int);
            param.Value = Convert.ToInt32(IDOrden);

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
                // 1. Mostrar diálogo para guardar el PDF
                string pdfPath = GuardarPDFConDialogo();

                if (string.IsNullOrEmpty(pdfPath))
                {
                    MessageBox.Show("Operación cancelada por el usuario", "Información",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 2. Configurar y enviar el correo con el PDF adjunto
                CsEmail objCorreo = new CsEmail("smtp.gmail.com", 587, true, txtCuentaEnvio.Text, "arcu tgpr psrq zqga", "BIG DATA");

                //CsEmail objCorreo = new CsEmail("smtp.gmail.com", 587, true, "nixonpiguave2019@gmail.com", "ygqy wsgx chzn fwqr", "Nixon Piguave");
                objCorreo.PARA = txtDestinatario.Text;
                objCorreo.ASUNTO = string.IsNullOrEmpty(txtAsunto.Text) ?
                    $"Orden de Compra {IDOrden}" : txtAsunto.Text;
                objCorreo.CUERPO = string.IsNullOrEmpty(txtCuerpo.Text) ?
                    $"Adjunto encontrará la Orden de Compra {IDOrden}." : txtCuerpo.Text;
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
            saveFileDialog.FileName = $"OrdenCompra_{IDOrden}_{DateTime.Now:yyyyMMddHHmmss}.pdf";
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
