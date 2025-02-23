using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    class CsCategoria
    {
        string Categoria;
        int IDCat;

        public bool AñadirCategoria()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarCategoria()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarCategoria()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaCategoria(string m)
        {
            string query =$"Select * from Categoria where Categoria like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
