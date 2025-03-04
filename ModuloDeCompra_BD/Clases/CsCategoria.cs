using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    class CsCategoria
    {
        string categoria;
        int IDCat;

        public int IdCat { get => IDCat; set => IDCat = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public bool AñadirCategoria()
        {
            string query = $"insert into Categoria (Categoria) values ('{categoria}')";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarCategoria()
        {
            string query = $"Update Categoria set Categoria = '{Categoria}' where ID_CAT = {IdCat}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarCategoria()
        {
            string query = $"Delete Categoria from Categoria where ID_CAT = {IdCat}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaCategoria(string m)
        {
            string query =$"Select * from Categoria where Categoria like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
