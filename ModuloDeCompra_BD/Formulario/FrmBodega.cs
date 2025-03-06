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
using static System.Net.Mime.MediaTypeNames;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmBodega: Form
    {
        public FrmBodega()
        {
            InitializeComponent();
        }

        private void FrmBodega_Load(object sender, EventArgs e)
        {
            dgvBodega.DataSource = CsComandosSql.RetornaDatos($"select * from Bodega");
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void txtID_Bodega_KeyUp(object sender, KeyEventArgs e)
        {

            dgvBodega.DataSource = CsComandosSql.RetornaDatos($" select * from Bodega where ID_BODEGA = '{txtStockMax.Text}'");

        }
    }
}
