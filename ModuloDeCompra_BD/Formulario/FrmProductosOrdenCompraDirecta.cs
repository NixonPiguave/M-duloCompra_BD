using ModuloDeCompra_BD.Clases;
using ModuloDeCompra_BD.Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menú.Formularios
{

    public partial class FrmProductosOrdenCompraDirecta : Form
    {
        DataTable tabla = new DataTable();
        int IDUsuario;
        string proveedor;
        bool primerEjecucion = true;
        public int IDUsuario1 { get => IDUsuario; set => IDUsuario = value; }
        public string Proveedor { get => proveedor; set => proveedor = value; }

        public FrmProductosOrdenCompraDirecta()
        {
            InitializeComponent();
        }
        private void FrmOrdenCompraDirecta_Load(object sender, EventArgs e)
        {
            tabla.Columns.Add("ID_Producto", typeof(string));
            tabla.Columns.Add("ID_Servicio", typeof(string));
            tabla.Columns.Add("Producto/Servicio", typeof(string));
            tabla.Columns.Add("Cantidad", typeof(string));
            dgvProductosAgregados.DataSource = tabla;

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
            dgvListadoProductos.DataSource = CsComandosSql.RetornaDatos($"select Pr.ID_Producto, Pr.NomProducto from Producto as Pr inner join Proveedores as P on Pr.ID_Proveedor = P.ID_Proveedor WHERE EstadoProducto='Activo' and P.Nombre_Proveedor = '{Proveedor}'");
            dgvListadoServicio.DataSource = CsComandosSql.RetornaDatos($"select Pr.ID_Producto, Pr.NomProducto from Producto as Pr inner join Proveedores as P on Pr.ID_Proveedor = P.ID_Proveedor WHERE EstadoProducto='Activo' and P.Nombre_Proveedor = '{Proveedor}'");
        }

        private void txtFiltroProduc_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoProductos.DataSource = CsComandosSql.RetornaDatos($"select ID_Producto, NomProducto  from Producto WHERE EstadoProducto='Activo' and NomProducto like '%{txtFiltroProduc.Text}%'");
        }

        private void txtFiltroServicio_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoServicio.DataSource = CsComandosSql.RetornaDatos($"select ID_Servicio, Nom_Servicio  from Servicio WHERE EstadoServicio='Activo'and Nom_Servicio like '%{txtFiltroServicio.Text}%'");
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

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
                    }
                }
                if (!Verificar)
                {
                    tabla.Rows.Add(null, txtIDServi.Text, txtServicio.Text, nudServicio.Value);
                    dgvProductosAgregados.DataSource = tabla;
                    txtServicio.Text = string.Empty;
                    nudServicio.Value = 1;
                    txtIDServi.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El servicio ya existe en la requisición");
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos por favor");
            }
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
                    tabla.Rows.Add(txtID.Text, null, txtProducto.Text, nudCantidad.Value);
                    dgvProductosAgregados.DataSource = tabla;
                    txtProducto.Text = string.Empty;
                    txtID.Text = string.Empty;
                    nudCantidad.Value = 1;
                }
                else
                {
                    MessageBox.Show("El producto ya existe en la requisición");
                }
            }
            else
            {
                MessageBox.Show("Rellene los campos por favor");
            }
        }

        private void btnCrearRequi_Click(object sender, EventArgs e)
        {
            int idGenerado = -1;
            string xmlRequisicion = $@"
            <Requisiciones>
              <Requisicion>
                <FechaRequisicion>{DateTime.Now.ToString("yyyy-MM-dd")}</FechaRequisicion>
                <EstadoRequisicion>Pendiente</EstadoRequisicion>
                <Observacion></Observacion>
                <IDUsuario>{IDUsuario1}</IDUsuario>
                <MotivoRequisicion>{txtMotivo.Text}</MotivoRequisicion>
              </Requisicion>
            </Requisiciones>";
            string query = $@"
                    DECLARE @TempID INT;
                    EXEC SpOrdenCompra @cadena = '{xmlRequisicion}', @IDIngresada = @TempID OUTPUT;
                    SELECT @TempID AS IDGenerado;";

            DataTable dt = CsComandosSql.RetornaDatos(query);

            if (dt.Rows.Count > 0)
            {
                idGenerado = Convert.ToInt32(dt.Rows[0]["IDGenerado"]);
            }
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
            txtMotivo.Text = string.Empty;
            this.Close();
        }
    }
}

