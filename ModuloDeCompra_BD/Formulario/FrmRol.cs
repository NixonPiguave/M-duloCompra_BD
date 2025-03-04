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
    public partial class FrmRol: Form
    {
        public FrmRol()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CsRoles csRol = new CsRoles();
            try
            {
                
                if (string.IsNullOrWhiteSpace(txtRol.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                try
                {
                    if (!CsComandosSql.verificar($"Select * from Roles where Rol = '{txtRol.Text}'"))
                    {
                        csRol.Rol = txtRol.Text;
                        csRol.AñadirRol();
                        dgvRol.DataSource = CsComandosSql.RetornaDatos($"select * from Roles");
                        MessageBox.Show("Se ha agregado el Roles");
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
 
            if (txtModificarRol.Visible == false)
            {
                lblModificarRol.Visible = true;
                txtModificarRol.Visible = true;
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
                lblModificarRol.Visible = false;
                txtModificarRol.Visible = false;
                btnAceptar.Visible = false;
                btnAgregar.Visible = true;
            }
        }

        private void FrmRol_Load(object sender, EventArgs e)
        {
            dgvRol.DataSource = CsComandosSql.RetornaDatos("Select * from Roles");
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvRol.CurrentCell.RowIndex;
            txtRol.Text = dgvRol[1, celda].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CsRoles csRoles = new CsRoles();
            try
            {

                if (string.IsNullOrWhiteSpace(txtRol.Text) || string.IsNullOrEmpty(txtModificarRol.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                try
                {
                    if (!CsComandosSql.verificar($"Select * from Roles where Rol= '{txtModificarRol.Text}'"))
                    {
                        int posicion = dgvRol.CurrentCell.RowIndex;
                        int ID = Convert.ToInt32(dgvRol[0, posicion].Value);
                        csRoles.RolID= ID;
                        csRoles.Rol = txtModificarRol.Text;
                        csRoles.ModificarRol();
                        dgvRol.DataSource = CsComandosSql.RetornaDatos($"select * from Roles");
                        MessageBox.Show("Se ha modificado el rol.");
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
            CsRoles csrol = new CsRoles();
            try
            {

                if (string.IsNullOrWhiteSpace(txtRol.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                try
                {
                    int posicion = dgvRol.CurrentCell.RowIndex;
                    int ID = Convert.ToInt32(dgvRol[0, posicion].Value);
                    csrol.RolID = ID;
                    csrol.EliminarRol();
                    dgvRol.DataSource = CsComandosSql.RetornaDatos($"select * from Roles");
                    MessageBox.Show("Se ha eliminado el rol");
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
