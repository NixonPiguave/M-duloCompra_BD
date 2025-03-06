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
using static System.Net.Mime.MediaTypeNames;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmBodega: Form
    {
        public FrmBodega()
        {
            InitializeComponent();
        }

        private void FrmBodega_Load(object sender, EventArgs e)
        {
            dgvBodega.DataSource = CsComandosSql.RetornaDatos($"select * from Bodega");
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {


            try
            {
                string x = txtID_Bodega.Text;
               

                    
                    try
                    {

                        bool success = CsComandosSql.InserDeletUpdate($"INSERT INTO Bodega(Ubicacion, StockActual, StockMin, StockMax) VALUES('{x}', 0, 0, 0)");

                        if (success)
                        {
                            MessageBox.Show("Medicina agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvBodega.DataSource = CsComandosSql.RetornaDatos("select * from Bodega");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error, verifique que se esté ingresando correctamente el proveedor ID y TipoID. Detalles del error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvBodega.DataSource=CsComandosSql.InserDeletUpdate($"INSERT INTO Bodega(Ubicacion, StockActual, StockMin, StockMax) VALUES('{txtDireccion.Text}', 0, 0, 0)");
        }

        private void txtID_Bodega_KeyUp(object sender, KeyEventArgs e)
        {

            dgvBodega.DataSource = CsComandosSql.RetornaDatos($" select * from Bodega where ID_BODEGA = '{txtStockMax.Text}'");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtStockMin.Text);
                double y = Convert.ToDouble(txtStockMax.Text);

                if (x > 0 && y > 0)
                {
                    if (string.IsNullOrWhiteSpace(txtStockMin.Text) || string.IsNullOrWhiteSpace(txtStockMax.Text))
                    {
                        
                        MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    
                        try
                        {
                            dgvBodega.DataSource = CsComandosSql.RetornaDatos($"select * from Bodega");
                            bool success = CsComandosSql.InserDeletUpdate($"update Bodega set StockMin='{x}', StockMax='{y}' where ID_Bodega='9'");

                            if (success)
                            {
                                MessageBox.Show("Medicina modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvBodega.DataSource = CsComandosSql.RetornaDatos("select * from Bodega");

                                txtStockMin.Text = string.Empty;
                                txtStockMax.Text = string.Empty;
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al modificar la medicina. Detalles del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        } 
                    
                }
                else
                {
                    MessageBox.Show("El precio y la cantidad deben ser valores positivos y encima de 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al procesar la modificación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
