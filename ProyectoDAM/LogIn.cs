using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ProyectoDAM;

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

                // Pasar datos de login a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(contrase�a, usuario);

                //Si la conexi�n es OK, muestra cartel verde
                conexion.conAbrir();
                lblOK.Visible = true;
                lblNOK.Visible = false;

                this.Hide();
                main mainForm = new main();
                mainForm.Show(); // Abre el formulario Main como ventana no modal
                

            }
            catch (Exception)
            {
                //Si la conexi�n es NOK, muestra cartel rojo
                lblNOK.Visible = true;
                lblOK.Visible = false;

            }
        }
    }
}
