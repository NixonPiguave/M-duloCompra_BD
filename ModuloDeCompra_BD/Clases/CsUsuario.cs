using System;
using System.Collections.Generic;
using System.Data;
using System.Deployment.Application;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDeCompra_BD.Clases
{
    public class CsUsuario
    {
        string nombre;
        string apellido;
        string encargado;
        string cedula;
        string contraseña;
        int departamento;
        int Rol;

        //dejando preparado los métodos, solo es de agregar la consulta y ya xD
        public bool AñadirUser()
        {
            string query = " Consulta, para ingresar los datos ";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarUser()
        {
            string query = " Consulta, para ingresar los datos ";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarUser()
        {
            string query = " Consulta, para ingresar los datos ";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListadoUser()
        {
            string query = " sentencia Uwu";
            return CsComandosSql.RetornaDatos(query);
        } 
    }
}
