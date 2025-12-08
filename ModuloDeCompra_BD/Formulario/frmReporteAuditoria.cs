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
    public partial class frmReporteAuditoria : Form
    {
        public frmReporteAuditoria()
        {
            InitializeComponent();
        }

        private void frmReporteAuditoria_Load(object sender, EventArgs e)
        {
            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;

            DataTable dt = CsComandosSql.RetornaDatos("select * from [MC-Usuario]");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbUsuarios.Items.Add(dt.Rows[i]["Usuario"].ToString());
            }
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Visible && dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final");
                return;
            }

            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);

            string sentencia="";

            if (chbUsuario.Checked)
            {
                if (cbUsuarios.SelectedItem == null)
                {
                    MessageBox.Show("Por favor, seleccione un usuario");
                    return;
                }

                if (chbFecha.Checked)
                {
                    sentencia = $"Select * from [MC-Auditoria] where Usuario = '{cbUsuarios.SelectedItem}' and Fecha between '{fechaDesde:yyyy-MM-dd HH:mm:ss}' and '{fechaHasta:yyyy-MM-dd HH:mm:ss}'";
                }
                else
                {
                    sentencia = $"Select * from [MC-Auditoria] where Usuario = '{cbUsuarios.SelectedItem}'";
                }
            }
            else if (chbGeneral.Checked)
            {
                if (chbFecha.Checked)
                {
                    sentencia = $"Select * from [MC-Auditoria] where Fecha between '{fechaDesde:yyyy-MM-dd HH:mm:ss}' and '{fechaHasta:yyyy-MM-dd HH:mm:ss}'";
                }
                else
                {
                    sentencia = "Select * from [MC-Auditoria]";
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un opcion de reporte");
            }

                frmreport reporteAuditoria = new frmreport(sentencia, "dsAuditoria", "Reporte.rpt_Auditoria.rdlc");
            reporteAuditoria.ShowDialog();
        }

        private void chbGeneral_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGeneral.Checked == true)
            {
                chbUsuario.Checked = false;
                lblUsuario.Visible = false;
                cbUsuarios.Visible = false;
                btnGenerarReporte.Visible = true;
                pnlFecha.Visible = true;
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
                pnlFecha.Visible = false;
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
                pnlFecha.Visible = true;
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
                pnlFecha.Visible = false;
            }
        }

        private void chbGeneralFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chbGeneralFecha.Checked)
            {
                chbFecha.Checked = false;
                dtpDesde.Visible = false;
                dtpHasta.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
            }

        }
        private void chbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (chbFecha.Checked)
            {
                chbGeneralFecha.Checked = false;
                dtpDesde.Visible = true;
                dtpHasta.Visible = true;
                lblDesde.Visible = true;
                lblHasta.Visible = true;
            }
            else
            {
                dtpDesde.Visible = false;
                dtpHasta.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
            }
        }

        private void lblDesde_Click(object sender, EventArgs e)
        {

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblHasta_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
