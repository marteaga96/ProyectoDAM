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
        public FrmMain()
        {
            InitializeComponent();
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
    }
}
