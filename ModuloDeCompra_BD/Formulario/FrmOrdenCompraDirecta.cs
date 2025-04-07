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
            dtpFechaLimite.MinDate = DateTime.Now;
            chkProductos.Checked = true;

            lblProductos.Visible = true;
            txtFiltroProduc.Visible = true;
            pnlProductos.Visible = true;
            pnlProductosSelect.Visible = true;
            chkProductos.Checked = true;
            lblProductos.Visible = true;
            txtFiltroProduc.Visible = true;
            pnlProductos.Visible = true;
            pnlProductosSelect.Visible = true;
            lbID.Visible = true;
            txtID.Visible = true;
            lbProduc.Visible = true;
            txtProducto.Visible = true;
            lbCantidad.Visible = true;
            nudCantidad.Visible = true;
            btnAgregarP.Visible = true;

            lblServicio.Visible = false;
            txtFiltroServicio.Visible = false;
            pnlServicio.Visible = false;
            pnlServiciosSelect.Visible = false;
            btnServicio.Visible = false;
            lbIDserv.Visible = false;
            txtIDServi.Visible = false;
            lbServi.Visible = false;
            txtServicio.Visible = false;
            lbCanServ.Visible = false;
            nudServicio.Visible = false;
            btnAgregarS.Visible = false;

            nudCantidad.Minimum = 1;
            nudCantidad.Value = 1;
            nudServicio.Minimum = 1;
            nudServicio.Value = 1;


            txtProveedor.Text = string.Empty;
            string queryProducto = $"select Pr.ID_Producto, Pr.NomProducto from Producto as Pr inner join Proveedores as P on Pr.ID_Proveedor = P.ID_Proveedor WHERE EstadoProducto='Activo' and P.Nombre_Proveedor = '{txtProveedor.Text}'";
            dgvListadoProductos.DataSource = CsComandosSql.RetornaDatos(queryProducto);
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

                    foreach (DataGridViewRow fila in dgvProductosAgregados.Rows)
                    {
                        if (fila.IsNewRow)
                            continue;

                        string cantidad = fila.Cells["Cantidad"].Value?.ToString();
                        if (!int.TryParse(cantidad, out int cantidadValida) || cantidadValida <= 0)
                        {
                            MessageBox.Show("La cantidad debe ser un número entero válido y mayor que cero");
                            return;
                        }

                        string costo = fila.Cells["Costo"].Value?.ToString();
                        if (!decimal.TryParse(costo, out decimal costoValido) || costoValido <= 0)
                        {
                            MessageBox.Show("El costo debe ser un número válido y mayor que cero");
                            return;
                        }

                        string descuento = fila.Cells["Descuento"].Value?.ToString();
                        if (!decimal.TryParse(descuento, out decimal descuentoValido) || descuentoValido < 0)
                        {
                            MessageBox.Show("El descuento debe ser un número válido y no puede ser negativo");
                            return;
                        }

                        if (descuentoValido > costoValido)
                        {
                            MessageBox.Show("El descuento no puede ser mayor que el costo");
                            return;
                        }
                    }

                    string xmlOrdenCompra = $@"
                <ORDEN>
                    <FECHAORDEN>{DateTime.Now.ToString("yyyy-MM-dd")}</FECHAORDEN>
                    <FECHALIMITE>{dtpFechaLimite.Value.ToString("yyyy-MM-dd")}</FECHALIMITE>
                    <ESTADORDEN>Pendiente</ESTADORDEN>
                    <IDUSUARIO>{idUsuario}</IDUSUARIO>
                    <IDPROVE>{idproveedor}</IDPROVE>
                </ORDEN>";

                    StringBuilder sbDetalle = new StringBuilder();
                    sbDetalle.Append("<DETALLEORDENES>");

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

                        sbDetalle.Append($@"
                    <DETALLEORDEN>
                        <CANTIDAD>{cantidad}</CANTIDAD>
                        <COSTO>{costo}</COSTO>
                        <DESCUENTO>{descuento}</DESCUENTO>
                        <IDSERVICIO>{(string.IsNullOrEmpty(idServicio) ? "NULL" : idServicio)}</IDSERVICIO>
                        <IDPRODUCTO>{(string.IsNullOrEmpty(idProducto) ? "NULL" : idProducto)}</IDPRODUCTO>
                        <ESTADO>Pendiente</ESTADO>
                    </DETALLEORDEN>");
                    }

                    sbDetalle.Append("</DETALLEORDENES>");
                    string xmlDetalleOrden = sbDetalle.ToString();

                    string query = $@"
                DECLARE @TempID INT;
                EXEC SpOrdenCompraDirecta 
                    @XMLOrden = '{xmlOrdenCompra}', 
                    @XMLdetalleOrden = '{xmlDetalleOrden}', 
                    @IDIngresada = @TempID OUTPUT;
                SELECT @TempID AS IDGenerado;";

                    DataTable dt = CsComandosSql.RetornaDatos(query);

                    if (dt.Rows.Count > 0)
                    {
                        int idGenerado = Convert.ToInt32(dt.Rows[0]["IDGenerado"]);

                        tabla.Clear();
                        dgvProductosAgregados.DataSource = null;
                        //txtMotivo.Text = string.Empty;

                        MessageBox.Show("La orden ha sido guardada correctamente");
                        btnGenerarDocumento.Visible = true;
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
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Escoja los productos");
            }
        }
        public string DocNomProveedor;
        private void txtProveedor_Click(object sender, EventArgs e)
        {
            FrmListadoProveedor prov = new FrmListadoProveedor();
            prov.ShowDialog();
            idproveedor = prov.IdProvee1;
            txtProveedor.Text = prov.Nombre1;
            DocNomProveedor = prov.Nombre1;
            tabla.Clear();
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
            tabla.Clear();
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
            if (idproveedor == 0 || string.IsNullOrEmpty(txtProveedor.Text))
            {
                MessageBox.Show("Debe seleccionar un proveedor antes de elegir un producto");
                return;
            }
            pnlProductosSelect.Visible = true;
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

            if (dgvListadoProductos.CurrentCell != null)
            {
                int fila = dgvListadoProductos.CurrentCell.RowIndex;
                txtID.Text = dgvListadoProductos[0, fila].Value.ToString();
                txtProducto.Text = dgvListadoProductos[1, fila].Value.ToString();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto");
            }
        }

        private void btnAgregarP_Click(object sender, EventArgs e)
        {
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero");
                return;
            }
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

                    btnAgregarP.Visible = false;
                    lbID.Visible = false;
                    lbProduc.Visible = false;
                    lbCantidad.Visible = false;
                    txtProducto.Visible = false;
                    txtID.Visible = false;
                    nudCantidad.Visible = false;

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
            if (idproveedor == 0 || string.IsNullOrEmpty(txtProveedor.Text))
            {
                MessageBox.Show("Debe seleccionar un proveedor antes de elegir un servicio");
                return;
            }
            pnlServiciosSelect.Visible = true;
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

            if (dgvListadoProductos.CurrentCell != null)
            {
                int fila = dgvListadoServicio.CurrentCell.RowIndex;
                txtIDServi.Text = dgvListadoServicio[0, fila].Value.ToString();
                txtServicio.Text = dgvListadoServicio[1, fila].Value.ToString();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún servicio");
            }
        }

        private void btnAgregarS_Click(object sender, EventArgs e)
        {
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero");
                return;
            }
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

                    btnAgregarS.Visible = false;
                    lbIDserv.Visible = false;
                    lbCanServ.Visible = false;
                    lbServi.Visible = false;
                    txtServicio.Visible = false;
                    txtIDServi.Visible = false;
                    nudServicio.Visible = false;
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

        private void btnGenerarDocumento_Click(object sender, EventArgs e)
        {
            frmreportDoc DocumentoOC = new frmreportDoc();
            DocumentoOC.DocProveedor = DocNomProveedor;
            DocumentoOC.ShowDialog();
        }

        private void chkProductos_CheckedChanged(object sender, EventArgs e)
        {
            if(chkProductos.Checked==true)
            {
                chkServicios.Checked = false;
            }
            lblServicio.Visible = false;
            txtFiltroServicio.Visible = false;
            pnlServicio.Visible = false;
            pnlServiciosSelect.Visible = false;
            btnServicio.Visible = false;
            lbIDserv.Visible = false;
            txtIDServi.Visible = false;
            lbServi.Visible = false;
            txtServicio.Visible = false;
            lbCanServ.Visible = false;
            nudServicio.Visible = false;
            btnAgregarS.Visible = false;

            lblProductos.Visible = true;
            txtFiltroProduc.Visible = true;
            pnlProductos.Visible = true;
            pnlProductosSelect.Visible = true;
            //chkProductos.Checked = true;
            lblProductos.Visible = true;
            txtFiltroProduc.Visible = true;
            pnlProductos.Visible = true;
            pnlProductosSelect.Visible = true;
            lbID.Visible = true;
            txtID.Visible = true;
            lbProduc.Visible = true;
            txtProducto.Visible = true;
            lbCantidad.Visible = true;
            nudCantidad.Visible = true;
            btnAgregarP.Visible = true;
        }

        private void chkServicios_CheckedChanged(object sender, EventArgs e)
        {
            if(chkServicios.Checked==true)
            {
                chkProductos.Checked=false;
            }
            lblProductos.Visible = false;
            txtFiltroProduc.Visible = false;
            pnlProductos.Visible = false;
            pnlProductosSelect.Visible = false;
            //chkProductos.Checked = false;
            lblProductos.Visible = false;
            txtFiltroProduc.Visible = false;
            pnlProductos.Visible = false;
            pnlProductosSelect.Visible = false;
            lbID.Visible = false;
            txtID.Visible = false;
            lbProduc.Visible = false;
            txtProducto.Visible = false;
            lbCantidad.Visible = false;
            nudCantidad.Visible = false;
            btnAgregarP.Visible = false;


            lblServicio.Visible = true;
            txtFiltroServicio.Visible = true;
            pnlServicio.Visible = true;
            pnlServiciosSelect.Visible = true;
            btnServicio.Visible = true;
            btnServicio.BringToFront();
            lbIDserv.Visible = true;
            txtIDServi.Visible = true;
            lbServi.Visible = true;
            txtServicio.Visible = true;
            lbCanServ.Visible = true;
            nudServicio.Visible = true;
            btnAgregarS.Visible = true;
            
        }

        private void btnProducto_Click_1(object sender, EventArgs e)
        {
            if (idproveedor == 0 || string.IsNullOrEmpty(txtProveedor.Text))
            {
                MessageBox.Show("Debe seleccionar un proveedor antes de elegir un producto");
                return;
            }

            lblProductos.Visible = true;
            txtFiltroProduc.Visible = true;
            pnlProductos.Visible = true;
            pnlProductosSelect.Visible = true;
            chkProductos.Checked = true;
            lblProductos.Visible = true;
            txtFiltroProduc.Visible = true;
            pnlProductos.Visible = true;
            pnlProductosSelect.Visible = true;
            lbID.Visible = true;
            txtID.Visible = true;
            lbProduc.Visible = true;
            txtProducto.Visible = true;
            lbCantidad.Visible = true;
            nudCantidad.Visible = true;
            btnAgregarP.Visible = true;

            lblServicio.Visible = false;
            txtFiltroServicio.Visible = false;
            pnlServicio.Visible = false;
            pnlServiciosSelect.Visible = false;
            btnServicio.Visible = false;
            lbIDserv.Visible = false;
            txtIDServi.Visible = false;
            lbServi.Visible = false;
            txtServicio.Visible = false;
            lbCanServ.Visible = false;
            nudServicio.Visible = false;
            btnAgregarS.Visible = false;

            if (dgvListadoProductos.CurrentCell != null)
            {
                int fila = dgvListadoProductos.CurrentCell.RowIndex;
                txtID.Text = dgvListadoProductos[0, fila].Value.ToString();
                txtProducto.Text = dgvListadoProductos[1, fila].Value.ToString();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún producto");
            }
        }

        private void btnServicio_Click_1(object sender, EventArgs e)
        {
            if (idproveedor == 0 || string.IsNullOrEmpty(txtProveedor.Text))
            {
                MessageBox.Show("Debe seleccionar un proveedor antes de elegir un servicio");
                return;
            }
            pnlServiciosSelect.Visible = true;
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

            if (dgvListadoProductos.CurrentCell != null)
            {
                int fila = dgvListadoServicio.CurrentCell.RowIndex;
                txtIDServi.Text = dgvListadoServicio[0, fila].Value.ToString();
                txtServicio.Text = dgvListadoServicio[1, fila].Value.ToString();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún servicio");
            }
        }

        private void btnAgregarP_Click_1(object sender, EventArgs e)
        {
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero");
                return;
            }
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

                    lbID.Visible = false;
                    txtID.Visible = false;
                    lbProduc.Visible = false;
                    txtProducto.Visible = false;
                    lbCantidad.Visible = false;
                    nudCantidad.Visible = false;
                    btnAgregarP.Visible = false;
                    pnlProductosSelect.Visible = false; 

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

        private void btnAgregarS_Click_1(object sender, EventArgs e)
        {
            if (nudCantidad.Value <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que cero");
                return;
            }
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

                    btnAgregarS.Visible = false;
                    lbIDserv.Visible = false;
                    lbCanServ.Visible = false;
                    lbServi.Visible = false;
                    txtServicio.Visible = false;
                    txtIDServi.Visible = false;
                    nudServicio.Visible = false;
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
