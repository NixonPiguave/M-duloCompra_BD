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
    public partial class FrmEstadoRequisiciones: Form
    {
        public FrmEstadoRequisiciones()
        {
            InitializeComponent();
        }

        private void FrmEstadoRequisiciones_Load(object sender, EventArgs e)
        {
            dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos("Select * from Requisicion");
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvEstadoRequision.CurrentCell.RowIndex;
            txtRequisicion.Text = dgvEstadoRequision[0, celda].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int posicion = dgvEstadoRequision.CurrentCell.RowIndex;
            int ID = Convert.ToInt32(dgvEstadoRequision[0, posicion].Value);
            string Estado;
            if (cmbEstadoRechazar.SelectedIndex == 0)
            {
                Estado = "Aprobado";
                string Observacion = "Requisición aprobada por el departamento de finanzas";
                string cadenaXML = $@"<Requisiciones>
                        <Requisicion>
                            <ID_Requisicion>{ID}</ID_Requisicion>
                            <Estado_Requisicion>{Estado}</Estado_Requisicion>
                            <Observacion>{Observacion}</Observacion>
                        </Requisicion>
                    </Requisiciones>";
                string query = $@"exec spModificarRequisicion '{cadenaXML}'";
                CsComandosSql.InserDeletUpdate(query);
                dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos("Select * from Requisicion");
            }
            else
            {
                Estado = "Rechazado";
                string Observacion = "Requisición aprobada por el departamento de finanzas";
                string cadenaXML = $@"<Requisiciones>
                        <Requisicion>
                            <ID_Requisicion>{ID}</ID_Requisicion>
                            <Estado_Requisicion>{Estado}</Estado_Requisicion>
                            <Observacion>{Observacion}</Observacion>
                        </Requisicion>
                    </Requisiciones>";
                string query = $@"exec spModificarRequisicion '{cadenaXML}'";
                CsComandosSql.InserDeletUpdate(query);
                dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos("Select * from Requisicion");
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRequisicion.Text))
            {
                int celda = dgvEstadoRequision.CurrentCell.RowIndex;
                FrmDetalleRequisicion frmDetalle = new FrmDetalleRequisicion();
                frmDetalle.txtRequisicion.Text = txtRequisicion.Text;
                frmDetalle.txtMotivo.Text = dgvEstadoRequision[5, celda].Value.ToString();
                frmDetalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("Escoga una requisición con doble click");
            }
        }
    }
}
