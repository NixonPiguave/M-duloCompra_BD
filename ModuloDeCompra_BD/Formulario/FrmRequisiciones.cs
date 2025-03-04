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

namespace Menú.Formularios
{
    public partial class FrmRequisiciones: Form
    {
         DataTable tabla = new DataTable();
        public FrmRequisiciones()
        {
            InitializeComponent();
        }

        private void FrmRequisiciones_Load(object sender, EventArgs e)
        {
            tabla.Columns.Add("ID_Producto", typeof(string));
            tabla.Columns.Add("ID_Servicio", typeof(string));
            tabla.Columns.Add("Producto/Servicio", typeof(string));
            tabla.Columns.Add("Cantidad", typeof(string));
            dgvProductosAgregados.DataSource = tabla;

            btnAgregarP.Visible = false;
            lbID.Visible = false;
            lbProduc.Visible = false;
            lbCantidad.Visible = false;
            txtProducto.Visible = false;
            txtID.Visible = false;
            nudCantidad.Visible = false;

            btnAgregarS.Visible = false;
            lbIDserv.Visible = false;
            lbCanServ.Visible = false;
            lbServi.Visible = false;
            txtServicio.Visible = false;
            txtIDServi.Visible = false;
            nudServicio.Visible = false;

            nudCantidad.Minimum = 1;
            nudCantidad.Value = 1;
            dgvListadoProductos.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, NomProducto, Costo from Producto WHERE EstadoProducto='Activo'");
            dgvListadoServicio.DataSource = CsComandosSql.RetornaDatos("select ID_Servicio, Nom_Servicio, Costo from Servicio WHERE EstadoServicio='Activo'");
            dgvRequisiciones.DataSource = CsComandosSql.RetornaDatos("select * from Requisicion");
        }

        private void txtFiltroProduc_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoProductos.DataSource = CsComandosSql.RetornaDatos($"select ID_Producto, NomProducto, Costo from Producto WHERE EstadoProducto='Activo' and NomProducto like '%{txtFiltroProduc.Text}%'");
        }

        private void txtFiltroServicio_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoServicio.DataSource = CsComandosSql.RetornaDatos($"select ID_Servicio, Nom_Servicio, Costo from Servicio WHERE EstadoServicio='Activo'and Nom_Servicio like '%{txtFiltroServicio.Text}%'");
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            btnAgregarP.Visible = true;
            lbID.Visible = true;
            lbProduc.Visible = true;
            lbCantidad.Visible = true;
            txtProducto.Visible = true;
            txtID.Visible = true;
            nudCantidad.Visible = true;

            btnAgregarS.Visible = false;
            lbIDserv.Visible = false;
            lbCanServ.Visible = false;
            lbServi.Visible = false;
            txtServicio.Visible = false;
            txtIDServi.Visible = false;
            nudServicio.Visible = false;

            int fila = dgvListadoProductos.CurrentCell.RowIndex;
            txtID.Text = dgvListadoProductos[0, fila].Value.ToString();
            txtProducto.Text = dgvListadoProductos[1, fila].Value.ToString();

        }

       

        private void btnServicio_Click(object sender, EventArgs e)
        {
            btnAgregarP.Visible = false;
            lbID.Visible = false;
            lbProduc.Visible = false;
            lbCantidad.Visible = false;
            txtProducto.Visible = false;
            txtID.Visible = false;
            nudCantidad.Visible = false;

            btnAgregarS.Visible = true;
            lbIDserv.Visible = true;
            lbCanServ.Visible = true;
            lbServi.Visible = true;
            txtServicio.Visible = true;
            txtIDServi.Visible = true;
            nudServicio.Visible = true;
            int fila = dgvListadoServicio.CurrentCell.RowIndex;
            txtIDServi.Text = dgvListadoServicio[0, fila].Value.ToString();
            txtServicio.Text = dgvListadoServicio[1, fila].Value.ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarS_Click(object sender, EventArgs e)
        {
            tabla.Rows.Add( null, txtIDServi.Text, txtServicio.Text, nudServicio.Value);
            dgvProductosAgregados.DataSource = tabla;
            txtServicio.Text = string.Empty;
            nudServicio.Value = 1;
            txtIDServi.Text = string.Empty;

        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            tabla.Rows.Add(txtID.Text, null, txtProducto.Text, nudCantidad.Value);
            dgvProductosAgregados.DataSource = tabla;
            txtProducto.Text = string.Empty;
            txtID.Text = string.Empty;
            nudCantidad.Value = 1;
        }
    }
}
