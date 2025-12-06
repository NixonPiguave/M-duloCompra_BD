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
    public partial class frmListadoRequiPendiente: Form
    {
        string Nombre;
        int Id;
        int IdUsuario;
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Id1 { get => Id; set => Id = value; }
        public int IdUsuario1 { get => IdUsuario; set => IdUsuario = value; }

        public frmListadoRequiPendiente()
        {
            InitializeComponent();
        }

        private void frmListadoRequiPendiente_Load(object sender, EventArgs e)
        {
            dgvListRequiPendientes.DataSource = CsComandosSql.RetornaDatos($"Select ID_Requisicion, Estado_Requisicion, MotivoRequisicion, Nombre_Departamento from (Select * from (Select R.UsuarioSolicitanteID, U.ID_Depa, R.ID_Requisicion, R.Estado_Requisicion,R.MotivoRequisicion, D.Nombre_Departamento\r\nfrom [OC-Requisicion] R inner join [MC-Usuario] U on R.UsuarioSolicitanteID = U.ID_Usuario inner join [MC-Departamento] D on U.ID_Depa= D.ID_Depa) as X where ID_Depa in\r\n(Select D.ID_Depa from [MC-Departamento] D inner join [MC-Usuario] U on D.ID_Depa= U.ID_Depa where ID_Usuario= {IdUsuario1})) as Y where Estado_Requisicion= 'Pendiente'\r\n");
        }

        private void btnSelecRequi_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvListRequiPendientes.CurrentCell.RowIndex;
                txtBuscarRequiPendiente.Text = dgvListRequiPendientes[0, fila].Value.ToString();
                Nombre = dgvListRequiPendientes[0, fila].Value.ToString();
                Id = Convert.ToInt32(dgvListRequiPendientes[0, fila].Value);
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
