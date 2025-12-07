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
            string cadenaXML = $@"<Proveedores>
	                   <Proveedor>
		                    <Nombre>{NombreProvee}</Nombre>
		                    <Contacto>{NombreContacto}</Contacto>
		                    <Correo>{Correo}</Correo>
		                    <Pais>{Pais}</Pais>
		                    <Ciudad>{Ciudad}</Ciudad>
		                    <Telefono>{Telefono}</Telefono>
		                    <TipoDocumento>{TipoDoc}</TipoDocumento>
		                    <NroDocumento>{NumDoc}</NroDocumento>
		                    <Descuento>{precioUFormatoSQL}</Descuento>
		                    <Direccion>{Direccion}</Direccion>
		                    <Estado>{Estado}</Estado>		
	                        </Proveedor>
                       </Proveedores>";
            string query = $@"exec spRegistrarProveedor '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarProveedor()
        {
            string precioUFormatoSQL = Descuento1.ToString(CultureInfo.InvariantCulture);
            string XMLcadena = $@"<Proveedores>
                    <Proveedor>
                        <ID_Proveedor>{IdProvee}</ID_Proveedor>
                        <Nombre>{NombreProvee}</Nombre>
                        <Contacto>{NombreContacto}</Contacto>
                        <Correo>{Correo}</Correo>
                        <Pais>{Pais}</Pais>
                        <Ciudad>{Ciudad}</Ciudad>
                        <Telefono>{Telefono}</Telefono>
                        <TipoDocumento>{TipoDoc}</TipoDocumento>
                        <NroDocumento>{NumDoc}</NroDocumento>
                        <Descuento>{precioUFormatoSQL}</Descuento>
                        <Direccion>{Direccion}</Direccion>
                        <Estado>{Estado}</Estado>
                    </Proveedor>
                </Proveedores>";
            string query = $@"exec spModificarProveedor '{XMLcadena}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaProveedor(string m)
        {
            string query = $"select * from [OC-Proveedores] where Nombre_Proveedor like '%{m}%' or  ID_Proveedor like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }

        public DataTable ListaProvee(string d)
        {
            string query = $"Select ID_Proveedor, Nombre_Proveedor from [OC-Proveedores] where Nombre_Proveedor like '%{d}%' ";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
