using Menú.Formularios;
using ModuloDeCompra_BD.Clases;
using ModuloDeCompra_BD.Formulario;
using ModuloDeCompra_BD.Properties;
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
    public partial class FrmMenu3: Form
    {

        //uwuasa
        int IDusuario;
        public FrmMenu3()
        {
            InitializeComponent();
        }

        private Form activeForm = null;

        public int IDusuario1 { get => IDusuario; set => IDusuario = value; }

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
            pnlRequisiciones.BringToFront();

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            pnMantenimientos.Visible = false;
            pnlRequisiciones.Visible = false;
            if (!pnIventario.Visible)
                pnIventario.Visible = true;
            else
                pnIventario.Visible = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            pnIventario.Visible = false;
            pnlRequisiciones.Visible = false;
            if (!pnMantenimientos.Visible)
                pnMantenimientos.Visible = true;
            else
                pnMantenimientos.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnIventario.Visible = false;
            pnMantenimientos.Visible = false;
            pnlRequisiciones.Visible = false;
            dgvOrdenesRequisicion.DataSource = CsComandosSql.RetornaDatos("select * from Requisicion");
        }

        private void btnOrdenesCompra_Click(object sender, EventArgs e)
        {

        }

        private void btnRequisiciones_Click(object sender, EventArgs e)
        {
            if (pnlRequisiciones.Visible == false)
            {
                pnlRequisiciones.Visible = true;
                pnIventario.Visible = false;
                pnMantenimientos.Visible = false;
            }
            else if (pnlRequisiciones.Visible == true)
            { 
                pnlRequisiciones.Visible = false;
            }
            else
            { 
                pnlRequisiciones.Visible = false;
                pnIventario.Visible = false;
                pnMantenimientos.Visible = false;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios user = new FrmUsuarios();
            pnMantenimientos.Visible = false;
            pnlRequisiciones.Visible = false;
            openChildForm(user);
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            FrmCategorias frmCate = new FrmCategorias();
            pnMantenimientos.Visible=false;
            pnlRequisiciones.Visible = false;
            openChildForm(frmCate);
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            pnMantenimientos.Visible = false;
            pnlRequisiciones.Visible = false;
            FrmProveedores frmProveedores = new FrmProveedores();
            openChildForm(frmProveedores);
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            pnMantenimientos.Visible = false;
            pnlRequisiciones.Visible = false;
            FrmProductos frmProductos = new FrmProductos();
            openChildForm(frmProductos);
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            pnMantenimientos.Visible = false;
            pnlRequisiciones.Visible = false;
            FrmRol frRol = new FrmRol();
            openChildForm(frRol);
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            pnMantenimientos.Visible = false;
            pnlRequisiciones.Visible = false;
            FrmDepartamento frmDepartamento = new FrmDepartamento();
            openChildForm(frmDepartamento);
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            pnMantenimientos.Visible = false;
            pnlRequisiciones.Visible = false;
            FrmIVA frmIVA = new FrmIVA();
            openChildForm(frmIVA);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            pnIventario.Visible = false;
            pnlRequisiciones.Visible = false;
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            pnIventario.Visible = false;
            pnlRequisiciones.Visible = false;
            FrmBodega frmBodega = new FrmBodega();
            openChildForm(frmBodega);
        }

        private void btnCrearRequisicion_Click(object sender, EventArgs e)
        {
            FrmRequisiciones req = new FrmRequisiciones();
            pnlRequisiciones.Visible = false;
            req.IDUsuario1 = IDusuario;
            openChildForm(req);
        }

        private void btnRequisicionesPendientes_Click(object sender, EventArgs e)
        {
            FrmEstadoRequisiciones frmEstado = new FrmEstadoRequisiciones();
            openChildForm(frmEstado);
            pnlRequisiciones.Visible = false;
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {

        }
    }
}
