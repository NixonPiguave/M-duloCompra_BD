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
using static System.Net.Mime.MediaTypeNames;

namespace ModuloDeCompra_BD.Formulario
{
    public partial class FrmMovimientoInventario: Form
    {
        public FrmMovimientoInventario()
        {
            InitializeComponent();
        }

        private void FrmMovimientoInventario_Load(object sender, EventArgs e)
        {
            dgvMovimientoInventario.DataSource = CsComandosSql.RetornaDatos($"select * from Mov_Inventario");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow fila in dgvAux.Rows)
                {
                    if (!fila.IsNewRow)
                    {
                        decimal Valor = decimal.Parse(fila.Cells["TotalPagar"].Value.ToString());
                        decimal CostoUni = decimal.Parse(fila.Cells["CostoUnit"].Value.ToString());
                        decimal CostoInve = decimal.Parse(fila.Cells["CostoInventario"].Value.ToString());
                        decimal CUCompra = decimal.Parse(fila.Cells["CUCompra"].Value.ToString());
                        int cantidad = int.Parse(fila.Cells["Cantidad"].Value.ToString());
                        int GRNDetalle = int.Parse(fila.Cells["ID_GRNDetails"].Value.ToString());
                        var culture = System.Globalization.CultureInfo.InvariantCulture;
                        string XML = $@"
                        <Movimiento>
                            <Info>
                                <VALOR>{Valor.ToString(culture)}</VALOR>
                                <FECHA>{DateTime.Now.ToString("yyyy-MM-dd")}</FECHA>
                                <CANTIDAD>{cantidad}</CANTIDAD>
                                <COSTOUNI>{CostoUni.ToString(culture)}</COSTOUNI>
                                <COSTOINVE>{CostoInve.ToString(culture)}</COSTOINVE>
                                <CUCOMPRA>{CUCompra.ToString(culture)}</CUCOMPRA>
                                <TIPOMOV>R</TIPOMOV>
                                <GRNDETALLE>{GRNDetalle}</GRNDETALLE>
                            </Info>
                        </Movimiento>";

                        MessageBox.Show(XML);
                        string query = $"exec spMovInventario @cadena = '{XML}'";

                        try
                        {
                            if (CsComandosSql.InserDeletUpdate(query))
                            {
                                MessageBox.Show($"Se ha registrado un movimiento de inventario para la fila {fila.Index + 1}");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error en fila {fila.Index + 1}: {ex.Message}");
                        }
                    }
                }
                txtIDGRN.Text = string.Empty;
                txtValor.Text = string.Empty;
                txtCantidad.Text = string.Empty;
                txtCostoUni.Text = string.Empty;
                txtCostoInve.Text = string.Empty;
                txtCUCompra.Text = string.Empty;
                txtGRNDetalle.Text = string.Empty;
                dgvMovimientoInventario.DataSource = CsComandosSql.RetornaDatos("select * from Mov_Inventario");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error general: " + ex.Message);
            }
        }

        private void txtID_Bodega_KeyUp(object sender, KeyEventArgs e)
        {
            dgvMovimientoInventario.DataSource = CsComandosSql.RetornaDatos($"select * from Bodega where  ID_BODEGA like '%{txtIDGRN.Text}%'");
        }   

        private void btnEscogerGRN_Click(object sender, EventArgs e)
        {
            FrmListadoGRN frmGRN = new FrmListadoGRN();
            frmGRN.ShowDialog();
            txtIDGRN.Text = frmGRN.ID.ToString();
        }

        private void dgvAux_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = dgvMovimientoInventario.CurrentCell.RowIndex;
            txtGRNDetalle.Text = dgvAux[1, fila].Value.ToString();
            txtValor.Text = dgvAux[2, fila].Value.ToString();
            txtCantidad.Text = dgvAux[3, fila].Value.ToString();
            txtCostoUni.Text = dgvAux[4, fila].Value.ToString();
            txtCostoInve.Text = dgvAux[5, fila].Value.ToString();
            txtCUCompra.Text = dgvAux[6,fila].Value.ToString();
        }

        private void txtIDGRN_TextChanged(object sender, EventArgs e)
        {
            dgvAux.Visible = true;
            string query = $"select G.ID_GRN, D.ID_GRNDetails, G.TotalPagar, D.Cantidad, cast((G.TotalPagar / D.Cantidad) as decimal(10,3)) as CostoUnit, cast((SUM(D.Cantidad) * (G.TotalPagar / D.Cantidad)) as decimal(10,3)) as CostoInventario, (P.Costo * SUM(D.Cantidad)) as CUCompra from GRN_Header as G inner join Grn_Details as D on G.ID_GRN = D.ID_GRN inner join Producto as P on D.ID_Producto = P.ID_Producto where G.ID_GRN = {txtIDGRN.Text} group by G.TotalPagar, D.Cantidad, P.Costo, G.ID_GRN, D.ID_GRNDetails";
            dgvAux.DataSource = CsComandosSql.RetornaDatos(query);
        }
    }
}
