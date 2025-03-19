using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmEditarEmpresa: Form
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
                byte[] nuevaImagen;
                using (MemoryStream ms = new MemoryStream())
                {
                    pbLogo.Image.Save(ms, pbLogo.Image.RawFormat);
                    nuevaImagen = ms.ToArray();
                }

                if (imagenActual == null || !imagenActual.SequenceEqual(nuevaImagen))
                {
                    empresa.Logo1 = nuevaImagen;
                }
                else
                {
                    empresa.Logo1 = imagenActual;
                }
            }
            else
            {
                empresa.Logo1 = imagenActual;
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
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNombreEmpresa.Enabled = true;
            btnAgregarCambios.Visible = true;
            btnSeleccionarImagen.Visible = true;
            btnEditar.Visible = false;
        }

        private void btnSeleccionarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Imágenes|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pbLogo.Image = Image.FromFile(ofd.FileName);
                }
            }
        }
    }
}
