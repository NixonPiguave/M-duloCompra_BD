using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public string Nom_Producto1 { get => Nom_Producto; set => Nom_Producto = value; }
        public decimal Precio_Unit1 { get => Precio_Unit; set => Precio_Unit = value; }
        public int Iva1 { get => Iva; set => Iva = value; }
        public int Estado1 { get => Estado; set => Estado = value; }
        public int Categoria1 { get => Categoria; set => Categoria = value; }
        public int Proveedor1 { get => Proveedor; set => Proveedor = value; }

        public bool AñadirProducto()
        {
            string query = $"INSERT INTO Producto(Nom_Producto, Precio_Unit, ID_IVA, ID_Estado, ID_CAT, ID_Prov) VALUES ({Nom_Producto1}', {Precio_Unit1}, {Iva1}, {Estado1}, {Categoria1}, {Proveedor1});";
           
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
