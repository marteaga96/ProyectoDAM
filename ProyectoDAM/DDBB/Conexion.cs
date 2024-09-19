using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ProyectoDAM.DDBB
{
    public class Conexion
    {

        //public static MySqlConnection datos_conexion = new MySqlConnection();
        public SqlConnection datos_conexion;



        //Datos de conexión
        private string server = "127.0.0.1";
        private string database = "prueba";

        public Conexion(string Uid, string password)
        {
            string connectionString = $"data source=127.0.0.1;Initial Catalog=master;Persist Security Info=True;TrustServerCertificate=true;User ID={Uid};Password={password}";
            datos_conexion = new SqlConnection(connectionString);
        }

        //Abrir conexión
        public bool conAbrir()
        {
            bool rdo = false;
            try
            {
                if (datos_conexion.State == System.Data.ConnectionState.Closed)
                {
                    datos_conexion.Open();
                    rdo = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la base de datos: " + ex.Message);
            }

            return rdo;
        }

        public void conCerrar()
        {
            try
            {
                if (datos_conexion.State == System.Data.ConnectionState.Open)
                {
                    datos_conexion.Close();
                    datos_conexion.Dispose();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la base de datos: " + ex.Message);
            }
        }
    }
}