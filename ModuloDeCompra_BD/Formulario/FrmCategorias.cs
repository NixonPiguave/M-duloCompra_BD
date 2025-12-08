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
                if (!CsComandosSql.verificar($"select * from [IN-Categoria] where Categoria = '{txtCategoria.Text}'"))
                {
                    csCategoria.Categoria = txtCategoria.Text;
                    csCategoria.AñadirCategoria();
                    dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from [IN-Categoria]");
                    txtCategoria.Text = string.Empty;
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
            
        }

        private void FrmCategorias_Load(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from [IN-Categoria]");
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvCategoria.CurrentCell.RowIndex;
            txtCategoria.Text = dgvCategoria[1, celda].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CsCategoria csCategoria = new CsCategoria();
            if (!string.IsNullOrEmpty(txtCategoria.Text) || string.IsNullOrEmpty(txtModificarCategoria.Text))
            {
                if (CsComandosSql.verificar($"select * from [IN-Categoria] where Categoria = '{txtCategoria.Text}'"))
                {
                    csCategoria.Categoria = txtModificarCategoria.Text;
                    int posicion = dgvCategoria.CurrentCell.RowIndex;
                    int ID = Convert.ToInt32(dgvCategoria[0, posicion].Value);
                    csCategoria.IdCat = ID;
                    csCategoria.ModificarCategoria();
                    dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from [IN-Categoria]");
                    txtCategoria.Text = string.Empty;
                    txtModificarCategoria.Text = string.Empty;
                    MessageBox.Show("Se ha modificado la categoria");
                }
                else
                {
                    MessageBox.Show("La categoria ya existe");
                }
            }
            else
            {
                MessageBox.Show("Escoja la categoria");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCategoria.Text))
            {
                if (CsComandosSql.verificar($"select * from [IN-Categoria] where Categoria = '{txtCategoria.Text}'"))
                {
                    int posicion = dgvCategoria.CurrentCell.RowIndex;
                    int ID = Convert.ToInt32(dgvCategoria[0, posicion].Value);
                    CsCategoria csCategoria = new CsCategoria();
                    csCategoria.IdCat = ID;
                    csCategoria.EliminarCategoria();
                    txtCategoria.Text = string.Empty;
                    dgvCategoria.DataSource = CsComandosSql.RetornaDatos("select * from [IN-Categoria]");
                    MessageBox.Show("Se ha eliminado la categoria");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar la categoria");
                }
            }
            else
            {
                MessageBox.Show("Escoja la categoria");
            }
        }
    }
}
