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
    public partial class FrmListadoCategoria: Form
    {
        CsCategoria cate = new CsCategoria();
        string Nombre;
        int IdCat;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int IdCat1 { get => IdCat; set => IdCat = value; }

        public FrmListadoCategoria()
        {
            InitializeComponent();

        }

        private void FrmListadoCategoria_Load(object sender, EventArgs e)
        {

            dgvListadoCategoria.DataSource = cate.ListaCategoria("");
        }

        private void btnSeleccionarCatego_Click(object sender, EventArgs e)
        {
            int fila = dgvListadoCategoria.CurrentCell.RowIndex;
            txtBuscarCategoria.Text = dgvListadoCategoria[1, fila].Value.ToString();
            Nombre= dgvListadoCategoria[1, fila].Value.ToString();
            IdCat= Convert.ToInt32(dgvListadoCategoria[0, fila].Value);
            MessageBox.Show("Categoria seleccionada");
            this.Close();
        }

        private void txtBuscarCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoCategoria.DataSource = cate.ListaCategoria(txtBuscarCategoria.Text);
        }
    }
}
