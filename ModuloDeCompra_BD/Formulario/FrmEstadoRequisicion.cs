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
            if (cmbEstadoRechazar.SelectedIndex == 0)
            {  
                CsComandosSql.verificar($"Update Requisicion set Estado_Requisicion = 'Aprobado' where ID_Requisicion = {ID}");
                dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos("Select * from Requisicion");
            }
            else
            {
                CsComandosSql.verificar($"Update Requisicion set Estado_Requisicion = 'Rechazado' where ID_Requisicion = {ID}");
                dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos("Select * from Requisicion");
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            int posicion = dgvEstadoRequision.CurrentCell.RowIndex;
            int ID = Convert.ToInt32(dgvEstadoRequision[0, posicion].Value);
            btnDetalle.Visible = false;
            btnRegresar.Visible = true;
            dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos($"Select * from Requi_Details where ID_Requisicion = {ID}");
        }


        private void btnRegresar_Click(object sender, EventArgs e)
        {
            btnRegresar.Visible = false;
            btnDetalle.Visible = true;
            dgvEstadoRequision.DataSource = CsComandosSql.RetornaDatos("select * from Requisicion");
        }
    }
}
