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
        public bool agregarBodega(string direccion)
        {
            return CsComandosSql.InserDeletUpdate($"  insert into Bodega (StockMin,StockMax,Ubicacion)values('0','0','{direccion}')");
        }

        public bool ModificarStockBodega(int idBodega, double stockMin, double stockMax)
        {
            return CsComandosSql.InserDeletUpdate($"  UPDATE Bodega SET StockMin='{stockMin}', StockMax='{stockMax}' WHERE ID_Bodega={idBodega}");
        }
    }
}
