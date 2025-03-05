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
        string IDiva;
        string estado;
        double valorIVA;

        public string IDIVA { get => IDiva; set => IDiva = value; }
        public double ValorIva { get => valorIVA; set => valorIVA = value; }
        public string Estado { get => estado; set => estado = value; }
        public bool AñadirIVA()
        {
            decimal valorIva = Convert.ToDecimal(ValorIva, CultureInfo.InvariantCulture);
            string query = $"insert into IVA (ID_IVA, Valor_IVA, EstadoIVA) values ('{IDIVA}', {ValorIva}, '{Estado}')";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarIVA()
        {
            decimal valorIva = Convert.ToDecimal(ValorIva, CultureInfo.InvariantCulture);
            string query = $"Update IVA set ID_IVA = '{IDIVA}' Valor_IVA = {ValorIva}, EstadoIVA = '{Estado}' where ID_IVA = '{IDiva}'";
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