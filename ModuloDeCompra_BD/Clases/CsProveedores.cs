using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    class CsProveedores
    {
        int IdProvee;
        string NombreProvee;
        decimal Descuento;
        string correo;
        int TipoDoc;
        int NumDoc;

        public bool AñadirProveedor()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarProveedor()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarProveedor()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaProveedor(string m)
        {
            string query = $"Select ID_Prov ,Nombre_Proveedor from Proveedores where Nombre_Proveedor like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
