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
            string cadenaXML = $@"<IVA>
                    <RegistroIVA>
                        <ID_IVA>{IDiva}</ID_IVA>
                        <Valor_IVA>{precioUFormatoSQL}</Valor_IVA>
                        <EstadoIVA>{estado}</EstadoIVA>
                    </RegistroIVA>
                </IVA>";
            string query = $@"exec spAgregarIVA '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarIVA()
        {
            string precioUFormatoSQL = ValorIva.ToString(CultureInfo.InvariantCulture);
            string cadenaXML = $@"<IVA>
                    <RegistroIVA>
                        <ID_IVA>{IDiva}</ID_IVA>
                        <Valor_IVA>{precioUFormatoSQL}</Valor_IVA>
                        <EstadoIVA>{Estado}</EstadoIVA>
                    </RegistroIVA>
                </IVA>";
            string query = $@"exec spModificarIVA '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarIVA()
        {
            string cadenaXML = $@"<IVA>
                    <RegistroIVA>
                        <ID_IVA>{IDiva}</ID_IVA>
                    </RegistroIVA>
                </IVA>";
            string query = $@"exec spEliminarIVA '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaIVA(string m)
        {
            string query = $"Select * from IVA where Valor_IVA like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}