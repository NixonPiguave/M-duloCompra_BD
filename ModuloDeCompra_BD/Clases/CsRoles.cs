using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheArtOfDevHtmlRenderer.Adapters;

namespace ModuloDeCompra_BD.Clases
{
    internal class CsRoles
    {
        int idRol;
        string rol;
        int idrolfun;
        int funciones;
        public int RolID { get => idRol; set => idRol = value; }
        public string Rol { get => rol; set => rol = value; }
        public int Funciones { get => funciones; set => funciones = value; }
        public int Idrolfun { get => idrolfun; set => idrolfun = value; }

        public bool AñadirRol()
        {
            string cadenaXML = $@"<Roles>
                    <Rol>
                        <Rol>{rol}</Rol>
                    </Rol>
                </Roles>";
            string query = $@"exec spAgregarRol '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool funcionRol()
        {       
                string query = $"exec sp_AsignarFuncionARol '{idrolfun}','{funciones}'";
                return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarRol()
        {
            string cadenaXML = $@"<Roles>
                <Rol>
                    <ID_Rol>{idRol}</ID_Rol>
                    <Rol>{rol}</Rol>
                </Rol>
            </Roles>";
            string query = $@"exec spModificarRol '{cadenaXML}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
    }
}
