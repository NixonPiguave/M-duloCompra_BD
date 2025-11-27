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
            tabla.Columns.Add("Producto", typeof(string));
            tabla.Columns.Add("Cantidad", typeof(string));
            dgvProductosAgregados.DataSource = tabla;
            btnAgregarP.Visible = false;
            lbProduc.Visible = false;
            lbCantidad.Visible = false;
            txtProducto.Visible = false;
            nudCantidad.Visible = false;
            txtID.Visible = false;
            lbID.Visible = false;
            nudCantidad.Minimum = 1;
            nudCantidad.Value = 1;
            dgvListadoProductos.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, NomProducto from Producto WHERE EstadoProducto='Activo'");
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
                        string producto = fila.Cells["Producto"].Value?.ToString();
                        string cantidad = fila.Cells["Cantidad"].Value?.ToString();

                        if (string.IsNullOrEmpty(idProducto))
                        {
                            MessageBox.Show("Debe seleccionar un producto");
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
                                <ID_Producto>{idProducto}</ID_Producto>
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

       
        private void txtFiltroProduc_KeyUp_1(object sender, KeyEventArgs e)
        {
            dgvListadoProductos.DataSource = CsComandosSql.RetornaDatos($"select ID_Producto, NomProducto  from Producto WHERE EstadoProducto='Activo' and NomProducto like '%{txtFiltroProduc.Text}%'");
        }

        private void btnProducto_Click_1(object sender, EventArgs e)
        {

            btnAgregarP.Visible = true;
            lbProduc.Visible = true;
            lbCantidad.Visible = true;
            txtProducto.Visible = true;
            txtID.Visible = true;
            nudCantidad.Visible = true;
            txtID.Visible = true;
            lbID.Visible = true;
            int fila = dgvListadoProductos.CurrentCell.RowIndex;
            txtID.Text = dgvListadoProductos[0, fila].Value.ToString();
            txtProducto.Text = dgvListadoProductos[1, fila].Value.ToString();
        }  
        private void btnAgregarP_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text) && !string.IsNullOrEmpty(txtProducto.Text))
            {
                bool Verificar = false;
                foreach (DataGridViewRow fila in dgvProductosAgregados.Rows)
                {
                    string producto = fila.Cells["Producto"].Value?.ToString();
                    if (txtProducto.Text == producto)
                    {
                        Verificar = true;
                        break;
                    }
                }
                if (!Verificar)
                {
                    tabla.Rows.Add(txtID.Text, txtProducto.Text, nudCantidad.Value);
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
    }
}

