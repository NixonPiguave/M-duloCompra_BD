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
            string sentencia = "select P.ID_Prov, P.Nombre_Proveedor, P.NombreContacto, P.Correo, P.Descuento_Predeterminado, P.Pais, P.Ciudad, P.Direccion, P.Telefono, T.Tipo, P.Num_Documento from Proveedoress as P inner join TipoDocumento as T on P.Tipo_Documento=T.TipoID";
            dgvProveedores.DataSource = CsComandosSql.RetornaDatos(sentencia);

            DataTable tb = CsComandosSql.RetornaDatos("select * from TipoDocumento");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cmbDocumento.Items.Add(tb.Rows[i]["Tipo"].ToString());
            }
        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posCelda = dgvProveedores.CurrentCell.RowIndex;
            id = Convert.ToInt32(dgvProveedores[0, posCelda].Value.ToString());
            txtNombreProveedor.Text = dgvProveedores[1, posCelda].Value.ToString();
            txtDescPredeterminadoProveedor.Text = dgvProveedores[2, posCelda].Value.ToString();
            txtCorreoProveedor.Text = dgvProveedores[3, posCelda].Value.ToString();
            cmbDocumento.Text = dgvProveedores[4, posCelda].Value.ToString();
            txtNroDocProveedor.Text = dgvProveedores[5, posCelda].Value.ToString();
        }

        private void btnAggProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(CsComandosSql.verificar($"Select * from Proveedoress where Num_Documento = {txtNroDocProveedor.Text}")))
                {
                    CsProveedores CsProveedor = new CsProveedores();
                    CsProveedor.IdProvee1 = id;
                    CsProveedor.NombreProvee1 = txtNombreProveedor.Text;
                    CsProveedor.NombreContacto1 = txtNombreContacto.Text;
                    CsProveedor.Descuento1 = Convert.ToDouble(txtDescPredeterminadoProveedor.Text);
                    CsProveedor.Pais1 = txtPais.Text;
                    CsProveedor.Ciudad1 = txtCiudad.Text;
                    CsProveedor.Direccion1 = txtDireccion.Text;
                    CsProveedor.Telefono1 = txtTelefono.Text;
                    DataTable dt = CsComandosSql.RetornaDatos($"Select TipoID from TipoDocumento where Tipo = '{cmbDocumento.SelectedItem.ToString()}'");
                    CsProveedor.TipoDoc1 = Convert.ToInt32(dt.Rows[0]["TipoID"].ToString());
                    CsProveedor.NumDoc1 = txtNroDocProveedor.Text;
                    CsProveedor.AñadirProveedor();
                    MessageBox.Show("Se ha agregado el proveedor");
                    string sentencia = "select P.ID_Prov, P.Nombre_Proveedor, P.NombreContacto, P.Correo, P.Descuento_Predeterminado, P.Pais, P.Ciudad, P.Direccion, P.Telefono, T.Tipo, P.Num_Documento from Proveedoress as P inner join TipoDocumento as T on P.Tipo_Documento=T.TipoID"; dgvProveedores.DataSource = CsComandosSql.RetornaDatos(sentencia);
                }
                else
                {
                    MessageBox.Show("Ya existe número de documento");
                }
            }
            catch
            {
                MessageBox.Show("Error al insertar proveedor");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!(CsComandosSql.verificar($"Select * from Proveedoress where Num_Documento = {txtNroDocProveedor.Text}")))
                {
                    CsProveedores CsProveedor = new CsProveedores();
                    CsProveedor.IdProvee1 = id;
                    CsProveedor.NombreProvee1 = txtNombreProveedor.Text;
                    CsProveedor.NombreContacto1 = txtNombreContacto.Text;
                    CsProveedor.Descuento1 = Convert.ToDouble(txtDescPredeterminadoProveedor.Text);
                    CsProveedor.Pais1 = txtPais.Text;
                    CsProveedor.Ciudad1 = txtCiudad.Text;
                    CsProveedor.Direccion1 = txtDireccion.Text;
                    CsProveedor.Telefono1 = txtTelefono.Text;
                    DataTable dt = CsComandosSql.RetornaDatos($"Select TipoID from TipoDocumento where Tipo = '{cmbDocumento.SelectedItem.ToString()}'");
                    CsProveedor.TipoDoc1 = Convert.ToInt32(dt.Rows[0]["TipoID"].ToString());
                    CsProveedor.NumDoc1 = txtNroDocProveedor.Text;
                    CsProveedor.ModificarProveedor();
                    MessageBox.Show("Se ha cambiado el proveedor");
                    string sentencia = "select P.ID_Prov, P.Nombre_Proveedor, P.NombreContacto, P.Correo, P.Descuento_Predeterminado, P.Pais, P.Ciudad, P.Direccion, P.Telefono, T.Tipo, P.Num_Documento from Proveedoress as P inner join TipoDocumento as T on P.Tipo_Documento=T.TipoID"; dgvProveedores.DataSource = CsComandosSql.RetornaDatos(sentencia);
                }
                else
                {
                    MessageBox.Show("Ya existe número de documento");
                }
            }
            catch
            {
                MessageBox.Show("No se ha cambiado el proveedor");
            }

        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            CsProveedores CsProveedor = new CsProveedores();
            dgvProveedores.DataSource = CsProveedor.ListaProveedor(txtBuscar.Text);
        }
    }
}
