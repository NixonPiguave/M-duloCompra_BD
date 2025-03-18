using Menú.Formularios;
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
    public partial class FrmOrdenCompraDirecta: Form
    {
        int idproveedor;
        int idUsuario;
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public FrmOrdenCompraDirecta()
        {
            InitializeComponent();
        }

        private void FrmOrdenCompraDirecta_Load(object sender, EventArgs e)
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
                  <IDREQUI></IDREQUI>
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
                MessageBox.Show("La orden ha sido guardada correctamente.");
                DialogResult result = MessageBox.Show("Añadir Productos", "Aceptar");
                if (result == DialogResult.OK)
                {
                    FrmProductosOrdenCompraDirecta frmProductos = new FrmProductosOrdenCompraDirecta();
                    frmProductos.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dtpFechaLimite_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
