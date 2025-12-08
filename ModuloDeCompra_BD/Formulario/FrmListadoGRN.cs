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
    public partial class FrmListadoGRN: Form
    {
        int IdCat;
        int IDProv;
        public int ID { get => IdCat; set => IdCat = value; }
        public int IDProv1 { get => IDProv; set => IDProv = value; }

        public FrmListadoGRN()
        {
            InitializeComponent();

        }

        private void FrmListadoCategoria_Load(object sender, EventArgs e)
        {
            dgvListadoCategoria.DataSource = CsComandosSql.RetornaDatos("select * from [IN-GRN_Header] where Estado='R'");
        }

        private void btnSeleccionarCatego_Click(object sender, EventArgs e)
        {
            try
            {
                int fila = dgvListadoCategoria.CurrentCell.RowIndex;
                txtGRN.Text = dgvListadoCategoria[0, fila].Value.ToString();
                ID = Convert.ToInt32(dgvListadoCategoria[0, fila].Value);
                IDProv = Convert.ToInt32(dgvListadoCategoria[6, fila].Value);
                MessageBox.Show("GRN seleccionado");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error al seleccionar");
            }
        }
    }
}
