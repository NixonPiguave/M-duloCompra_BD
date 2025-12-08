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

namespace ModuloDeCompra_BD.Clases
{
    public partial class fecha : Form
    {
        public fecha()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            if (dtpDesde.Visible && dtpDesde.Value > dtpHasta.Value)
            {
                MessageBox.Show("La fecha inicial no puede ser mayor que la fecha final", "Error de fechas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!chbGeneralFecha.Checked && !chbFecha.Checked)
            {
                MessageBox.Show("Por favor, seleccione una opción de reporte", "Opción requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime fechaDesde = dtpDesde.Value.Date;
            DateTime fechaHasta = dtpHasta.Value.Date.AddDays(1).AddSeconds(-1);
            if (chbFecha.Checked == true)
            {
                string sentencia = $"SELECT \r\n    g.ID_GRN,\r\n    g.Fecha_Generada,\r\n    g.Estado,\r\n    g.TotalPagar,\r\n    g.TotalDevuelto,\r\n    g.TotalPagar - g.TotalDevuelto AS Neto,\r\n    c.Fecha_Registro,\r\n    c.Total_Valor,\r\n    c.Total_Bodega,\r\n    c.Diferencia,\r\n    c.Estado_Contable,\r\n    c.Usuario_Registro,\r\n    p.Nombre_Proveedor AS Proveedor\r\nFROM GRN_Header g\r\nLEFT JOIN [CG-GRN_Contable] c ON g.ID_GRN = c.ID_GRN\r\nLEFT JOIN [OC-Proveedores] p ON g.ID_Proveedor = p.ID_Proveedor\r\nWHERE \r\n    (CONVERT(date, g.Fecha_Generada) = CONVERT(date, '{fechaDesde:yyyy-MM-dd HH:mm:ss}')\r\n    OR CONVERT(date, g.Fecha_Generada) = CONVERT(date, '{fechaHasta:yyyy-MM-dd HH:mm:ss}'))\r\nORDER BY g.Fecha_Generada ASC";

                frmreport ventas = new frmreport(sentencia, "dsGRN", "Reporte.rptgrn.rdlc");
                ventas.ShowDialog();
            }
            else
            {
                string sentencia = $"SELECT \r\n    g.ID_GRN,\r\n    g.Fecha_Generada,\r\n    g.Estado,\r\n    g.TotalPagar,\r\n    g.TotalDevuelto,\r\n    g.TotalPagar - g.TotalDevuelto AS Neto,\r\n    c.Fecha_Registro,\r\n    c.Total_Valor,\r\n    c.Total_Bodega,\r\n    c.Diferencia,\r\n    c.Estado_Contable,\r\n    c.Usuario_Registro,\r\n    p.Nombre_Proveedor AS Proveedor\r\nFROM GRN_Header g\r\nLEFT JOIN [CG-GRN_Contable] c ON g.ID_GRN = c.ID_GRN\r\nLEFT JOIN [OC-Proveedores] p ON g.ID_Proveedor = p.ID_Proveedor\r\nORDER BY g.Fecha_Generada asc";

                frmreport ventas = new frmreport(sentencia, "dsGRN", "Reporte.rptgrn.rdlc");
                ventas.ShowDialog();
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
                btnGenerarReporte.Visible = true;

            }
            else
            {
                dtpDesde.Visible = false;
                dtpHasta.Visible = false;
                lblDesde.Visible = false;
                lblHasta.Visible = false;
                btnGenerarReporte.Visible = true;
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
                btnGenerarReporte.Visible = true;
            }
        }
    }
}
