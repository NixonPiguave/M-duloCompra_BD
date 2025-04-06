﻿using System;
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
using ModuloDeCompra_BD.Formulario;

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
        private void btnDetalles_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC ObtenerOrdenesCompraConDetalles";
            frmreport ventas = new frmreport(sentencia, "dsOrdenesDetalles", "Reporte.dArpt_OrdenesDetalles.rdlc");
            ventas.ShowDialog();
        }
        private void btnrequisicion_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC ObtenerRequisicionesConDetalles";
            frmreport ventas = new frmreport(sentencia, "dsRequisicionesDetalle", "Reporte.dArpt_RequisicionesDetalles.rdlc");
            ventas.ShowDialog();
        }
        private void btnCategoria_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC rpt_ObtenerCategoriasConDetalles";
            frmreport ventas = new frmreport(sentencia, "dsCategoriaDetalles", "Reporte.dArpt_CategoriasDetalles.rdlc");
            ventas.ShowDialog();
        }
        private void btnusuario_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC rpt_RolesPorUsuario";
            frmreport ventas = new frmreport(sentencia, "dsUsuarioRoles", "Reporte.dArpt_UsuarioRoles.rdlc");
            ventas.ShowDialog();
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            string sentencia = "EXEC rpt_DetallesPorRequisicion";
            frmreport ventas = new frmreport(sentencia, "dsProductoRequiDetalles", "Reporte.dArpt_ProductosRequiDetalles.rdlc");
            ventas.ShowDialog();
        }

        private void btnReportAuditoria_Click(object sender, EventArgs e)
        {
            frmReporteAuditoria audit = new frmReporteAuditoria();
            audit.ShowDialog();
        }

        private void btnReporteSesion_Click(object sender, EventArgs e)
        {
            frmReporteAuditoriaSesion audit = new frmReporteAuditoriaSesion();
            audit.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string sentencia = "SELECT \r\n    RD.ID_GRN,\r\n    RD.Cantidad,\r\n    P.NomProducto,\r\n    S.Nom_Servicio,\r\n    RH.Fecha_RTV,\r\n    RH.Motivo,\r\n    CASE \r\n        WHEN S.Nom_Servicio IS NOT NULL THEN 'Service'\r\n        WHEN P.NomProducto IS NOT NULL THEN 'Product'\r\n        ELSE 'Unknown' \r\n    END AS RecordType\r\nFROM RTV_Header RH \r\nINNER JOIN RTV_Details RD ON RH.ID_RTV = RD.ID_RTV \r\nLEFT JOIN Producto P ON RD.ID_Producto = P.ID_Producto\r\nLEFT JOIN Servicio S ON RD.ID_Servicio = S.ID_Servicio\r\nORDER BY \r\n    RH.Fecha_RTV asc, \r\n    RecordType,     \r\n    COALESCE(S.Nom_Servicio, P.NomProducto)  ";
            frmreport ventas = new frmreport(sentencia, "dsDevolucion", "Reporte.rptDevolucion.rdlc");
            ventas.ShowDialog();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string sentencia = "SELECT \r\n    g.ID_GRN,\r\n    g.Fecha_Generada,\r\n    g.Estado,\r\n    g.TotalPagar,\r\n    g.TotalDevuelto,\r\n    g.TotalPagar - g.TotalDevuelto AS Neto,\r\n    c.Fecha_Registro,\r\n    c.Total_Valor,\r\n    c.Total_Bodega,\r\n    c.Diferencia,\r\n    c.Estado_Contable,\r\n    c.Usuario_Registro,\r\n    p.Nombre_Proveedor AS Proveedor\r\nFROM GRN_Header g\r\nLEFT JOIN GRN_Contable c ON g.ID_GRN = c.ID_GRN\r\nLEFT JOIN Proveedores p ON g.ID_Proveedor = p.ID_Proveedor\r\nORDER BY g.Fecha_Generada asc;";
            frmreport ventas = new frmreport(sentencia, "dsGRN", "Reporte.rptgrn.rdlc");
            ventas.ShowDialog();
        }
    }
}
