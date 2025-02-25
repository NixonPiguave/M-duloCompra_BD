﻿using Menú;
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
                user.Cedula = txtCedula.Text;
                CsEncriptarMDS encryp = new CsEncriptarMDS();
                user.Contraseña = encryp.Encriptar(txtContraseña.Text, txtCedula.Text);
                string rol = CsComandosSql.verificarlogin(user.Cedula, user.Contraseña);
                if (!string.IsNullOrEmpty(rol))
                {
                    if (rol == "Administrador")
                    {
                        MessageBox.Show("Inicio de sesión Exitoso");
                        FrmInicio2 ini = new FrmInicio2();
                        txtCedula.Text = string.Empty;
                        txtContraseña.Text = string.Empty;
                        this.Hide();
                        ini.ShowDialog();
                        this.Show();
                    }
                    if (rol == "Usuario")
                    {
                        MessageBox.Show("Inicio de sesión Exitoso");
                        FrmInicioUsuario inic = new FrmInicioUsuario();
                        txtCedula.Text = string.Empty;
                        txtContraseña.Text = string.Empty;
                        this.Hide();
                        inic.ShowDialog();
                        this.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Inicio de sesión Fallido, error en los datos");
                }
            }
            catch(Exception ex)
                {
                 MessageBox.Show("Error "+ ex);
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
