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
    public partial class FrmMenuJefeDepartamental: Form
    {
        public string rol;
        //uwuasa
        int IDusuario;
        public FrmMenuJefeDepartamental()
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

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CsComandosSql.InserDeletUpdate("insert into AuditoriaSesion (Usuario, Accion, Fecha, Detalles) values (SUSER_NAME(), 'INICIO SESIÓN', GETDATE(), 'El usuario '+ SUSER_NAME() + ' ha iniciado sesión')");
            dgvOrdenesRequisicion.DataSource = CsComandosSql.RetornaDatos("select * from Requisicion");

        }

        private void btnRequisicionesPendientes_Click(object sender, EventArgs e)
        {
            

           
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            FrmReportes reportes = new FrmReportes();
            openChildForm(reportes);
        }


        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            FrmOrdenCompraDirecta frmDirecta = new FrmOrdenCompraDirecta();
            frmDirecta.IdUsuario = IDusuario;
            openChildForm(frmDirecta);
        }

        private void FrmMenuJefeDepartamental_FormClosing(object sender, FormClosingEventArgs e)
        {
            string query = "insert into AuditoriaSesion (Usuario, Accion, Fecha, Detalles) values (SUSER_NAME(), 'CERRAR SESIÓN', GETDATE(), 'El usuario '+ SUSER_NAME() + ' ha cerrado sesión')";
            CsComandosSql.InserDeletUpdate(query);
        }    
    }
}
