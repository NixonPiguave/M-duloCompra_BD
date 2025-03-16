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
    public partial class frmreport: Form
    {
        string Sentencia;
        string DsInforme;
        string RptInforme;
        private void frmreport_Load(object sender, EventArgs e)
        {
            DataTable Dt = new DataTable();
            ReportDataSource dataset = new ReportDataSource();
            reportViewer1.LocalReport.DataSources.Clear();
            Dt = CsComandosSql.RetornaDatos(Sentencia);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ModuloDeCompra_BD." + RptInforme;
            try
            {
                dataset = new ReportDataSource(DsInforme, Dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            reportViewer1.LocalReport.DataSources.Add(dataset);
            dataset.Value = Dt;
            this.reportViewer1.RefreshReport();
        }
        public frmreport(string sentencia, string informe, string rptInforme)
        {
            InitializeComponent();
            Sentencia = sentencia;
            DsInforme = informe;
            RptInforme = rptInforme;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
