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
    public partial class frmListadoRequiPendienteDerivados: Form
    {
        string IdRequisicion;
        string Id;
        int IdUsuario;
        public string IdRequisicion1 { get => IdRequisicion; set => IdRequisicion = value; }
        public string Id1 { get => Id; set => Id = value; }
        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }

        public frmListadoRequiPendienteDerivados()
        {
            InitializeComponent();
        }

        private void frmListadoRequiPendienteDerivados_Load(object sender, EventArgs e)
        {
            string sentenciaExtraerRequisiciones = $"select * from Requisicion where (RequisicionDerivadaUsuario = {IdUsuario1} and Estado_Requisicion = 'Pendiente') ";
            dgvListRequiPendientes.DataSource = CsComandosSql.RetornaDatos(sentenciaExtraerRequisiciones);
        }
        private void btnSelecRequi_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvListRequiPendientes.CurrentCell.RowIndex;
                txtBuscarRequiPendiente.Text = dgvListRequiPendientes[0, fila].Value.ToString();
                FrmAprobarRequisicion frmAprobar = new FrmAprobarRequisicion();
                Id1 = dgvListRequiPendientes[0, fila].Value.ToString();
                frmAprobar.RequisicionID1 = Id1;
                MessageBox.Show(frmAprobar.RequisicionID1);
                MessageBox.Show("Requisición seleccionada");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}
