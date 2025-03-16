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
using static Guna.UI2.Native.WinApi;

namespace ModuloDeCompra_BD.Formulario
{

    public partial class FrmInventario: Form
    {
        int z ;
        public FrmInventario()
        {
            InitializeComponent();
        }

        private void txtNombreProducto_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }


        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvInventario_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {
           dgvInventario.DataSource = CsComandosSql.RetornaDatos($"select I.ID_Inventario,I.ID_Producto,P.NomProducto,P.Costo, P.EstadoProducto, I.ID_Bodega from Inventario I inner Join Producto P on I.ID_Producto=P.ID_Producto");
            
        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvInventario.CurrentCell.RowIndex;
        }

        private void guna2HtmlLabel9_Click(object sender, EventArgs e)
        {

        }

        private void txtID_Inventario_KeyUp(object sender, KeyEventArgs e)
        {
            dgvInventario.DataSource = CsComandosSql.RetornaDatos($"select I.ID_Producto,P.NomProducto,P.Costo, P.EstadoProducto, I.ID_Bodega,i.ID_Inventario  From Inventario I Inner Join Producto P on I.ID_Producto= P.ID_Producto where I.ID_Inventario like '{txtID_Inventario.Text}%'");

        }
    }
}
