using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
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
        int rol;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Encargado { get => encargado; set => encargado = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Departamento { get => departamento; set => departamento = value; }
        public int Rol { get => rol; set => rol = value; }

        public bool AñadirUser() {
            string query = $"insert into Usuario (Nombre, Apellido, Encargado, Cedula, Contraseña, Dep_ID, Rol) values ('{nombre}', '{apellido}','{encargado}', '{cedula}', '{contraseña}',{departamento}, {rol})";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool ModificarUser()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarUser()
        {
            string query = "";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListadoUser()
        {
            string query = "select U.ID, U.Nombre,U.Apellido, U.Encargado, U.Cedula, D.Dep_ID,D.Nombre_Departamento, R.ID_Rol, R.Rol  from Departamento D inner join Usuario U on D.Dep_ID=U.Dep_ID \r\ninner join Roles R on U.Rol=R.ID_Rol";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
