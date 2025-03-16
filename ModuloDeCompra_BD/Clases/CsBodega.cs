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
            string cadenaXML = $@"<AgregarBodega>
                                    <Ubicacion>{direccion}</Ubicacion>
                                  </AgregarBodega>";
            string query = $@"EXEC spAgregarBodega '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarStockBodega(int idBodega, double stockMin, double stockMax)
        {
            string cadenaXML = $@"<ModificarBodega>
                                    <ID_Bodega>{idBodega}</ID_Bodega>
                                    <StockMin>{stockMin}</StockMin>
                                    <StockMax>{stockMax}</StockMax>
                                  </ModificarBodega>";
            string query = $@"EXEC spModificarBodega '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
    }
}
