using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using ProyectoDAM.DDBB;
using ProyectoDAM.Resources;

namespace ProyectoDAM
{
    public partial class ucCOMPRAS : UserControl
    {
        public ucCOMPRAS()
        {
            InitializeComponent();
        }

        private void CONSULTA_Click(object sender, EventArgs e)
        {
            Consultas.consulta_historial_compras(this, EventArgs.Empty, this.DatagridView1);

            try
            {
                // Pasar datos de login a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "SELECT NOMBRE_USUARIO FROM USUARIOS", // Consulta para obtener NOMBRE_USUARIO
                    Connection = conexion.datos_conexion
                };

                if (conexion.conAbrir())
                {
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        // Crear un DataTable para almacenar los resultados
                        DataTable dataTable = new DataTable();
                        dataTable.Load(Reader);  // Cargar los datos del SqlDataReader al DataTable

                        // Limpiar el ComboBox antes de llenarlo
                        comboBox1.Items.Clear();

                        // Llenar el ComboBox con los nombres de usuario
                        foreach (DataRow row in dataTable.Rows)
                        {
                            comboBox1.Items.Add(row["NOMBRE_USUARIO"].ToString());
                        }
                    }
                    conexion.conCerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btn_CREAR_COMPRA_Click(object sender, EventArgs e)
        {
            MessageBox.Show("heelo");
        }


    }
}
