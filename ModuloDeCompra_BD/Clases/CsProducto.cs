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
        

        public string Nom_Producto1 { get => Nom_Producto; set => Nom_Producto = value; }
        public decimal Precio_Unit1 { get => Precio_Unit; set => Precio_Unit = value; }
        public char Iva1 { get => Iva; set => Iva = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public int Categoria1 { get => Categoria; set => Categoria = value; }
        public int Proveedor1 { get => Proveedor; set => Proveedor = value; }

        public bool AñadirProducto()
        {
            string query;
            if(Iva==null)
            {
                string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
                query= $"INSERT INTO Producto(NomProducto, Costo, EstadoProducto, ID_CAT, ID_Proveedor) VALUES ('{Nom_Producto}', {precioUFormatoSQL}, '{Estado}', {Categoria}, {Proveedor})";
            }
            else
            {
                string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
                query = $"INSERT INTO Producto(NomProducto, Costo, EstadoProducto, ID_CAT,ID_IVA, ID_Proveedor) VALUES ('{Nom_Producto}', {precioUFormatoSQL}, '{Estado}', {Categoria}, '{Iva}', {Proveedor})";
            }   
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool AñadirServicio()
        {
            string query;
            if(Iva==null)
            {
                string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
                query = $"insert into Servicio (Nom_Servicio, Costo, ID_Proveedor, EstadoServicio) values ('{Nom_Producto}',{precioUFormatoSQL},{Proveedor},'{Estado}')";
            }
            else
            {
                string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
                query = $"insert into Servicio (Nom_Servicio, Costo, ID_IVA, ID_Proveedor, EstadoServicio) values ('{Nom_Producto}',{precioUFormatoSQL},'{Iva}',{Proveedor},'{Estado}')";
            }
            
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarProducto(int id)
        {
            string query;
           if(Iva==null)
            {
                string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
                query = $"Update Producto set NomProducto= '{Nom_Producto}', Costo= {precioUFormatoSQL}, EstadoProducto='{Estado}', ID_CAT= {Categoria}, ID_Proveedor= {Proveedor} where ID_Producto= {id}";
            }
            else
            {
                string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
                query = $"Update Producto set NomProducto= '{Nom_Producto}', Costo= {precioUFormatoSQL}, EstadoProducto='{Estado}', ID_CAT= {Categoria}, ID_IVA= '{Iva}', ID_Proveedor= {Proveedor} where ID_Producto= {id}";
            }
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarServicio(int id)
        {
            string query;
            if(Iva==null)
            {
                string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
                query = $"Update Servicio set Nom_Servicio= '{Nom_Producto}', Costo= {precioUFormatoSQL}, ID_Proveedor= {Proveedor}, EstadoServicio= '{Estado}' where ID_Servicio= {id}";
            }
            else
            {
                string precioUFormatoSQL = Precio_Unit.ToString(CultureInfo.InvariantCulture);
                query = $"Update Servicio set Nom_Servicio= '{Nom_Producto}', Costo= {precioUFormatoSQL}, ID_IVA= '{Iva}', ID_Proveedor= {Proveedor}, EstadoServicio= '{Estado}' where ID_Servicio= {id}";
            }
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
