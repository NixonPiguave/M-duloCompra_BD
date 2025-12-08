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
    public partial class FrmUsuarios: Form
    {
        int Id;
        int Id2;
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            FrmListadoDepa dep = new FrmListadoDepa();
            dep.ShowDialog();
            txtListDepa.Text = dep.Nombre1;
            Id = dep.IdCat1;
            
        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CsUsuario user = new CsUsuario();
            dgvUser.DataSource = user.ListadoUser();
            DataTable dt = CsComandosSql.RetornaDatos("select * from [MC-Roles]");
            for(int i=0; i< dt.Rows.Count; i++)
            {
                cbRol.Items.Add(dt.Rows[i]["Rol"].ToString());
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(CsComandosSql.verificar($"Select * from [MC-Usuario] where Cedula = {txtcedula.Text} or Usuario='{txtUsuario.Text}'")))
                {
                    CsEncriptarMDS encrypt = new CsEncriptarMDS();
                    string contraEncrypt = encrypt.Encriptar(txtContra.Text, txtUsuario.Text);
                    string contraEncrypt2 = encrypt.Encriptar(txtContra2.Text, txtUsuario.Text);
                    CsUsuario user = new CsUsuario();
                    user.Nombre = txtNombre.Text;
                    user.Apellido = txtApellido.Text;
                    user.Cedula = txtcedula.Text;
                    user.Contraseña = contraEncrypt;
                    user.Contraseña2 = contraEncrypt2;
                    user.Usuario = txtUsuario.Text;
                    DataTable dt = CsComandosSql.RetornaDatos($"select * from [MC-Roles] where Rol='{cbRol.SelectedItem.ToString()}'");
                    user.Rol = Convert.ToInt32(dt.Rows[0]["ID_Rol"].ToString());
                    user.Departamento = Id;
                    user.Rolname = cbRol.SelectedItem.ToString();
                    if (user.AñadirUser())
                    {    
                         MessageBox.Show("Usuario Agregado");
                            txtNombre.Text = string.Empty;
                            txtListDepa.Text = string.Empty;
                            txtContra.Text = string.Empty;
                            txtcedula.Text = string.Empty;
                            txtApellido.Text = string.Empty;
                            txtContra2.Text = string.Empty;
                            txtUsuario.Text = string.Empty;
                            cbRol.SelectedItem = string.Empty;
                            dgvUser.DataSource = user.ListadoUser();
                        
                    }
                    else
                        MessageBox.Show("Error, Verifique que los datos sean correctos");
                }
                else
                    MessageBox.Show("Ya existe ese usuario");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void txtBuscarCed_KeyUp(object sender, KeyEventArgs e)
        {
            dgvUser.DataSource = CsComandosSql.RetornaDatos($"select U.ID_Usuario, U.Nombre, U.Apellido, U.Cedula, U.Usuario, U.Contraseña,R.ID_Rol, R.Rol, D.ID_Depa, D.Nombre_Departamento from [MC-Departamento] D inner join [MC-Usuario] U on D.ID_Depa= U.ID_Depa inner join [MC-Roles] R on U.ID_Rol= R.ID_Rol WHERE U.Cedula like '{txtBuscarCed.Text}%'");
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CsUsuario user = new CsUsuario();
                user.ID = Id2;
                user.Nombre = txtNombre.Text;
                user.Apellido = txtApellido.Text;
                user.Cedula = txtcedula.Text;
                user.Usuario = txtUsuario.Text;
                CsEncriptarMDS encry = new CsEncriptarMDS();
                user.Contraseña = encry.Encriptar(txtContra.Text, txtUsuario.Text);
                if (user.ModificarUser())
                {
                    dgvUser.DataSource = user.ListadoUser();
                    btnLimpiar_Click(sender, e);
                    MessageBox.Show("Usuario Modificado");
                    if (btnListadoDepa.Enabled == false)
                        btnListadoDepa.Enabled = true;
                    if (cbRol.Enabled == false)
                        cbRol.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void dgvUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvUser.CurrentCell.RowIndex;
            Id2 = Convert.ToInt32(dgvUser[0, fila].Value);
            txtNombre.Text = dgvUser[1, fila].Value.ToString();
            txtApellido.Text = dgvUser[2, fila].Value.ToString();
            txtcedula.Text = dgvUser[3, fila].Value.ToString();
            txtUsuario.Text= dgvUser[4, fila].Value.ToString();
            string contra= dgvUser[5, fila].Value.ToString();
            CsEncriptarMDS encry = new CsEncriptarMDS();
            txtContra.Text=encry.Desencriptar(contra, dgvUser[4, fila].Value.ToString());
            btnListadoDepa.Enabled=false;
            cbRol.Enabled = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if (btnListadoDepa.Enabled == false)
                btnListadoDepa.Enabled = true;
            if (cbRol.Enabled == false)
                cbRol.Enabled = true;
        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvUser.CurrentCell.RowIndex;
                CsUsuario user = new CsUsuario();
                user.ID = Convert.ToInt32(dgvUser[0, fila].Value);
                string Usuario = dgvUser[4, fila].Value.ToString();
                DialogResult resultado = MessageBox.Show($"¿Estás seguro de eliminar a ID: {dgvUser[0, fila].Value} - Usuario: {Usuario}?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resultado == DialogResult.Yes)
                {
                    user.EliminarUser();
                    dgvUser.DataSource = user.ListadoUser();
                    MessageBox.Show("Usuario Eliminado");
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar");
            }
        }
    }
}
