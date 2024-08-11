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
        public main()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(Main_FormClosed);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Detiene la aplicación cuando se cierra este formulario
            Application.Exit(); 
        }



    }
}
