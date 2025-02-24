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
    public partial class FrmCategorias: Form
    {
        public FrmCategorias()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CsCategoria csCategoria = new CsCategoria();
            if (!string.IsNullOrEmpty(txtCategoria.Text))
            {
                if (!CsComandosSql.verificar($"select * from Categoria where Categoria = '{txtCategoria.Text}'"))
                {
                    csCategoria.Categoria = txtCategoria.Text;
                    csCategoria.AñadirCategoria();
                    MessageBox.Show("Se ha agregado la categoria");
                }
                else
                {
                    MessageBox.Show("La categoria ya existe");
                }
            }
            else
            {
                MessageBox.Show("Rellene la categoria");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            CsCategoria csCategoria = new CsCategoria();
            if (!string.IsNullOrEmpty(txtCategoria.Text))
            {
                if (!CsComandosSql.verificar($"select * from Categoria where Categoria = '{txtCategoria.Text}'"))
                {
                    DataTable dt = CsComandosSql.RetornaDatos($"Select ID_CAT from Categoria where Categoria = {txtCategoria.Text}");
                    csCategoria.IdCat = Convert.ToInt32(dt.Rows[0][0]);
                    csCategoria.Categoria = txtCategoria.Text;
                    csCategoria.ModificarCategoria();
                    MessageBox.Show("Se ha modificado la categoria");
                }
                else
                {
                    MessageBox.Show("La categoria ya existe");
                }
            }
            else
            {
                MessageBox.Show("Rellene la categoria");
            }
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from Categoria");
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvCategoria.CurrentCell.RowIndex;
            txtCategoria.Text = dgvCategoria[1, celda].Value.ToString();
        }
    }
}
