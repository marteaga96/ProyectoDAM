using System.Web;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using ProyectoDAM;
using ProyectoDAM.DDBB;

namespace ProyectoDAM
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            lblOK.Visible = false;
            lblNOK.Visible = false;
        }


        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables de los campos de login
                string usuario = txtUSUARIO.Text;
                string pass = txtCONTRASEÑA.Text;


                //Instancia conexion con los parametros
                DDBB.Conexion conexion = new DDBB.Conexion(usuario, pass);




                //Login correcto
                //if (true)
                if (conexion.conAbrir() == true)
                {
                    //Main.cs
                    main mainForm = new main(usuario);

                    //Mensaje bienvendia 
                    MessageBox.Show($"Login Correcto. Bienvenido {usuario}");
                    
                    this.Hide();

                    //Si el main se ha abierto correctamente, lo muestra como ventana principal
                    mainForm.ShowDialog();


                    //mostrarDatosUsuario(usuario, pass);

                    //Si main se cierra, se para la ejecución del programa.
                    //Application.Exit();



                    //Si se quita el Application.Exit, con el this.show se volvería al inicio de sesión.
                    this.Show();
                }


            }
            //Captura de errores
            catch (Exception ex)
            {
                //Si la conexión es NOK, muestra cartel rojo
                lblNOK.Visible = true;
                lblOK.Visible = false;

            }

        }

        //private void mostrarDatosUsuario(string usuario, string pass)
        //{
        //    string R = "";

        //    //Pasar datos de login a la clase Conexion
        //    DDBB.Conexion conexion = new DDBB.Conexion(usuario, pass);

        //    SqlCommand comando = new SqlCommand();
        //    comando.CommandText = Properties.Resources.Consulta1;
        //    comando.Parameters.AddWithValue("@user", txtUSUARIO.Text);
        //    comando.Connection = conexion.datos_conexion;


        //    if (conexion.conAbrir())
        //    {
        //        SqlDataReader Reader = comando.ExecuteReader();
        //        while (Reader.Read())
        //        {
        //            R = Reader.GetString(0) + " " + Reader.GetString(1) + " " + Reader.GetString(2) + " " + Reader.GetString(3) + " " + Reader.GetString(24);

        //        }

        //        Reader.Close();
        //        lblOK.Visible = true;
        //        lblNOK.Visible = false;
        //        conexion.conCerrar();

        //        MessageBox.Show(R);
        //    }
        //}


    }
}
