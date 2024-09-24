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


        public main()
        {

        }

        private void pestaña_actual(string pestaña)
        {
            switch (pestaña)
            {
                case "HOME":
                    //MessageBox.Show("HE ENTRADO AL CASE PORQUE VOY A HOME");

                    Controls.Remove(userControl2);  // Quitar UserControl2 si está visible
                    Controls.Remove(userControl3);  // Quitar UserControl3 si está visible
                    Controls.Remove(userControl4);  // Quitar UserControl4 si está visible
                    Controls.Add(userControl1);
                    break;

                case "COMPRAS":
                    //MessageBox.Show("HE ENTRADO AL CASE PORQUE VOY A COMPRAS");

                    Controls.Remove(userControl1);  // Quitar UserControl1 si está visible
                    Controls.Remove(userControl3);  // Quitar UserControl3 si está visible
                    Controls.Remove(userControl4);  // Quitar UserControl4 si está visible
                    Controls.Add(userControl2);
                    break;

                case "VENTAS":
                    //MessageBox.Show("HE ENTRADO AL CASE PORQUE VOY A VENTAS");
                    Controls.Remove(userControl1);  // Quitar UserControl1 si está visible
                    Controls.Remove(userControl2);  // Quitar UserControl2 si está visible
                    Controls.Remove(userControl4);  // Quitar UserControl4 si está visible
                    Controls.Add(userControl3);
                    break;

                case "INVENTARIO":
                    //MessageBox.Show("HE ENTRADO AL CASE PORQUE VOY A INVENTARIO");
                    Controls.Remove(userControl1);  // Quitar UserControl1 si está visible
                    Controls.Remove(userControl2);  // Quitar UserControl2 si está visible
                    Controls.Remove(userControl3);  // Quitar UserControl3 si está visible
                    Controls.Add(userControl4);
                    break;
            }
        }



        private void btnPERFIL_Click(object sender, EventArgs e)
        {
            //Cambio color del NAV a RGB específico
            panelNAV.BackColor = Color.FromArgb(255, 32, 43, 54);

        }

        public main(string usuario)
        {
            InitializeComponent();
            //Texto de bienvenida.
            lblBIENVENIDA.Text = $"Bienvenid@ {usuario}";

            // Crear instancia de UserControl1(HOME) y mosrtarla en el formulario.
            userControl1 = new UserControl1();
            userControl1.Dock = DockStyle.Fill;  // Espacio del UserContro1 maximizado
            this.Controls.Add(userControl1);      // Mostrar UserControl1 en el formulario

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
