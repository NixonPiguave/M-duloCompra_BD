using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmRecepcionCompra: Form
    {
        public FrmRecepcionCompra()
        {
            InitializeComponent();
        }

        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            FrmListadoOrdenCompra ordenCompra = new FrmListadoOrdenCompra();
            ordenCompra.ShowDialog();
            txtOrdenCompra.Text = ordenCompra.IdCat1.ToString();
            txtProveedor.Text = ordenCompra.IdProv.ToString();
            int idorden = ordenCompra.IdCat1;
            if (txtProveedor.Text!= 0.ToString())
            {
                OrdenyGrn(idorden);
                ActualizarEstadoRecibido(idorden);
                lbCantRecib.Visible = true;
            }
        }
        
        private void OrdenyGrn(int idorden)
        {
            string query = $"SELECT d.ID_Detail AS Detalle_De_Compra, p.ID_Producto, s.ID_Servicio,p.NomProducto AS Producto,s.Nom_Servicio AS Servicio,d.Cantidad AS Cantidad_Ordenada," +
                    $" 0 AS CantidadRecibida,d.Cantidad - ISNULL((SELECT SUM(gd.Cantidad) FROM Grn_Details gd" +
                    $" INNER JOIN Grn_Header gh ON gd.ID_GRN = gh.ID_GRN WHERE (gd.ID_Producto = d.ID_Producto or gd.ID_Servicio=d.ID_Servicio)" +
                    $" AND gh.ID_Orden = {idorden}), 0) AS Cantidad_Pendiente,d.Costo AS Costo_Unitario FROM Detalle_Orden d" +
                    $" JOIN Orden_Compra o ON d.ID_Orden = o.ID_Orden LEFT JOIN Producto p ON d.ID_Producto = p.ID_Producto " +
                    $"  LEFT JOIN Servicio s ON d.ID_Servicio = s.ID_Servicio WHERE o.ID_Orden = {idorden} and d.Estado='Pendiente';";
            dgvDetalleOrden.DataSource = CsComandosSql.RetornaDatos(query);
            dgvDetalleOrden.Columns["CantidadRecibida"].ReadOnly = false;
            string queryDetalle = $"select * from GRN_Header where ID_Orden={idorden}";
            dgvGrnDeOrden.DataSource = CsComandosSql.RetornaDatos(queryDetalle);
            dgvDetalleOrden.RowTemplate.Height = 30;
            foreach (DataGridViewColumn column in dgvDetalleOrden.Columns)
            {
                if (column.Name != "CantidadRecibida")
                {
                    column.ReadOnly = true;
                }

            }
            foreach (DataGridViewRow row in dgvDetalleOrden.Rows)
            {
                row.Cells["CantidadRecibida"].Style.BackColor = Color.LightGray;
                row.Cells["CantidadRecibida"].Style.ForeColor = Color.Black;
            }


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

                        string updateQuery = $"update Detalle_Orden set Estado='Recibido' where  ID_Detail= {idOrdenDetalle};";
                        CsComandosSql.InserDeletUpdate(updateQuery);

                    }
                }
            }
            OrdenyGrn(idorden);
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
            bool hayregistros = false;
            foreach (DataGridViewRow fila in dgvDetalleOrden.Rows)
            {
                if (fila.IsNewRow)
                    continue;

                string idProducto = fila.Cells["ID_Producto"].Value?.ToString();
                string idServicio = fila.Cells["ID_Servicio"].Value?.ToString();
                string cantidad = fila.Cells["CantidadRecibida"].Value?.ToString();
                string costoU = fila.Cells["Costo_Unitario"].Value?.ToString();
                int cant = Convert.ToInt32(cantidad);
                if ( cant> 0)
                {
                    hayregistros = true;
                }
            }

            string fecha = dtpFecha.Value.Date.ToString("yyyy-MM-dd");

            if (hayregistros)
            {
                int idGenerado;

                string xmlRequisicion = $@"'<GRNHeaders>
                                                      <GRNHeader>
                                                     <Fecha_Generada>{fecha}</Fecha_Generada>
                                                        <Estado>R</Estado>
                                                        <TotalPagar>{0}</TotalPagar>
                                                             <Origen>O</Origen>
                                                           <ID_Orden>{txtOrdenCompra.Text}</ID_Orden>
                                                           <ID_Proveedor>{txtProveedor.Text}</ID_Proveedor>
                                                              </GRNHeader>
                                                             </GRNHeaders>'";
                try
                {
                    string query = $@"
                DECLARE @TempID INT;
                EXEC spAgregarGRNHeader {xmlRequisicion}, @TempID OUTPUT;
                SELECT @TempID AS IDGenerado;";

                    DataTable dt = CsComandosSql.RetornaDatos(query);

                    if (dt.Rows.Count > 0)
                    {
                        idGenerado = Convert.ToInt32(dt.Rows[0]["IDGenerado"]);
                        foreach (DataGridViewRow fila in dgvDetalleOrden.Rows)
                        {
                            if (fila.IsNewRow)
                                continue;

                            string idProducto = fila.Cells["ID_Producto"].Value?.ToString();
                            string idServicio = fila.Cells["ID_Servicio"].Value?.ToString();
                            string cantidad = fila.Cells["CantidadRecibida"].Value?.ToString();
                            string costoU = fila.Cells["Costo_Unitario"].Value?.ToString();
                            int cant = Convert.ToInt32(cantidad);
                            costoU = costoU.Replace(',', '.');
                            if (cant > 0)
                            {
                                string xmlDetalleRequi = $@"'<GRNDetails>
                                                            <GRNDetail>
                                                                <Cantidad>{cant}</Cantidad>
                                                                <Costo>{costoU}</Costo>
                                                                <ID_Servicio>{(string.IsNullOrEmpty(idServicio) ? "NULL" : idServicio)}</ID_Servicio>
                                                                <ID_Producto>{(string.IsNullOrEmpty(idProducto) ? "NULL" : idProducto)}</ID_Producto>
                                                                <ID_GRN>{idGenerado}</ID_GRN>
                                                            </GRNDetail>
                                                        </GRNDetails>'
                                                        ";

                                string queryD = $"EXEC spAgregarGRNDetails {xmlDetalleRequi}";
                                try
                                {
                                    if (!CsComandosSql.InserDeletUpdate(queryD))
                                    {
                                        MessageBox.Show("Error al insertar detalle");
                                    }
                                    
                                       
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message);
                                }
                            }


                        }
                        MessageBox.Show("GRN REGISTRADO");
                        int idorden = Convert.ToInt32(txtOrdenCompra.Text);
                        OrdenyGrn(idorden);
                        ActualizarEstadoRecibido(idorden);
                       
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Registrar GRN: " + ex.Message);
                }
            }
            else
                MessageBox.Show("Error, no hay registros para Generar un GRN");


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
                int cantidadPendiente = Convert.ToInt32(dgvDetalleOrden[7, e.RowIndex].Value);
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
            lbCantRecib.Visible = false;
        }

        private void FrmRecepcionCompra_Load(object sender, EventArgs e)
        {
            lbCantRecib.Visible = false;
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
    }
}
