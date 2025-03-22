using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    class CsEmpresa
    {
        int ID_Empresa;
        string Nombre_Empresa;
        byte[] Logo;

        public int ID_Empresa1 { get => ID_Empresa; set => ID_Empresa = value; }
        public string Nombre_Empresa1 { get => Nombre_Empresa; set => Nombre_Empresa = value; }
        public byte[] Logo1 { get => Logo; set => Logo = value; }

        public bool AgregarEmpresa()
        {
            string logoBase64 = Convert.ToBase64String(Logo);
            string cadenaXML = $@"<Empresas>
                    <Empresa>
                        <Nombre_Empresa>{Nombre_Empresa}</Nombre_Empresa>
                        <Logo_Empresa>{logoBase64}</Logo_Empresa>
                    </Empresa>
                </Empresas>";
            string query = $@"exec spAgregarEmpresa '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarEmpresa()
        {
            string logoBase64 = Logo != null ? Convert.ToBase64String(Logo) : string.Empty;
            string cadenaXML = $@"<Empresas>
                <Empresa>
                        <ID_Empresa>{ID_Empresa}</ID_Empresa>
                        <Nombre_Empresa>{Nombre_Empresa}</Nombre_Empresa>
                        <Logo_Empresa>{logoBase64}</Logo_Empresa>
                </Empresa>
            </Empresas>";
            string query = $@"exec spModificarEmpresa '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaEmpresa(string m)
        {
            string query = $"select * from Empresa where Nombre_Empresa like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }

    }
}
