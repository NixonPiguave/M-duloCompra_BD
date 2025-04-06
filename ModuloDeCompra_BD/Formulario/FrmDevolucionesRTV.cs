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
    public partial class FrmRTV : Form
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
                CargarDGV(grn.ID);
                lbCantRecib.Visible = true;

                DataTable tb = CsComandosSql.RetornaDatos($"select Nombre_Proveedor from Proveedores where ID_Proveedor={grn.IDProv1}");

                if (tb.Rows.Count > 0)
                {
                    string Provedorname =tb.Rows[0]["Nombre_Proveedor"].ToString();
                    txtNombreProveedor.Text = Provedorname;
                }

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
        private void CargarDGV(int ID)
        {
            string query = $"SELECT X.[Cod Detalle], X.ID_Producto, X.ID_Servicio,p.NomProducto,s.Nom_Servicio, X.[Cantidad Recibida], X.[Cantidad a Devolver], X.CantidadDevuelta " +
                $" FROM (SELECT  GR.ID_GRNDetails AS [Cod Detalle], GR.ID_Producto, GR.ID_Servicio, GR.Cantidad AS [Cantidad Recibida]," +
                $"  0 AS [Cantidad a Devolver],CASE WHEN ISNULL((SELECT sum(D.Cantidad) FROM RTV_Details D " +
                $" WHERE D.ID_GRN = {ID} AND (D.ID_Producto = GR.ID_Producto or D.ID_Servicio=GR.ID_Servicio)), 0) = 0 " +
                $" THEN 0 ELSE ISNULL((SELECT sum(D.Cantidad) FROM RTV_Details D" +
                $"  WHERE D.ID_GRN = {ID} AND (D.ID_Producto = GR.ID_Producto or D.ID_Servicio=GR.ID_Servicio)), 0) END AS [CantidadDevuelta] " +
                $" FROM Grn_Details GR WHERE GR.ID_GRN = {ID} ) AS X Left join Producto p on X.ID_Producto=p.ID_Producto  " +
                $"left join Servicio s on s.ID_Servicio=X.ID_Servicio WHERE [Cantidad Recibida] <> CantidadDevuelta";

            dgvDetalleGrn.DataSource = CsComandosSql.RetornaDatos(query);
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

                    int cantidadRecibida = Convert.ToInt32(dgvDetalleGrn[5, e.RowIndex].Value);
                    int cantidadDevolver = Convert.ToInt32(dgvDetalleGrn[e.ColumnIndex, e.RowIndex].Value?.ToString());
                    int cantidadDevuelta = Convert.ToInt32(dgvDetalleGrn[7, e.RowIndex].Value);
                    if (cantidadDevolver > cantidadRecibida - cantidadDevuelta)
                    {
                        MessageBox.Show("La cantidad Devuelta no puede ser mayor que la cantidad que se recibió.");
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

            if (!string.IsNullOrEmpty(txtDebito.Text) || !string.IsNullOrEmpty(txtCredito.Text))
            {
                string Motivo = "PRODUCTO EN MAL ESTADO";
                if (!String.IsNullOrEmpty(txtProveedor.Text))
                {
                    string detalle = "";

                    foreach (DataGridViewRow fila in dgvDetalleGrn.Rows)
                    {
                        if (fila.IsNewRow)
                            continue;

                        string idServicio = fila.Cells["ID_Servicio"].Value?.ToString();
                        string idProducto = fila.Cells["ID_Producto"].Value?.ToString();
                        string cantidad = fila.Cells["Cantidad a Devolver"].Value?.ToString();
                        int cant = Convert.ToInt32(cantidad);
                        if (cant > 0)
                        {
                            detalle += $@"
                                <DETALLE>
                                     <IDSERVICIO>{(string.IsNullOrEmpty(idServicio) ? "NULL" : idServicio)}</IDSERVICIO>
                                <IDPRODUCTO>{(string.IsNullOrEmpty(idProducto) ? "NULL" : idProducto)}</IDPRODUCTO>
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
                                            <ID_Proveedor>{txtProveedor.Text}</ID_Proveedor>
                                        </HEADER>
                                        {detalle}
                                 </RTV>'
                        ";
                        string queryD = $"EXEC InsertarRTV {xml},  '{txtDebito.Text}', '{txtCredito.Text}'";
                        //MessageBox.Show(xml);
                        if (CsComandosSql.InserDeletUpdate(queryD))
                        {
                            MessageBox.Show("RTV REGISTRADO");
                            CargarDGV(Convert.ToInt32(txtSeleccionGRN.Text));
                        }

                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("" + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            dgvDetalleGrn.DataSource = null;
            txtMotivo.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtSeleccionGRN.Text = string.Empty;
            txtNombreProveedor.Text = string.Empty;
            txtDebito.Text = string.Empty;
            txtCredito.Text = string.Empty;
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

        private void btnGenerarDocumento_Click(object sender, EventArgs e)
        {
            frmreportDocDevo devo = new frmreportDocDevo();
            devo.ShowDialog();
        }
    }
}
