using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    internal class csOrdenCompra
    {
        public DataTable ListaRequisicion(string m)
        {
            string query = $"Select * from Categoria where Categoria like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
