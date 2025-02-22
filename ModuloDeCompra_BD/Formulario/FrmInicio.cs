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
    public partial class FrmInicio: Form
    {
        public FrmInicio()
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
            FrmCategorias frmCategoria = new FrmCategorias();
            openChildForm(frmCategoria);
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            FrmDepartamentos frmDepartamentos = new FrmDepartamentos();
            openChildForm(frmDepartamentos);
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();
            openChildForm(frmInventario);
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            openChildForm(frmProductos);
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            openChildForm(frmProveedores);
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            FrmRoles FrmRol = new FrmRoles();
            openChildForm(FrmRol);
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            FrmServicios frmServicio = new FrmServicios();
            openChildForm(frmServicio);
        }
    }
}
