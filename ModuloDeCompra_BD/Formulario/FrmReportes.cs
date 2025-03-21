using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ModuloDeCompra_BD.Clases;

namespace reporte
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
        }

        private void btnreport_Click(object sender, System.EventArgs e)
        {
            string sentencia = "EXEC sp_SumarVentasPorOrden";
            frmreport ventas = new frmreport(sentencia, "dsCompra", "Reporte.rptVentasOrden.rdlc");
            ventas.ShowDialog();
        }
        private void btnProveedor_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC sp_Proveedores_ProductosComprados";
            frmreport ventas = new frmreport(sentencia, "dsReporteProveedores", "Reporte.rpt_Reporte_Proveedores.rdlc");
            ventas.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC sp_ReporteComprasPorProveedor";
            frmreport ventas = new frmreport(sentencia, "dsReporteComprasVentas", "Reporte.rpt_ReporteComprasVentas.rdlc");
            ventas.ShowDialog();
        }

        private void btnDevoluciones_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC rpt_Reporte_DevolucionesProducto";
            frmreport ventas = new frmreport(sentencia, "dsReporteDevolucionesProducto", "Reporte.rpt_ReporteDevolucionesProducto.rdlc");
            ventas.ShowDialog();
        }

        private void btnstock_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC sp_ReporteEstadoStock";
            frmreport ventas = new frmreport(sentencia, "dsReporteEstadoStock", "Reporte.rpt_ReporteEstadoStock.rdlc");
            ventas.ShowDialog();
        }

        private void btnIva_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC sp_ReporteIVAProductosServicios";
            frmreport ventas = new frmreport(sentencia, "dsReporteIVAPS", "Reporte.rpt_ReporteIVAProductos_Servicios.rdlc");
            ventas.ShowDialog();
        }

        private void btnmovimientos_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC sp_MovimientosInventario";
            frmreport ventas = new frmreport(sentencia, "dsReporteMovimientosInventario", "Reporte.rpt_ReporteMovimientosInventario.rdlc");
            ventas.ShowDialog();
        }
        //allison
        private void btnrequisicion_Click(object sender, EventArgs e)
        {

        }

        private void btnusuario_Click(object sender, EventArgs e)
        {

        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {

        }

        private void btnProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
