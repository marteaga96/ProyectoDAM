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
        static string server = "127.0.0.1;";
        static string database = "prueba;";
        static string Uid = "mario;";
        static string password = "mario;";

        public static MySqlConnection dataSource()
        {
            datos_conexion = new MySqlConnection($"server={server} database={database} Uid={Uid} password={password}");
            return datos_conexion;
        }

        //Abrir conexión
        public void connOpen() { 
            dataSource();
            datos_conexion.Open();

        }

        //Cerrar conexión
        public void connClose() {
            dataSource();
            datos_conexion.Close();
        }
    }
}
