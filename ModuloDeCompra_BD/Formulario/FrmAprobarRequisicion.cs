using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmAprobarRequisicion: Form
    {
        int id;
        int idUsuario;
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public FrmAprobarRequisicion()
        {
            InitializeComponent();
        }
        private void btnListRequiPendientes_Click(object sender, EventArgs e)
        {
            frmListadoRequiPendiente listaRequiPendiente = new frmListadoRequiPendiente();
            listaRequiPendiente.IdUsuario1 = idUsuario;
            listaRequiPendiente.ShowDialog();
            txtIDRequisicionPendiente.Text = listaRequiPendiente.Nombre1;
            id = listaRequiPendiente.Id1;

            int idRequi = int.Parse(txtIDRequisicionPendiente.Text);
            LlenarDgv(idRequi);
        }
        private void LlenarDgv(int idRequi)
        {
            try
            {
                DgvRequisicionPendiente.DataSource = CsComandosSql.RetornaDatos($"Select * from Requisicion where ID_Requisicion = {idRequi}");
                dgvDetalleRequiPendiente.DataSource = CsComandosSql.RetornaDatos($"Select * from Requi_Details where ID_Requisicion= {idRequi}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos" + ex.Message);
            }
            
        }
        private void btnAprobarRequi_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = DgvRequisicionPendiente.CurrentCell.RowIndex;
                int id = Convert.ToInt32(DgvRequisicionPendiente[0, pos].Value);
                string obser = $"Requisicion acepatada por el departamento";
                string cadenaXML = $@"<Requisiciones>
	                    <Requisicion>
		                    <ID_Requisicion>{id}</ID_Requisicion> 
		                    <Estado_Requisicion>Aprobada</Estado_Requisicion>
		                     <Observacion>{obser}</Observacion>
	                    </Requisicion>
                    </Requisiciones>";
                string query = $@"exec spModificarRequisicion '{cadenaXML}'";
                CsComandosSql.InserDeletUpdate(query);
                MessageBox.Show("Se ha aprovado la requisición");
                int idRequi = int.Parse(txtIDRequisicionPendiente.Text);
                DgvRequisicionPendiente.DataSource = CsComandosSql.RetornaDatos($"Select * from Requisicion where ID_Requisicion = {idRequi}");
                dgvDetalleRequiPendiente.DataSource = CsComandosSql.RetornaDatos($"Select * from Requi_Details where ID_Requisicion= {idRequi} AND Estado= 'Pendiente'");
                Limpiar();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al aceptar requisición" + ex.Message);
            }
        }

        private void btnRechazarRequi_Click(object sender, EventArgs e)
        {
            try
            {
                int pos = DgvRequisicionPendiente.CurrentCell.RowIndex;
                int id = Convert.ToInt32(DgvRequisicionPendiente[0, pos].Value);
                string obser = $"Requisicion rechazada por el departamento";
                string cadenaXML = $@"<Requisiciones>
	                    <Requisicion>
		                    <ID_Requisicion>{id}</ID_Requisicion> 
		                    <Estado_Requisicion>Rechazada</Estado_Requisicion>
		                    <Observacion>{obser}</Observacion>
	                        </Requisicion>
                        </Requisiciones>";
                string query = $@"exec spModificarRequisicion '{cadenaXML}'";
                CsComandosSql.InserDeletUpdate(query);
                MessageBox.Show("Se ha rechazado la requisición");
                int idRequi = int.Parse(txtIDRequisicionPendiente.Text);
                DgvRequisicionPendiente.DataSource = CsComandosSql.RetornaDatos($"Select * from Requisicion where ID_Requisicion = {idRequi}");
                dgvDetalleRequiPendiente.DataSource = CsComandosSql.RetornaDatos($"Select * from Requi_Details where ID_Requisicion= {idRequi} AND Estado= 'Pendiente'");
                Limpiar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al rechazar requisición" + ex.Message);
            }
        }

        private void btnModificarCantidadRequi_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDetalleRequiPendiente.CurrentRow == null)
                {
                    MessageBox.Show("¡Debe seleccionar una fila primero antes de modificar la cantidad!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string CadenaXML = $@"<RequiDetalle> 
	                <Detalle>
		                <Cantidad>{txtCantidad.Text}</Cantidad>
		                <ID_Servicio>{txtIdServicio.Text}</ID_Servicio>
		                <ID_Producto>{txtIdProducto.Text}</ID_Producto>
		                <ID_Requisicion>{txtIDRequisicionPendiente.Text}</ID_Requisicion>
	                </Detalle>
                </RequiDetalle>";
                string query = $@"exec spModificarCantidadRequisicion '{CadenaXML}'";
                CsComandosSql.InserDeletUpdate(query);
                MessageBox.Show("Se ha modificado la cantidad");
                int idRequi = int.Parse(txtIDRequisicionPendiente.Text);
                dgvDetalleRequiPendiente.DataSource = CsComandosSql.RetornaDatos($"Select * from Requi_Details where ID_Requisicion= {idRequi} AND Estado= 'Pendiente'");
                Limpiar();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al modificar" + ex.Message);
            }
        }

        private void dgvDetalleRequiPendiente_DoubleClick(object sender, EventArgs e)
        {
            int celda = dgvDetalleRequiPendiente.CurrentCell.RowIndex;
            txtCantidad.Text = dgvDetalleRequiPendiente[2, celda].Value.ToString();
            txtIdProducto.Text = dgvDetalleRequiPendiente[5, celda].Value.ToString();
            txtIdServicio.Text = dgvDetalleRequiPendiente[4, celda].Value.ToString();
        }

        private void btnRechazarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                string cadenaXML = $@"<RequiDetalle> 
	                    <Detalle> 
		                    <ID_Requisicion>{txtIDRequisicionPendiente.Text}</ID_Requisicion>
		                    <ID_Producto>{txtIdProducto.Text}</ID_Producto>
		                    <ID_Servicio>{txtIdServicio.Text}</ID_Servicio>
		                    <Estado>Rechazado</Estado>
	                    </Detalle>
                    </RequiDetalle>";
                string query = $@"exec spRechazarProductoRequisicion '{cadenaXML}'";
                CsComandosSql.InserDeletUpdate(query);
                int idRequi = int.Parse(txtIDRequisicionPendiente.Text);
                dgvDetalleRequiPendiente.DataSource = CsComandosSql.RetornaDatos($"Select * from Requi_Details where ID_Requisicion= {idRequi} AND Estado= 'Pendiente'");
                DgvRequisicionPendiente.DataSource = CsComandosSql.RetornaDatos($"Select * from Requisicion where ID_Requisicion = {idRequi}");
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al rechazar producto o servicio");
            }
        }

        private void Limpiar()
        {
            txtIdServicio.Text = " ";
            txtCantidad.Text = " ";
            txtIdProducto.Text = " ";
        }
    }
}
