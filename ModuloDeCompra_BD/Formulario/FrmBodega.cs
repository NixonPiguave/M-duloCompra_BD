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
        int id;
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
            CsBodega bodega = new CsBodega();
            bool resultado = bodega.agregarBodega(txtDireccion.Text);

            if (resultado)
            {
                MessageBox.Show("Bodega creada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvBodega.DataSource = CsComandosSql.RetornaDatos("SELECT * FROM Bodega");
            }
            else
            {
                MessageBox.Show("Error al crear la bodega. Verifique los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
  

        }

        private void txtID_Bodega_KeyUp(object sender, KeyEventArgs e)
        {

            dgvBodega.DataSource = CsComandosSql.RetornaDatos($"select * from Bodega where  ID_BODEGA like '%{txtID_Bodega.Text}%'");

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                double stockMin = Convert.ToDouble(txtStockMin.Text);
                double stockMax = Convert.ToDouble(txtStockMax.Text);
                CsBodega bodega = new CsBodega();
                bool resultado = bodega.ModificarStockBodega(id, stockMin, stockMax);

                if (resultado)
                {
                    MessageBox.Show("Bodega modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvBodega.DataSource = CsComandosSql.RetornaDatos("SELECT * FROM Bodega");

                    txtStockMin.Text = string.Empty;
                    txtStockMax.Text = string.Empty;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Los valores de Stock Mínimo y Stock Máximo deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al procesar la modificación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBodega_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvBodega.CurrentCell.RowIndex;
            int id = Convert.ToInt32(dgvBodega[0, fila].Value.ToString());

        }
    }
}
