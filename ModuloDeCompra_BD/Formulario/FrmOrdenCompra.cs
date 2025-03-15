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
    public partial class FrmOrdenCompra: Form
    {
        int idproveedor;
        int idUsuario;
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public FrmOrdenCompra()
        {
            InitializeComponent();
        }

        private void FrmOrdenCompra_Load(object sender, EventArgs e)
        {
            
           
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fechaLimite = dtpFechaLimite.Value;
                DateTime fechaActual = DateTime.Now;

                if (fechaLimite <= fechaActual)
                {
                    MessageBox.Show("La Fecha Límite debe ser mayor a la fecha actual.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                foreach (DataGridViewRow fila in dgvRequisiciones.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    string costo = fila.Cells["Costo"].Value?.ToString();
                    string descuento = fila.Cells["Descuento"].Value?.ToString();

                    // Reemplazar las comas por puntos
                    costo = costo.Replace(',', '.');
                    descuento = descuento.Replace(',', '.');

                    decimal costoValido, descuentoValido;

                    if (!decimal.TryParse(costo, out costoValido))
                    {
                        MessageBox.Show("El costo debe ser un número válido.");
                        return; 
                    }
                    if (costoValido <= 0)
                    {
                        MessageBox.Show("El costo debe ser mayor a cero.");
                        return; 
                    }
                    if (!decimal.TryParse(descuento, out descuentoValido))
                    {
                        MessageBox.Show("El descuento debe ser un número válido.");
                        return; 
                    }
                }
                int idGenerado = -1;
                string xmlOrdenCompra = $@"
                <ORDEN>
                  <FECHAORDEN>{DateTime.Now.ToString("yyyy-MM-dd")}</FECHAORDEN>
                  <FECHALIMITE>{dtpFechaLimite.Value.ToString("yyyy-MM-dd")}</FECHALIMITE>
                  <ESTADORDEN>Pendiente</ESTADORDEN>
                  <IDREQUI>{txtRequisicionID.Text}</IDREQUI>
                  <IDUSUARIO>{idUsuario}</IDUSUARIO>
                  <IDPROVE>{idproveedor}</IDPROVE>
                </ORDEN>";

                try
                {
                    string query = $@"
                DECLARE @TempID INT;
                EXEC SpOrdenCompra @cadena = '{xmlOrdenCompra}', @IDIngresada = @TempID OUTPUT;
                SELECT @TempID AS IDGenerado;";

                    DataTable dt = CsComandosSql.RetornaDatos(query);

                    if (dt.Rows.Count > 0)
                    {
                        idGenerado = Convert.ToInt32(dt.Rows[0]["IDGenerado"]);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }

                foreach (DataGridViewRow fila in dgvRequisiciones.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    string idProducto = fila.Cells["ID_Producto"].Value?.ToString();
                    string idServicio = fila.Cells["ID_Servicio"].Value?.ToString();
                    string cantidad = fila.Cells["Cantidad"].Value?.ToString();
                    string costo = fila.Cells["Costo"].Value?.ToString();
                    string descuento = fila.Cells["Descuento"].Value?.ToString();

                    costo = costo.Replace(',', '.');
                    descuento = descuento.Replace(',', '.');

                    string xmlDetalleOrden = $@"
                        <DETALLEORDENES>
                            <DETALLEORDEN>
                                <CANTIDAD>{cantidad}</CANTIDAD>
                                <COSTO>{costo}</COSTO>
                                <DESCUENTO>{descuento}</DESCUENTO>
                                <IDSERVICIO>{(string.IsNullOrEmpty(idServicio) ? "NULL" : idServicio)}</IDSERVICIO>
                                <IDPRODUCTO>{(string.IsNullOrEmpty(idProducto) ? "NULL" : idProducto)}</IDPRODUCTO>
                                <IDORDEN>{idGenerado}</IDORDEN>
                            </DETALLEORDEN>
                        </DETALLEORDENES>";

                    string queryD = $"exec SpDetalleOrden @XMLdetalleOrden = '{xmlDetalleOrden}'";

                    try
                    {
                        if (!CsComandosSql.InserDeletUpdate(queryD))
                            MessageBox.Show("Error al insertar detalle de orden");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                MessageBox.Show("La orden ha sido guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            try
            {
                FrmListadoRequisicion frmListado = new FrmListadoRequisicion();
                frmListado.ShowDialog();
                txtRequisicionID.Text = frmListado.RequisicionID.ToString();
                DataTable Tb = new DataTable();
                Tb = CsComandosSql.RetornaDatos($"select Cantidad, ID_Servicio, ID_Producto from Requi_Details  where Estado = 'Aprobado' and ID_Requisicion='{txtRequisicionID.Text}'");
                Tb.Columns.Add("Costo", typeof(decimal));
                Tb.Columns.Add("Descuento", typeof(decimal));
               
                foreach (DataRow row in Tb.Rows)
                {
                    row["Costo"] = 0;
                    row["Descuento"] = 0;
                }
                Tb.Columns["Costo"].SetOrdinal(1);
                Tb.Columns["Descuento"].SetOrdinal(2);

                dgvRequisiciones.DataSource = Tb;
                dgvRequisiciones.Columns["Costo"].DefaultCellStyle.Format = "C2";
                dgvRequisiciones.Columns["Descuento"].DefaultCellStyle.Format = "C2";
                dgvRequisiciones.Columns["Costo"].ReadOnly = false;
                dgvRequisiciones.Columns["Descuento"].ReadOnly = false;

                foreach (DataGridViewColumn column in dgvRequisiciones.Columns)
                {
                    if (column.Name != "Costo" && column.Name != "Descuento")
                    {
                        column.ReadOnly = true;
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : "+ ex);
            }
        }
        private void txtProveedor_Click(object sender, EventArgs e)
        {
            FrmListadoProveedor prov = new FrmListadoProveedor();
            prov.ShowDialog();
            idproveedor= prov.IdProvee1;
            txtProve.Text= prov.Nombre1;
        }

        private void dgvRequisiciones_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (dgvRequisiciones.CurrentCell.ColumnIndex == dgvRequisiciones.Columns["Costo"].Index ||
                dgvRequisiciones.CurrentCell.ColumnIndex == dgvRequisiciones.Columns["Descuento"].Index)
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
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != (char)8)
            {
                e.Handled = true; 
            }
        }

        private void dgvRequisiciones_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvRequisiciones.Columns[e.ColumnIndex].Name == "Costo" || dgvRequisiciones.Columns[e.ColumnIndex].Name == "Descuento")
            {
                MessageBox.Show("El valor ingresado no es válido. Por favor, ingrese un número con el formato correcto (ejemplo: 0,00)");
                e.Cancel = true;
                dgvRequisiciones.CancelEdit(); 
                dgvRequisiciones[e.ColumnIndex, e.RowIndex].Value = 0; 
            }
            else
            {
       
                e.Cancel = true;
            }
        }

        private void lblFechaLimite_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaLimite_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbEstadoOrden_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
