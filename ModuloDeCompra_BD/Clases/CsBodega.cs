using ModuloDeCompra_BD.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Clases
{
    class CsBodega
    {
        public bool agregarBodega( string direccion)
        {
            try
            {
                if (string.IsNullOrEmpty(direccion))
                {
                    throw new ArgumentException("Los campos ID Bodega y Dirección no pueden estar vacíos.");
                }

                bool success = CsComandosSql.InserDeletUpdate($"INSERT INTO Bodega(Ubicacion, StockActual, StockMin, StockMax) VALUES('0,0,{direccion}')");

                if (success)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool ModificarStockBodega(int idBodega, double stockMin, double stockMax)
        {
            try
            {
                if (stockMin <= 0 || stockMax <= 0)
                {
                    MessageBox.Show("Los valores de Stock Mínimo y Stock Máximo deben ser mayores que 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                bool success = CsComandosSql.InserDeletUpdate($"UPDATE Bodega SET StockMin={stockMin}, StockMax={stockMax} WHERE ID_Bodega={idBodega}");

                if (success)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error al modificar la bodega en la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al modificar la bodega. Detalles del error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
