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

        public int IdProvee1 { get => IdProvee; set => IdProvee = value; }
        public string NombreProvee1 { get => NombreProvee; set => NombreProvee = value; }
        public decimal Descuento1 { get => Descuento; set => Descuento = value; }
        public string Correo { get => correo; set => correo = value; }
        public int TipoDoc1 { get => TipoDoc; set => TipoDoc = value; }
        public int NumDoc1 { get => NumDoc; set => NumDoc = value; }

        public bool AñadirProveedor()
        {
            string query = $"INSERT INTO Proveedores(Nombre_Proveedor, Descuento_Predeterminado, Correo, Tipo_Documento, Num_Documento) VALUES ('{NombreProvee}', {Descuento}, '{correo}', {TipoDoc}, {NumDoc});";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarProveedor()
        {
            string query = $"update Proveedores set Nombre_Proveedor = '{NombreProvee}', Descuento_Predeterminado= {Descuento} , Correo= '{correo}',Tipo_Documento= {TipoDoc}, Num_Documento= {NumDoc};";
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
