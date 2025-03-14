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
    public partial class FrmDepartamento: Form
    {
        public FrmDepartamento()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CsDepartamentos csDepa = new CsDepartamentos();
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtNombreDepartamento.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                try
                {
                    if (!CsComandosSql.verificar($"Select * from Departamento where Nombre_Departamento = '{txtNombreDepartamento.Text}'"))
                    {
                        csDepa.Depa = txtNombreDepartamento.Text;
                        csDepa.AñadirDepartamento();
                        dgvDepartamento.DataSource = CsComandosSql.RetornaDatos($"select * from Departamento");
                        MessageBox.Show("Se ha agregado el departamento");
                    }
                    else
                    {
                        MessageBox.Show("El departamento ya existe");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
 
            if (txtModificarDepartamento.Visible == false)
            {
                lblModificarDepartamento.Visible = true;
                txtModificarDepartamento.Visible = true;
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
                lblModificarDepartamento.Visible = false;
                txtModificarDepartamento.Visible = false;
                btnAceptar.Visible = false;
                btnAgregar.Visible = true;
            }
        }

        private void FrmDepartamento_Load(object sender, EventArgs e)
        {
            dgvDepartamento.DataSource = CsComandosSql.RetornaDatos("Select * from Departamento");
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvDepartamento.CurrentCell.RowIndex;
            txtNombreDepartamento.Text = dgvDepartamento[1, celda].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CsDepartamentos csDepa = new CsDepartamentos();
            try
            {

                if (string.IsNullOrWhiteSpace(txtNombreDepartamento.Text) || string.IsNullOrEmpty(txtModificarDepartamento.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                try
                {
                    if (!CsComandosSql.verificar($"Select * from Departamento where Nombre_Departamento = '{txtModificarDepartamento.Text}'"))
                    {
                        int posicion = dgvDepartamento.CurrentCell.RowIndex;
                        int ID = Convert.ToInt32(dgvDepartamento[0, posicion].Value);
                        csDepa.DepaID = ID;
                        csDepa.Depa = txtModificarDepartamento.Text;
                        csDepa.ModificarDepartamento();
                        dgvDepartamento.DataSource = CsComandosSql.RetornaDatos($"select * from Departamento");
                        MessageBox.Show("Se ha modificado el departamento.");
                    }
                    else
                    {
                        MessageBox.Show("El departamento ya existe");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            CsDepartamentos csDepa = new CsDepartamentos();
            try
            {

                if (string.IsNullOrWhiteSpace(txtNombreDepartamento.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                try
                {
                    int posicion = dgvDepartamento.CurrentCell.RowIndex;
                    int ID = Convert.ToInt32(dgvDepartamento[0, posicion].Value);
                    csDepa.DepaID = ID;
                    csDepa.EliminarDepartamento();
                    dgvDepartamento.DataSource = CsComandosSql.RetornaDatos($"select * from Departamento");
                    MessageBox.Show("Se ha eliminado el departamento");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
