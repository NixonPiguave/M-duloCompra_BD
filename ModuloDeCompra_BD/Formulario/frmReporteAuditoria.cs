using ModuloDeCompra_BD.Clases;
using reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class frmReporteAuditoria: Form
    {
        public frmReporteAuditoria()
        {
            InitializeComponent();
        }

        private void frmReporteAuditoria_Load(object sender, EventArgs e)
        {
            DataTable dt = CsComandosSql.RetornaDatos("select * from Usuario");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbUsuarios.Items.Add(dt.Rows[i]["Usuario"].ToString());
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (chbUsuario.Checked == true)
            {
                chbGeneral.Checked = false;
                if (cbUsuarios.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un usuario.");
                    return;
                }
                string usuarioSeleccionado = cbUsuarios.SelectedItem.ToString();
                string sentencia = $"Select * from Auditoria where Usuario = '{usuarioSeleccionado}'";
                frmreport reporteAuditoria = new frmreport(sentencia, "dsAuditoria", "Reporte.rpt_Auditoria.rdlc");
                reporteAuditoria.ShowDialog();
            }else if (chbGeneral.Checked==true)
            {
                chbUsuario.Checked = false;
                string sentencia = $"Select * from Auditoria ";
                frmreport reporteAuditoria = new frmreport(sentencia, "dsAuditoria", "Reporte.rpt_Auditoria.rdlc");
                reporteAuditoria.ShowDialog();
            }
        }

        private void chbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGeneral.Checked == true)
            {
                chbUsuario.Checked = false;
                lblUsuario.Visible = false;
                cbUsuarios.Visible = false;
                btnGenerarReporte.Visible = true;
            }
            else
            {
                lblUsuario.Visible = false;
                cbUsuarios.Visible = false;
                btnGenerarReporte.Visible = false;
            }
        }

        private void chbUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUsuario.Checked == true)
            {
                chbGeneral.Checked = false;
                lblUsuario.Visible = true;
                cbUsuarios.Visible = true;
                btnGenerarReporte.Visible = true;
            }
            else
            {
                lblUsuario.Visible = false;
                cbUsuarios.Visible = false;
                btnGenerarReporte.Visible = false;
            }
        }
    }
}
