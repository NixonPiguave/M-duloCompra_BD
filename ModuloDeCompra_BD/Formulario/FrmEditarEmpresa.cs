using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmEditarEmpresa : Form
    {
        private CsEmpresa empresa;
        private byte[] imagenActual;

        public FrmEditarEmpresa()
        {
            InitializeComponent();
        }

        private void btnAgregarCambios_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpresa.Text == string.Empty || txtRUC.Text==string.Empty || txtTelefono.Text==string.Empty ||
                txtDireccion.Text==string.Empty || txtCorreo.Text==string.Empty)
            {
                MessageBox.Show("Todos los campos son obligatorios excepto el logo.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            empresa.Nombre_Empresa1 = txtNombreEmpresa.Text;
            empresa.RUC1 = txtRUC.Text;
            empresa.Telefono1 = txtTelefono.Text;
            empresa.Direccion1 = txtDireccion.Text;
            empresa.Correo1 = txtCorreo.Text;

            if (pbLogo.Image != null)
            {
                try
                {
                    byte[] nuevaImagen;
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbLogo.Image.Save(ms, ImageFormat.Png);
                        nuevaImagen = ms.ToArray();
                    }

                    if (imagenActual == null || !imagenActual.SequenceEqual(nuevaImagen))
                    {
                        empresa.Logo1 = nuevaImagen;
                    }
                    else
                    {
                        empresa.Logo1 = null;
                    }
                }
                catch (System.Runtime.InteropServices.ExternalException exe)
                {
                    MessageBox.Show("Error al guardar la imagen: La imagen no es compatible o está corrupta. " + exe, "Error de imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                empresa.Logo1 = null;
            }

            bool resultado;
            string queryVerificar = $"SELECT ID_Empresa FROM Empresa WHERE ID_Empresa = {empresa.ID_Empresa1}";
            bool existe = CsComandosSql.verificar(queryVerificar);

            if (existe)
            {
                resultado = empresa.ModificarEmpresa();
            }
            else
            {
                resultado = empresa.AgregarEmpresa();
            }

            if (resultado)
            {
                MessageBox.Show(existe ? "Empresa modificada correctamente." : "Empresa agregada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al realizar la operación.");
            }
        }

        private void FrmEditarEmpresa_Load(object sender, EventArgs e)
        {
            string sentencia = "SELECT * FROM Empresa WHERE ID_Empresa = 1";
            dgvEmpresa.DataSource = CsComandosSql.RetornaDatos(sentencia);

            empresa = new CsEmpresa();
            empresa.ID_Empresa1 = 1;

            if (dgvEmpresa.Rows.Count > 0)
            {
                pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                DataGridViewRow row = dgvEmpresa.Rows[0];

                txtNombreEmpresa.Text = row.Cells["Nombre_Empresa"].Value.ToString();
                txtRUC.Text = row.Cells["RUC"].Value.ToString();
                txtTelefono.Text = row.Cells["Telefono"].Value.ToString();
                txtDireccion.Text = row.Cells["Direccion"].Value.ToString();
                txtCorreo.Text = row.Cells["Correo"].Value.ToString();

                if (row.Cells["Logo_Empresa"].Value != DBNull.Value)
                {
                    imagenActual = (byte[])row.Cells["Logo_Empresa"].Value;
                    using (MemoryStream ms = new MemoryStream(imagenActual))
                    {
                        pbLogo.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    imagenActual = null;
                    pbLogo.Image = null;
                }
            }
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes compatibles|*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (EsImagenValida(ofd.FileName))
                    {
                        try
                        {
                            using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                            {
                                Image img = Image.FromStream(fs);
                                pbLogo.Image = img;
                            }
                        }
                        catch (System.Runtime.InteropServices.ExternalException ex)
                        {
                            MessageBox.Show("Error al cargar la imagen: La imagen no es compatible o está corrupta.", "Error de imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error inesperado al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("La imagen seleccionada no es válida o está corrupta.", "Error de imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private bool EsImagenValida(string filePath)
        {
            try
            {
                using (Image img = Image.FromFile(filePath))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void txtRUC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
