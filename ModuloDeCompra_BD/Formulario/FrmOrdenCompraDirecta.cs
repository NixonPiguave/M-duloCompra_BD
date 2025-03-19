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
        DataTable tabla = new DataTable();
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }

        public FrmOrdenCompraDirecta()
        {
            InitializeComponent();
        }

        private void FrmOrdenCompraDirecta_Load(object sender, EventArgs e)
        {
            tabla.Columns.Add("Cantidad", typeof(int));
            tabla.Columns.Add("Costo", typeof(decimal));
            tabla.Columns.Add("Descuento", typeof(decimal));
            tabla.Columns.Add("Producto/Servicio", typeof(string));
            tabla.Columns.Add("ID_Servicio", typeof(int));
            tabla.Columns.Add("ID_Producto", typeof(int));
            btnAgregarP.Visible = false;
            lbID.Visible = false;
            lbProduc.Visible = false;
            lbCantidad.Visible = false;
            txtProducto.Visible = false;
            txtID.Visible = false;
            nudCantidad.Visible = false;

            btnAgregarS.Visible = false;
            lbIDserv.Visible = false;
            lbCanServ.Visible = false;
            lbServi.Visible = false;
            txtServicio.Visible = false;
            txtIDServi.Visible = false;
            nudServicio.Visible = false;

            nudCantidad.Minimum = 1;
            nudCantidad.Value = 1;
            nudServicio.Minimum = 1;
            nudServicio.Value = 1;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvProductosAgregados.DataSource != null)
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

                    int idGenerado = -1;
                    string xmlOrdenCompra = $@"
            <ORDEN>
              <FECHAORDEN>{DateTime.Now.ToString("yyyy-MM-dd")}</FECHAORDEN>
              <FECHALIMITE>{dtpFechaLimite.Value.ToString("yyyy-MM-dd")}</FECHALIMITE>
              <ESTADORDEN>Pendiente</ESTADORDEN>
              <IDUSUARIO>{idUsuario}</IDUSUARIO>
              <IDPROVE>{idproveedor}</IDPROVE>
            </ORDEN>";

                    try
                    {
                        // Crear la orden de compra
                        string query = $@"
                DECLARE @TempID INT;
                EXEC SpOrdenCompra @cadena = '{xmlOrdenCompra}', @IDIngresada = @TempID OUTPUT;
                SELECT @TempID AS IDGenerado;";

                        DataTable dt = CsComandosSql.RetornaDatos(query);

                        if (dt.Rows.Count > 0)
                        {
                            idGenerado = Convert.ToInt32(dt.Rows[0]["IDGenerado"]);
                        }

                        // Enviar el detalle de la orden
                        foreach (DataGridViewRow fila in dgvProductosAgregados.Rows)
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
                            <ESTADO>Pendiente</ESTADO>
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

                        tabla.Clear();
                        dgvProductosAgregados.DataSource = null;
                        txtMotivo.Text = string.Empty;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error: {ex.Message}");
                    }

                    MessageBox.Show("La orden ha sido guardada correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Escoja los productos");
            }
        }
        private void txtProveedor_Click(object sender, EventArgs e)
        {
            FrmListadoProveedor prov = new FrmListadoProveedor();
            prov.ShowDialog();
            idproveedor= prov.IdProvee1;
            txtProveedor.Text= prov.Nombre1;
        }
        private void dtpFechaLimite_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedor_TextChanged(object sender, EventArgs e)
        {
            string queryProducto = $"select Pr.ID_Producto, Pr.NomProducto from Producto as Pr inner join Proveedores as P on Pr.ID_Proveedor = P.ID_Proveedor WHERE EstadoProducto='Activo' and P.Nombre_Proveedor = '{txtProveedor.Text}'";
            string queryServicio = $"select S.ID_Servicio, S.Nom_Servicio from Servicio as S inner join Proveedores as P on S.ID_Proveedor = P.ID_Proveedor WHERE S.EstadoServicio='Activo' and P.Nombre_Proveedor = '{txtProveedor.Text}'";
            dgvListadoProductos.DataSource = CsComandosSql.RetornaDatos(queryProducto);
            dgvListadoServicio.DataSource = CsComandosSql.RetornaDatos(queryServicio);
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Cantidad", typeof(int));
            tabla.Columns.Add("Costo", typeof(decimal));
            tabla.Columns.Add("Descuento", typeof(decimal));
            tabla.Columns.Add("Producto/Servicio", typeof(string));
            tabla.Columns.Add("ID_Servicio", typeof(int));
            tabla.Columns.Add("ID_Producto", typeof(int));

            foreach (DataRow row in tabla.Rows)
            {
                row["Costo"] = 0;
                row["Descuento"] = 0;
            }

            dgvProductosAgregados.DataSource = tabla;
            dgvProductosAgregados.Columns["Costo"].DefaultCellStyle.Format = "C2";
            dgvProductosAgregados.Columns["Descuento"].DefaultCellStyle.Format = "C2";
            dgvProductosAgregados.Columns["Costo"].ReadOnly = false;
            dgvProductosAgregados.Columns["Descuento"].ReadOnly = false;

            foreach (DataGridViewColumn column in dgvProductosAgregados.Columns)
            {
                if (column.Name != "Costo" && column.Name != "Descuento")
                {
                    column.ReadOnly = true;
                }
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            btnAgregarP.Visible = true;
            lbID.Visible = true;
            lbProduc.Visible = true;
            lbCantidad.Visible = true;
            txtProducto.Visible = true;
            txtID.Visible = true;
            nudCantidad.Visible = true;

            btnAgregarS.Visible = false;
            lbIDserv.Visible = false;
            lbCanServ.Visible = false;
            lbServi.Visible = false;
            txtServicio.Visible = false;
            txtIDServi.Visible = false;
            nudServicio.Visible = false;

            int fila = dgvListadoProductos.CurrentCell.RowIndex;
            txtID.Text = dgvListadoProductos[0, fila].Value.ToString();
            txtProducto.Text = dgvListadoProductos[1, fila].Value.ToString();
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text) && !string.IsNullOrEmpty(txtProducto.Text))
            {
                bool Verificar = false;
                foreach (DataGridViewRow fila in dgvProductosAgregados.Rows)
                {
                    string producto = fila.Cells["Producto/Servicio"].Value?.ToString();
                    if (txtProducto.Text == producto)
                    {
                        Verificar = true;
                        break;
                    }
                }

                if (!Verificar)
                {
                    int cantidad = (int)nudCantidad.Value;
                    decimal costo = 0;
                    decimal descuento = 0;
                    string nombreProducto = txtProducto.Text;
                    int idProducto = Convert.ToInt32(txtID.Text);

                    tabla.Rows.Add(cantidad, costo, descuento, nombreProducto, null, idProducto);

                    dgvProductosAgregados.DataSource = tabla;
                    txtProducto.Text = string.Empty;
                    txtID.Text = string.Empty;
                    nudCantidad.Value = 1;
                }
                else
                {
                    MessageBox.Show("El producto ya existe en la Orden de Compra");
                }
            }
            else
            {
                MessageBox.Show("Rellene los campos por favor");
            }

        }

        private void btnServicio_Click(object sender, EventArgs e)
        {
            btnAgregarP.Visible = false;
            lbID.Visible = false;
            lbProduc.Visible = false;
            lbCantidad.Visible = false;
            txtProducto.Visible = false;
            txtID.Visible = false;
            nudCantidad.Visible = false;

            btnAgregarS.Visible = true;
            lbIDserv.Visible = true;
            lbCanServ.Visible = true;
            lbServi.Visible = true;
            txtServicio.Visible = true;
            txtIDServi.Visible = true;
            nudServicio.Visible = true;
            int fila = dgvListadoServicio.CurrentCell.RowIndex;
            txtIDServi.Text = dgvListadoServicio[0, fila].Value.ToString();
            txtServicio.Text = dgvListadoServicio[1, fila].Value.ToString();
        }

        private void btnAgregarS_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDServi.Text) && !string.IsNullOrEmpty(txtServicio.Text))
            {
                bool Verificar = false;
                foreach (DataGridViewRow fila in dgvProductosAgregados.Rows)
                {
                    string servicio = fila.Cells["Producto/Servicio"].Value?.ToString();
                    if (txtServicio.Text == servicio)
                    {
                        Verificar = true;
                        break;
                    }
                }

                if (!Verificar)
                {
                    int cantidad = (int)nudServicio.Value;
                    decimal costo = 0;
                    decimal descuento = 0;
                    string nombreServicio = txtServicio.Text;
                    int idServicio = Convert.ToInt32(txtIDServi.Text);

                    tabla.Rows.Add(cantidad, costo, descuento, nombreServicio, idServicio, null);

                    dgvProductosAgregados.DataSource = tabla;

                    txtServicio.Text = string.Empty;
                    nudServicio.Value = 1;
                    txtIDServi.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El servicio ya existe en la Orden de Compra");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos por favor");
            }
        }
    }
}
