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
    public partial class FrmCategoriasUsuario: Form
    {
        public FrmCategoriasUsuario()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CsCategoria csCategoria = new CsCategoria();
            if (!string.IsNullOrEmpty(txtCategoria.Text))
            {
                dgvCategoria.DataSource = CsComandosSql.RetornaDatos($"Select * from Categoria where Categoria = '{txtCategoria.Text}'");
            }
            else
            {
                MessageBox.Show("Rellene la categoria");
            }
        }

        private void FrmCategoriasUsuario_Load(object sender, EventArgs e)
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
