using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmProductos : Form
    {
        int Id;
        int Id2;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            dgvService.DataSource = CsComandosSql.RetornaDatos("select ID_Servicio, Nom_Servicio, Precio_Unit from Servicios");
            dgvProducto.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, Nom_Producto, Precio_Unit from Producto");
            cbTipoP.SelectedIndex = 0;
           DataTable tb= CsComandosSql.RetornaDatos("select * from IVA");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cmbIVA.Items.Add(tb.Rows[i]["Valor_IVA"].ToString());
            }
            DataTable tn = CsComandosSql.RetornaDatos("Select * from EstadoIVA");
            for (int i = 0; i < tn.Rows.Count; i++)
            {
                cmbEstado.Items.Add(tn.Rows[i]["Estado"].ToString());
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            double precioU;
            try
            {
                precioU = Convert.ToDouble(txtPrecioUnitario.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("taa " + ex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cbTipoP.SelectedItem.ToString()=="Producto")
            {
                decimal precioU=0;
                try
                {
                    precioU = decimal.Parse(txtPrecioUnitario.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Precio no válido" + ex);
                }
                try
                {
                    CsProducto producto = new CsProducto();
                    producto.Nom_Producto1 = txtNombreProducto.Text;
                    producto.Precio_Unit1 = precioU;
                    double iva = Convert.ToDouble(cmbIVA.SelectedItem);
                    DataTable tb = CsComandosSql.RetornaDatos($"select * from IVA where Valor_IVA={iva}");
                    producto.Iva1 = Convert.ToInt32(tb.Rows[0]["ID_IVA"].ToString());
                    DataTable T = CsComandosSql.RetornaDatos($"select ID_Estado from EstadoIVA where Estado='{cmbEstado.SelectedItem.ToString()}'");
                    producto.Estado1= Convert.ToInt32(T.Rows[0]["ID_Estado"].ToString());
                    producto.Categoria1 = Id;
                    producto.Proveedor1 = Id2;

                    if (producto.AñadirProducto())
                    {
                        dgvProducto.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, Nom_Producto, Precio_Unit from Producto");
                        MessageBox.Show("Producto agregado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar producto, verifique que los datos sean correctos");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                 decimal precioU=0;
                try
                {
                    precioU = decimal.Parse(txtPrecioUnitario.Text, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Precio no válido" + ex);
                }
                try
                {
                    //mal mal mal mal 
                    CsProducto producto = new CsProducto();
                    producto.Nom_Producto1 = txtNombreProducto.Text;
                    producto.Precio_Unit1 = precioU;
                    double iva = Convert.ToDouble(cmbIVA.SelectedItem);
                    DataTable tb = CsComandosSql.RetornaDatos($"select * from IVA where Valor_IVA={iva}");
                    producto.Iva1 = Convert.ToInt32(tb.Rows[0]["ID_IVA"].ToString());
                    DataTable T = CsComandosSql.RetornaDatos($"select ID_Estado from EstadoIVA where Estado='{cmbEstado.SelectedItem.ToString()}'");
                    producto.Estado1 = Convert.ToInt32(T.Rows[0]["ID_Estado"].ToString());
                    producto.Proveedor1 = Id2;

                    if (producto.AñadirServicio())
                    {
                        dgvService.DataSource = CsComandosSql.RetornaDatos("select ID_Servicio, Nom_Servicio, Precio_Unit from Servicios");
                        MessageBox.Show("Servicio agregado correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Servicio, verifique que los datos sean correctos");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
        }

        private void btnListadoCategoria_Click(object sender, EventArgs e)
        {
            FrmListadoCategoria ListadoCategoria = new FrmListadoCategoria();
            ListadoCategoria.ShowDialog();
            txtListadoCategory.Text= ListadoCategoria.Nombre1;
            Id = ListadoCategoria.IdCat1;
        }

        private void btnListadoProveedor_Click(object sender, EventArgs e)
        {
            FrmListadoProveedor listadoProveedor = new FrmListadoProveedor();
            listadoProveedor.ShowDialog();
            txtListadoProvee.Text = listadoProveedor.Nombre1;
            Id2 = listadoProveedor.IdProvee1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = " ";
            txtPrecioUnitario.Text = " ";
            txtListadoCategory.Text = " ";
            txtListadoProvee.Text = " ";
            cmbIVA.SelectedIndex = -1;
            cmbEstado.SelectedIndex = -1;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoP.SelectedItem.ToString() == "Servicio")
            {
                btnListadoCategoria.Enabled = false;
            }
            else
                btnListadoCategoria.Enabled = true;
        }
    }
}
