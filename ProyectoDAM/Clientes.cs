using ProyectoDAM.DDBB;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }


        private void gestionOpciones(string opcion)
        {
            switch (opcion)
            {

                case "CONSULTA":
                    pnlCREAR.Visible = false;
                    pnlMODIFICAR.Visible = false;
                    pnlCONSULTA.Visible = true;
                    break;

                case "CREAR":
                    pnlCONSULTA.Visible = false;
                    pnlMODIFICAR.Visible = false;
                    pnlCREAR.Visible = true;
                    break;
                case "MODIFICAR":
                    pnlCONSULTA.Visible = false;
                    pnlMODIFICAR.Visible = true;
                    pnlCREAR.Visible = false;
                    break;

            }

        }

        private void btn_CONSULTA_CLIENTES_Click(object sender, EventArgs e)
        {
            gestionOpciones("CONSULTA");
            Consultas.consulta_clientes(this, EventArgs.Empty, this.datagridCLIENTES);
        }

        private void btn_CREAR_CLIENTE_Click(object sender, EventArgs e)
        {
            gestionOpciones("CREAR");
        }

        private void btn_confirmarCliente_Click(object sender, EventArgs e)
        {
            Consultas.crear_cliente(this, EventArgs.Empty, this.txtCrearApellidosCliente.Text, this.txtCrearCiudadCliente.Text, this.txtCrearDireccionCliente.Text, this.txtCrearDNICliente.Text, this.txtCrearEmailCliente.Text, this.txtCrearNombreCliente.Text, this.txtCrearPaisCliente.Text, this.txtCrearPoblacionCliente.Text, this.txtCrearTelefonoCliente.Text);

        }

        private void btn_MODIFICAR_CLIENTE_Click(object sender, EventArgs e)
        {
            gestionOpciones("MODIFICAR");
        }

        private void btnConfirmarModificarCliente_Click(object sender, EventArgs e)
        {
            Consultas.modificar_cliente(this, EventArgs.Empty, this.txtIDCliente.Text, this.txtModificarApellidosCliente.Text, this.txtModificarCiudadCliente.Text, this.txtModificarDireccionCliente.Text, this.txtModificarDNICliente.Text, this.txtModificarEmailCliente.Text, this.txtModificarNombreCliente.Text, this.txtModificarPaisCliente.Text, this.txtModificarPoblacionCliente.Text, this.txtModificarTelefonoCliente.Text);

        }
    }
}
