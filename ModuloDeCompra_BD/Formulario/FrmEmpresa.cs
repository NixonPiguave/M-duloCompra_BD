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
    public partial class FrmEmpresa: Form
    {
        int id;
        public FrmEmpresa()
        {
            InitializeComponent();
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            btnAgregarEmpresa.Enabled = false;
            btnModificarEmpresa.Enabled = false;
            string sentencia = "Select * from Empresa";
            dgvEmpresa.DataSource = CsComandosSql.RetornaDatos(sentencia);
        }

        private void dgvEmpresa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int posCelda = e.RowIndex;
            id = Convert.ToInt32(dgvEmpresa[0, posCelda].Value.ToString());
            txtNombreEmpresa.Text = dgvEmpresa[1, posCelda].Value.ToString();

            if (dgvEmpresa[2, posCelda].Value != DBNull.Value)
            {
                byte[] imageBytes = (byte[])dgvEmpresa[2, posCelda].Value;
                try
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pbLogo.Image = Image.FromStream(ms);
                    }
                }
                catch
                {
                    MessageBox.Show("Error al cargar la imagen: ");
                    pbLogo.Image = null;
                }
            }
            else
            {
                pbLogo.Image = null;
            }
            btnAgregarEmpresa.Enabled = true;
            btnModificarEmpresa.Enabled = true;

        }

        private void btnAgregarLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog fo = new OpenFileDialog();
            DialogResult rs = fo.ShowDialog();
            if (rs == DialogResult.OK)
            {
                pbLogo.Image = Image.FromFile(fo.FileName);
            }

            btnAgregarEmpresa.Enabled = true;
            btnModificarEmpresa.Enabled = true;
        }

        private void btnAgregarEmpresa_Click(object sender, EventArgs e)
        {
            CsEmpresa empresa = new CsEmpresa();

            if (pbLogo.Image == null)
            {
                MessageBox.Show("Por favor, selecciona una imagen para el corte.");
                return;
            }
            if (txtNombreEmpresa.Text == string.Empty)
            {
                MessageBox.Show("Por favor, ingrese un nombre para la empresa.");
                return;
            }
            try
            {
                MemoryStream ms = new MemoryStream();
                pbLogo.Image.Save(ms, pbLogo.Image.RawFormat);
                byte[] imageBytes = ms.ToArray();

                empresa.Nombre_Empresa1 = txtNombreEmpresa.Text;
                empresa.Logo1 = imageBytes;
                bool resultado = empresa.AgregarEmpresa();

                if (resultado)
                {
                    MessageBox.Show("Empresa agregada correctamente.");
                    string sentencia = "Select * from Empresa";
                    dgvEmpresa.DataSource = CsComandosSql.RetornaDatos(sentencia);
                }
                else
                {
                    MessageBox.Show("Error al agregar la empresa.");
                }
                txtNombreEmpresa.Text = string.Empty;
                pbLogo.Image = null;
                btnAgregarEmpresa.Enabled = false;
                btnModificarEmpresa.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error al guardar la imagen ");
            }
        }

        private void btnModificarEmpresa_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Por favor, selecciona una empresa para modificar.");
                return;
            }

            if (pbLogo.Image == null)
            {
                MessageBox.Show("Por favor, selecciona una imagen para el logo.");
                return;
            }

            if (txtNombreEmpresa.Text == string.Empty)
            {
                MessageBox.Show("Por favor, ingrese un nombre para la empresa.");
                return;
            }

            CsEmpresa empresa = new CsEmpresa();
            empresa.ID_Empresa1 = id;
            empresa.Nombre_Empresa1 = txtNombreEmpresa.Text;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    pbLogo.Image.Save(ms, pbLogo.Image.RawFormat);
                    empresa.Logo1 = ms.ToArray();
                }

                bool resultado = empresa.ModificarEmpresa();

                if (resultado)
                {
                    MessageBox.Show("Empresa modificada correctamente.");
                    string sentencia = "Select * from Empresa";
                    dgvEmpresa.DataSource = CsComandosSql.RetornaDatos(sentencia);
                }
                else
                {
                    MessageBox.Show("Error al modificar la empresa.");
                }
            }
            catch
            {
                MessageBox.Show("Error al guardar la imagen ");
            }

            txtNombreEmpresa.Text = string.Empty;
            pbLogo.Image = null;
            btnAgregarEmpresa.Enabled = false;
            btnModificarEmpresa.Enabled = false;
        }
    }
}
