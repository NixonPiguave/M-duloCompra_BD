using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmCatalogoCuentas: Form
    {
        public FrmCatalogoCuentas()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCuenta.Text))
            {
                if (!CsComandosSql.verificar($"select * from CatalogoCuentas where ID_IVA= '{txtCuenta.Text}'"))
                {
                    string XML = "<CuentasContables>" +
                        "               <Cuenta>" +
                        $"                   <Cuenta>{txtCuenta.Text}</Cuenta>" +
                        $"                   <Nombre>{txtNombre.Text}</Nombre>" +
                        $"                   <Tipo>{txtTipo.Text}</Tipo>" +
                        $"                   <Descripcion>{txtDescripcion.Text}</Descripcion>" +
                        $"                   <Categoria>{txtCategoria.Text}</Categoria>" +
                        "               </Cuenta>" +
                        "         </CuentasContables>";
                    string query = $"EXEC spAgregarCuentaContable @XML_Cuentas = {XML}";

                }
                else
                {
                    MessageBox.Show("La Cuenta Contable ya existe");
                }
            }
            else
            {
                MessageBox.Show("Rellene el tipo de Cuenta Contable");
            }
        }

        private void FrmCatalogoCuentas_Load(object sender, EventArgs e)
        {
            dgvCuentaContables.DataSource = CsComandosSql.RetornaDatos("select * from CatalogoCuentas");
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvCuentaContables.CurrentCell.RowIndex;
            txtCuenta.Text = dgvCuentaContables[0, celda].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCuenta.Text))
            {
                int posicion = dgvCuentaContables.CurrentCell.RowIndex;
                string ID = Convert.ToString(dgvCuentaContables[0, posicion].Value.ToString());
                string query = $"delete from CatalogoCuentas where Cuenta = '{txtCuenta.Text}'";
            }
            else
            {
                MessageBox.Show("Escoja la Cuenta Contable");
            }
        }
    }
}
