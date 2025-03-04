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
                    dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from Categoria");
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
            Point boton = new Point();
            Point btnAgregarLocalizacion = new Point();
            boton.Y = 317;
            boton.X = 175;
            btnAgregarLocalizacion.Y = boton.Y;
            btnAgregarLocalizacion.X = 12;
            btnModificar.Location = boton;
            btnAgregar.Location = btnAgregarLocalizacion;
 
            if (txtModificarCategoria.Visible == false)
            {
                lblModificarCategoria.Visible = true;
                txtModificarCategoria.Visible = true;
                btnAceptar.Visible = true;
                btnAgregar.Visible = false;
            }
            else
            {
                Point regresarPosicionBtnModificar = new Point();
                Point regresarPosicionBtnAgregar = new Point();
                regresarPosicionBtnModificar.X = 175;
                regresarPosicionBtnModificar.Y = 217;
                regresarPosicionBtnAgregar.X = 12;
                regresarPosicionBtnAgregar.Y = 217;
                btnAgregar.Location = regresarPosicionBtnAgregar;
                btnModificar.Location = regresarPosicionBtnModificar;
                lblModificarCategoria.Visible = false;
                txtModificarCategoria.Visible = false;
                btnAceptar.Visible = false;
                btnAgregar.Visible = true;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CsCategoria csCategoria = new CsCategoria();
            if (!string.IsNullOrEmpty(txtCategoria.Text))
            {
                if (CsComandosSql.verificar($"select * from Categoria where Categoria = '{txtCategoria.Text}'"))
                {
                    csCategoria.Categoria = txtModificarCategoria.Text;
                    int posicion = dgvCategoria.CurrentCell.RowIndex;
                    int ID = Convert.ToInt32(dgvCategoria[0, posicion].Value);
                    csCategoria.IdCat = ID;
                    csCategoria.ModificarCategoria();
                    dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from Categoria");
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
                if (CsComandosSql.verificar($"select * from Categoria where Categoria = '{txtCategoria.Text}'"))
                {
                    int posicion = dgvCategoria.CurrentCell.RowIndex;
                    int ID = Convert.ToInt32(dgvCategoria[0, posicion].Value);
                    CsCategoria csCategoria = new CsCategoria();
                    csCategoria.IdCat = ID;
                    csCategoria.EliminarCategoria();
                    txtCategoria.Text = string.Empty;
                    dgvCategoria.DataSource = CsComandosSql.RetornaDatos("select * from Categoria");
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
