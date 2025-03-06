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
        string TipoDoc;
        string NumDoc;
        char Estado;

        public int IdProvee1 { get => IdProvee; set => IdProvee = value; }
        public string NombreProvee1 { get => NombreProvee; set => NombreProvee = value; }
        public string NombreContacto1 { get => NombreContacto; set => NombreContacto = value; }
        public double Descuento1 { get => Descuento; set => Descuento = value; }
        public string Correo1 { get => Correo; set => Correo = value; }
        public string Pais1 { get => Pais; set => Pais = value; }
        public string Ciudad1 { get => Ciudad; set => Ciudad = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string TipoDoc1 { get => TipoDoc; set => TipoDoc = value; }
        public string NumDoc1 { get => NumDoc; set => NumDoc = value; }
        public char Estado1 { get => Estado; set => Estado = value; }

        public bool AñadirProveedor()
        {
            string precioUFormatoSQL = Descuento1.ToString(CultureInfo.InvariantCulture);
            string query = $"INSERT INTO Proveedores(Nombre_Proveedor, Nombre_Contacto, Correo, Pais, Ciudad, NroTelefono, TipoDocumento, NroDocumento, Descuento_Predeterminado, Direccion, EstadoProveedor) VALUES ('{NombreProvee}', '{NombreContacto}', '{Correo}', '{Pais}', '{Ciudad}', '{Telefono}', '{TipoDoc}', '{NumDoc}', {precioUFormatoSQL}, '{Direccion}', '{Estado}') ";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarProveedor()
        {
            string precioUFormatoSQL = Descuento1.ToString(CultureInfo.InvariantCulture);
            string query = $"update Proveedores set Nombre_Proveedor = '{NombreProvee1}', Nombre_Contacto = '{NombreContacto1}', Correo = '{Correo1}',  Pais = '{Pais1}', Ciudad = '{Ciudad1}', NroTelefono = '{Telefono1}', TipoDocumento= '{TipoDoc1}', NroDocumento= '{NumDoc1}', Descuento_Predeterminado = {precioUFormatoSQL}, Direccion = '{Direccion1}', EstadoProveedor = '{Estado1}' where ID_Proveedor= {IdProvee1}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarProveedor()
        {
            string query = $"Delete from Proveedores where ID_Proveedor = {IdProvee1}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaProveedor(string m)
        {
            string query = $"select * from Proveedores where Nombre_Proveedor like '%{m}%' or  ID_Proveedor like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }

        public DataTable ListaProvee(string d)
        {
            string query = $"Select ID_Proveedor, Nombre_Proveedor from Proveedores where Nombre_Proveedor like '%{d}%' ";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
