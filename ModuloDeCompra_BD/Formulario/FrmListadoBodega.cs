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
    public partial class FrmListadoBodega: Form
    {
        CsBodega bodega = new CsBodega();
        string Nombre;
        int Id;
        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public int Id1 { get => Id; set => Id = value; }

        public FrmListadoBodega()
        {
            InitializeComponent();
        }
        private void FrmListadoBodega_Load(object sender, EventArgs e)
        {
            dgvListadoUbiBodega.DataSource = bodega.ListaBodega("");
        }

        private void btnSeleccionarBodega_Click(object sender, EventArgs e)
        {
            int fila = dgvListadoUbiBodega.CurrentCell.RowIndex;
            txtBuscarBodega.Text = dgvListadoUbiBodega[1, fila].Value.ToString();
            Nombre = dgvListadoUbiBodega[1, fila].Value.ToString();
            Id = Convert.ToInt32(dgvListadoUbiBodega[0, fila].Value);
            MessageBox.Show("Ubicación de bodega seleccionada");
            this.Close();
        }

        private void txtBuscarBodega_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoUbiBodega.DataSource = bodega.ListaBodega(txtBuscarBodega.Text);
        }
    }
}
