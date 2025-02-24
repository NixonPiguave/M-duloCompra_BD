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

    public partial class FrmInventarioUsuario: Form
    {
        int z ;
        public FrmInventarioUsuario()
        {
            InitializeComponent();
        }

        private void txtNombreProducto_KeyUp(object sender, KeyEventArgs e)
        {
            dgvInventario.DataSource = CsComandosSql.RetornaDatos($"select I.ID_Product, P.Nom_Producto, I.StockMin, I.StockMax, I.StockActual  From Inventario I Inner Join Producto P on I.ID_Product= P.ID_Producto where P.Nom_Producto like '{txtNombreProducto.Text}%'");
        }

        private void FrmInventarioUsuario_Load(object sender, EventArgs e)
        {
           dgvInventario.DataSource = CsComandosSql.RetornaDatos($"select I.ID_Product, P.Nom_Producto, I.StockMin, I.StockMax, I.StockActual  From Inventario I Inner Join Producto P on I.ID_Product= P.ID_Producto");
        }

        private void dgvInventario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvInventario.CurrentCell.RowIndex;
            txtStockMin.Text = dgvInventario[2, fila].Value.ToString();
            txtStockMax.Text = dgvInventario[3, fila].Value.ToString();
            z= Convert.ToInt32(dgvInventario[0, fila].Value.ToString());
        }
    }
}
