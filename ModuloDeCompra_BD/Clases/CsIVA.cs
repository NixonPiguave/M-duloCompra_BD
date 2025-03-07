using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    internal class CsIVA
    {
        char IDiva;
        char estado;
        decimal valorIVA;

        public char IDIVA { get => IDiva; set => IDiva = value; }
        public decimal ValorIva { get => valorIVA; set => valorIVA = value; }
        public char Estado { get => estado; set => estado = value; }
        public bool AñadirIVA()
        {
            string precioUFormatoSQL = ValorIva.ToString(CultureInfo.InvariantCulture);
            string query = $"insert into IVA (ID_IVA, Valor_IVA, EstadoIVA) values ('{IDIVA}', {precioUFormatoSQL}, '{Estado}')";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarIVA()
        {
            string precioUFormatoSQL = ValorIva.ToString(CultureInfo.InvariantCulture);
            string query = $"Update IVA set Valor_IVA = {precioUFormatoSQL}, EstadoIVA = '{Estado}' where ID_IVA = '{IDIVA}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarIVA()
        {
            string query = $"Delete from IVA where ID_IVA = '{IDiva}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaIVA(string m)
        {
            string query = $"Select * from IVA where Valor_IVA like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}