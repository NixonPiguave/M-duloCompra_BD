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
    class CsProveedores
    {
        int IdProvee;
        string NombreProvee;
        string NombreContacto;
        double Descuento;
        string Correo;
        string Pais;
        string Ciudad;
        string Direccion;
        string Telefono;
        int TipoDoc;
        string NumDoc;

        public int IdProvee1 { get => IdProvee; set => IdProvee = value; }
        public string NombreProvee1 { get => NombreProvee; set => NombreProvee = value; }
        public string NombreContacto1 { get => NombreContacto; set => NombreContacto = value; }
        public double Descuento1 { get => Descuento; set => Descuento = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Pais1 { get => Pais; set => Pais = value; }
        public string Ciudad1 { get => Ciudad; set => Ciudad = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public int TipoDoc1 { get => TipoDoc; set => TipoDoc = value; }
        public string NumDoc1 { get => NumDoc; set => NumDoc = value; }

        public bool AñadirProveedor()
        {
            string precioUFormatoSQL = Descuento1.ToString(CultureInfo.InvariantCulture);
            string query = $"INSERT INTO Proveedoress(Nombre_Proveedor, NombreContacto, Correo, Descuento_Predeterminado, Pais, Ciudad, Direccion, Telefono, Tipo_Documento, Num_Documento) VALUES ('{NombreProvee}', '{NombreContacto}', '{Correo}', {precioUFormatoSQL}, '{Pais}', '{Ciudad}', '{Direccion}', '{Telefono}', {TipoDoc}, '{NumDoc}');";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarProveedor()
        {
            string precioUFormatoSQL = Descuento1.ToString(CultureInfo.InvariantCulture);
            string query = $"update Proveedoress set Nombre_Proveedor = '{NombreProvee1}', Nombre_Contacto = '{NombreContacto1}', Correo = '{Correo1}', Descuento_Predeterminado = {precioUFormatoSQL} , Pais = '{Pais1}', Ciudad = '{Ciudad1}', Direccion = '{Direccion1}', Telefono = '{Telefono1}', Tipo_Documento= {TipoDoc1}, Num_Documento= '{NumDoc1}' where ID_Prov= {IdProvee1}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarProveedor()
        {
            string query = $"Delete from Proveedoress where ID_Prov = {IdProvee1}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaProveedor(string m)
        {
            string query = $"select P.ID_Prov, P.Nombre_Proveedor, P.NombreContacto, P.Correo, P.Descuento_Predeterminado, P.Pais, P.Ciudad, P.Direccion, P.Telefono, T.Tipo, P.Num_Documento from Proveedoress as P inner join TipoDocumento as T on P.Tipo_Documento=T.TipoID where Nombre_Proveedor like '%{m}%' or  ID_Prov like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
