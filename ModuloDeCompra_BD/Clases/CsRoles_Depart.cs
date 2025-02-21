using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    class CsRoles_Depart
    {
        string Rol;
        string NombreDepartamento;
        public bool añadirRol()
        {
            string query = " sentencia Uwu";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool añadirDepartamento()
        {
            string query = " sentencia Uwu";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarDepartamento()
        {
            string query = " sentencia Uwu";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarDepartamento()
        {
            string query = " sentencia Uwu";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListadoRoles()
        {
            string query = " sentencia Uwu";
            return CsComandosSql.RetornaDatos(query);
        }
        public DataTable ListadoDepartamentos()
        {
            string query = " sentencia Uwu";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
