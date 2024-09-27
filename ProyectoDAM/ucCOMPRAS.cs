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

            string resultado = "";

            //Pasar datos de login a la clase Conexion
            DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);

            SqlCommand comando = new SqlCommand();
            comando.CommandText = Properties.Resources.consultaAlmacen;
            comando.Connection = conexion.datos_conexion;


            if (conexion.conAbrir())
            {
                SqlDataReader Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    resultado = Reader.GetString(0) + " " + Reader.GetDouble(1);

                }

                Reader.Close();
                conexion.conCerrar();

                MessageBox.Show(resultado);
            }
        }

        private void btn_CREAR_COMPRA_Click(object sender, EventArgs e)
        {

        }
    }
}
