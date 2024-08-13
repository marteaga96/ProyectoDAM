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
            Application.Exit(); // Cierra toda la aplicaci�n cuando se cierra el formulario Main
        }


        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUSUARIO.Text;
                string contrase�a = txtCONTRASE�A.Text;


                //Instancia conexion
                DDBB.Conexion asdf = new DDBB.Conexion(usuario, contrase�a);

                

                
                //Login correcto
                if (asdf.conAbrir() == true)
                {
                    //Main.cs
                    main mainForm = new main();

                    //Mensaje bienvendia 
                    MessageBox.Show($"Login Correcto. Bienvenido {usuario}");
                    if (mainForm.DialogResult == DialogResult.OK) //<-- Comprobar en main???
                    {
                        //Si el main se ha abierto correctamente, lo muestra como ventana principal
                        mainForm.ShowDialog();

                        //mostrarDatosUsuario();
                    }
                }


            }
            catch (Exception ex)
            {
                //Si la conexi�n es NOK, muestra cartel rojo
                lblNOK.Visible = true;
                lblOK.Visible = false;

            }

        }

        //private void mostrarDatosUsuario()
        //{
        //    string R = "";

        //    // Pasar datos de login a la clase Conexion
        //    DDBB.Conexion conexion = new DDBB.Conexion();

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
