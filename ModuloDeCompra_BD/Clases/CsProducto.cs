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
        int Estado;
        int Categoria;
        int Proveedor;

        public string Nom_Producto1 { get => Nom_Producto; set => Nom_Producto = value; }
        public decimal Precio_Unit1 { get => Precio_Unit; set => Precio_Unit = value; }
        public char Iva1 { get => Iva; set => Iva = value; }
        public int Estado1 { get => Estado; set => Estado = value; }
        public int Categoria1 { get => Categoria; set => Categoria = value; }
        public int Proveedor1 { get => Proveedor; set => Proveedor = value; }

        public bool AñadirProducto()
        {
            string estadoProducto = (Estado == 1) ? "Activo" : "Inactivo";
            string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
            string query = $"INSERT INTO Producto(NomProducto, Costo, EstadoProducto, ID_CAT,ID_IVA, ID_Proveedor) VALUES ('{Nom_Producto}', {precioUFormatoSQL}, '{estadoProducto}', {Categoria}, '{Iva}', {Proveedor})";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool AñadirServicio()
        {
            
            string estadoServicio = (Estado == 1) ? "Activo" : "Inactivo";
            string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
            string query = $"insert into Servicio (Nom_Servicio, Costo, ID_IVA, ID_Proveedor, EstadoServicio) values ('{Nom_Producto}',{precioUFormatoSQL},'{Iva}',{Proveedor},'{estadoServicio}')";

            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarProducto(int id, string nombreprodu, string precioUnit)
        {
            string estadoProducto = (Estado == 1) ? "Activo" : "Inactivo";
            string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
            string query = $"Update Producto set NomProducto= '{nombreprodu}', Costo= {precioUFormatoSQL}, EstadoProducto={estadoProducto}, ID_CAT= {Categoria}, ID_IVA= '{Iva}', ID_Proveedor= {Proveedor} where ID_Producto= {id}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarServicio(int id)
        {
            string estadoServicio = (Estado == 1) ? "Activo" : "Inactivo";
            string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
            string query = $"Update Servicio set Nom_Servicio= '{Nom_Producto}', Costo= {precioUFormatoSQL}, ID_IVA= '{Iva}', ID_Proveedor= {Proveedor}, EstadoServicio= {estadoServicio} where ID_Servicio= {id}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarProducto(int ID)
        {
            string query = $"delete Producto where ID_Producto={ID}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarServicio(int Id)
        {
            string query = $"Delete Servicio where ID_Servicio= {Id}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaProducto()
        {
            string query = "";
            return CsComandosSql.RetornaDatos(query);
        }

    }
}
