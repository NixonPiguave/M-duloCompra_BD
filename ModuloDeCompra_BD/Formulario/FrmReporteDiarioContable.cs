using ModuloDeCompra_BD.Clases;
using reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class frmReporteDiarioContable : Form
    {
        public frmReporteDiarioContable()
        {
            InitializeComponent();
        }

        private void frmReporteDiarioContable_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDiario_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAnio.Text) || !string.IsNullOrEmpty(txtDiarioID.Text) || cmbPeriodos.SelectedIndex == -1)
            {
                string periodo = cmbPeriodos.SelectedItem.ToString();
                FrmListadoDiario diario = new FrmListadoDiario();
                diario.Anio1 = txtAnio.Text;
                diario.Periodo1 = periodo;
                diario.ShowDialog();
                txtDiarioID.Text = diario.ID;
            }
            else
                MessageBox.Show("Rellene los campos");
        }
    }
}
