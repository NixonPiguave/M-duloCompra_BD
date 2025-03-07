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
    public partial class FrmIVA2: Form
    {
        public FrmIVA2()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CsIVA csIVA = new CsIVA();
            if (!string.IsNullOrEmpty(txtIDIVA.Text))
            {
                if (!CsComandosSql.verificar($"select * from IVA where ID_IVA= '{txtIDIVA.Text}'"))
                {
                    csIVA.IDIVA = Convert.ToChar(txtIDIVA.Text);
                    csIVA.Estado = Convert.ToChar(txtEstadoIVA.Text);
                    csIVA.ValorIva = Convert.ToDecimal(txtValorIVA.Text);
                    if (csIVA.AñadirIVA())
                    {
                        dgvIVA.DataSource = CsComandosSql.RetornaDatos("Select * from IVA");
                        txtIDIVA.Text = string.Empty;
                        txtValorIVA.Text = string.Empty;
                        txtEstadoIVA.Text = string.Empty;
                        MessageBox.Show("Se ha agregado el IVA");
                    }
                    else
                    {
                        MessageBox.Show("El IVA no se ha podido agregar");
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
            if (lblIVAEscogido.Visible == false)
            {
                lblIVAEscogido.Visible = true;
                lblNuevoValorIVA.Visible = true;
                txtNuevoValorIVA.Visible = true;
                lblNuevoEstadoIVA.Visible = true;
                txtNuevoEstadoIVA.Visible = true;
                btnAceptar.Visible = true;

                lblModificarCategoria.Visible = false;
                txtValorIVA.Visible = false;
                lblEstadoIVA.Visible = false;
                txtEstadoIVA.Visible = false;
                btnAgregar.Visible = false;
            }
            else
            {
                lblIVAEscogido.Visible = false;
                lblNuevoValorIVA.Visible = false;
                txtNuevoValorIVA.Visible = false;
                lblNuevoEstadoIVA.Visible = false;
                txtNuevoEstadoIVA.Visible = false;
                btnAceptar.Visible = false;

                lblModificarCategoria.Visible = true;
                txtValorIVA.Visible = true;
                lblEstadoIVA.Visible = true;
                txtEstadoIVA.Visible = true;
                btnAgregar.Visible = true;
            }
        }

        private void FrmIVA2_Load(object sender, EventArgs e)
        {
            dgvIVA.DataSource = CsComandosSql.RetornaDatos("Select * from IVA");
        }

        private void dgvCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int celda = dgvIVA.CurrentCell.RowIndex;
            txtIDIVA.Text = dgvIVA[0, celda].Value.ToString();
            txtValorIVA.Text = dgvIVA[1, celda].Value.ToString();
            txtEstadoIVA.Text = dgvIVA[2, celda].Value.ToString();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDIVA.Text) || !string.IsNullOrEmpty(txtValorIVA.Text))
            {
                if (CsComandosSql.verificar($"select * from IVA where ID_IVA= '{txtIDIVA.Text}'"))
                {
                    int posicion = dgvIVA.CurrentCell.RowIndex;
                    char ID = Convert.ToChar(dgvIVA[0, posicion].Value.ToString());
                    CsIVA csIVA = new CsIVA();
                    csIVA.IDIVA = Convert.ToChar(txtIDIVA.Text);
                    csIVA.ValorIva = Convert.ToDecimal(txtNuevoValorIVA.Text);
                    csIVA.Estado = Convert.ToChar(txtNuevoEstadoIVA.Text);
                    csIVA.ModificarIVA();
                    txtNuevoValorIVA.Text = string.Empty;
                    txtNuevoEstadoIVA.Text = string.Empty;
                    dgvIVA.DataSource = CsComandosSql.RetornaDatos("Select * from IVA");
                    MessageBox.Show("Se ha modificado el IVA");
                }
                else
                {
                    MessageBox.Show("El IVA ya existe");
                }
            }
            else
            {
                MessageBox.Show("Escoja el IVA");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIDIVA.Text))
            {
                int posicion = dgvIVA.CurrentCell.RowIndex;
                char ID = Convert.ToChar(dgvIVA[0, posicion].Value.ToString());
                CsIVA csIVA = new CsIVA();
                csIVA.IDIVA = ID;
                if (csIVA.EliminarIVA())
                {
                    txtIDIVA.Text = string.Empty;
                    txtValorIVA.Text = string.Empty;
                    txtEstadoIVA.Text = string.Empty;
                    dgvIVA.DataSource = CsComandosSql.RetornaDatos("select * from IVA");
                    MessageBox.Show("Se ha eliminado el IVA");
                }
                else
                {
                    MessageBox.Show("El IVA no se ha poddio Eliminar");
                }
            }
            else
            {
                MessageBox.Show("Escoja la categoria");
            }
        }
    }
}
