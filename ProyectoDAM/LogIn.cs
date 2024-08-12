using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using ProyectoDAM;
using ProyectoDAM.DDBB;

namespace ProyectoDAM
{
    public partial class LogIn : Form
    {
        // Constructor de la clase Form1
        public LogIn()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Main_FormClosed);
            lblOK.Visible = false;
            lblNOK.Visible = false;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); // Cierra toda la aplicación cuando se cierra el formulario Main
        }


        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUSUARIO.Text;
                string contraseña = txtCONTRASEÑA.Text;



                //Si la conexión es OK, muestra cartel verde

                this.Hide();
                main mainForm = new main();
               mainForm.ShowDialog(); // Abre el formulario Main como ventana no modal
                if (mainForm.DialogResult == DialogResult.OK) { mostrarDatosUsuario(); }
            

            }
            catch (Exception ex)
            {
                //Si la conexión es NOK, muestra cartel rojo
                lblNOK.Visible = true;
                lblOK.Visible = false;

            }

        }

        private void mostrarDatosUsuario()
        {
            string R ="";

            // Pasar datos de login a la clase Conexion
            DDBB.Conexion conexion = new DDBB.Conexion();

            SqlCommand comando = new SqlCommand();
            comando.CommandText = Properties.Resources.Consulta1;
            comando.Parameters.AddWithValue("@user", txtUSUARIO.Text);
            comando.Connection = conexion.datos_conexion;

           
            if (conexion.conAbrir())
            {
                SqlDataReader Reader = comando.ExecuteReader();
                while (Reader.Read())
                {
                    R = Reader.GetString(0) + " " + Reader.GetString(1) + " " + Reader.GetString(2) + " " + Reader.GetString(3) + " " + Reader.GetString(4);

                }
 Reader.Close();
                lblOK.Visible = true;
                lblNOK.Visible = false;
                conexion.conCerrar();

                MessageBox.Show(R);
            }
        }


    }
}
