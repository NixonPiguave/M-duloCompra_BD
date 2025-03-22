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
            empresa.Nombre_Empresa1 = txtNombreEmpresa.Text;

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
                catch (System.Runtime.InteropServices.ExternalException ex)
                {
                    MessageBox.Show("Error al guardar la imagen: La imagen no es compatible o está corrupta.", "Error de imagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            string queryVerificar = $"Select ID_Empresa FROM Empresa WHERE ID_Empresa = {empresa.ID_Empresa1}";
            bool existe = CsComandosSql.verificar(queryVerificar);

            if (existe)
            {
                resultado = empresa.ModificarEmpresa();
            }
            else
            {
                if (pbLogo.Image == null)
                {
                    MessageBox.Show("Seleccione un logo para su empresa.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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
            string sentencia = "Select * from Empresa where ID_Empresa = 1";
            dgvEmpresa.DataSource = CsComandosSql.RetornaDatos(sentencia);

            empresa = new CsEmpresa();
            empresa.ID_Empresa1 = 1;

            if (dgvEmpresa.Rows.Count > 0)
            {
                pbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
                DataGridViewRow row = dgvEmpresa.Rows[0];
                txtNombreEmpresa.Text = row.Cells["Nombre_Empresa"].Value.ToString();

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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombreEmpresa.Enabled = true;
            btnAgregarCambios.Visible = true;
            btnSeleccionarImagen.Visible = true;
            btnEditar.Visible = false;
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

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes compatibles|*.jpg;*.jpeg;*.png;*.bmp";
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
    }
}
