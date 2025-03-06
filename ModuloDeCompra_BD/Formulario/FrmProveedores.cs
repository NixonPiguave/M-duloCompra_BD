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
    public partial class FrmProveedores: Form
    {
        int id;
        public FrmProveedores()
        {
            InitializeComponent();
        }

        private void FrmProveedores_Load(object sender, EventArgs e)
        {
            string sentencia = "Select * from Proveedores";
            dgvProveedores.DataSource = CsComandosSql.RetornaDatos(sentencia);
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posCelda = dgvProveedores.CurrentCell.RowIndex;
            id = Convert.ToInt32(dgvProveedores[0, posCelda].Value.ToString());
            txtNombreProveedor.Text = dgvProveedores[1, posCelda].Value.ToString();
            txtNombreContacto.Text = dgvProveedores[2, posCelda].Value.ToString();
            txtCorreoProveedor.Text = dgvProveedores[3, posCelda].Value.ToString();
            txtPais.Text = dgvProveedores[4, posCelda].Value.ToString();
            txtCiudad.Text = dgvProveedores[5, posCelda].Value.ToString();
            txtTelefono.Text = dgvProveedores[6, posCelda].Value.ToString();
            cmbDocumento.Text = dgvProveedores[7, posCelda].Value.ToString();
            txtNroDocProveedor.Text = dgvProveedores[8, posCelda].Value.ToString();
            txtDescPredeterminadoProveedor.Text = dgvProveedores[9, posCelda].Value.ToString();
            txtDireccion.Text = dgvProveedores[10, posCelda].Value.ToString();
            if (dgvProveedores[11, posCelda].Value.ToString() == "1")
            {
                cmbEstado.SelectedIndex = 0;
            }
            else
            {
                cmbEstado.SelectedIndex = 1;
            }
        }

        private void btnAggProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(CsComandosSql.verificar($"Select * from Proveedores where NroDocumento = {txtNroDocProveedor.Text}")))
                {
                    CsProveedores CsProveedor = new CsProveedores();
                    CsProveedor.NombreProvee1 = txtNombreProveedor.Text;
                    CsProveedor.NombreContacto1 = txtNombreContacto.Text;
                    CsProveedor.Descuento1 = Convert.ToDouble(txtDescPredeterminadoProveedor.Text);
                    CsProveedor.Correo1 = txtCorreoProveedor.Text;
                    CsProveedor.Pais1 = txtPais.Text;
                    CsProveedor.Ciudad1 = txtCiudad.Text;
                    CsProveedor.Direccion1 = txtDireccion.Text;
                    CsProveedor.Telefono1 = txtTelefono.Text;
                    CsProveedor.TipoDoc1 = cmbDocumento.SelectedItem.ToString();
                    CsProveedor.NumDoc1 = txtNroDocProveedor.Text;
                    CsProveedor.Estado1 = (cmbEstado.SelectedIndex == 0) ? '1' : '0';
                    if (CsProveedor.AñadirProveedor())
                    {
                        MessageBox.Show("Se ha agregado el proveedor");
                        txtNombreProveedor.Text = string.Empty;
                        txtNombreContacto.Text = string.Empty;
                        txtDescPredeterminadoProveedor.Text = string.Empty;
                        txtCorreoProveedor.Text = string.Empty;
                        txtPais.Text = string.Empty;
                        txtCiudad.Text = string.Empty;
                        txtDireccion.Text = string.Empty;
                        txtTelefono.Text = string.Empty;
                        cmbDocumento.SelectedIndex = -1;
                        cmbEstado.SelectedIndex = -1;
                        txtNroDocProveedor.Text = string.Empty;
                    }
                    string sentencia = "select * from Proveedores"; dgvProveedores.DataSource = CsComandosSql.RetornaDatos(sentencia);
                }
                else
                {
                    MessageBox.Show("Ya existe número de documento");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al insertar proveedor"+ ex);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                CsProveedores CsProveedor = new CsProveedores();
                CsProveedor.IdProvee1 = id;
                CsProveedor.NombreProvee1 = txtNombreProveedor.Text;
                CsProveedor.NombreContacto1 = txtNombreContacto.Text;
                CsProveedor.Descuento1 = Convert.ToDouble(txtDescPredeterminadoProveedor.Text);
                CsProveedor.Correo1 = txtCorreoProveedor.Text;
                CsProveedor.Pais1 = txtPais.Text;
                CsProveedor.Ciudad1 = txtCiudad.Text;
                CsProveedor.Direccion1 = txtDireccion.Text;
                CsProveedor.Telefono1 = txtTelefono.Text;
                CsProveedor.TipoDoc1 = cmbDocumento.SelectedItem.ToString();
                CsProveedor.NumDoc1 = txtNroDocProveedor.Text;
                CsProveedor.Estado1 = (cmbEstado.SelectedIndex == 0) ? '1' : '0';
                if (CsProveedor.ModificarProveedor())
                {
                    MessageBox.Show("Se ha cambiado el proveedor");
                    txtNombreProveedor.Text = string.Empty;
                    txtNombreContacto.Text = string.Empty;
                    txtDescPredeterminadoProveedor.Text = string.Empty;
                    txtCorreoProveedor.Text = string.Empty;
                    txtPais.Text = string.Empty;
                    txtCiudad.Text = string.Empty;
                    txtDireccion.Text = string.Empty;
                    txtTelefono.Text = string.Empty;
                    cmbDocumento.SelectedIndex = -1;
                    cmbEstado.SelectedIndex = -1;
                    txtNroDocProveedor.Text = string.Empty;
                }
                string sentencia = "select * from Proveedores";
                dgvProveedores.DataSource = CsComandosSql.RetornaDatos(sentencia);
            }
            catch
            {
                MessageBox.Show("Error al intentar modificar el proveedor");
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CsProveedores CsProveedor = new CsProveedores();
            dgvProveedores.DataSource = CsProveedor.ListaProveedor(txtBuscar.Text);
        }
    }
}
