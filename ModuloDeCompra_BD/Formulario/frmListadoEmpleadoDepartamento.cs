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
    public partial class frmListaEmpleadosDepartamentos: Form
    {
        string DepaID;

        public string DepaID1 { get => DepaID; set => DepaID = value; }

        public frmListaEmpleadosDepartamentos()
        {
            InitializeComponent();
        }

        private void frmListaEmpleadosDepartamentos_Load(object sender, EventArgs e)
        {
            dgvListaEmpleados.DataSource = CsComandosSql.RetornaDatos($"select U.ID_Usuario, U.Nombre, U.Apellido, U.Cedula, D.Nombre_Departamento, R.Rol from Usuario as U inner join Departamento as D on U.ID_Depa = D.ID_Depa inner join Roles as R on U.ID_Rol = R.ID_Rol where U.ID_Depa = {DepaID1}");
        }

        private void btnSelecRequi_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(txtBuscarEmpleadoPendiente.Text))
                {
                    string RequisicionID = "0";
                    FrmAprobarRequisicion frmAprobar = new FrmAprobarRequisicion();

                    string derivarRequisicion = $"update Requisicion set RequisicionDerivadaUsuario = {txtBuscarEmpleadoPendiente.Text}";
                    CsComandosSql.InserDeletUpdate(derivarRequisicion);
                    MessageBox.Show("Se ha enviado la requisicion");
                    this.Close();
                }
                else
                { 
                    MessageBox.Show("Escoja un empleado");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void dgvListaEmpleados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celdaActual = dgvListaEmpleados.CurrentCell.RowIndex;
            string EmpleadoID = dgvListaEmpleados[0,celdaActual].Value.ToString();
            txtBuscarEmpleadoPendiente.Text = EmpleadoID;
        }
    }
}
