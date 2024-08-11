using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ProyectoDAM.DDBB
{
    public class Conexion
    {

        public static MySqlConnection datos_conexion = new MySqlConnection();



        //Datos de conexión
        private string server = "127.0.0.1;";
        private string database = "prueba;";
        private string Uid;
        private string password;


        public Conexion(string password, string Uid)
        {
            this.password = password;
            this.Uid = Uid;
            string connectionString = $"server={server};database={database};Uid={Uid};password={password}";
            datos_conexion = new MySqlConnection(connectionString);
        }

        //Abrir conexión
        public void connOpen()
        {
            try
            {
                if (datos_conexion.State == System.Data.ConnectionState.Closed)
                {
                    datos_conexion.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al abrir la conexión a la base de datos: " + ex.Message);
            }
        }

        public void connClose()
        {
            try
            {
                if (datos_conexion.State == System.Data.ConnectionState.Open)
                {
                    datos_conexion.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cerrar la conexión a la base de datos: " + ex.Message);
            }
        }

        public MySqlConnection GetConnection()
        {
            return datos_conexion;
        }
    }
}