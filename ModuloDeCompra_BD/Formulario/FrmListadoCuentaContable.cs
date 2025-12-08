using Microsoft.Win32;
using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.WebSockets;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrnListadoCatalogoCuentas: Form
    {
        CsBodega bodega = new CsBodega();
        int Id;
        public int Id1 { get => Id; set => Id = value; }

        public FrnListadoCatalogoCuentas()
        {
            InitializeComponent();
        }
        private void FrnListadoCatalogoCuentas_Load(object sender, EventArgs e)
        {
            dgvListadoCuenta.DataSource = CsComandosSql.RetornaDatos("select * from [CG-CatalogoCuentasContables]");
        }

        private void btnSeleccionarBodega_Click(object sender, EventArgs e)
        {
            int fila = dgvListadoCuenta.CurrentCell.RowIndex;
            txtBuscarBodega.Text = dgvListadoCuenta[1, fila].Value.ToString();
            Id1 = Convert.ToInt32(dgvListadoCuenta[0, fila].Value);
            MessageBox.Show("Catálogo Cuenta seleccionada");
            this.Close();
        }
    }
}
