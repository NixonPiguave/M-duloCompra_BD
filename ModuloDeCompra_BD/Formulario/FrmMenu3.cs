using Menú.Formularios;
using ModuloDeCompra_BD.Clases;
using ModuloDeCompra_BD.Formulario;
using ModuloDeCompra_BD.Properties;
using reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú
{
    public partial class FrmMenu3: Form
    {
        public string rol;
        //uwuasa
        int IDusuario;
        int []botones;
        public FrmMenu3()
        {
            InitializeComponent();
            CargarLogoEmpresa();
        }

        private Form activeForm = null;

        public int IDusuario1 { get => IDusuario; set => IDusuario = value; }
        public int[] Botones { get => botones; set => botones = value; }

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
            pnlSubMenuOrdenCompra.BringToFront();

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            pnMantenimientos.Visible = false;
            pnlSubMenuOrdenCompra.Visible = false;
            pnlRequisiciones.Visible = false;
            if (!pnIventario.Visible)
                pnIventario.Visible = true;
            else
                pnIventario.Visible = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            pnlSubMenuOrdenCompra.Visible = false;
            pnIventario.Visible = false;
            pnlRequisiciones.Visible = false;
            if (!pnMantenimientos.Visible)
                pnMantenimientos.Visible = true;
            else
                pnMantenimientos.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CsComandosSql.InserDeletUpdate("insert into AuditoriaSesion (Usuario, Accion, Fecha, Detalles) values (SUSER_NAME(), 'INICIO SESIÓN', GETDATE(), 'El usuario '+ SUSER_NAME() + ' ha iniciado sesión')");
            pnIventario.Visible = false;
            pnMantenimientos.Visible = false;
            pnlRequisiciones.Visible = false;
            dgvOrdenesRequisicion.DataSource = CsComandosSql.RetornaDatos("select * from Requisicion");
        }

        private void btnOrdenesCompra_Click(object sender, EventArgs e)
        {
            pnMantenimientos.Visible = false;
            pnIventario.Visible = false;
            pnlRequisiciones.Visible = false;
            if (!pnlSubMenuOrdenCompra.Visible)
                pnlSubMenuOrdenCompra.Visible = true;
            else
                pnlSubMenuOrdenCompra.Visible = false;
        }

        private void btnRequisiciones_Click(object sender, EventArgs e)
        {
            if (pnlRequisiciones.Visible == false)
            {
                pnlRequisiciones.Visible = true;
                pnIventario.Visible = false;
                pnMantenimientos.Visible = false;
                pnlSubMenuOrdenCompra.Visible = false;
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
                pnlSubMenuOrdenCompra.Visible = false;
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuario = new FrmUsuarios();
            openChildForm(usuario);
            pnMantenimientos.Visible=false;
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
            pnlSubMenuOrdenCompra.Visible = false;
            pnMantenimientos.Visible=false;
            FrmMovimientoInventario frmInventario = new FrmMovimientoInventario();
            openChildForm(frmInventario);
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
            FrmAprobarRequisicion frmAprobarRequisicion = new FrmAprobarRequisicion();
            frmAprobarRequisicion.IdUsuario = IDusuario;
            openChildForm(frmAprobarRequisicion);
            pnlRequisiciones.Visible = false;
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            FrmRTV frmRTV = new FrmRTV();
            openChildForm(frmRTV);
            pnlRequisiciones.Visible = false;
            pnIventario.Visible = false;
            pnMantenimientos.Visible = false;
        }

        private void btnUsuarioSistemaaa_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuario = new FrmUsuarios();
            openChildForm(usuario);
            pnMantenimientos.Visible = false;
        }

        private void btnInventariooo_Click(object sender, EventArgs e)
        {
            FrmInventario invent = new FrmInventario();
            pnIventario.Visible = false;
            pnlRequisiciones.Visible = false;
            pnMantenimientos.Visible = false;
            openChildForm(invent);

        }

        private void btnEmpresa_Click(object sender, EventArgs e)
        {
            FrmEmpresa frmEmpresa = new FrmEmpresa();
            pnMantenimientos.Visible = false;
            pnlRequisiciones.Visible = false;
            openChildForm(frmEmpresa);
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes reportes = new FrmReportes();
            pnIventario.Visible = false;
            pnlRequisiciones.Visible = false;
            pnMantenimientos.Visible = false;
            openChildForm(reportes);
        }

        private void btnOrdenCompraRequisicion_Click(object sender, EventArgs e)
        {
            FrmOrdenCompra frmOrdenCompra = new FrmOrdenCompra();
            frmOrdenCompra.IdUsuario = IDusuario;
            pnIventario.Visible = false;
            pnlRequisiciones.Visible = false;
            pnMantenimientos.Visible = false;
            openChildForm(frmOrdenCompra);
        }

        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            FrmOrdenCompraDirecta frmDirecta = new FrmOrdenCompraDirecta();
            frmDirecta.IdUsuario = IDusuario;
            pnIventario.Visible = false;
            pnlRequisiciones.Visible = false;
            pnMantenimientos.Visible = false;
            pnlSubMenuOrdenCompra.Visible = false;
            openChildForm(frmDirecta);
        }

        private void FrmMenu3_FormClosing(object sender, FormClosingEventArgs e)
        {
            string query = "insert into AuditoriaSesion (Usuario, Accion, Fecha, Detalles) values (SUSER_NAME(), 'CERRAR SESIÓN', GETDATE(), 'El usuario '+ SUSER_NAME() + ' ha cerrado sesión')";
            CsComandosSql.InserDeletUpdate(query);
        }

        private void pbEditarEmpresa_Click(object sender, EventArgs e)
        {
            FrmEditarEmpresa EditarEmpresa = new FrmEditarEmpresa();
            EditarEmpresa.ShowDialog();
            CargarLogoEmpresa();
        }
        private void CargarLogoEmpresa()
        {
            string sentencia = "Select Logo_Empresa from Empresa where ID_Empresa = 1";
            DataTable dt = CsComandosSql.RetornaDatos(sentencia);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                if (row["Logo_Empresa"] != DBNull.Value)
                {
                    byte[] imagenBytes = (byte[])row["Logo_Empresa"];
                    using (MemoryStream ms = new MemoryStream(imagenBytes))
                    {
                        pbEditarEmpresa.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    pbEditarEmpresa.Image = null; 
                }
            }
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            FrmRecepcionCompra recepcionCompra = new FrmRecepcionCompra();
            pnIventario.Visible = false;
            pnlRequisiciones.Visible = false;
            pnMantenimientos.Visible = false;
            pnlSubMenuOrdenCompra.Visible = false;
            openChildForm(recepcionCompra);
        }
    }
}
