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
            DataTable tbUB = CsComandosSql.RetornaDatos("select * from [IN-UnidadesMedida] where IdUnidad!=20");
            for (int i = 0; i < tbUB.Rows.Count; i++)
            {
                cmbUnidadBase.Items.Add(tbUB.Rows[i]["Nombre"].ToString());
            }
            //Unidad Alterna
            DataTable tbUA = CsComandosSql.RetornaDatos("select * from [IN-UnidadesAlternativas] where IdUnidadAlt!=11");
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
                        producto.Inventariable1 = "SI";

                            string nombreUnidadBase = cmbUnidadBase.SelectedItem?.ToString();
                            if (!string.IsNullOrEmpty(nombreUnidadBase))
                            {
                            DataTable dtUnidad = CsComandosSql.RetornaDatos(
                                $"SELECT IdUnidad FROM [IN-UnidadesMedida] WHERE Nombre = '{nombreUnidadBase}'");

                                if (dtUnidad.Rows.Count > 0)
                                {
                                    producto.IdUnidad1 = Convert.ToInt32(dtUnidad.Rows[0]["IdUnidad"]);
                                }

                            }
                        else
                            {
                            MessageBox.Show("Por favor, seleccione una unidad base.");
                            }

                        string nombreUnidadAlt = cmbUnidadAlterna.SelectedItem?.ToString();
                        if (!string.IsNullOrEmpty(nombreUnidadAlt))
                        {
                            DataTable dtUnidadAlt = CsComandosSql.RetornaDatos(
                                $"SELECT IdUnidadAlt FROM [IN-UnidadesAlternativas] WHERE Nombre = '{nombreUnidadAlt}'");

                            if (dtUnidadAlt.Rows.Count > 0)
                            {
                                producto.IdUnidadAlternativa1 = Convert.ToInt32(dtUnidadAlt.Rows[0]["IdUnidadAlt"]);
                            }

                        }
                        else
                        {
                        MessageBox.Show("Por favor, seleccione una unidad alternativa.");
                        }

             

                    string ubicacionBodega = txtListadoUbiBodega.Text.Trim();
                    DataTable ubicacionBodegaData = CsComandosSql.RetornaDatos($"SELECT ID_Bodega FROM [IN-Bodega] WHERE Ubicacion = '{ubicacionBodega}'");

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
                            cmbUnidadBase.SelectedIndex = -1;
                            cmbUnidadAlterna.SelectedIndex = -1;
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
                else
                {
                    producto.Inventariable1 = "NO";
                    if (producto.AñadirProducto())
                    {
                        dgvProducto.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, NomProducto, Costo from [IN-Producto]");
                        MessageBox.Show("Servicio agregado correctamente");
                        txtNombreProducto.Text = string.Empty;
                        txtPrecioUnitario.Text = string.Empty;
                        cmbIVA.SelectedIndex = -1;
                        cmbEstadoProducto.SelectedIndex = -1;
                        txtListadoCategory.Text = string.Empty;
                        txtListadoProvee.Text = string.Empty;
                        txtListadoUbiBodega.Text = string.Empty;
                        cmbUnidadBase.SelectedIndex = -1;
                        cmbUnidadAlterna.SelectedIndex = -1;
                        CHBInventariable.Checked = false;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar Servicio, verifique que los datos sean correctos");
                    }

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
            
            DataTable dtProducto = CsComandosSql.RetornaDatos(
          $"SELECT * FROM [IN-Producto] WHERE ID_Producto = {Id3}");

            if (dtProducto.Rows.Count > 0)
            {
                DataRow producto = dtProducto.Rows[0];
                string inventariable = producto["Inventariable"].ToString();
                CHBInventariable.Checked = (inventariable == "Si" || inventariable == "SI");
                if(inventariable=="Si")
                {
                    if (!Convert.IsDBNull(producto["IdUnidad"]) && producto["IdUnidad"] != DBNull.Value)
                    {
                        int idUnidad = Convert.ToInt32(producto["IdUnidad"]);

                        // Buscar la unidad en el ComboBox
                        DataTable dtUnidad = CsComandosSql.RetornaDatos(
                            $"SELECT Nombre FROM [IN-UnidadesMedida] WHERE IdUnidad = {idUnidad}");

                        if (dtUnidad.Rows.Count > 0)
                        {
                            string nombreUnidad = dtUnidad.Rows[0]["Nombre"].ToString();

                            // Buscar y seleccionar en el ComboBox
                            for (int i = 0; i < cmbUnidadBase.Items.Count; i++)
                            {
                                if (cmbUnidadBase.Items[i].ToString() == nombreUnidad)
                                {
                                    cmbUnidadBase.SelectedIndex = i;
                                    break;
                                }
                            }
                        }
                    }

                    // Cargar Unidad Alternativa
                    if (!Convert.IsDBNull(producto["IdUnidadAlternativa"]) &&
                        producto["IdUnidadAlternativa"] != DBNull.Value)
                    {
                        int idUnidadAlt = Convert.ToInt32(producto["IdUnidadAlternativa"]);

                        // Buscar la unidad en el ComboBox
                        DataTable dtUnidadAlt = CsComandosSql.RetornaDatos(
                            $"SELECT Nombre FROM [IN-UnidadesAlternativas] WHERE IdUnidadAlt = {idUnidadAlt}");

                        if (dtUnidadAlt.Rows.Count > 0)
                        {
                            string nombreUnidadAlt = dtUnidadAlt.Rows[0]["Nombre"].ToString();

                            // Buscar y seleccionar en el ComboBox
                            for (int i = 0; i < cmbUnidadAlterna.Items.Count; i++)
                            {
                                if (cmbUnidadAlterna.Items[i].ToString() == nombreUnidadAlt)
                                {
                                    cmbUnidadAlterna.SelectedIndex = i;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
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
                        producto.Inventariable1 = "SI";

                        string nombreUnidadBase = cmbUnidadBase.SelectedItem?.ToString();
                        if (!string.IsNullOrEmpty(nombreUnidadBase))
                        {
                            DataTable dtUnidad = CsComandosSql.RetornaDatos(
                                $"SELECT IdUnidad FROM [IN-UnidadesMedida] WHERE  Nombre = '{nombreUnidadBase}'");

                            if (dtUnidad.Rows.Count > 0)
                            {
                                producto.IdUnidad1 = Convert.ToInt32(dtUnidad.Rows[0]["IdUnidad"]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, seleccione una unidad base.");
                        }

                        string nombreUnidadAlt = cmbUnidadAlterna.SelectedItem?.ToString();
                        if (!string.IsNullOrEmpty(nombreUnidadAlt))
                        {
                            DataTable dtUnidadAlt = CsComandosSql.RetornaDatos(
                                $"SELECT IdUnidadAlt FROM [IN-UnidadesAlternativas] WHERE Nombre = '{nombreUnidadAlt}'");

                            if (dtUnidadAlt.Rows.Count > 0)
                            {
                                producto.IdUnidadAlternativa1 = Convert.ToInt32(dtUnidadAlt.Rows[0]["IdUnidadAlt"]);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Por favor, seleccione una unidad alternativa.");
                        }

                    }
                    else
                    {
                        producto.Inventariable1 = "NO";
                        producto.IdUnidad1 = 20;
                        producto.IdUnidadAlternativa1 = 11;
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
                            CHBInventariable.Checked = false;
                            cmbUnidadBase.SelectedIndex = -1;
                            cmbUnidadAlterna.SelectedIndex = -1;
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
                lbl_Bode.Visible = true;
                btnListadoUbiBodega.Visible = true;
                txtListadoUbiBodega.Visible = true;
            }
            else
            {
                pnlUnidades.Visible = false;
                lbl_Bode.Visible = false;
                btnListadoUbiBodega.Visible = false;
                txtListadoUbiBodega.Visible = false;
            }
        }
    }
}
