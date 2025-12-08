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
    public partial class FrmListadoBodega : Form
    {
        CsBodega bodega = new CsBodega();
        string Nombre;
        List<int> IdsSeleccionados = new List<int>();
        string NombresSeleccionados;

        public string Nombre1 { get => Nombre; set => Nombre = value; }
        public List<int> IdsSeleccionados1 { get => IdsSeleccionados; set => IdsSeleccionados = value; }
        public string NombresSeleccionados1 { get => NombresSeleccionados; set => NombresSeleccionados = value; }

        public FrmListadoBodega()
        {
            InitializeComponent();
        }

        private void FrmListadoBodega_Load(object sender, EventArgs e)
        {
            dgvListadoUbiBodega.DataSource = bodega.ListaBodega("");
            // Permitir selección múltiple
            dgvListadoUbiBodega.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListadoUbiBodega.MultiSelect = true;
        }

        private void btnSeleccionarBodega_Click(object sender, EventArgs e)
        {
            if (dgvListadoUbiBodega.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione al menos una bodega.");
                return;
            }

            IdsSeleccionados.Clear();
            List<string> nombres = new List<string>();

            foreach (DataGridViewRow fila in dgvListadoUbiBodega.SelectedRows)
            {
                int id = Convert.ToInt32(fila.Cells[0].Value);
                string nombre = fila.Cells[1].Value.ToString();

                IdsSeleccionados.Add(id);
                nombres.Add(nombre);
            }

            NombresSeleccionados = string.Join(", ", nombres);
            MessageBox.Show($"Se seleccionaron {IdsSeleccionados.Count} bodega(s)");
            this.Close();
        }

        private void txtBuscarBodega_KeyUp(object sender, KeyEventArgs e)
        {
            dgvListadoUbiBodega.DataSource = bodega.ListaBodega(txtBuscarBodega.Text);
        }
    }
}
