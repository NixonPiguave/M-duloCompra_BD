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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_IncioSesion iniciarSesion = new Frm_IncioSesion();
            iniciarSesion.ShowDialog();
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
            frmCategoria.ShowDialog();
        }

        private void btnDepartamento_Click(object sender, EventArgs e)
        {
            FrmDepartamentos frmDepartamentos = new FrmDepartamentos();
            frmDepartamentos.ShowDialog();
        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            FrmInventario frmInventario = new FrmInventario();  
            frmInventario.ShowDialog();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProductos frmProductos = new FrmProductos();
            frmProductos.ShowDialog();
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedores frmProveedores = new FrmProveedores();
            frmProveedores.ShowDialog();
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            FrmRoles FrmRol = new FrmRoles();
            FrmRol.ShowDialog();
        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            FrmServicios frmServicio = new FrmServicios();
            frmServicio.ShowDialog();
        }
    }
}
