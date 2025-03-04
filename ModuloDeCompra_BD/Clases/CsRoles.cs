using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    internal class CsRoles
    {
        int idRol;
        string rol;
        public int RolID { get => idRol; set => idRol = value; }
        public string Rol { get => rol; set => rol = value; }
        public bool AñadirRol()
        {
            string query = $"insert into Roles (Rol) values ('{Rol}')";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarRol()
        {
            string query = $"Update Roles set Rol = '{Rol}' where ID_Rol = {RolID}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarRol()
        {
            string query = $"Delete from Roles where ID_Rol = {RolID}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListaRol(string m)
        {
            string query = $"Select * from Categoria where Categoria like '%{m}%'";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
