using ModuloDeCompra_BD.Clases;
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
    public partial class FrmListadoDepa: Form
    {
        string Nombre;
        int IdCat;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int IdCat1 { get => IdCat; set => IdCat = value; }

        public FrmListadoDepa()
        {
            InitializeComponent();

        }

        private void FrmListadoCategoria_Load(object sender, EventArgs e)
        {

            dgvListadoCategoria.DataSource = CsComandosSql.RetornaDatos("select * from [MC-Departamento]");
        }

        private void btnSeleccionarCatego_Click(object sender, EventArgs e)
        {
            int fila = dgvListadoCategoria.CurrentCell.RowIndex;
            txtBuscarCategoria.Text = dgvListadoCategoria[1, fila].Value.ToString();
            Nombre= dgvListadoCategoria[1, fila].Value.ToString();
            IdCat= Convert.ToInt32(dgvListadoCategoria[0, fila].Value);
            MessageBox.Show("Departamento seleccionado");
        }

        private void txtBuscarCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoCategoria.DataSource = CsComandosSql.RetornaDatos($"select * from [MC-Departamento] where Nombre_Departamento like '%{txtBuscarCategoria.Text}%'");
        }
    }
}
