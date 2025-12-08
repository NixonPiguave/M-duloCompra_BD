using ModuloDeCompra_BD.Clases;
using reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmRecepcionCompra : Form
    {
        public FrmRecepcionCompra()
        {
            InitializeComponent();
            dgvDetalleOrden.EditMode = DataGridViewEditMode.EditOnEnter;

        }

        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            FrmListadoOrdenCompra ordenCompra = new FrmListadoOrdenCompra();
            ordenCompra.ShowDialog();
            txtOrdenCompra.Text = ordenCompra.IdCat1.ToString();
            txtProveedor.Text = ordenCompra.IdProv.ToString();
            int idorden = ordenCompra.IdCat1;
            if (txtProveedor.Text != 0.ToString())
            {
                OrdenyGrn(idorden, cbTipoGRN.SelectedIndex);
                ActualizarEstadoRecibido(idorden);
                DataTable tb = CsComandosSql.RetornaDatos($"select Nombre_Proveedor from [OC-Proveedores] where ID_Proveedor={ordenCompra.IdProv}");
                if (tb.Rows.Count > 0)
                {
                    string Provedorname = tb.Rows[0]["Nombre_Proveedor"].ToString();
                    txtNombreProveedor.Text = Provedorname;
                }
            }
        }
        private void OrdenyGrn(int idorden, int index)
        {

            dgvDetalleOrden.AutoGenerateColumns = true;
            dgvDetalleOrden.DataSource = null;

            string query = (index == 0) ? $@"
        SELECT 
            d.ID_Detail AS Detalle_De_Compra,
            p.ID_Producto, 
            p.NomProducto AS Producto,
            d.Cantidad AS Cantidad_Ordenada,
            0 AS CantidadRecibida,
            d.Cantidad - ISNULL(
                (
                    SELECT SUM(gd.Cantidad) 
                    FROM [IN-Grn_Details] gd
                    INNER JOIN [IN-GRN_Header] gh ON gd.ID_GRN = gh.ID_GRN
                    WHERE gd.ID_Producto = d.ID_Producto
                    AND gh.ID_Orden = {idorden}
                ), 0
            ) AS Cantidad_Pendiente,
            d.Costo AS Costo_Unitario
        FROM [OC-Detalle_Orden] d
        INNER JOIN [OC-Orden_Compra] o ON d.ID_Orden = o.ID_Orden
        LEFT JOIN [IN-Producto] p ON d.ID_Producto = p.ID_Producto
        WHERE o.ID_Orden = {idorden}
        AND d.Estado = 'Pendiente';
    "
            :
            $@"
        SELECT 
            d.ID_Detail AS Detalle_De_Compra,
            p.ID_Producto, 
            p.NomProducto AS Producto,
            d.Cantidad AS Cantidad_Ordenada,
            d.Cantidad - ISNULL(
                (
                    SELECT SUM(gd.Cantidad)
                    FROM [IN-Grn_Details] gd
                    INNER JOIN [IN-GRN_Header] gh ON gd.ID_GRN = gh.ID_GRN
                    WHERE gd.ID_Producto = d.ID_Producto
                    AND gh.ID_Orden = {idorden}
                ), 0
            ) AS Cantidad_Pendiente,
            d.Costo AS Costo_Unitario
        FROM [OC-Detalle_Orden] d
        INNER JOIN [OC-Orden_Compra] o ON d.ID_Orden = o.ID_Orden
        LEFT JOIN [IN-Producto] p ON d.ID_Producto = p.ID_Producto
        WHERE o.ID_Orden = {idorden}
        AND d.Estado = 'Pendiente';
    ";


            DataTable dt = CsComandosSql.RetornaDatos(query);
            dgvDetalleOrden.DataSource = dt;


            dgvDetalleOrden.RowTemplate.Height = 30;
            lbCantRecib.Visible = (index == 0);


            if (!dgvDetalleOrden.Columns.Contains("Bodega"))
            {
                DataGridViewComboBoxColumn colBodega = new DataGridViewComboBoxColumn();
                colBodega.Name = "Bodega";
                colBodega.HeaderText = "Bodega Destino";
                colBodega.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
                colBodega.Width = 150;
                dgvDetalleOrden.Columns.Add(colBodega);
            }


            if (index == 0)
            {
                foreach (DataGridViewColumn col in dgvDetalleOrden.Columns)
                {

                    if (col.Name == "CantidadRecibida" || col.Name == "Bodega")
                    {
                        col.ReadOnly = false;
                    }
                    else
                    {

                        col.ReadOnly = true;
                    }
                }
            }

            foreach (DataGridViewRow row in dgvDetalleOrden.Rows)
            {
                if (row.IsNewRow) continue;

                int idProducto = 0;
                if (row.Cells["ID_Producto"].Value != null &&
                    int.TryParse(row.Cells["ID_Producto"].Value.ToString(), out idProducto))
                {
                    DataTable bodegas = CsComandosSql.RetornaDatos($@"
                SELECT i.ID_Bodega AS ID, b.Ubicacion AS Bodega
                FROM [IN-Inventario] i
                INNER JOIN [IN-Bodega] b ON b.ID_Bodega = i.ID_Bodega
                WHERE i.ID_Producto = {idProducto};
            ");

                    var comboCell = row.Cells["Bodega"] as DataGridViewComboBoxCell;
                    comboCell.DisplayMember = "Bodega";
                    comboCell.ValueMember = "ID";

                    if (bodegas != null && bodegas.Rows.Count > 0)
                    {
                        comboCell.DataSource = bodegas;
                        comboCell.Value = bodegas.Rows[0]["ID"];
                    }
                    else
                    {
                        comboCell.DataSource = null;
                        comboCell.Items.Clear();
                        comboCell.Items.Add("NO INVENTARIABLE");
                        comboCell.Value = "NO INVENTARIABLE";
                        comboCell.ReadOnly = true;
                    }
                }
                else
                {
                    var comboCell = row.Cells["Bodega"] as DataGridViewComboBoxCell;
                    comboCell.DataSource = null;
                    comboCell.Items.Clear();
                    comboCell.Items.Add("NO DATA");
                    comboCell.Value = "NO DATA";
                    comboCell.ReadOnly = true;
                }
            }

            dgvGrnDeOrden.DataSource = CsComandosSql.RetornaDatos(
                $"select * from [IN-GRN_Header] where ID_Orden={idorden}");
        }


        private void ActualizarEstadoRecibido(int idorden)
        {
            foreach (DataGridViewRow fila in dgvDetalleOrden.Rows)
            {
                if (fila.IsNewRow) continue;

                string cantidadPendiente = fila.Cells["Cantidad_Pendiente"].Value?.ToString();
                int cantidadPendienteInt = Convert.ToInt32(cantidadPendiente);

                if (cantidadPendienteInt == 0)
                {
                    string idOrdenDetalle = fila.Cells["Detalle_De_Compra"].Value?.ToString();

                    if (!string.IsNullOrEmpty(idOrdenDetalle))
                    {
                        string updateQuery = $"update [OC-Detalle_Orden] set Estado='Recibido' where  ID_Detail= {idOrdenDetalle};";
                        CsComandosSql.InserDeletUpdate(updateQuery);
                    }
                }
            }
            OrdenyGrn(idorden, cbTipoGRN.SelectedIndex);
        }
        private void dgvDetalleOrden_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDetalleOrden.CurrentCell.ColumnIndex == dgvDetalleOrden.Columns["CantidadRecibida"].Index)
            {
                TextBox editingControl = e.Control as TextBox;
                if (editingControl != null)
                {
                    editingControl.KeyPress -= new KeyPressEventHandler(EditingControl_KeyPress);
                    editingControl.KeyPress += new KeyPressEventHandler(EditingControl_KeyPress);
                }
            }
        }
        private void EditingControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void dgvDetalleOrden_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

            if (dgvDetalleOrden.Columns[e.ColumnIndex].Name == "CantidadRecibida")
            {
                MessageBox.Show("El valor ingresado no es válido. Por favor, ingrese numeros enteros");
                e.Cancel = true;
                dgvDetalleOrden.CancelEdit();
                dgvDetalleOrden[e.ColumnIndex, e.RowIndex].Value = 0;
            }
            else
            {

                e.Cancel = true;
            }
        }

        private void btnGenerarGrn_Click(object sender, EventArgs e)
        {

            try
            {

                foreach (DataGridViewRow row in dgvDetalleOrden.Rows)
                {
                    if (row.IsNewRow) continue;

                    string bodega = row.Cells["Bodega"].Value?.ToString();

                    if (string.IsNullOrEmpty(bodega))
                    {
                        MessageBox.Show("Seleccione la Bodega para cada producto inventariable.",
                            "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string Detalle = "";
                foreach (DataGridViewRow fila in dgvDetalleOrden.Rows)
                {
                    string idBodega = fila.Cells["Bodega"].Value?.ToString();

                    if (cbTipoGRN.SelectedIndex == 0)
                    {
                        if (fila.IsNewRow)
                            continue;

                        string idProducto = fila.Cells["ID_Producto"].Value?.ToString();
                        string cantidad = fila.Cells["CantidadRecibida"].Value?.ToString();
                        string costoU = fila.Cells["Costo_Unitario"].Value?.ToString();
                        int cant = Convert.ToInt32(cantidad);
                        costoU = costoU.Replace(',', '.');
                        if (cant > 0)
                        {
                            Detalle += $@"<GRNDetail>
                                        <Cantidad>{cant}</Cantidad>
                                        <Costo>{costoU}</Costo>
                                        <ID_Producto>{idProducto}</ID_Producto> 
                                        <ID_Bodega>{idBodega}</ID_Bodega>  
                                    </GRNDetail>";
                        }
                    }
                    else
                    {
                        if (fila.IsNewRow)
                            continue;

                        string idProducto = fila.Cells["ID_Producto"].Value?.ToString();
                        string cantidad = fila.Cells["Cantidad_Pendiente"].Value?.ToString();
                        string costoU = fila.Cells["Costo_Unitario"].Value?.ToString();
                        int cant = Convert.ToInt32(cantidad);
                        costoU = costoU.Replace(',', '.');
                        if (cant > 0)
                        {
                            Detalle += $@"<GRNDetail>
                                        <Cantidad>{cant}</Cantidad>
                                        <Costo>{costoU}</Costo>
                                        <ID_Producto>{idProducto}</ID_Producto>  
                                        <ID_Bodega>{idBodega}</ID_Bodega>                      
                                    </GRNDetail>";
                        }
                    }
                }
                string xmlRequisicion = $@"<GRNHeaders>
                                            <GRNHeader>
                                              <Estado>R</Estado>
                                              <TotalPagar>{0}</TotalPagar>
                                              <Origen>O</Origen>
                                              <ID_Orden>{txtOrdenCompra.Text}</ID_Orden>
                                              <ID_Proveedor>{txtProveedor.Text}</ID_Proveedor>
                                            </GRNHeader>
                                            {Detalle}
                                         </GRNHeaders>";
                try
                {

                    if (!string.IsNullOrEmpty(txtDebito.Text) || !string.IsNullOrEmpty(txtCredito.Text))
                    {
                        string query = $@"
                        DECLARE @GRNID INT = 0;
                        EXEC Prueba 
                           '{xmlRequisicion}', 
                            {1}, 
                            '{txtDebito.Text}',  
                            '{txtCredito.Text}',
                            @GRNID;
                            SELECT @GRNID AS GRN_ID";
                        dgvaux.DataSource = CsComandosSql.RetornaDatos(query);
                        if (dgvaux.Rows.Count > 0)
                        {
                            int grnId = Convert.ToInt32(dgvaux.Rows[0].Cells[0].Value);
                            int idorden = Convert.ToInt32(txtOrdenCompra.Text);
                            OrdenyGrn(idorden, cbTipoGRN.SelectedIndex);
                            ActualizarEstadoRecibido(idorden);
                            string sentencia = $@"
                                                    SELECT 
                                                        GH.ID_Orden,
                                                        Pr.Nombre_Proveedor,
                                                        Pr.Correo,
                                                        Pr.Direccion,
                                                        P.NomProducto AS ProductoServicio,
                                                        GD.Cantidad,
                                                        GD.Costo
                                                    FROM [IN-Grn_Details] GD
                                                    INNER JOIN [IN-GRN_Header] GH 
                                                        ON GD.ID_GRN = GH.ID_GRN
                                                    LEFT JOIN [IN-Producto] P 
                                                        ON GD.ID_Producto = P.ID_Producto
                                                    INNER JOIN [OC-Proveedores] Pr 
                                                        ON Pr.ID_Proveedor = GH.ID_Proveedor
                                                    WHERE 
                                                        GD.ID_GRN = {grnId};
                                                    ";

                            frmreport ventas = new frmreport(sentencia, "dsGrn", "Reporte.DocumentoGRNrecibido.rdlc");
                            ventas.ShowDialog();

                        }
                        if (CsComandosSql.InserDeletUpdate(query))
                        {
                            MessageBox.Show("Se ha registrado el GRN");

                        }
                        else
                        {
                            MessageBox.Show("Error");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rellene todos los campos");
                    }
                }
                catch (SqlException esc)
                {
                    MessageBox.Show("Error: " + esc);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al Registrar GRN: " + ex.Message);
            }
        }

        private void dgvDetalleOrden_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetalleOrden.Columns[e.ColumnIndex].Name == "CantidadRecibida")
            {
                var value = dgvDetalleOrden[e.ColumnIndex, e.RowIndex].Value;
                if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                {
                    dgvDetalleOrden[e.ColumnIndex, e.RowIndex].Value = 0;
                    return;
                }
                int cantidadPendiente = Convert.ToInt32(dgvDetalleOrden[6, e.RowIndex].Value);
                int cantidadRecibida = Convert.ToInt32(dgvDetalleOrden[e.ColumnIndex, e.RowIndex].Value?.ToString());
                if (cantidadRecibida > cantidadPendiente)
                {
                    MessageBox.Show("La cantidad recibida no puede ser mayor que la cantidad pendiente.");
                    dgvDetalleOrden[e.ColumnIndex, e.RowIndex].Value = 0;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dgvDetalleOrden.DataSource = null;
            dgvGrnDeOrden.DataSource = null;
            txtProveedor.Text = string.Empty;
            txtOrdenCompra.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            lbCantRecib.Visible = false;
        }

        private void FrmRecepcionCompra_Load(object sender, EventArgs e)
        {
            lbCantRecib.Visible = false;
            cbTipoGRN.SelectedIndex = 0;

        }

        private void dgvDetalleOrden_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (dgvDetalleOrden.Columns[e.ColumnIndex].Name == "CantidadRecibida" && e.RowIndex >= 0)
            {

                if (dgvDetalleOrden.Rows[e.RowIndex].Selected)
                {
                    e.Handled = true;

                    using (SolidBrush brush = new SolidBrush(Color.LightGray))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    e.PaintContent(e.ClipBounds);
                }
            }
        }

        private void btnDebito_Click(object sender, EventArgs e)
        {
            FrnListadoCatalogoCuentas ListadoCC = new FrnListadoCatalogoCuentas();
            ListadoCC.ShowDialog();
            txtDebito.Text = ListadoCC.Id1.ToString();
        }

        private void btnCredito_Click(object sender, EventArgs e)
        {
            FrnListadoCatalogoCuentas ListadoCC = new FrnListadoCatalogoCuentas();
            ListadoCC.ShowDialog();
            txtCredito.Text = ListadoCC.Id1.ToString();
        }

        private void txtOrdenCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDebito_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCredito_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbTipoGRN_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbTipoGRN.SelectedIndex;
            if (!string.IsNullOrEmpty(txtOrdenCompra.Text) && Convert.ToInt32(txtOrdenCompra.Text) > 0)
            {
                OrdenyGrn(Convert.ToInt32(txtOrdenCompra.Text), index);
                ActualizarEstadoRecibido(Convert.ToInt32(txtOrdenCompra.Text));
            }
        }

        private void BtnCancelarOrden_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
