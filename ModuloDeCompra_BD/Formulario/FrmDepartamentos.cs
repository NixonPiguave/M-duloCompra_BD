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
    public partial class FrmDepartamentos: Form
    {
        int z;
        public FrmDepartamentos()
        {
            InitializeComponent();
        }

        private void txtnombredepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmDepartamentos_Load(object sender, EventArgs e)
        {
            dgvDepartamento.DataSource = CsComandosSql.RetornaDatos($"select *from Departamento");
        }

        private void bntagregar_Click(object sender, EventArgs e)
        {

            try
            {
                string x = txtNombreDepartamento.Text;
                if (string.IsNullOrWhiteSpace(txtNombreDepartamento.Text))
                {
                    MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                    try
                    {

                        bool success = CsComandosSql.InserDeletUpdate($"insert into Departamento (Nombre_Departamento) values ('{x}')");

                        if (success)
                        {
                            MessageBox.Show("Departamento agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvDepartamento.DataSource = CsComandosSql.RetornaDatos($"select *from Departamento");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string x = txtNombreDepartamento.Text;
             
                    if (string.IsNullOrWhiteSpace(txtNombreDepartamento.Text))
                    {
                        MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    try
                    {
                            if (CsComandosSql.InserDeletUpdate($"update Departamento set Nombre_Departamento ='{txtNombreDepartamento.Text}' where Dep_ID= '{z}'"))
                            {

                                MessageBox.Show("Departamento modificada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                dgvDepartamento.DataSource = CsComandosSql.RetornaDatos("select *from Departamento");

                                // Limpiar los campos de texto
                                txtNombreDepartamento.Text = string.Empty;
                            }
                            else
                                MessageBox.Show("Inventario no.");
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al modificar el departamento. Detalles del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al procesar la modificación: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNombreDepartamento_KeyUp(object sender, KeyEventArgs e)
        {
            dgvDepartamento.DataSource=CsComandosSql.RetornaDatos($"  select *from Departamento where Nombre_Departamento like '{txtNombreDepartamento.Text}%'");
        }

        private void dgvDepartamento_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvDepartamento.CurrentCell.RowIndex;
            txtNombreDepartamento.Text =dgvDepartamento[1,fila].Value.ToString();
            z = Convert.ToInt32(dgvDepartamento[0, fila].Value.ToString());

        }
    }
}
