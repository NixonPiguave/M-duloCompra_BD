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

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmListadoDiario: Form
    {
        string DiarioID;
        string Anio;
        string Periodo;
        public string ID { get => DiarioID; set => DiarioID = value; }
        public string Anio1 { get => Anio; set => Anio = value; }
        public string Periodo1 { get => Periodo; set => Periodo = value; }

        public FrmListadoDiario()
        {
            InitializeComponent();
        }

        private void FrmListadoCategoria_Load(object sender, EventArgs e)
        {
            frmReporteDiarioContable diario = new frmReporteDiarioContable();
            MessageBox.Show($"{Anio1}, {Periodo1}");
            string query = $"select * from DiarioCont_Header where YEAR(Fecha) = {Anio} and MONTH(Fecha) = {Periodo1}";
            dgvListadoDiario.DataSource = CsComandosSql.RetornaDatos(query);
        }

        private void btnSeleccionarCatego_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvListadoDiario.CurrentCell.RowIndex;
                txtDiarioContable.Text = dgvListadoDiario[0, fila].Value.ToString();
                ID = dgvListadoDiario[0, fila].Value.ToString();
                MessageBox.Show("Diario seleccionado");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error al seleccionar");
            }
        }
    }
}
