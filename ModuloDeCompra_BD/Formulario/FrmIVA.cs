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
    public partial class FrmIVA: Form
    {
        public FrmIVA()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CsIVA csIva = new CsIVA();
            if (!string.IsNullOrEmpty(txtIDIVA.Text))
            {
                if (!CsComandosSql.verificar($"select * from IVA where Valor_IVA= '{txtIDIVA.Text}'"))
                {
                    csIva.IDIVA = txtIDIVA.Text;
                    csIva.ValorIva = Convert.ToDouble(txtAgregarValorIVA.Text);
                    csIva.Estado = txtEstadoIVA.Text;
                    if (csIva.AñadirIVA())
                    {
                        txtIDIVA.Text = string.Empty;
                        txtAgregarValorIVA.Text = string.Empty;
                        txtEstadoIVA.Text = string.Empty;
                        dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from IVA");
                        MessageBox.Show("Se ha agregado el IVA");
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el IVA.");
                    }
                }
                else
                {
                    MessageBox.Show("El IVA ya existe");
                }
            }
            else
            {
                MessageBox.Show("Rellene el IVA");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (lblModificarIDIVA.Visible == false)
            {
                Point CordAbajoModificar = new Point();
                Point CordAbajoEliminar = new Point();
                CordAbajoModificar.X = 183;
                CordAbajoModificar.Y = 519;
                CordAbajoEliminar.X = 97;
                CordAbajoEliminar.Y = 591;
                btnModificar.Location = CordAbajoModificar;
                btnEliminar.Location = CordAbajoEliminar;

                lblModificarIDIVA.Visible = true;
                txtModificarIDIVA.Visible = true;
                lblModificarValorIVA.Visible = true;
                txtModificarValorIVA.Visible = true;
                lblModificarEstadoIVA.Visible = true;
                txtModificarEstadoIVA.Visible = true;
                btnAceptar.Visible = true;

                lblValorIVA.Visible = false;
                txtAgregarValorIVA.Visible = false;
                lblEstadoIva.Visible = false;
                txtEstadoIVA.Visible = false;
                btnAgregar.Visible = false;
            }
            else
            {
                Point CordArribaModificar = new Point();
                Point CordArribaEliminar = new Point();
                CordArribaModificar.X = 183;
                CordArribaModificar.Y = 408;
                CordArribaEliminar.X = 97;
                CordArribaEliminar.Y = 482;
                btnModificar.Location = CordArribaModificar;
                btnEliminar.Location = CordArribaEliminar;

                lblModificarIDIVA.Visible = false;
                txtModificarIDIVA.Visible = false;
                lblModificarValorIVA.Visible = false;
                txtModificarValorIVA.Visible = false;
                lblModificarEstadoIVA.Visible = false;
                txtModificarEstadoIVA.Visible = false;
                btnAceptar.Visible = false;

                lblValorIVA.Visible = true;
                txtAgregarValorIVA.Visible = true;
                lblEstadoIva.Visible = true;
                txtEstadoIVA.Visible = true;
                btnAgregar.Visible = true;
            }
        }

        private void FrmIVA_Load(object sender, EventArgs e)
        {
            dgvCategoria.DataSource = CsComandosSql.RetornaDatos("Select * from IVA");
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvCategoria.CurrentCell.RowIndex;
            txtIDIVA.Text = dgvCategoria[0, celda].Value.ToString();
            txtAgregarValorIVA.Text = dgvCategoria[1, celda].Value.ToString();
            txtEstadoIVA.Text = dgvCategoria[2, celda].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            CsIVA csIva = new CsIVA();
            if (!string.IsNullOrEmpty(txtIDIVA.Text) || string.IsNullOrEmpty(txtAgregarValorIVA.Text))
            {
                if (CsComandosSql.verificar($"select * from IVA where Valor_IVA= '{txtIDIVA.Text}'"))
                {
                    csIva.IDIVA = txtIDIVA.Text;
                    csIva.ValorIva = Convert.ToDouble(txtAgregarValorIVA.Text);
                    csIva.Estado = txtEstadoIVA.Text;
                    csIva.ModificarIVA();
                    MessageBox.Show("Se ha modificado el IVA");
                }
                else
                {
                    MessageBox.Show("El IVA ya existe");
                }
            }
            else
            {
                MessageBox.Show("Rellena los campos");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDIVA.Text))
            {
                if (CsComandosSql.verificar($"select * from IVA where Valor_IVA= '{txtIDIVA.Text}'"))
                {
                    int posicion = dgvCategoria.CurrentCell.RowIndex;
                    string ID = dgvCategoria[0, posicion].Value.ToString();
                    CsIVA csIVA = new CsIVA();
                    csIVA.IDIVA= ID;
                    csIVA.EliminarIVA();
                    txtIDIVA.Text = string.Empty;
                    dgvCategoria.DataSource = CsComandosSql.RetornaDatos("select * from IVA");
                    MessageBox.Show("Se ha eliminado el IVA");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el IVA");
                }
            }
            else
            {
                MessageBox.Show("Escoja el IVA");
            }
        }
    }
}
