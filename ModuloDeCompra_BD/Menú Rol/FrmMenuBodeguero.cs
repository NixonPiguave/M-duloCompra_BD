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
    public partial class FrmMenuBodeguero: Form
    {
        public string rol;
        //uwuasa
        int IDusuario;
        public FrmMenuBodeguero()
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

        }
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (!pnIventario.Visible)
                pnIventario.Visible = true;
            else
                pnIventario.Visible = false;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CsComandosSql.InserDeletUpdate("insert into AuditoriaSesion (Usuario, Accion, Fecha, Detalles) values (SUSER_NAME(), 'INICIO SESIÓN', GETDATE(), 'El usuario '+ SUSER_NAME() + ' ha iniciado sesión')");
            pnIventario.Visible = false;
            dgvOrdenesRequisicion.DataSource = CsComandosSql.RetornaDatos("select * from Requisicion");         
        }


 

        private void guna2Button8_Click(object sender, EventArgs e) //movimientos
        {
            pnIventario.Visible = false;
        }

        private void guna2Button9_Click(object sender, EventArgs e) // bodega
        {
            pnIventario.Visible = false;
            FrmBodega frmBodega = new FrmBodega();
            openChildForm(frmBodega);
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            FrmRTV frmRTV = new FrmRTV();
            openChildForm(frmRTV);
            pnIventario.Visible = false;
        }


        private void btnInventariooo_Click(object sender, EventArgs e)
        {
            FrmInventario invent = new FrmInventario();
            pnIventario.Visible = false;
            openChildForm(invent);

        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes reportes = new FrmReportes();
            pnIventario.Visible = false;
            openChildForm(reportes);
        }

        private void FrmMenuBodeguero_FormClosing(object sender, FormClosingEventArgs e)
        {
            string query = "insert into AuditoriaSesion (Usuario, Accion, Fecha, Detalles) values (SUSER_NAME(), 'CERRAR SESIÓN', GETDATE(), 'El usuario '+ SUSER_NAME() + ' ha cerrado sesión')";
            CsComandosSql.InserDeletUpdate(query);
        }

        private void btnRecepcion_Click(object sender, EventArgs e)
        {
            FrmRecepcionCompra recepcionCompra = new FrmRecepcionCompra();
            pnIventario.Visible = false;
            openChildForm(recepcionCompra);
        }
    }
}
