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
        int Id3;
        int Id4;
        int Id5;

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            cmbEstadoProducto.SelectedItem = 1;
            cmbIVA.SelectedIndex = 0;           
            dgvProducto.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, NomProducto, Costo from [IN-Producto]");
           DataTable tb= CsComandosSql.RetornaDatos("select * from [CG-IVA] where EstadoIVA= 1");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cmbIVA.Items.Add(tb.Rows[i]["Valor_IVA"].ToString());
            }
            //Unidad Base
            DataTable tbUB = CsComandosSql.RetornaDatos("select * from [IN-UnidadesMedida]");
            for (int i = 0; i < tbUB.Rows.Count; i++)
            {
                cmbUnidadBase.Items.Add(tbUB.Rows[i]["Nombre"].ToString());
            }
            //Unidad Alterna
            DataTable tbUA = CsComandosSql.RetornaDatos("select * from [IN-UnidadesAlternativas]");
            for (int i = 0; i < tbUA.Rows.Count; i++)
            {
                cmbUnidadAlterna.Items.Add(tbUA.Rows[i]["Nombre"].ToString());
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
            
                decimal precioU = 0;
                string precioTexto = txtPrecioUnitario.Text.Trim();
                precioTexto = precioTexto.Replace(',', '.');

                if (!decimal.TryParse(precioTexto, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out precioU))
                {
                    MessageBox.Show("Precio no válido. Asegúrate de ingresar un número con punto decimal.");
                    return;
                }

                try
                {
                    CsProducto producto = new CsProducto();
                    producto.Nom_Producto1 = txtNombreProducto.Text;
                    producto.Precio_Unit1 = precioU;

                    if (cmbIVA.SelectedItem.ToString() == "Exento")
                    {
                        producto.Iva1 = 'C';
                    }
                    else
                    {
                        string iva = cmbIVA.SelectedItem.ToString();
                       
                        string precioUFormatoSQL = iva.ToString(CultureInfo.InvariantCulture);
                        precioUFormatoSQL = precioUFormatoSQL.Replace(',', '.');
                        DataTable tb = CsComandosSql.RetornaDatos($"SELECT * FROM [CG-IVA] WHERE Valor_IVA = '{precioUFormatoSQL}'");

                        if (tb.Rows.Count > 0)
                        {
                            var v = Convert.ToChar(tb.Rows[0]["ID_IVA"]);
                            producto.Iva1 = v;
                        }
                        else
                        {
                            MessageBox.Show("El IVA seleccionado no existe en la base de datos.");
                            return; 
                        }
                    }

                    producto.Estado1 = cmbEstadoProducto.SelectedItem.ToString();
                    producto.Categoria1 = Id;
                    producto.Proveedor1 = Id2;
                    if (CHBInventariable.Checked == true) 
                    {
                        producto.Inventariable1 = "Si";
                        if(chbUnidadBase.Checked==true)
                        {
                            producto.IdUnidad1 = cmbUnidadBase.SelectedIndex + 1;
                        }
                        else if(chbUnidadAlterna.Checked==true)
                        {
                            producto.IdUnidadAlternativa1 = cmbUnidadAlterna.SelectedIndex + 1;
                        }

                    }else
                    {
                        producto.Inventariable1 = "No";
                    }

                    string ubicacionBodega = txtListadoUbiBodega.Text.Trim();
                    DataTable ubicacionBodegaData = CsComandosSql.RetornaDatos($"SELECT ID_Bodega FROM Bodega WHERE Ubicacion = '{ubicacionBodega}'");

                    if (ubicacionBodegaData.Rows.Count > 0)
                    {
                        int idBodega = Convert.ToInt32(ubicacionBodegaData.Rows[0]["ID_Bodega"]);

                        if (producto.AñadirProducto(idBodega))
                        {
                            dgvProducto.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, NomProducto, Costo from [IN-Producto]");
                            MessageBox.Show("Producto agregado correctamente");
                            txtNombreProducto.Text = string.Empty;
                            txtPrecioUnitario.Text = string.Empty;
                            cmbIVA.SelectedIndex = -1;
                            cmbEstadoProducto.SelectedIndex = -1;
                            txtListadoCategory.Text = string.Empty;
                            txtListadoProvee.Text = string.Empty;
                            txtListadoUbiBodega.Text = string.Empty; 
                            chbUnidadAlterna.Checked = false;
                            chbUnidadBase.Checked = false;
                            CHBInventariable.Checked = false;
                    }
                        else
                        {
                            MessageBox.Show("Error al agregar producto, verifique que los datos sean correctos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ubicación de bodega no válida.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
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
        private void btnListadoUbiBodega_Click(object sender, EventArgs e)
        {
            FrmListadoBodega listadoBodega = new FrmListadoBodega();
            listadoBodega.ShowDialog();
            txtListadoUbiBodega.Text = listadoBodega.Nombre1;
            Id5 = listadoBodega.Id1;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombreProducto.Text = " ";
            txtPrecioUnitario.Text = " ";
            txtListadoCategory.Text = " ";
            txtListadoProvee.Text = " ";
            cmbIVA.SelectedIndex = -1;
            
        }

      
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                int fila = dgvProducto.SelectedRows[0].Index; 
                int prod = Convert.ToInt32(dgvProducto.Rows[fila].Cells[0].Value);  
                CsProducto pro = new CsProducto();
                if (pro.EliminarProducto(prod))  
                {
                    dgvProducto.DataSource = CsComandosSql.RetornaDatos("SELECT ID_Producto, NomProducto, Costo FROM [IN-Producto]");
                    MessageBox.Show("Producto eliminado correctamente");

                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto de la lista.");
            }
        }

        private void dgvProducto_DoubleClick(object sender, EventArgs e)
        {
            int fila = dgvProducto.CurrentCell.RowIndex;
            Id3 = Convert.ToInt32(dgvProducto[0, fila].Value);
            txtNombreProducto.Text = dgvProducto[1, fila].Value.ToString();
            txtPrecioUnitario.Text = dgvProducto[2, fila].Value.ToString();
            DataTable dt = CsComandosSql.RetornaDatos($"select Ubicacion from [IN-Inventario] I inner join [IN-Bodega] B on I.ID_Bodega=B.ID_Bodega where ID_Producto={Id3}");
            txtListadoUbiBodega.Text = dt.Rows[0]["Ubicacion"].ToString();
        }

        private void btnEditarGeneral_Click(object sender, EventArgs e)
        {
            if (txtNombreProducto.Text != string.Empty || txtPrecioUnitario.Text != string.Empty || cmbIVA.SelectedIndex != -1 || cmbEstadoProducto.SelectedIndex != -1 || txtListadoCategory.Text != string.Empty || txtListadoProvee.Text != string.Empty || txtListadoUbiBodega.Text != string.Empty)
            {

                decimal precioU = 0;
                string precioTexto = txtPrecioUnitario.Text.Trim();

                precioTexto = precioTexto.Replace(',', '.');


                if (!decimal.TryParse(precioTexto, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out precioU))
                {
                    MessageBox.Show("Precio no válido. Asegúrate de ingresar un número con punto decimal.");
                    return;
                }
                try
                {
                    CsProducto producto = new CsProducto();
                    producto.Nom_Producto1 = txtNombreProducto.Text;
                    producto.Precio_Unit1 = precioU;
                    if (cmbIVA.SelectedItem.ToString() == "Exento")
                    {
                        producto.Iva1 = 'C';
                    }
                    else
                    {
                        string iva = cmbIVA.SelectedItem.ToString();

                        string precioUFormatoSQL = iva.ToString(CultureInfo.InvariantCulture);
                        precioUFormatoSQL = precioUFormatoSQL.Replace(',', '.');
                        DataTable tb = CsComandosSql.RetornaDatos($"SELECT * FROM [CG-IVA] WHERE Valor_IVA = '{precioUFormatoSQL}'");

                        if (tb.Rows.Count > 0)
                        {
                            var v = Convert.ToChar(tb.Rows[0]["ID_IVA"]);
                            producto.Iva1 = v;
                        }
                        else
                        {
                            MessageBox.Show("El IVA seleccionado no existe en la base de datos.");
                            return;
                        }
                    }

                    producto.Estado1 = cmbEstadoProducto.SelectedItem.ToString();
                    producto.Categoria1 = Id;
                    producto.Proveedor1 = Id2;
                    string ubicacionBodega = txtListadoUbiBodega.Text.Trim();
                    DataTable ubicacionBodegaData = CsComandosSql.RetornaDatos($"SELECT ID_Bodega FROM [IN-Bodega] WHERE Ubicacion = '{ubicacionBodega}'");
                    if (CHBInventariable.Checked == true)
                    {
                        producto.Inventariable1 = "Si";
                        if (chbUnidadBase.Checked == true)
                        {
                            producto.IdUnidad1 = cmbUnidadBase.SelectedIndex + 1;
                        }
                        else if (chbUnidadAlterna.Checked == true)
                        {
                            producto.IdUnidadAlternativa1 = cmbUnidadAlterna.SelectedIndex + 1;
                        }

                    }
                    else
                    {
                        producto.Inventariable1 = "No";
                    }

                    if (ubicacionBodegaData.Rows.Count > 0)
                    {
                        int idBodega = Convert.ToInt32(ubicacionBodegaData.Rows[0]["ID_Bodega"]);

                        if (producto.ModificarProducto(Id3, idBodega))
                        {
                            dgvProducto.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, NomProducto, Costo from [IN-Producto]");
                            MessageBox.Show("Producto editado correctamente");
                            txtNombreProducto.Text = string.Empty;
                            txtPrecioUnitario.Text = string.Empty;
                            cmbIVA.SelectedIndex = -1;
                            cmbEstadoProducto.SelectedIndex = -1;
                            txtListadoCategory.Text = string.Empty;
                            txtListadoProvee.Text = string.Empty;
                            chbUnidadAlterna.Checked = false;
                            chbUnidadBase.Checked = false;
                            CHBInventariable.Checked = false;
                        }
                        else
                        {
                            MessageBox.Show("Error al editar producto, verifique que los datos sean correctos");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ubicación de bodega no válida.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex);
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }
        }

        private void CHBInventariable_CheckedChanged(object sender, EventArgs e)
        {
            if(CHBInventariable.Checked==true)
            {
                pnlUnidades.Visible = true;
            }
            else
            {
                pnlUnidades.Visible = false;
            }
        }

        private void chbUnidadBase_CheckedChanged(object sender, EventArgs e)
        {
            if(chbUnidadBase.Checked==true)
            {
                cmbUnidadBase.Enabled = true;
                chbUnidadAlterna.Checked = false;
                cmbUnidadAlterna.SelectedIndex = -1;
            }
            else
            {
                cmbUnidadBase.Enabled = false;
            }
        }

        private void chbUnidadAlterna_CheckedChanged(object sender, EventArgs e)
        {
            if (chbUnidadAlterna.Checked == true)
            {
                cmbUnidadAlterna.Enabled = true;
                chbUnidadBase.Checked = false;
                cmbUnidadBase.SelectedIndex = -1;
            }
            else
            {
                cmbUnidadAlterna.Enabled = false;
            }
        }
    }
}
