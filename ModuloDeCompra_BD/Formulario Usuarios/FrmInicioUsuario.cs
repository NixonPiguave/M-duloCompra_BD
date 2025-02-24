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
    public partial class FrmInicioUsuario: Form
    {
        int PosX, PosY;
        public FrmInicioUsuario()
        {
            InitializeComponent();
        }
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            plFormHijos.Controls.Add(childForm);
            plFormHijos.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoriasUsuario frmCategoria = new FrmCategoriasUsuario();
            openChildForm(frmCategoria);
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            FrmDepartamentosUsuarios frmDepartamentos = new FrmDepartamentosUsuarios();
            openChildForm(frmDepartamentos);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventarioUsuario frmInventario = new FrmInventarioUsuario();
            openChildForm(frmInventario);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProductosUsuarios frmProductos = new FrmProductosUsuarios();
            openChildForm(frmProductos);
        }

        private void pnlSuperior_MouseMove(object sender, MouseEventArgs e)
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
    }
}
