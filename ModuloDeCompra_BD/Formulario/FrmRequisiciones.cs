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

namespace Menú.Formularios
{

    public partial class FrmRequisiciones : Form
    {
        DataTable tabla = new DataTable();
        int IDUsuario;
        bool primerEjecucion = true;
        public int IDUsuario1 { get => IDUsuario; set => IDUsuario = value; }

        public FrmRequisiciones()
        {
            InitializeComponent();
        }
        private void FrmRequisiciones_Load(object sender, EventArgs e)
        {
            tabla.Columns.Add("ID_Producto", typeof(string));
            tabla.Columns.Add("ID_Servicio", typeof(string));
            tabla.Columns.Add("Producto/Servicio", typeof(string));
            tabla.Columns.Add("Cantidad", typeof(string));
            dgvProductosAgregados.DataSource = tabla;

            panel3.Visible = false;
            panel4.Visible = false;
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
            dgvListadoProductos.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, NomProducto from Producto WHERE EstadoProducto='Activo'");
            dgvListadoServicio.DataSource = CsComandosSql.RetornaDatos("select ID_Servicio, Nom_Servicio from Servicio WHERE EstadoServicio='Activo'");
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
            panel4.Visible = true;
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
            panel3.Visible = true;
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
            int idGenerado;

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
            try
            {
                string query = $@"
                DECLARE @TempID INT;
                EXEC SpRequisicion @XMLrequisicion = '{xmlRequisicion}', @IDIngresada=@TempID OUTPUT;
                SELECT @TempID AS IDGenerado;";

                DataTable dt = CsComandosSql.RetornaDatos(query);

                if (dt.Rows.Count > 0)
                {
                    idGenerado = Convert.ToInt32(dt.Rows[0]["IDGenerado"]);
                    foreach (DataGridViewRow fila in dgvProductosAgregados.Rows)
                    {
                        if (fila.IsNewRow)
                            continue;

                        string idProducto = fila.Cells["ID_Producto"].Value?.ToString();
                        string idServicio = fila.Cells["ID_Servicio"].Value?.ToString();
                        string producto = fila.Cells["Producto/Servicio"].Value?.ToString();
                        string cantidad = fila.Cells["Cantidad"].Value?.ToString();

                        if (string.IsNullOrEmpty(idProducto) && string.IsNullOrEmpty(idServicio))
                        {
                            MessageBox.Show("Debe seleccionar un producto o un servicio.");
                            continue;
                        }

                        if (!string.IsNullOrEmpty(idProducto) && !string.IsNullOrEmpty(idServicio))
                        {
                            MessageBox.Show("Solo debe seleccionar un producto o un servicio, no ambos.");
                            continue;
                        }
            
                        int cantidadValida;
                        if (!int.TryParse(cantidad, out cantidadValida))
                        {
                            MessageBox.Show("La cantidad debe ser un número válido.");
                            continue;
                        }

                        string xmlDetalleRequi = $@"
                        <DRequiciciones>
                            <DRequisicion>
                                <Producto>{producto}</Producto>
                                <Cantidad>{cantidadValida}</Cantidad>
                                <Estado>Pendiente</Estado>
                                <ID_Servicio>{(string.IsNullOrEmpty(idServicio) ? "NULL" : idServicio)}</ID_Servicio>
                                <ID_Producto>{(string.IsNullOrEmpty(idProducto) ? "NULL" : idProducto)}</ID_Producto>
                                <ID_Requisicion>{idGenerado}</ID_Requisicion>
                            </DRequisicion>
                        </DRequiciciones>";

                        string queryD = $"exec SpDetalleRequi @XMLdetalleRequi = '{xmlDetalleRequi}'";
                        try
                        {
                            if (CsComandosSql.InserDeletUpdate(queryD))
                            {
                            }
                            else
                                MessageBox.Show("Error al insertar detalle");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                    MessageBox.Show("Requisición Creada");
                    tabla.Clear();
                    txtMotivo.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar requisición: " + ex.Message);
            }
        }
    }
}

