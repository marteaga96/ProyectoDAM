using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDAM
{
    public partial class FrmMain : Form
    {
        public FrmMain(string usuario)
        {
            InitializeComponent();
            //Texto de bienvenida.
            lblBIENVENIDA.Text = $"Bienvenid@ {usuario}";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count(x => x.Name == "LogIn") < 1)
            {
                LogIn _Conf = new LogIn();
                _Conf.MdiParent = this;
                _Conf.WindowState = FormWindowState.Maximized;
                _Conf.Dock = DockStyle.Fill;
                _Conf.Show();
            }
            else
            {
                this.MdiChildren.First(y => y.Name == "LogIn").Activate();
            }
        }

        private void btnCOMPRAS_Click(object sender, EventArgs e)
        {

        }

        private void btnCERRARSESION_Click(object sender, EventArgs e)
        {
            //Botón que cierra la sesión del usuario conectado.
            MessageBox.Show("Sesión cerrada con éxito.");
            Application.Exit();
        }
    }
}
