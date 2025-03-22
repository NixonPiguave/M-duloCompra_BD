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
    public partial class FrmMenuComprador: Form
    {
        public string rol;
        //uwuasa
        int IDusuario;
        public FrmMenuComprador()
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
            pnlSubMenuOrdenCompra.BringToFront();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            CsComandosSql.InserDeletUpdate("insert into AuditoriaSesion (Usuario, Accion, Fecha, Detalles) values (SUSER_NAME(), 'INICIO SESIÓN', GETDATE(), 'El usuario '+ SUSER_NAME() + ' ha iniciado sesión')");
            dgvOrdenesRequisicion.DataSource = CsComandosSql.RetornaDatos("select * from Requisicion");

        }

        private void btnOrdenesCompra_Click(object sender, EventArgs e)
        {
            if (!pnlSubMenuOrdenCompra.Visible)
                pnlSubMenuOrdenCompra.Visible = true;
            else
                pnlSubMenuOrdenCompra.Visible = false;
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes reportes = new FrmReportes();
            openChildForm(reportes);
        }

        private void btnOrdenCompraRequisicion_Click(object sender, EventArgs e)
        {
            FrmOrdenCompra frmOrdenCompra = new FrmOrdenCompra();
            frmOrdenCompra.IdUsuario = IDusuario;;
            openChildForm(frmOrdenCompra);
        }

        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            FrmOrdenCompraDirecta frmDirecta = new FrmOrdenCompraDirecta();
            frmDirecta.IdUsuario = IDusuario;

            pnlSubMenuOrdenCompra.Visible = false;
            openChildForm(frmDirecta);
        }

        private void FrmMenuComprador_FormClosing(object sender, FormClosingEventArgs e)
        {
            string query = "insert into AuditoriaSesion (Usuario, Accion, Fecha, Detalles) values (SUSER_NAME(), 'CERRAR SESIÓN', GETDATE(), 'El usuario '+ SUSER_NAME() + ' ha cerrado sesión')";
            CsComandosSql.InserDeletUpdate(query);
        }


    }
}
