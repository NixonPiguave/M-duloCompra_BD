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
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnreport_Click(object sender, System.EventArgs e)
        {
            string sentencia = "select * from Orden_Compra";
            frmreport ventas = new frmreport(sentencia, "dsCompra", "rptCompra.rdlc");
            ventas.ShowDialog();
        }
    }
}
