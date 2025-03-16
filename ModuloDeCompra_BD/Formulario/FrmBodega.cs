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
        string min,max;
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
            if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                MessageBox.Show("La dirección no puede estar vacía.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
            if (string.IsNullOrEmpty(txtStockMin.Text) || string.IsNullOrEmpty(txtStockMax.Text))
            {
                MessageBox.Show("Los campos Stock Mínimo y Stock Máximo no pueden estar vacíos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(txtStockMin.Text, out double stockMin) || !double.TryParse(txtStockMax.Text, out double stockMax))
            {
                MessageBox.Show("Los valores de Stock Mínimo y Stock Máximo deben ser números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((stockMin <= 0 || stockMax <= 0)&&(stockMin > stockMax ))
            {
                MessageBox.Show("Los valores de Stock Mínimo y Stock Máximo deben ser mayores que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (stockMin >= stockMax)
            {
                MessageBox.Show("El Stock Mínimo debe ser menor que el Stock Máximo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CsBodega bodega = new CsBodega();
            bool resultado = bodega.ModificarStockBodega(id, stockMin, stockMax);

            if (resultado)
            {
                MessageBox.Show("Bodega modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBodega.DataSource = CsComandosSql.RetornaDatos("SELECT * FROM Bodega");

                txtStockMin.Text = string.Empty;
                txtStockMax.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Error al modificar la bodega en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBodega_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvBodega.CurrentCell.RowIndex;
            id = Convert.ToInt32(dgvBodega[0, fila].Value.ToString());
            min = dgvBodega[1, fila].Value.ToString();
            max = dgvBodega[2, fila].Value.ToString();

            txtStockMin.Text = min;
            txtStockMax.Text = max;

        }
    }
}
