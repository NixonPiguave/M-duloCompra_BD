using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloDeCompra_BD.Clases
{
    public class CsConeccionServer
    {
        static SqlConnection con = new SqlConnection();
        static string servidor = "26.137.134.250,1433";
        static string bd = "BDModuloCompr";
        static string usuario = "sa";
        static string password = "1234";
        static string puerto = "1433";

        //cadena de conexion para conectarse por vpn
        static string cadenaConexion = "Data Source=" + servidor + "," + puerto + ";" +
                        "User ID=" + usuario + ";" +
                        "Password=" + password + ";" +
                        "Initial Catalog=" + bd + ";" +
                        "Persist Security Info=true;";

        public static SqlConnection ObtenerConexion()
        {
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

                con.ConnectionString = cadenaConexion;
                con.Open();
                
            }
            catch (SqlException e)
            {
                MessageBox.Show("Error al conectar: " + e.Message);
            }
            return con;
        }
        public static bool desconectarse()
        {
            try
            {
                con.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Mal" + e.Message);
                return false;
            }
            return true;
        }
    }
}