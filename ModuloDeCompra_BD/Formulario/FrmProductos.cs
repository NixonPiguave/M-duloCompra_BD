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

        public FrmProductos()
        {
            InitializeComponent();
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            //
            dgvService.DataSource = CsComandosSql.RetornaDatos("select ID_Servicio, Nom_Servicio, Costo from Servicio");
            dgvProducto.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, NomProducto, Costo from Producto");
            cbTipoP.SelectedIndex = 0;
           DataTable tb= CsComandosSql.RetornaDatos("select * from IVA where EstadoIVA= 1");
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                cmbIVA.Items.Add(tb.Rows[i]["Valor_IVA"].ToString());
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
                    if(cmbIVA.SelectedItem.ToString()== "Exento")
                    {
                        
                    }
                    else
                    {
                        string iva = cmbIVA.SelectedItem.ToString();
                        producto.Estado1 = cmbEstadoProducto.SelectedItem.ToString();
                        string precioUFormatoSQL = iva.ToString(CultureInfo.InvariantCulture);
                        precioUFormatoSQL = precioUFormatoSQL.Replace(',', '.');
                        DataTable tb = CsComandosSql.RetornaDatos($"select * from IVA where Valor_IVA={precioUFormatoSQL}");
                        var v = Convert.ToChar(tb.Rows[0]["ID_IVA"]);
                        producto.Iva1 = v;
                    }
                    producto.Estado1 = cmbEstadoProducto.SelectedItem.ToString();
                    

                    producto.Categoria1 = Id;
                    producto.Proveedor1 = Id2;

                    if (producto.AñadirProducto())
                    {
                        dgvProducto.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, NomProducto, Costo from Producto");
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
                   
                    CsProducto producto = new CsProducto();
                    producto.Nom_Producto1 = txtNombreProducto.Text;
                    producto.Precio_Unit1 = precioU;
                    string iva = Convert.ToString(cmbIVA.SelectedItem);
                    if(cmbEstadoProducto.SelectedItem.ToString()=="Exento")
                    {
                        //producto.Iva1 = '0';
                    }
                    else
                    {
                        string precioUFormatoSQL = iva.ToString(CultureInfo.InvariantCulture);
                        precioUFormatoSQL = precioUFormatoSQL.Replace(',', '.');
                        DataTable tb = CsComandosSql.RetornaDatos($"select * from IVA where Valor_IVA={precioUFormatoSQL}");
                        producto.Iva1 = Convert.ToChar(tb.Rows[0]["ID_IVA"].ToString());
                    }
                    producto.Estado1 = cmbEstadoProducto.SelectedItem.ToString();
                    //string precioUFormatoSQL = iva.ToString(CultureInfo.InvariantCulture);
                    //precioUFormatoSQL = precioUFormatoSQL.Replace(',', '.');
                    //DataTable tb = CsComandosSql.RetornaDatos($"select * from IVA where Valor_IVA={precioUFormatoSQL}");
                    //producto.Iva1 = Convert.ToChar(tb.Rows[0]["ID_IVA"].ToString());

                    
                    producto.Proveedor1 = Id2;

                    if (producto.AñadirServicio())
                    {
                        dgvService.DataSource = CsComandosSql.RetornaDatos("select ID_Servicio, Nom_Servicio, Costo from Servicio");
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
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvProducto.SelectedRows.Count > 0)
            {
                int fila = dgvProducto.SelectedRows[0].Index; 
                int prod = Convert.ToInt32(dgvProducto.Rows[fila].Cells[0].Value);  
                CsProducto pro = new CsProducto();
                if (pro.EliminarProducto(prod))  
                {
                    dgvProducto.DataSource = CsComandosSql.RetornaDatos("SELECT ID_Producto, NomProducto, Costo FROM Producto");
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
        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if(dgvService.SelectedRows.Count > 0)
            {
                int fila = dgvService.SelectedRows[0].Index;
                int prod = Convert.ToInt32(dgvService.Rows[fila].Cells[0].Value);
                CsProducto pro = new CsProducto();
                if(pro.EliminarServicio(prod))
                {
                    dgvService.DataSource = CsComandosSql.RetornaDatos("Select ID_Servicio, Nom_Servicio, Costo from Servicio ");
                    MessageBox.Show("Servicio eliminado correctamente");
                }
                else
                {
                    MessageBox.Show("Error al eliminar el servicio");
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un servicio de la lista");
            }
            
        }
        private void dgvProducto_DoubleClick(object sender, EventArgs e)
        {
            int fila = dgvProducto.CurrentCell.RowIndex;
            Id3 = Convert.ToInt32(dgvProducto[0, fila].Value);
            txtNombreProducto.Text = dgvProducto[1, fila].Value.ToString();
            txtPrecioUnitario.Text = dgvProducto[2, fila].Value.ToString();
        }

        private void dgvService_DoubleClick(object sender, EventArgs e)
        {
            int fila = dgvService.CurrentCell.RowIndex;
            Id4 = Convert.ToInt32(dgvService[0, fila].Value);
            txtNombreProducto.Text = dgvService[1, fila].Value.ToString();
            txtPrecioUnitario.Text = dgvService[2, fila].Value.ToString();
        }

        private void btnEditarGeneral_Click(object sender, EventArgs e)
        {
            if (cbTipoP.SelectedItem.ToString() == "Producto")
            {
                decimal precioU = 0;
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
                    string iva = cmbIVA.SelectedItem.ToString();
                    string precioUFormatoSQL = iva.ToString(CultureInfo.InvariantCulture);
                    precioUFormatoSQL = precioUFormatoSQL.Replace(',', '.');
                    DataTable tb = CsComandosSql.RetornaDatos($"select * from IVA where Valor_IVA={precioUFormatoSQL}");
                    var v = Convert.ToChar(tb.Rows[0]["ID_IVA"]);
                    producto.Iva1 = v;

                    producto.Categoria1 = Id;
                    producto.Proveedor1 = Id2;

                    if (producto.ModificarProducto(Id3))
                    {
                        dgvProducto.DataSource = CsComandosSql.RetornaDatos("select ID_Producto, NomProducto, Costo from Producto");
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
                decimal precioU = 0;
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
                    string iva = Convert.ToString(cmbIVA.SelectedItem);
                    string precioUFormatoSQL = iva.ToString(CultureInfo.InvariantCulture);
                    precioUFormatoSQL = precioUFormatoSQL.Replace(',', '.');
                    DataTable tb = CsComandosSql.RetornaDatos($"select * from IVA where Valor_IVA={precioUFormatoSQL}");
                    producto.Iva1 = Convert.ToChar(tb.Rows[0]["ID_IVA"].ToString());


                    producto.Proveedor1 = Id2;

                    if (producto.ModificarServicio(Id4))
                    {
                        dgvService.DataSource = CsComandosSql.RetornaDatos("select ID_Servicio, Nom_Servicio, Costo from Servicio");
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

        //private void btnEditar_Click(object sender, EventArgs e)
        //{
        //    CsProducto pro1 = new CsProducto();
        //    int fila = dgvProducto.CurrentCell.RowIndex;
        //    string nombre = txtNombreProducto.Text;
        //    string precioUnit = txtPrecioUnitario.Text;
        //    pro1.ModificarProducto(Id3,nombre, precioUnit);
        //}

        //private void btnEditarServicio_Click(object sender, EventArgs e)
        //{
        //    CsProducto serv = new CsProducto();
        //    int fila = dgvService.CurrentCell.RowIndex;
        //    string nombre = txtNombreProducto.Text;
        //    string precioUnit = txtPrecioUnitario.Text;
        //    serv.ModificarProducto(Id4,nombre, precioUnit);
        //}

        //MALLLLLLLLLL
        //private void btnEditarServicio_DoubleClick(object sender, EventArgs e)
        //{


        //}


    }
}
