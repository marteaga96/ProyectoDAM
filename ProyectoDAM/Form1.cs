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
                string contraseña = txtCONTRASEÑA.Text;

                // Pasar la contraseña a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(contraseña, usuario);

                //Si la conexión es OK, muestra cartel verde
                conexion.connOpen();
                lblOK.Visible = true;
                conexion.connClose();
            }
            catch (Exception)
            {
                //Si la conexión es NOK, muestra cartel rojo
                lblNOK.Visible = true;
            }
            finally
            {
                // Cierra la conexión
                DDBB.Conexion conexion = new DDBB.Conexion(txtCONTRASEÑA.Text, txtUSUARIO.Text);
                conexion.connClose();
            }
        }
    }
}
