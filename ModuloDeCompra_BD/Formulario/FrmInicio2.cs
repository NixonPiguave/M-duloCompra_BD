using Guna.UI2.WinForms;
using ModuloDeCompra_BD.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú
{
    public partial class FrmInicio2: Form
    {
        
        public FrmInicio2()
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
            pn2.Controls.Add(childForm);
            pn2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            pnIventario.BringToFront();
            pnMantenimientos.BringToFront();
      
        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            pnMantenimientos.Visible = false;
            if (!pnIventario.Visible)
                pnIventario.Visible = true;
            else
                pnIventario.Visible = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            pnIventario.Visible = false;
            if (!pnMantenimientos.Visible)
                pnMantenimientos.Visible = true;
            else
                pnMantenimientos.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnIventario.Visible = false;
            pnMantenimientos.Visible = false;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            FrmUsuarios user = new FrmUsuarios();
            openChildForm(user);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            FrmProductos productos = new FrmProductos();
            openChildForm(productos);
        }
    }
}
