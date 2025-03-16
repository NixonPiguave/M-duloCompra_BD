using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    class CsRTV
    {
        int ID_Devolucion;
        int Cantidad;
        string Motivo;
        DateTime Fecha;
        int ID_Orden;
        int ID_Proveedor;
        int ID_Producto;

        public int ID_Devolucion1 { get => ID_Devolucion; set => ID_Devolucion = value; }
        public int Cantidad1 { get => Cantidad; set => Cantidad = value; }
        public string Motivo1 { get => Motivo; set => Motivo = value; }
        public DateTime Fecha1 { get => Fecha; set => Fecha = value; }
        public int ID_Orden1 { get => ID_Orden; set => ID_Orden = value; }
        public int ID_Proveedor1 { get => ID_Proveedor; set => ID_Proveedor = value; }
        public int ID_Producto1 { get => ID_Producto; set => ID_Producto = value; }

        public bool AgregarDevolucion()
        {
            string cadenaXML = $@"
            <Devoluciones>
                <Devolucion>
                    <Cantidad_Devuelta>{Cantidad}</Cantidad_Devuelta>
                    <Motivo>{Motivo}</Motivo>
                    <Fecha_Devolucion>{DateTime.Now.ToString("yyyy-MM-dd")}</Fecha_Devolucion>
                    <ID_Orden>{ID_Orden}</ID_Orden>
                    <ID_Proveedor>{ID_Proveedor}</ID_Proveedor>
                    <ID_Producto>{ID_Producto}</ID_Producto>
                </Devolucion>
            </Devoluciones>";
            string query = $@"exec spRealizarDevolucion '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }

        public bool ModificarDevolucion()
        {
            string cadenaXML = $@"<Devoluciones>
                <Devolucion>
                    <ID_Devolucion>{ID_Devolucion}</ID_Devolucion>
                    <Cantidad_Devuelta>{Cantidad}</Cantidad_Devuelta>
                    <Motivo>{Motivo}</Motivo>
                    <Fecha_Devolucion>{Fecha}</Fecha_Devolucion>
                    <ID_Orden>{ID_Orden}</ID_Orden>
                    <ID_Proveedor>{ID_Proveedor}</ID_Proveedor>
                    <ID_Producto>{ID_Producto}</ID_Producto>
                </Devolucion>
              </Devoluciones>";
            string query = $@"exec spModificarDevolucion '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }

        public bool EliminarDevolucion()
        {
            string cadenaXML = $@"<Devoluciones>
                <Devolucion>
                    <ID_Devolucion>{ID_Devolucion}</ID_Devolucion>
                </Devolucion>
            </Devoluciones>";
            string query = $@"exec spEliminarDevolucion '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }

        public DataTable ListaProveedor(string m)
        {
            string query = $"select * from RTV_Devoluciones where ID_Devolucion like '%{m}%' ";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
