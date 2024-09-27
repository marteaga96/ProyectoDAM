using Microsoft.Data.SqlClient;
using ProyectoDAM.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDAM.DDBB
{
    public static class Consultas
    {
        public static string consulta_historial_compras(object sender, EventArgs e)
        {
            string resultado = "";

            try
            {
                // Pasar datos de login a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand{
                        CommandText = Properties.Resources.consultaCompras,
                        Connection = conexion.datos_conexion
                    };

                if (conexion.conAbrir()){
                        SqlDataReader Reader = comando.ExecuteReader();
                        while (Reader.Read()){
                        // Suponiendo que la primera columna es un string y la segunda es un double
                        resultado = Reader.GetInt32(0) + " " + Reader.GetString(1);
                    }

                        Reader.Close();
                        conexion.conCerrar();
                        MessageBox.Show(resultado);
                 }

                else{
                    MessageBox.Show(resultado);
                }
            }

            catch (Exception ex){
                MessageBox.Show(resultado + ex.Message);
            }

            return resultado;
        }

    }



}
