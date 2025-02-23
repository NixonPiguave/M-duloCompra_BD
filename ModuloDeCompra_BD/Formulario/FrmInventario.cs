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
            dgvInventario.DataSource = CsComandosSql.RetornaDatos($"\r\n  select I.ID_Product, P.Nom_Producto, I.StockMin, I.StockMax, I.StockActual  From Inventario I Inner Join Producto P on I.ID_Product= P.ID_Producto where P.Nom_Producto like '{txtNombreProducto.Text}%'");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(txtStockMin.Text);
                int y = Convert.ToInt32(txtStockMax.Text);
                if (x > 0 && y > 0)
                {
                    if (string.IsNullOrWhiteSpace(txtStockMin.Text) || string.IsNullOrWhiteSpace(txtStockMax.Text))
                    {
                        MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {

                        if (x<y)
                        {

                            if (CsComandosSql.InserDeletUpdate($"update Inventario set StockMin={x}, StockMax={y} where ID_Product = {z}")
    )
                            {

                                MessageBox.Show("Inventario modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvInventario.DataSource = CsComandosSql.RetornaDatos("select I.ID_Product, P.Nom_Producto, I.StockMin, I.StockMax, I.StockActual  From Inventario I Inner Join Producto P on I.ID_Product= P.ID_Producto");

                                // Limpiar los campos de texto
                                txtStockMin.Text = string.Empty;
                                txtStockMax.Text = string.Empty;
                            }
                            else
                                MessageBox.Show("Inventario no.");
                        }
                        else
                            MessageBox.Show("El stock min debe ser mayor que el stock max");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al modificar los stocks. Detalles del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("La cantidad deben ser valores positivos y encima de 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al procesar la modificación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void txtNombreProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvInventario_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void FrmInventario_Load(object sender, EventArgs e)
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
