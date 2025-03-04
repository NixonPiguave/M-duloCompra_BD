using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    internal class CsIVA
    {
        string iva;
        int IDIVA;

        public int IDiva { get => IDIVA; set => IDIVA = value; }
        public string Iva { get => iva; set => iva = value; }
        public bool AñadirCategoria()
        {
            string query = $"insert into IVA (Valor_IVAA) values ('{Iva}')";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarCategoria()
        {
            string query = $"Update IVA set Valor_IVA = '{Iva}' where ID_IVA = {IDiva}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarCategoria()
        {
            string query = $"Delete from IVA where ID_IVA = {IDiva}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaCategoria(string m)
        {
            string query = $"Select * from IVA where Valor_IVA like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
