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
    public partial class Gestion : Form
    {
        public Gestion()
        {
            InitializeComponent();
        }

        private void gestionOpciones(string opcion)
        {
            switch (opcion)
            {

                case "USUARIO":
                    btn_CREAR_USUARIO.Visible = true;
                    btn_MODIFICAR_USUARIO.Visible = true;
                    btn_BORRAR_USUARIO.Visible = true;
                    break;

                case "AJUSTES":
                    btn_CREAR_USUARIO.Visible = false;
                    btn_MODIFICAR_USUARIO.Visible = false;
                    btn_BORRAR_USUARIO.Visible = false;
                    break;

            }

        }

        private void btn_OPCIONES_USUARIO_Click(object sender, EventArgs e)
        {
            gestionOpciones("USUARIO");
        }

        private void btn_AJUSTES_Click(object sender, EventArgs e)
        {
            gestionOpciones("AJUSTES");
        }
    }
}
