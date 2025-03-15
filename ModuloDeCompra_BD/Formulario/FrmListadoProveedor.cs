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
    public partial class FrmListadoProveedor: Form
    {
        CsProveedores Prove = new CsProveedores();
        string Nombre;
        int IdProvee;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int IdProvee1 { get => IdProvee; set => IdProvee = value; }

        public FrmListadoProveedor()
        {
            InitializeComponent();
        }
        private void FrmListadoProveedor_Load(object sender, EventArgs e)
        {
            dgvListadoProveedores.DataSource = Prove.ListaProvee("");
        }

        private void txtBuscarProveedores_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoProveedores.DataSource = Prove.ListaProvee(txtBuscarProveedores.Text);
        }

        private void btnSeleccionarProvee_Click(object sender, EventArgs e)
        {
            int fila = dgvListadoProveedores.CurrentCell.RowIndex;
            txtBuscarProveedores.Text = dgvListadoProveedores[1, fila].Value.ToString();
            Nombre = dgvListadoProveedores[1, fila].Value.ToString();
            IdProvee = Convert.ToInt32(dgvListadoProveedores[0, fila].Value);
            MessageBox.Show("Proveedor seleccionado");
            this.Close();
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscarProveedores_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
