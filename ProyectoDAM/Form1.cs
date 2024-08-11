using MySql.Data.MySqlClient;
using ProyectoDAM;

namespace ProyectoDAM
{
    public partial class Form1 : Form
    {
        // Constructor de la clase Form1
        public Form1()
        {
            InitializeComponent();
            lblOK.Visible = false;
            lblNOK.Visible = false;
        }

        private void btnConexion_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUSUARIO.Text;
                string contrase�a = txtCONTRASE�A.Text;

                // Pasar la contrase�a a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(contrase�a, usuario);

                //Si la conexi�n es OK, muestra cartel verde
                conexion.connOpen();
                lblOK.Visible = true;
                conexion.connClose();
            }
            catch (Exception)
            {
                //Si la conexi�n es NOK, muestra cartel rojo
                lblNOK.Visible = true;
            }
            finally
            {
                // Cierra la conexi�n
                DDBB.Conexion conexion = new DDBB.Conexion(txtCONTRASE�A.Text, txtUSUARIO.Text);
                conexion.connClose();
            }
        }
    }
}
