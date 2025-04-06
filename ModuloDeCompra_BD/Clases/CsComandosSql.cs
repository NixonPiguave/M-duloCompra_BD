﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace ModuloDeCompra_BD.Clases
{
    public class CsComandosSql
    {
        private static SqlConnection conex;
        private static SqlCommand comando;
        string usuario;
        string contraseña;
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }

        public static void Conectar()
        {
            conex = CsConeccionServer.ObtenerConexion();
        }
        private static void ConfigurarComando(string query)
        {
            try
            {
                comando = new SqlCommand(query, conex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la Consulta Sql");
            }
        }
        public static void Desconectar()
        {
            CsConeccionServer.desconectarse();
            comando.Dispose();
        }
        public static DataTable RetornaDatos(string sentencia)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                ConfigurarComando(sentencia);
                SqlDataAdapter sDA = new SqlDataAdapter(comando);
                sDA.Fill(dt);
                Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error" + ex.Message);
            }
            return dt;
        }
        public static DataTable RetornaDatosConParametro(string query, SqlParameter parametro)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar(); // Usa tu método existente de conexión

                comando = new SqlCommand(query, conex);
                comando.Parameters.Add(parametro);

                SqlDataAdapter sDA = new SqlDataAdapter(comando);
                sDA.Fill(dt);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar consulta: " + ex.Message);
            }
            finally
            {
                Desconectar(); // Asegura que la conexión se cierre
            }
            return dt;
        }
        public static bool InserDeletUpdate(string coman)
        {
            int result = 0;
            try
            {
                Conectar();
                ConfigurarComando(coman);
                result = comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
            return result > 0;
        }
        public static bool verificar(string comand)
        {
            try
            {
                Conectar();
                ConfigurarComando(comand);
            }
            catch
            {
                MessageBox.Show("Error");
                return false;
            }
            SqlDataReader leer = comando.ExecuteReader();
            bool result = leer.Read();
            return result;
        }
        public static string verificarlogin(string user, string Contraseña)
        {
            string rol = string.Empty;
            Conectar();

            string query = $"select R.Rol from Usuario U inner join Roles R on U.ID_Rol=R.ID_Rol where   U.Usuario= '{user}' and U.Contraseña ='{Contraseña}'";
            ConfigurarComando(query);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                rol = reader["Rol"].ToString();
            }
            Desconectar();
            return rol;
        }
        public static bool verificarRol(string usuario)
        {
            bool permiso = false;
            Conectar();
            string query = $"select U.Usuario, R.Rol from Usuario as U inner join Roles as R on U.ID_Rol = R.ID_Rol where U.Usuario = '{usuario}' and (R.Rol = 'Administrador' or R.Rol = 'Jefe Departamentario')";
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                permiso = true;
            }
            Desconectar();
            return permiso;
        }
        public static int ObtenerIdUsuario(string user, string Contraseña)
        {
            
            int id=-1;
            Conectar();

            string query = $"select U.ID_Usuario from Usuario U inner join Roles R on U.ID_Rol=R.ID_Rol where   U.Usuario= '{user}' and U.Contraseña ='{Contraseña}'";
            ConfigurarComando(query);
            SqlDataReader reader = comando.ExecuteReader();
            if (reader.Read())
            {
                id = Convert.ToInt32(reader["ID_Usuario"].ToString());
            }
            Desconectar();
            return id;
        }
        public bool LoginBD()
        {
            SqlConnection conex = CsConeccionServer.ObtenerConexion();
            string query = $"IF NOT EXISTS (SELECT * FROM sys.server_principals WHERE name = '{usuario}') BEGIN " +
                $"CREATE LOGIN {usuario} WITH PASSWORD = '{Contraseña}'; END " +
                $"USE ModuloCompras; IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = '{usuario}') " +
                $"BEGIN CREATE USER {usuario} FOR LOGIN {usuario}; ALTER ROLE db_owner ADD MEMBER {usuario}; END";
            SqlCommand oCom = new SqlCommand(query, conex);
            try
            {
                oCom.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                CsConeccionServer.desconectarse();
            }
        }
        public static string GenerarSecuencial(string secuencia)
        {
            string secu = secuencia;
            int sufijo = 0;

            while (verificar($"select * from [Orden de Compra] where NumOrden='{secu}'"))
            {
                sufijo++;
                secu = secuencia.Substring(0, secuencia.Length - sufijo.ToString().Length) + sufijo.ToString();
            }
            return secu;
        }
        public static int[] Funcion_Rol(string user, string contraseña)
        {
            Conectar();

            string countQuery = $"SELECT COUNT(RF.ID_Funcion) FROM Usuario U INNER JOIN Roles R ON U.ID_Rol = R.ID_Rol INNER JOIN Roles_Funciones RF ON R.ID_Rol = RF.ID_Rol WHERE U.Usuario = '{user}' AND U.Contraseña = '{contraseña}'";

            ConfigurarComando(countQuery);

            int count = Convert.ToInt32(comando.ExecuteScalar());

            int[] funciones = new int[count];

            if (count > 0)
            {
                string Query = $"SELECT RF.ID_Funcion FROM Usuario U INNER JOIN Roles R ON U.ID_Rol = R.ID_Rol INNER JOIN Roles_Funciones RF ON R.ID_Rol = RF.ID_Rol WHERE U.Usuario = '{user}' AND U.Contraseña = '{contraseña}'";

                ConfigurarComando(Query);

                SqlDataReader reader = comando.ExecuteReader();
                int x = 0;

                while (reader.Read())
                {
                    funciones[x] = Convert.ToInt32(reader["ID_Funcion"]);
                    x++;
                }
            }
            Desconectar();
            return funciones;
        }
        public static int obtenerID(string sentencia)
        {
            Conectar();
            string query = sentencia;
            ConfigurarComando(query);
            object result = comando.ExecuteScalar();
            Desconectar();

            if (result == null || result == DBNull.Value)
            {
                throw new Exception("La consulta no devolvió ningún resultado.");
            }

            try
            {
                return Convert.ToInt32(result);
            }
            catch (FormatException)
            {
                throw new Exception($"No se pudo convertir el valor '{result}' a número. Verifica que la consulta devuelva un ID válido.");
            }
        }
        public static int Tam(string sentencia)
        {
            Conectar();
            string countQuery = sentencia;

            ConfigurarComando(countQuery);
            return( Convert.ToInt32(comando.ExecuteScalar()));

        }
        public static int[] IDmod(int idrol)
        {
            Conectar();

            string countQuery = $"select count(*) from Roles_Funciones where ID_Rol='{idrol}'";

            ConfigurarComando(countQuery);

            int count = Convert.ToInt32(comando.ExecuteScalar());

            int[] funciones = new int[count];

            if (count > 0)
            {
                string Query = $"SELECT ID_Funcion FROM Roles_Funciones  WHERE ID_Rol='{idrol}'";

                ConfigurarComando(Query);

                SqlDataReader reader = comando.ExecuteReader();
                int x = 0;

                while (reader.Read())
                {
                    funciones[x] = Convert.ToInt32(reader["ID_Funcion"]);
                    x++;
                }
            }
            Desconectar();
            return funciones;

        }
    }
}
