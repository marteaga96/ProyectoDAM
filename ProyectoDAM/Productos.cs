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
    public partial class Productos : Form
    {
        public Productos()
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

        private void btn_CONSULTAR_HISTORIAL_Click(object sender, EventArgs e)
        {
            Consultas.consulta_productos(this, EventArgs.Empty, this.datagridPRODUCTOS);
            gestionOpciones("CONSULTA");
        }

        private void btnCREAR_PRODUCTO_Click(object sender, EventArgs e)
        {
            gestionOpciones("CREAR");
        }

        private void btn_crearProducto_Click(object sender, EventArgs e)
        {
            Consultas.crear_producto(this, EventArgs.Empty, this.txtCrearNombreProducto.Text, this.txtCrearIvaProducto.Text, this.txtCrearPrecioProducto.Text);
        }

        private void btn_MODIFICAR_PRODUCTO_Click(object sender, EventArgs e)
        {
            gestionOpciones("MODIFICAR");
        }

        private void btnConfirmarModificarProducto_Click(object sender, EventArgs e)
        {
            Consultas.modificar_producto(this, EventArgs.Empty, this.txtIDModificarProducto.Text, this.txtNombreModificarProducto.Text, this.txtModificarPrecioProducto.Text, this.txtModificarIVAProducto.Text);
        }
    }
}
