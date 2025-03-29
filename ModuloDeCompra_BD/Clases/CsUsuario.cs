using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Clases
{
    public class CsUsuario
    {
        CsComandosSql CsComandosSql = new CsComandosSql();
        int Id;
        string nombre;
        string apellido;
        string usuario;
        string cedula;
        string contraseña;
        int departamento;
        int rol;
        string rolname;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
        public int Departamento { get => departamento; set => departamento = value; }
        public int Rol { get => rol; set => rol = value; }
        public int ID { get => Id; set => Id = value; }
        public string Rolname { get => rolname; set => rolname = value; }

        public bool AñadirUser()
        {
            string query = $"insert into Usuario (Nombre, Apellido, Cedula, Contraseña, ID_Depa, ID_Rol, Usuario) values ('{nombre}', '{apellido}', '{cedula}', '{contraseña}',{departamento} ,{rol} , '{usuario}')";
            CsComandosSql.InserDeletUpdate(query);
            switch (rolname)
            {
                case "Administrador":
                    {
                        string query2 = $"CREATE LOGIN [{usuario}] WITH PASSWORD = '{contraseña}';" +
                            $"USE ModuloCompras; " +
                            $"CREATE USER [{usuario}] FOR LOGIN [{usuario}]" +
                            $"EXEC sp_addrolemember 'db_owner', '{usuario}'";
                        CsComandosSql.InserDeletUpdate(query2);
                    }
                    break;
                default:
                    {
                        string query2 = $"CREATE LOGIN [{usuario}] WITH PASSWORD = '{contraseña}';" +
                            $"USE ModuloCompras; " +
                            $"CREATE USER [{usuario}] FOR LOGIN [{usuario}]" +
                             $"EXEC sp_addrolemember 'db_owner', '{usuario}'";
                        CsComandosSql.InserDeletUpdate(query2);
                    }
                    break;
            }
            return true;
        }
        public bool ModificarUser()
        {
            string query = $"update Usuario set Nombre='{nombre}', Apellido='{apellido}', Cedula='{cedula}', Usuario='{usuario}', Contraseña='{contraseña}' where ID_Usuario={Id}";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool EliminarUser()
        {
            string query = $"delete Usuario where ID_Usuario='{Id}'";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public bool AñadirUserBD()
        {
            string query = $"IF NOT EXIST (SELECT * FROM sys.server_principals WHERE name = '{usuario}') BEGIN " +
                $"CREATE LOGIN {usuario} WITH PASSWORD = '{contraseña}'; END" +
                $"  USE ModuloCompras; IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = '{usuario}')" +
                $"   BEGIN CREATE USER {usuario} FOR LOGIN {usuario}; ALTER ROLE db_owner ADD MEMBER {usuario}; END";
            return CsComandosSql.InserDeletUpdate(query);
        }
        public DataTable ListadoUser()
        {
            string query = "select U.ID_Usuario, U.Nombre, U.Apellido, U.Cedula, U.Usuario, U.Contraseña,R.ID_Rol, R.Rol, D.ID_Depa," +
                " D.Nombre_Departamento from Departamento D inner join Usuario U on D.ID_Depa= U.ID_Depa \r\ninner join Roles R on U.ID_Rol= R.ID_Rol";
            return CsComandosSql.RetornaDatos(query);
        }
    }
}
