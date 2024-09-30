using System.Web;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using ProyectoDAM.DDBB;
using ProyectoDAM.Resources;

namespace ProyectoDAM
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            lblNOK.Visible = false;
        }


        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                //Variables de los campos de login

                variablesGlobales.usuario = txtUSUARIO.Text;
                variablesGlobales.password = txtCONTRASEÑA.Text;



                //Instancia conexion con los parametros
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);




                //Login correcto
#if DEBUG
                if (true)
#else
                    if (conexion.conAbrir() == true)
#endif
                    {
                    //Main.cs
                    // main mainForm = new main(variablesGlobales.usuario);
                    FrmMain mainForm = new FrmMain(variablesGlobales.usuario);
                    //Mensaje bienvendia 
                    MessageBox.Show($"Login Correcto. Bienvenido {variablesGlobales.usuario}");
                    
                    this.Hide();

                    //Si el main se ha abierto correctamente, lo muestra como ventana principal
                    mainForm.ShowDialog();


                    //Si se quita el Application.Exit, con el this.show se volvería al inicio de sesión.
                    this.Show();
                }


            }
            //Captura de errores
            catch (Exception ex)
            {
                //Si la conexión es NOK, muestra el textox rojo
                lblNOK.Visible = true;
                MessageBox.Show(ex.Message);


            }

        }

    }
}
