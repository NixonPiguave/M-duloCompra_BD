using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Runtime.InteropServices.WindowsRuntime;

namespace ModuloDeCompra_BD.Clases
{
    class CsProducto
    {
        string Nom_Producto;
        decimal Precio_Unit;
        int Iva;
        int Estado;
        int Categoria;
        int Proveedor;

        public bool AñadirProducto()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarProducto()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarProducto()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaProducto()
        {
            string query = "";
            return CsComandosSql.RetornaDatos(query);
        }

    }
}
