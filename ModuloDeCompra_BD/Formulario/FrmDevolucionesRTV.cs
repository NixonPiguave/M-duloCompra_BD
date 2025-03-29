using ModuloDeCompra_BD.Clases;
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
    public partial class FrmRTV: Form
    {

        public FrmRTV()
        {
            InitializeComponent();
        }

        private void FrmRTV_Load(object sender, EventArgs e)
        {
            lbCantRecib.Visible = false;
        }

        private void btnSeleccionarGRN_Click(object sender, EventArgs e)
        {
            FrmListadoGRN grn = new FrmListadoGRN();
            grn.ShowDialog();
            txtSeleccionGRN.Text = grn.ID.ToString();
            txtProveedor.Text = grn.IDProv1.ToString();
            if (txtProveedor.Text != 0.ToString())
            {
                string query = $"select GR.ID_GRNDetails as [Cod Detalle], GR.ID_Producto, Cantidad [Cantidad Recibida], 0 as [Cantidad a Devolver]," +
                    $"(case when (select D.Cantidad from RTV_Header H inner join RTV_Details D on H.ID_RTV=D.ID_RTV where H.ID_GRN={grn.ID} AND D.ID_Producto=GR.ID_Producto) IS NULL " +
                    $"then 0 else (select D.Cantidad from RTV_Header H inner join RTV_Details D on H.ID_RTV=D.ID_RTV where H.ID_GRN={grn.ID} AND D.ID_Producto=GR.ID_Producto) end) as [CantidadDevuelta] " +
                    $"from Grn_Details GR where ID_GRN={grn.ID} and ID_Servicio IS NULL";
                dgvDetalleGrn.DataSource = CsComandosSql.RetornaDatos(query);
                lbCantRecib.Visible = true;

                dgvDetalleGrn.Columns["Cantidad a Devolver"].ReadOnly = false;
                dgvDetalleGrn.RowTemplate.Height = 80;
                dgvDetalleGrn.AllowUserToResizeColumns = true;
                dgvDetalleGrn.AllowUserToResizeRows = false;


                foreach (DataGridViewColumn column in dgvDetalleGrn.Columns)
                {
                    if (column.Name != "Cantidad a Devolver")
                    {
                        column.ReadOnly = true;
                    }

                }
                foreach (DataGridViewRow row in dgvDetalleGrn.Rows)
                {
                    row.Cells["Cantidad a Devolver"].Style.BackColor = Color.LightGray;
                    row.Cells["Cantidad a Devolver"].Style.ForeColor = Color.Black;
                }

            }
        }

        private void dgvDetalleGrn_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDetalleGrn.CurrentCell.ColumnIndex == dgvDetalleGrn.Columns["Cantidad a Devolver"].Index)
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

        private void dgvDetalleGrn_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (dgvDetalleGrn.Columns[e.ColumnIndex].Name == "Cantidad a Devolver")
            {
                MessageBox.Show("El valor ingresado no es válido. Por favor, ingrese numeros enteros");
                e.Cancel = true;
                dgvDetalleGrn.CancelEdit();
                dgvDetalleGrn[e.ColumnIndex, e.RowIndex].Value = 0;
            }
            else
            {

                e.Cancel = true;
            }
        }

        private void dgvDetalleGrn_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {

            if (dgvDetalleGrn.Columns[e.ColumnIndex].Name == "Cantidad a Devolver" && e.RowIndex >= 0)
            {

                if (dgvDetalleGrn.Rows[e.RowIndex].Selected)
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

        private void dgvDetalleGrn_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDetalleGrn.Columns[e.ColumnIndex].Name == "Cantidad a Devolver")
                {
                    var value = dgvDetalleGrn[e.ColumnIndex, e.RowIndex].Value;
                    if (value == null || string.IsNullOrWhiteSpace(value.ToString()))
                    {
                        dgvDetalleGrn[e.ColumnIndex, e.RowIndex].Value = 0;
                        return;
                    }

                    int cantidadRecibida = Convert.ToInt32(dgvDetalleGrn[2, e.RowIndex].Value);
                    int cantidadDevolver = Convert.ToInt32(dgvDetalleGrn[e.ColumnIndex, e.RowIndex].Value?.ToString());
                    if (cantidadDevolver > cantidadRecibida)
                    {
                        MessageBox.Show("La cantidad Devuelta no puede ser mayor que la cantidad que se recivió.");
                        dgvDetalleGrn[e.ColumnIndex, e.RowIndex].Value = 0;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnRegistrarRTV_Click(object sender, EventArgs e)
        {
            string Motivo = "PRODUCTO EN MAL ESTADO";
            if (!String.IsNullOrEmpty(txtProveedor.Text))
            {
                string detalle = "";

                foreach (DataGridViewRow fila in dgvDetalleGrn.Rows)
                {
                    if (fila.IsNewRow)
                        continue;

                    string idProducto = fila.Cells["ID_Producto"].Value?.ToString();
                    string cantidad = fila.Cells["Cantidad a Devolver"].Value?.ToString();
                    int cant = Convert.ToInt32(cantidad);
                    if (cant > 0)
                    {
                        detalle += $@"
                                <DETALLE>
                                    <ID_Producto>{idProducto}</ID_Producto>
                                    <Cantidad>{cantidad}</Cantidad>
                                </DETALLE>";
                    }
                }
                try
                {
                    if (!string.IsNullOrEmpty(txtMotivo.Text))
                    {
                        Motivo = txtMotivo.Text;
                    }
                    string xml = $@"'<RTV>
                                        <HEADER>
                                            <IDGRN>{txtSeleccionGRN.Text}</IDGRN>
                                            <Motivo>{Motivo}</Motivo>
                                            <ID_Proveedor>{txtProveedor}</ID_Proveedor>
                                        </HEADER>
                                        {detalle}
                                 </RTV>'
                        ";
                    string queryD = $"EXEC InsertarRTV {xml}";
                    MessageBox.Show(xml);
                    if (CsComandosSql.InserDeletUpdate(queryD))
                        MessageBox.Show("RTV REGISTRADO");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }
    }
}
