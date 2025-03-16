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
    public partial class FrmRTV: Form
    {

        public FrmRTV()
        {
            InitializeComponent();
        }

        private void FrmRTV_Load(object sender, EventArgs e)
        {
            
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int ProveedorID = Convert.ToInt32(dgvRequisiciones[6, 0].Value.ToString());
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            FrmListadoOrdenCompra frmOrden = new FrmListadoOrdenCompra();
            frmOrden.ShowDialog();
            txtOrdenCompraID.Text = frmOrden.IdCat1.ToString();
            int proveedor = Convert.ToInt32(dgvRequisiciones[6, 0].Value.ToString());
            dgvAux.DataSource = CsComandosSql.RetornaDatos($"select P.Nombre_Proveedor from Orden_Compra as O inner join Proveedores as P on O.ID_Proveedor = P.ID_Proveedor where O.ID_Proveedor = {proveedor}");
            txtProve.Text = dgvAux[0, 0].Value.ToString();

        }

        private void txtOrdenCompraID_TextChanged(object sender, EventArgs e)
        {
            dgvRequisiciones.DataSource = CsComandosSql.RetornaDatos($"select * from Orden_Compra where ID_Orden = {txtOrdenCompraID.Text}");
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoProductos frmProducto = new FrmListadoProductos();
                frmProducto.Orden = Convert.ToInt32(txtOrdenCompraID.Text);
                frmProducto.ShowDialog();
                txtProducto.Text = frmProducto.Producto.ToString();
            }
            catch
            {
                MessageBox.Show("Escoja una opcion");
            }
        }
    }
}
