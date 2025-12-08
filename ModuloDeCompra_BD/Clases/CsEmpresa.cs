using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    public class CsEmpresa
    {
        int ID_Empresa;
        string Nombre_Empresa;
        byte[] Logo;
        string RUC;
        string Direccion;
        string Telefono;
        string Correo;

        public int ID_Empresa1 { get => ID_Empresa; set => ID_Empresa = value; }
        public string Nombre_Empresa1 { get => Nombre_Empresa; set => Nombre_Empresa = value; }
        public byte[] Logo1 { get => Logo; set => Logo = value; }
        public string RUC1 { get => RUC; set => RUC = value; }
        public string Direccion1 { get => Direccion; set => Direccion = value; }
        public string Telefono1 { get => Telefono; set => Telefono = value; }
        public string Correo1 { get => Correo; set => Correo = value; }

        public bool AgregarEmpresa()
        {
            string logoBase64 = Convert.ToBase64String(Logo);
            string cadenaXML = $@"<Empresas>
                <Empresa>
                    <Nombre_Empresa>{Nombre_Empresa}</Nombre_Empresa>
                    <Logo_Empresa>{logoBase64}</Logo_Empresa>
                    <RUC>{RUC}</RUC>
                    <Direccion>{Direccion}</Direccion>
                    <Telefono>{Telefono}</Telefono>
                    <Correo>{Correo}</Correo>
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
                    <RUC>{RUC}</RUC>
                    <Direccion>{Direccion}</Direccion>
                    <Telefono>{Telefono}</Telefono>
                    <Correo>{Correo}</Correo>
                </Empresa>
            </Empresas>";
            string query = $@"exec spModificarEmpresa '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }

        public DataTable ListaEmpresa(string m)
        {
            string query = $"select * from [MC-Empresa] where Nombre_Empresa like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
