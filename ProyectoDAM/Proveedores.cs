using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDAM.DDBB;

namespace ProyectoDAM
{
    public partial class Proveedores : Form
    {
        public Proveedores()
        {
            InitializeComponent();
        }

        private void gestionOpciones(string opcion)
        {
            switch (opcion)
            {

                case "CONSULTA":
                    pnlCREAR.Visible = false;
                    //pnlMODIFICAR.Visible = false;
                    pnlCONSULTA.Visible = true;
                    break;

                case "CREAR":
                    pnlCONSULTA.Visible = false;
                    //pnlMODIFICAR.Visible = false;
                    pnlCREAR.Visible = true;
                    break;
                case "MODIFICAR":
                    pnlCONSULTA.Visible = false;
                    //pnlMODIFICAR.Visible = true;
                    pnlCREAR.Visible = false;
                    break;

            }

        }

        private void btn_CONSULTA_CLIENTES_Click(object sender, EventArgs e)
        {
            gestionOpciones("CONSULTA");
            Consultas.consulta_proveedores(this, EventArgs.Empty, this.datagridPROVEEDORES);
        }

        private void btn_CREAR_PROVEEDORES_Click(object sender, EventArgs e)
        {
            gestionOpciones("CREAR");
        }

        private void btn_confirmarProveedor_Click(object sender, EventArgs e)
        {
            Consultas.crear_proveedor(this, EventArgs.Empty, this.txtCrearApellidosProveedor.Text, this.txtCrearCiudadProveedor.Text, this.txtCrearDireccionProveedor.Text, this.txtCrearDNIProveedor.Text, this.txtCrearEmailProveedor.Text, this.txtCrearNombreProveedor.Text, this.txtCrearPaisProveedor.Text, this.txtCrearPoblacionProveedor.Text, this.txtCrearTelefonoProveedor.Text);

        }
    }
}
