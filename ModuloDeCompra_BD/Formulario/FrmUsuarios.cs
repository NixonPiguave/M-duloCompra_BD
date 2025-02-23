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
            DataTable dt = CsComandosSql.RetornaDatos("select * from Roles");
            for(int i=0; i< dt.Rows.Count; i++)
            {
                cbRol.Items.Add(dt.Rows[i]["Rol"].ToString());
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                CsEncriptarMDS encrypt = new CsEncriptarMDS();
                string contraEncrypt = encrypt.Encriptar(txtContra.Text, txtcedula.Text);
                CsUsuario user = new CsUsuario();
                user.Nombre = txtNombre.Text;
                user.Apellido = txtApellido.Text;
                user.Cedula = txtcedula.Text;
                user.Contraseña = contraEncrypt;
                DataTable dt = CsComandosSql.RetornaDatos($"select * from Roles where Rol='{cbRol.SelectedItem.ToString()}'");
                user.Rol = Convert.ToInt32(dt.Rows[0]["ID_Rol"].ToString());
                user.Departamento = Id;
                MessageBox.Show($"{Id}  {user.Rol}");
                if (cbxEncargado.Checked == true)
                    user.Encargado = "Encargado";
               if(user.AñadirUser())
                {
                    MessageBox.Show("Usuario Agregado");
                    txtNombre.Text = string.Empty;
                    txtListDepa.Text = string.Empty;
                    txtContra.Text = string.Empty;
                    txtcedula.Text = string.Empty;
                    txtApellido.Text = string.Empty;
                }
               else
                    MessageBox.Show("Error, Verifique que los datos sean correctos");
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void txtBuscarCed_KeyUp(object sender, KeyEventArgs e)
        {
            dgvUser.DataSource = CsComandosSql.RetornaDatos($"select U.ID, U.Nombre,U.Apellido, U.Encargado, U.Cedula, D.Dep_ID,D.Nombre_Departamento, R.ID_Rol, R.Rol  from Departamento D inner join Usuario U on D.Dep_ID=U.Dep_ID \r\ninner join Roles R on U.Rol=R.ID_Rol WHERE Cedula like '{txtBuscarCed.Text}%'");
        }
    }
}
