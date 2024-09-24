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
        private UserControl1 userControl1;
        private UserControl2 userControl2;

        public main()
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnPERFIL_Click(object sender, EventArgs e)
        {
            panelNAV.BackColor = Color.FromArgb(255, 32, 43, 54);

        }

        public main(string usuario)
        {
            //Texto de bienvenida.
            InitializeComponent();
            lblBIENVENIDA.Text = $"Bienvenid@ {usuario}";

            // Crear instancia de UserControl1 (HOME) y agregar al formulario
            userControl1 = new UserControl1();
            userControl1.Dock = DockStyle.Fill;  // Asegúrate de que ocupe todo el espacio
            this.Controls.Add(userControl1);      // Agregar UserControl1 al formulario

            // Crear instancia de UserControl2 (COMPRAS) pero no agregarlo aún
            userControl2 = new UserControl2();
            userControl2.Dock = DockStyle.Fill;  // Asegúrate de que ocupe todo el espacio

        }

        private void btnCERRARSESION_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión cerrada con éxito.");
            Application.Exit();
        }

        private void btnHOME_Click(object sender, EventArgs e)
        {
            // Verificar si UserControl2 está visible y ocultarlo
            if (userControl2.Parent != null)
            {
                this.Controls.Remove(userControl2);  // Remover UserControl2 si está visible
            }

            // Asegurarse de que UserControl1 esté visible
            if (userControl1.Parent == null)  // Solo agregarlo si no está ya en el formulario
            {
                this.Controls.Add(userControl1);
            }
            userControl1.Visible = true;  // Asegurarse de que UserControl1 sea visible

        }

        private void btnCOMPRAS_Click(object sender, EventArgs e)
        {
            // Verificar si UserControl1 está visible y ocultarlo
            if (userControl1.Parent != null)
            {
                this.Controls.Remove(userControl1);  // Remover UserControl1 si está visible
            }

            // Asegurarse de que UserControl2 esté visible
            if (userControl2.Parent == null)  // Solo agregarlo si no está ya en el formulario
            {
                this.Controls.Add(userControl2);
            }
            userControl2.Visible = true;  // Asegurarse de que UserControl2 sea visible

        }
    }
}
