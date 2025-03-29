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
        int[] funcion = new int[0];

        public int[] Funcion { get => funcion; set => funcion = value; }

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
                if (Funcion == null || Funcion.Length == 0)
                {
                    MessageBox.Show("No se han seleccionado funciones.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    if (!CsComandosSql.verificar($"Select * from Roles where Rol = '{txtRol.Text}'"))
                    {
                       int tam = Funcion.Length;
                        
                        csRol.Rol = txtRol.Text;
                        csRol.AñadirRol();
                        dgvRol.DataSource = CsComandosSql.RetornaDatos($"select * from Roles");
                        MessageBox.Show("Se ha agregado el Roles");
                        int rol = Convert.ToInt32(ObtenerIDDelRol(txtRol.Text));
                        for (int i = 0; i < tam; i++)
                        {
                            int funciones = Funcion[i];
                            csRol.Funciones = funciones;
                            csRol.Idrolfun = rol;
                            csRol.funcionRol();
                        }
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
        public int ObtenerIDDelRol(string nombreRol)
        {
            string query = $"SELECT TOP 1 ID_Rol FROM Roles WHERE Rol = '{nombreRol}' ORDER BY ID_Rol DESC";
            return Convert.ToInt32(CsComandosSql.obtenerID(query));
        }
        private void btnfuncionalidad_Click(object sender, EventArgs e)
        {
            CsRoles csRol = new CsRoles();
            FrmFunciones abri = new FrmFunciones(this); 
            abri.ShowDialog();
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
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validación de campos
                if (string.IsNullOrWhiteSpace(txtModificarRol.Text))
                {
                    MessageBox.Show("El nombre del rol es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Obtener ID del rol a modificar
                int posicion = dgvRol.CurrentCell.RowIndex;
                int ID = Convert.ToInt32(dgvRol[0, posicion].Value);

                // Verificar si es el rol Administrador (que no debería modificarse)
                string rolActual = dgvRol[1, posicion].Value.ToString();
                if (rolActual.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El rol Administrador no se puede modificar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Verificar si el nuevo nombre ya existe
                if (CsComandosSql.verificar($"Select * from Roles where Rol = '{txtModificarRol.Text}' AND RolID <> {ID}"))
                {
                    MessageBox.Show("Ya existe un rol con ese nombre.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Realizar la modificación
                CsRoles csRoles = new CsRoles
                {
                    RolID = ID,
                    Rol = txtModificarRol.Text
                };

                csRoles.ModificarRol();
                dgvRol.DataSource = CsComandosSql.RetornaDatos("select * from Roles");
                MessageBox.Show("Rol modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar el rol: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}

