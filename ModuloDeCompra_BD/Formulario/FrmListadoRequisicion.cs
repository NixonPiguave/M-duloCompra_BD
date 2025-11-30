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
    public partial class FrmListadoRequisicion: Form
    {
        csOrdenCompra ordenCompra = new csOrdenCompra();
        int IdReq;
        public int RequisicionID { get => IdReq; set => IdReq = value; }

        public FrmListadoRequisicion()
        {
            InitializeComponent();

        }

        private void FrmListadoRequisicion_Load(object sender, EventArgs e)
        {
            dgvListadoRequisicion.DataSource = CsComandosSql.RetornaDatos("select ID_Requisicion, Estado_Requisicion, UsuarioSolicitanteID from Requisicion where Estado_Requisicion = 'Aprobada'");
        }

        private void btnSeleccionarCatego_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvListadoRequisicion.CurrentCell.RowIndex;
                txtRequisicionID.Text = dgvListadoRequisicion[0, fila].Value.ToString();
                IdReq = Convert.ToInt32(dgvListadoRequisicion[0, fila].Value);
                MessageBox.Show("Requisición seleccionada");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error en Listado Requisición");
            }
        }

        private void txtBuscarCategoria_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoRequisicion.DataSource = ordenCompra.ListaRequisicion(txtRequisicionID.Text);
        }
    }
}
