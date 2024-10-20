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
    public partial class main : Form
    {
        public main(string usuario)
        {
            InitializeComponent();
            //Texto de bienvenida.
            lblBIENVENIDA.Text = $"Bienvenid@ {usuario}";

            if (this.MdiChildren.Count(x => x.Name == "Home") < 1)
            {
                Home _Conf = new Home();
                _Conf.MdiParent = this;
                //_Conf.WindowState = FormWindowState.Maximized;
                _Conf.Dock = DockStyle.Fill;
                _Conf.Show();
            }
            else
            {
                this.MdiChildren.First(y => y.Name == "Home").Activate();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count(x => x.Name == "Home") < 1)
            {
                Home _Conf = new Home();
                _Conf.MdiParent = this;
                //_Conf.WindowState = FormWindowState.Maximized;
                _Conf.Dock = DockStyle.Fill;
                _Conf.Show();
            }
            else
            {
                this.MdiChildren.First(y => y.Name == "Home").Activate();
            }
        }

        private void btnCERRARSESION_Click(object sender, EventArgs e)
        {
            //Botón que cierra la sesión del usuario conectado.
            MessageBox.Show("Sesión cerrada con éxito.");
            Application.Exit();
        }

        private void btnCOMPRAS_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count(x => x.Name == "Compras") < 1)
            {
                Compras _Conf = new Compras();
                _Conf.MdiParent = this;
                //_Conf.WindowState = FormWindowState.Maximized;
                _Conf.Dock = DockStyle.Fill;
                _Conf.Show();
            }
            else
            {
                this.MdiChildren.First(y => y.Name == "Compras").Activate();
            }
        }
        private void btnVENTAS_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count(x => x.Name == "Ventas") < 1)
            {
                Ventas _Conf = new Ventas();
                _Conf.MdiParent = this;
                //_Conf.WindowState = FormWindowState.Maximized;
                _Conf.Dock = DockStyle.Fill;
                _Conf.Show();
            }
            else
            {
                this.MdiChildren.First(y => y.Name == "Ventas").Activate();
            }
        }

        private void btnINVENTARIO_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count(x => x.Name == "Inventario") < 1)
            {
                Inventario _Conf = new Inventario();
                _Conf.MdiParent = this;
                //_Conf.WindowState = FormWindowState.Maximized;
                _Conf.Dock = DockStyle.Fill;
                _Conf.Show();
            }
            else
            {
                this.MdiChildren.First(y => y.Name == "Inventario").Activate();
            }
        }

        private void btnGESTION_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count(x => x.Name == "Gestion") < 1)
            {
                Gestion _Conf = new Gestion();
                _Conf.MdiParent = this;
                //_Conf.WindowState = FormWindowState.Maximized;
                _Conf.Dock = DockStyle.Fill;
                _Conf.Show();
            }
            else
            {
                this.MdiChildren.First(y => y.Name == "Gestion").Activate();
            }
        }

        private void btnPRODUCTOS_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Count(x => x.Name == "Productos") < 1)
            {
                Productos _Conf = new Productos();
                _Conf.MdiParent = this;
                //_Conf.WindowState = FormWindowState.Maximized;
                _Conf.Dock = DockStyle.Fill;
                _Conf.Show();
            }
            else
            {
                this.MdiChildren.First(y => y.Name == "Productos").Activate();
            }
        }
    }
}
