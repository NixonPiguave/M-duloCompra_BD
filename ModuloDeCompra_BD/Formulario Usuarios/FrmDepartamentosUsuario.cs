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
    public partial class FrmDepartamentosUsuarios: Form
    {
        int z;
        public FrmDepartamentosUsuarios()
        {
            InitializeComponent();
        }
        private void FrmDepartamentosUsuarios_Load(object sender, EventArgs e)
        {
            dgvDepartamento.DataSource = CsComandosSql.RetornaDatos($"select *from Departamento");
        }
        private void txtNombreDepartamento_KeyUp(object sender, KeyEventArgs e)
        {
            dgvDepartamento.DataSource=CsComandosSql.RetornaDatos($"select * from Departamento where Nombre_Departamento like '{txtNombreDepartamento.Text}%'");
        }

        private void dgvDepartamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvDepartamento.CurrentCell.RowIndex;
            txtNombreDepartamento.Text =dgvDepartamento[1,fila].Value.ToString();
            z = Convert.ToInt32(dgvDepartamento[0, fila].Value.ToString());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
