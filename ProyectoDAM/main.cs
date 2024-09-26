using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDAM
{
    public partial class main : Form
    {
        private float originalFontSize;
        private bool isIncreasing;
        private float fontStep = 1.0f;

        //Variable control de pestaña
        private string pestaña;

        //Variables UserControl
        private UserControl1 userControl1;
        private UserControl2 userControl2;
        private UserControl3 userControl3;
        private UserControl4 userControl4;

        // UserControl para controlar pestaña actual
        private UserControl currentControl;


        public main()
        {

        }

        private void pestaña_actual(string pestaña)
        {
            //Variable para asignar nueva pestaña acutal
            UserControl newControl;

            switch (pestaña)
            {
                case "HOME":
                    newControl = userControl1;
                    break;

                case "COMPRAS":
                    newControl = userControl2;
                    break;

                case "VENTAS":
                    newControl = userControl3;
                    break;

                case "INVENTARIO":
                    newControl = userControl4;
                    break;

                default:
                    MessageBox.Show("Pestaña desconocida.");
                    return;
            }


            // Quitar pestaña actual y añadir nuevo userControl
            this.Controls.Remove(currentControl);
            currentControl = newControl;
            this.Controls.Add(currentControl);
        }


        public main(string usuario)
        {
            InitializeComponent();
            //Texto de bienvenida.
            lblBIENVENIDA.Text = $"Bienvenid@ {usuario}";

            //Crear instancia de UserControl1(HOME) y mosrtarla en el formulario.
            userControl1 = new UserControl1();
            this.Controls.Add(userControl1);      // Mostrar UserControl1 en el formulario

            //Configurar y mostrar el UserControl inicial (HOME)
            currentControl = userControl1;
            this.Controls.Add(currentControl);

            //Creo instancias del resto de UsersControls sin mostrarlos.
            userControl2 = new UserControl2();
            userControl3 = new UserControl3();
            userControl4 = new UserControl4();         

        }

        private void btnCERRARSESION_Click(object sender, EventArgs e)
        {
            //Botón que cierra la sesión del usuario conectado.
            MessageBox.Show("Sesión cerrada con éxito.");
            Application.Exit();
        }

        private void btnHOME_Click(object sender, EventArgs e)
        {
            pestaña = "HOME";
            pestaña_actual(pestaña);
        }

        private void btnCOMPRAS_Click(object sender, EventArgs e)
        {
            pestaña = "COMPRAS";
            pestaña_actual(pestaña);
        }

        private void btnVENTAS_Click(object sender, EventArgs e)
        {
            pestaña = "VENTAS";
            pestaña_actual(pestaña);
        }

        private void btnINVENTARIO_Click(object sender, EventArgs e)
        {
            pestaña = "INVENTARIO";
            pestaña_actual(pestaña);
        }
    }
}
