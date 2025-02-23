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
        double Descuento;
        string correo;
        int TipoDoc;
        string NumDoc;

        public int IdProvee1 { get => IdProvee; set => IdProvee = value; }
        public string NombreProvee1 { get => NombreProvee; set => NombreProvee = value; }
        public double Descuento1 { get => Descuento; set => Descuento = value; }
        public string Correo { get => correo; set => correo = value; }
        public int TipoDoc1 { get => TipoDoc; set => TipoDoc = value; }
        public string NumDoc1 { get => NumDoc; set => NumDoc = value; }

        public bool AñadirProveedor()
        {
            string query = $"INSERT INTO Proveedores(Nombre_Proveedor, Descuento_Predeterminado, Correo, Tipo_Documento, Num_Documento) VALUES ('{NombreProvee}', {Descuento}, '{correo}', {TipoDoc}, {NumDoc});";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarProveedor()
        {
            string precioUFormatoSQL = Descuento1.ToString(CultureInfo.InvariantCulture);
            MessageBox.Show($"{IdProvee1.ToString()}, {NombreProvee1.ToString()}, {Descuento1.ToString()}, {Correo.ToString()}, {TipoDoc1.ToString()}, {NumDoc1.ToString()}");
            string query = $"update Proveedores set Nombre_Proveedor = '{NombreProvee1}', Descuento_Predeterminado= {precioUFormatoSQL} , Correo= '{Correo}', Tipo_Documento= {TipoDoc1}, Num_Documento= '{NumDoc1}' where ID_Prov= {IdProvee1}";
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
