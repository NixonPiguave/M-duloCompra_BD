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

        // Método para obtener la conexión (ya configurada)
        private static void Conectar()
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
        private static void Desconectar()
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
                MessageBox.Show("error");
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
                MessageBox.Show("Error");
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

        //este metodo es para generar secuenciales para facturas por ejemplo
        public static string GenerarSecuencial(string secuencia)
        {
            string secu = secuencia;
            int sufijo = 0;

            while (verificar($"select * from [Orden de Compra] where NumOrden='{secu}'"))
            {
                sufijo++;
                // Reemplazar los últimos dígitos por el nuevo sufijo
                secu = secuencia.Substring(0, secuencia.Length - sufijo.ToString().Length) + sufijo.ToString();
            }
            return secu;
        }
    }
}
