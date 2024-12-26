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
    public partial class Ventas : Form
    {
        public Ventas()
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
            gestionOpciones("CONSULTA");
            Consultas.consulta_historial_ventas(this, EventArgs.Empty, this.datagridVENTAS);
        }

        private void btnCREAR_VENTA_Click(object sender, EventArgs e)
        {
            gestionOpciones("CREAR");
        }


        private void btn_confirmarVenta_Click(object sender, EventArgs e)
        {
            Consultas.crear_venta(this, EventArgs.Empty, this.txtCrearNombreCliente.Text, this.txtCrearNombreProducto.Text, this.txtCrearCantidadVendida.Text);
        }

        private void btn_MODIFICAR_VENTA_Click(object sender, EventArgs e)
        {
            gestionOpciones("MODIFICAR");
        }

        private void btn_confirmarModificacion_Click(object sender, EventArgs e)
        {
            Consultas.modificar_venta(this, EventArgs.Empty, this.txtCrearID.Text, this.txtModificarCliente.Text, this.txtModificarProducto.Text, this.txtModificarCantidad.Text);

        }

        private void btn_MODO_OSCURO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OSCURO");
            this.BackColor = Color.Black;
            btn_CONSULTAR_HISTORIAL.BackColor = Color.Black;
            btn_CONSULTAR_HISTORIAL.ForeColor = Color.White;
            btnCREAR_VENTA.BackColor = Color.Black;
            btnCREAR_VENTA.ForeColor = Color.White;
            btn_MODIFICAR_VENTA.BackColor = Color.Black;
            btn_MODIFICAR_VENTA.ForeColor = Color.White;
        }
    }
}
