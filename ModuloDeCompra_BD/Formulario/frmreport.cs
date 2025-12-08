using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ModuloDeCompra_BD.Clases;

namespace reporte
{
    public partial class frmreport : Form
    {
        private string Sentencia;
        private string DsInforme;
        private string RptInforme;
        private byte[] imagenLogo;

        public frmreport(string sentencia, string informe, string rptInforme)
        {
            InitializeComponent();
            Sentencia = sentencia;
            DsInforme = informe;
            RptInforme = rptInforme;

            // Siempre obtener el logo de la empresa
            DataTable dtEmpresa = CsComandosSql.RetornaDatos("Select Logo_Empresa from [MC-Empresa] where ID_Empresa = 1");
            if (dtEmpresa.Rows.Count > 0 && dtEmpresa.Rows[0]["Logo_Empresa"] != DBNull.Value)
            {
                imagenLogo = (byte[])dtEmpresa.Rows[0]["Logo_Empresa"];
            }
        }

        private void frmreport_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener datos principales
                DataTable DtPrincipal = CsComandosSql.RetornaDatos(Sentencia);

                // 2. Obtener datos completos de empresa (para dsEmpresa)
                DataTable DtEmpresa = CsComandosSql.RetornaDatos("Select * from [MC-Empresa] where ID_Empresa = 1");

                // 3. Configurar reporte
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "ModuloDeCompra_BD." + RptInforme;

                // 4. Agregar todos los orígenes de datos
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource(DsInforme, DtPrincipal));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("dsEmpresa", DtEmpresa));

                // 5. Configurar parámetro de imagen (aunque sea null)
                ReportParameter parametroImagen = new ReportParameter("LogoEmpresa",
                    imagenLogo != null ? Convert.ToBase64String(imagenLogo) : null);
                reportViewer1.LocalReport.SetParameters(parametroImagen);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar el reporte: {ex.Message}\n\nDetalle técnico:\n{ex.StackTrace}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }

}

