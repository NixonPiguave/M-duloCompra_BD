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
    public partial class FrmListadoOrdenCompra: Form
    {
        CsCategoria cate = new CsCategoria();
        string Nombre;
        int IdCat;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int IdCat1 { get => IdCat; set => IdCat = value; }

        public FrmListadoOrdenCompra()
        {
            InitializeComponent();

        }

        private void FrmListadoOrdenCompra_Load(object sender, EventArgs e)
        {

            dgvListadoOrdenCompra.DataSource = CsComandosSql.RetornaDatos("Select * from Orden_Compra");
        }

        private void btnSeleccionarCatego_Click(object sender, EventArgs e)
        {
            int fila = dgvListadoOrdenCompra.CurrentCell.RowIndex;
            txtOrdenCompraID.Text = dgvListadoOrdenCompra[0, fila].Value.ToString();
            Nombre = dgvListadoOrdenCompra[1, fila].Value.ToString();
            IdCat = Convert.ToInt32(dgvListadoOrdenCompra[0, fila].Value);
            MessageBox.Show("Oredn de Compra seleccionada");
        }

        private void txtBuscarCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoOrdenCompra.DataSource = cate.ListaCategoria(txtOrdenCompraID.Text);
        }
    }
}
