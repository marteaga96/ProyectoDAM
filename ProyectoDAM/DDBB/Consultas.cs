using Microsoft.Data.SqlClient;
using ProyectoDAM.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDAM.DDBB
{
    public static class Consultas
    {
        public static void consulta_historial_compras(object sender, EventArgs e, DataGridView dataGridView1)
        {
            try
            {
                // Pasar datos de login a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = Properties.Resources.consultaCompras,
                    Connection = conexion.datos_conexion
                };

                if (conexion.conAbrir())
                {
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        // Crear un DataTable para almacenar los resultados
                        DataTable dataTable = new DataTable();
                        dataTable.Load(Reader);  // Cargar los datos del SqlDataReader al DataTable

                        // Asignar el DataTable como DataSource del DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    conexion.conCerrar();
                }
                else
                {
                    MessageBox.Show("Error al abrir la conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }



}
