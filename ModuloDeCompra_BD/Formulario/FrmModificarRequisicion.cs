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
    public partial class FrmDetalleRequisicion: Form
    {
        public FrmDetalleRequisicion()
        {
            InitializeComponent();
        }

        private void FrmDetalleRequisicion_Load(object sender, EventArgs e)
        {
            FrmEstadoRequisiciones frmRequisicion = new FrmEstadoRequisiciones();
            int ID = Convert.ToInt32(txtRequisicion.Text);
            string cadena = $"select R.ID_Requisicion, R.MotivoRequisicion, D.Producto, D.ID_Producto, D.ID_Servicio, D.Cantidad from Requisicion as R inner join Requi_Details as D on R.ID_Requisicion = D.ID_Requisicion where R.ID_Requisicion = {ID}";
            dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos(cadena);
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvEstadoRequision.CurrentCell.RowIndex;
            txtProducto.Text = dgvEstadoRequision[3, celda].Value.ToString();
            txtServicioID.Text = dgvEstadoRequision[4, celda].Value.ToString();
            txtCantidad.Text = dgvEstadoRequision[5, celda].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string XML = $@"
                <RequiDetalle>
	                <Detalle>
		                <Cantidad>{txtNuevaCantidad.Text}</Cantidad>
		                <Estado>{cmbEstados.SelectedItem.ToString()}</Estado>
		                <ID_Servicio>{txtServicioID.Text}</ID_Servicio>
		                <ID_Producto>{txtProducto.Text}</ID_Producto>
		                <ID_Requisicion>{txtRequisicion.Text}</ID_Requisicion>
	                </Detalle>
                </RequiDetalle>
            ";
            string Exec = $"exec spModificarCantidadRequisicion @cadena = '{XML}'";
            if (!string.IsNullOrEmpty(txtNuevaCantidad.Text))
            {
                try
                {
                    if (CsComandosSql.InserDeletUpdate(Exec))
                    {
                        int ID = Convert.ToInt32(txtRequisicion.Text);
                        MessageBox.Show("Se ha modificado la cantidad");
                        Point cordArribaMotivoRequisicionTxT = new Point();
                        cordArribaMotivoRequisicionTxT.X = 62;
                        cordArribaMotivoRequisicionTxT.Y = 404;
                        Point cordArribaLblMotivo = new Point();
                        cordArribaLblMotivo.X = 93;
                        cordArribaLblMotivo.Y = 373;
                        txtNuevaCantidad.Visible = false;
                        txtNuevaCantidad.Text = string.Empty;
                        lblNuevaCantidad.Visible = false;
                        cmbEstados.SelectedIndex = -1;
                        btnRegresar.BringToFront();
                        lblMotivo.Location = cordArribaLblMotivo;
                        txtMotivo.Location = cordArribaMotivoRequisicionTxT;
                        string cadena = $"select R.ID_Requisicion, R.MotivoRequisicion, D.Producto, D.ID_Producto, D.ID_Servicio, D.Cantidad from Requisicion as R inner join Requi_Details as D on R.ID_Requisicion = D.ID_Requisicion where R.ID_Requisicion = {ID}";
                        dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos(cadena);
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido modificar la cantidad");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se ha podido modificar la cantidad " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Ingrese la nueva cantidad");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Point cordAbajoMotivoRequisicionTxT = new Point();
            cordAbajoMotivoRequisicionTxT.X = 62;
            cordAbajoMotivoRequisicionTxT.Y = 482;
            Point cordAbajoLblMotivo = new Point();
            cordAbajoLblMotivo.X = 93;
            cordAbajoLblMotivo.Y = 459;
            Point cordArribaMotivoRequisicionTxT = new Point();
            cordArribaMotivoRequisicionTxT.X = 62;
            cordArribaMotivoRequisicionTxT.Y = 404;
            Point cordArribaLblMotivo = new Point();
            cordArribaLblMotivo.X = 93;
            cordArribaLblMotivo.Y = 373;
            if (txtNuevaCantidad.Visible == false)
            {
                txtNuevaCantidad.Visible = true;
                lblNuevaCantidad.Visible = true;
                btnAceptar.BringToFront();
                txtMotivo.Location = cordAbajoMotivoRequisicionTxT;
                lblMotivo.Location = cordAbajoLblMotivo;
            }
            else
            {
                txtNuevaCantidad.Visible = false;
                lblNuevaCantidad.Visible = false;
                btnRegresar.BringToFront();
                txtMotivo.Location = cordArribaMotivoRequisicionTxT;
                lblMotivo.Location = cordArribaLblMotivo;
            }
        }
    }
}
