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
            string cadena = $"select R.ID_Requisicion, R.MotivoRequisicion, D.Producto, D.Cantidad from Requisicion as R inner join Requi_Details as D on R.ID_Requisicion = D.ID_Requisicion where R.ID_Requisicion = {ID}";
            dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos(cadena);
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvEstadoRequision.CurrentCell.RowIndex;
            txtProducto.Text = dgvEstadoRequision[2, celda].Value.ToString();
            txtCantidad.Text = dgvEstadoRequision[3, celda].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Point posArribaTxT = new Point();
            posArribaTxT.X = 62;
            posArribaTxT.Y = 343;
            Point posArribaLbL = new Point();
            posArribaLbL.X = 93;
            posArribaLbL.Y = 307;
            txtNuevaCantidad.Visible = false;
            txtNuevaCantidad.Text = string.Empty;
            lblNuevaCantidad.Visible = false;
            btnRegresar.BringToFront();
            lblMotivo.Location = posArribaLbL;
            txtMotivo.Location = posArribaTxT;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Point posArribaTxT = new Point();
            posArribaTxT.X = 62;
            posArribaTxT.Y = 343;
            Point posArribaLbL = new Point();
            posArribaLbL.X = 93;
            posArribaLbL.Y = 307;
            Point posAbajoTxT = new Point();
            posAbajoTxT.X = 62;
            posAbajoTxT.Y = 443;
            Point posAbajoLbL = new Point();
            posAbajoLbL.X = 93;
            posAbajoLbL.Y = 400;
            if (txtNuevaCantidad.Visible == false)
            {
                txtNuevaCantidad.Visible = true;
                lblNuevaCantidad.Visible = true;
                btnAceptar.BringToFront();
                lblMotivo.Location = posAbajoLbL;
                txtMotivo.Location = posAbajoTxT;
            }
            else
            {
                txtNuevaCantidad.Visible = false;
                lblNuevaCantidad.Visible = false;
                btnRegresar.BringToFront();
                lblMotivo.Location = posArribaLbL;
                txtMotivo.Location = posArribaTxT;
            }
        }
    }
}
