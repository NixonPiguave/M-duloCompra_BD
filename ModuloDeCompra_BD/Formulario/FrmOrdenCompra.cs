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
    public partial class FrmOrdenCompra: Form
    {
        public FrmOrdenCompra()
        {
            InitializeComponent();
        }

        private void FrmOrdenCompra_Load(object sender, EventArgs e)
        {
            dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos("select * from Requisicion where Estado_Requisicion = 'Aprobado'");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            FrmListadoRequisicion frmListado = new FrmListadoRequisicion();
            frmListado.ShowDialog();
            txtRequisicionID.Text = frmListado.RequisicionID.ToString();
        }

        private void dgvEstadoRequision_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvEstadoRequision.CurrentCell.RowIndex;
            txtOrdenCompra.Text = dgvEstadoRequision[0, celda].Value.ToString();
        }
    }
}
