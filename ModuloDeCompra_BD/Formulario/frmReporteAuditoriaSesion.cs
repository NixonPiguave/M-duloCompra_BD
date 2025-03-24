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
    public partial class frmReporteAuditoriaSesion : Form
    {
        public frmReporteAuditoriaSesion()
        {
            InitializeComponent();
        }

        private void frmReporteAuditoriaSesion_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;

            DataTable dt = CsComandosSql.RetornaDatos("select * from Usuario");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbUsuarios.Items.Add(dt.Rows[i]["Usuario"].ToString());
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final");
                return;
            }

            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

            if (chbUsuario.Checked == true)
            {
                chbGeneral.Checked = false;
                if (cbUsuarios.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un usuario");
                    return;
                }

                string usuarioSeleccionado = cbUsuarios.SelectedItem.ToString();
                string sentencia = $"Select * from AuditoriaSesion where Usuario = '{usuarioSeleccionado}' and Fecha between '{fechaDesde:yyyy-MM-dd HH:mm:ss}' and '{fechaHasta:yyyy-MM-dd HH:mm:ss}'";

                frmreport reporteAuditoriaSesion = new frmreport(sentencia, "dsAuditoriaSesion", "Reporte.rpt_AuditoriaSesion.rdlc");
                reporteAuditoriaSesion.ShowDialog();
            }
            else if (chbGeneral.Checked == true)
            {
                chbUsuario.Checked = false;
                string sentencia = $"Select * from AuditoriaSesion where Fecha between '{fechaDesde:yyyy-MM-dd HH:mm:ss}' and '{fechaHasta:yyyy-MM-dd HH:mm:ss}'";

                frmreport reporteAuditoriaSesion = new frmreport(sentencia, "dsAuditoriaSesion", "Reporte.rpt_AuditoriaSesion.rdlc");
                reporteAuditoriaSesion.ShowDialog();
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
                lblDesde.Visible = true;
                lblHasta.Visible = true;
                dtpDesde.Visible = true;
                dtpHasta.Visible = true;
            }
            else
            {
                lblUsuario.Visible = false;
                cbUsuarios.Visible = false;
                btnGenerarReporte.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
                dtpDesde.Visible = false;
                dtpHasta.Visible = false;
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
                lblDesde.Visible = true;
                lblHasta.Visible = true;
                dtpDesde.Visible = true;
                dtpHasta.Visible = true;
            }
            else
            {
                lblUsuario.Visible = false;
                cbUsuarios.Visible = false;
                btnGenerarReporte.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
                dtpDesde.Visible = false;
                dtpHasta.Visible = false;
            }
        }
    }
}
