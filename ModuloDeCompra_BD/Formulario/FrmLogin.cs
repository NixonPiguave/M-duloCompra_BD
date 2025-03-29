using Menú;
using ModuloDeCompra_BD.Clases;
using ModuloDeCompra_BD.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD
{
    public partial class Frm_IncioSesion : Form
    {
        private static SqlConnection conex;
        public Frm_IncioSesion()
        {
            InitializeComponent();

        }
        int PosY = 0;
        int PosX = 0;
        private void pnlMover_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                PosX = e.X;
                PosY = e.Y;
            }
            else
            {
                Left = Left + (e.X - PosX);
                Top = Top + (e.Y - PosY);
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                CsUsuario user = new CsUsuario();
                user.Cedula = txtUser.Text;
                CsEncriptarMDS encryp = new CsEncriptarMDS();
                user.Contraseña = encryp.Encriptar(txtContraseña.Text, txtUser.Text);

                string rol = CsComandosSql.verificarlogin(user.Cedula, user.Contraseña);
                int[] funcion = CsComandosSql.Funcion_Rol(user.Cedula, user.Contraseña);
                int IDusuario = CsComandosSql.ObtenerIdUsuario(user.Cedula, user.Contraseña);
                FrmMenu3 menu = new FrmMenu3();
                menu.Botones=funcion;
                string idsTexto = string.Join(", ", funcion);
                //MessageBox.Show("IDs de funciones: " + idsTexto);


                if (!string.IsNullOrEmpty(rol))
                {

                    CsConeccionServer.Usuario = txtUser.Text;
                    CsConeccionServer.Password = user.Contraseña;
                    CsConeccionServer.ActualizarCadenaConexion(txtUser.Text, user.Contraseña);
                    CsConeccionServer.ObtenerConexion();
                    
                        MessageBox.Show("Inicio de sesión Exitoso");
                        FrmMenu3 ini = new FrmMenu3();
                        ini.IDusuario1 = IDusuario;
                        ini.rol = rol;
                        ini.Botones = funcion;                    
                        txtUser.Text = string.Empty;
                        txtContraseña.Text = string.Empty;
                        this.Hide();
                        ini.ShowDialog();
                        this.Show();
                }
                else
                {
                    MessageBox.Show("Inicio de sesión Fallido, error en los datos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar)
            {
                txtContraseña.UseSystemPasswordChar = false;
                pbxOjo.Image = Properties.Resources.ojo_abierto1;
            }
            else
            {
                txtContraseña.UseSystemPasswordChar = true;
                pbxOjo.Image = Properties.Resources.ojo_cerrado1;
            }
        }
    }
}
