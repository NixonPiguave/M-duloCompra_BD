using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Clases
{
    class CsProducto
    {
        string Nom_Producto;
        decimal Precio_Unit;
        char Iva;
        string Estado;
        int Categoria;
        int Proveedor;
        string Inventariable;

        public string Nom_Producto1 { get => Nom_Producto; set => Nom_Producto = value; }
        public decimal Precio_Unit1 { get => Precio_Unit; set => Precio_Unit = value; }
        public char Iva1 { get => Iva; set => Iva = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public int Categoria1 { get => Categoria; set => Categoria = value; }
        public int Proveedor1 { get => Proveedor; set => Proveedor = value; }
        public string Inventariable1 { get => Inventariable; set => Inventariable = value; }

        public bool AñadirProducto(int idBodega)
        {
            string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);

            string cadenaXML = $@"<Productos>
                <Producto>
                    <NomProducto>{Nom_Producto}</NomProducto>
                    <Costo>{precioUFormatoSQL}</Costo>
                    <EstadoProducto>{Estado}</EstadoProducto>
                    <ID_CAT>{Categoria}</ID_CAT>
                    <ID_IVA>{Iva}</ID_IVA>
                    <ID_Proveedor>{Proveedor}</ID_Proveedor>
                    <Inventariable>{Inventariable}</Inventariable>
                </Producto>
            </Productos>";

            
            string query = $@"exec spAgregarProducto '{cadenaXML}', {idBodega}";
            return CsComandosSql.InserDeletUpdate(query);
        }

        public bool ModificarProducto(int id, int idBodega)
        {
            string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
            string cadenaXML = $@"<Productos>
                    <Producto>
                        <ID_Producto>{id}</ID_Producto>
                        <NomProducto>{Nom_Producto}</NomProducto>
                        <Costo>{precioUFormatoSQL}</Costo>
                        <EstadoProducto>{Estado}</EstadoProducto>
                        <ID_CAT>{Categoria}</ID_CAT>
                        <ID_IVA>{Iva}</ID_IVA>
                        <ID_Proveedor>{Proveedor}</ID_Proveedor>
                        <Inventariable>{Inventariable}</Inventariable>
                    </Producto>
                </Productos>";
            string query = $@"exec spModificarProducto '{cadenaXML}', {idBodega}";
            return CsComandosSql.InserDeletUpdate(query);
        }
  
        public bool EliminarProducto(int ID)
        {
            string cadenaXML = $@"<Productos>
                    <Producto>
                        <ID_Producto>{ID}</ID_Producto>
                    </Producto>
                </Productos>";
            string query = $@"exec spEliminarProducto '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }

        public DataTable ListaProducto()
        {
            string query = "";
            return CsComandosSql.RetornaDatos(query);
        }

    }
}
