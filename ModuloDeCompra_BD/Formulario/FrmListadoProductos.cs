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
    public partial class FrmListadoProductos: Form
    {
        int orden;
        public int Orden { get => orden; set => orden = value; }
        string producto;
        public string Producto { get => producto; set => producto = value; }
        public FrmListadoProductos()
        {
            InitializeComponent();
        }

        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            dgvListadoProductos.DataSource = CsComandosSql.RetornaDatos($"select RE.Producto from Orden_Compra as O inner join Requisicion as R on O.ID_REQUI = R.ID_Requisicion inner join Requi_Details as RE on RE.ID_Requisicion = R.ID_Requisicion where O.ID_Orden = {Orden}");
        }

        private void btnSeleccionarProductos_Click(object sender, EventArgs e)
        {
            int fila = dgvListadoProductos.CurrentCell.RowIndex;
            txtBuscarProductos.Text = dgvListadoProductos[0, fila].Value.ToString();
            Producto = dgvListadoProductos[0, fila].Value.ToString();
            MessageBox.Show("Producto seleccionado");
        }
    }
}
