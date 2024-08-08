using MySql.Data.MySqlClient;


namespace ProyectoDAM
{
    
    public partial class Form1 : Form
    {
        //Objeto para conexi�n a la DDBB
        DDBB.Conexion conexion = new DDBB.Conexion();

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
                //Si la conexi�n es OK, muestra cartel verde
                DDBB.Conexion.dataSource();
                conexion.connOpen();
                lblOK.Visible=true;
                conexion.connClose();
            }

            catch (Exception)
            {
                //Si la conexi�n es NOK, muestra cartel rojo
                lblNOK.Visible = true;
                conexion.connClose();
            }

            finally {
                //Cierra conexi�n
                conexion.connClose();
            }
        }

    }
}
