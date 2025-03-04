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
    public partial class FrmIVA: Form
    {
        public FrmIVA()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CsIVA csIva = new CsIVA();
            if (!string.IsNullOrEmpty(txtIVA.Text))
            {
                if (!CsComandosSql.verificar($"select * from IVA where Valor_IVA= '{txtIVA.Text}'"))
                {
                    csIva.Iva = txtIVA.Text;
                    csIva.AñadirCategoria();
                    dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from Categoria");
                    txtIVA.Text = string.Empty;
                    MessageBox.Show("Se ha agregado el IVA");
                }
                else
                {
                    MessageBox.Show("El IVA ya existe");
                }
            }
            else
            {
                MessageBox.Show("Rellene el IVA");
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
 
            if (txtModificarIVA.Visible == false)
            {
                lblModificarCategoria.Visible = true;
                txtModificarIVA.Visible = true;
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
                txtModificarIVA.Visible = false;
                btnAceptar.Visible = false;
                btnAgregar.Visible = true;
            }
        }

        private void FrmIVA_Load(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from IVA");
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvCategoria.CurrentCell.RowIndex;
            txtIVA.Text = dgvCategoria[1, celda].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CsIVA csIVA = new CsIVA();
            if (!string.IsNullOrEmpty(txtIVA.Text) || string.IsNullOrEmpty(txtModificarIVA.Text))
            {
                if (CsComandosSql.verificar($"select * from IVA where Valor_IVA= '{txtIVA.Text}'"))
                {
                    csIVA.Iva = txtModificarIVA.Text;
                    int posicion = dgvCategoria.CurrentCell.RowIndex;
                    int ID = Convert.ToInt32(dgvCategoria[0, posicion].Value);
                    csIVA.IDiva = ID;
                    csIVA.ModificarCategoria();
                    dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from IVA");
                    txtIVA.Text = string.Empty;
                    txtModificarIVA.Text = string.Empty;
                    MessageBox.Show("Se ha modificado el IVA");
                }
                else
                {
                    MessageBox.Show("El IVA0 ya existe");
                }
            }
            else
            {
                MessageBox.Show("Escoja la categoria");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIVA.Text))
            {
                if (CsComandosSql.verificar($"select * from Categoria where Categoria = '{txtIVA.Text}'"))
                {
                    int posicion = dgvCategoria.CurrentCell.RowIndex;
                    int ID = Convert.ToInt32(dgvCategoria[0, posicion].Value);
                    CsCategoria csCategoria = new CsCategoria();
                    csCategoria.IdCat = ID;
                    csCategoria.EliminarCategoria();
                    txtIVA.Text = string.Empty;
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
