using Microsoft.Data.SqlClient;
using ProyectoDAM.DDBB;
using ProyectoDAM.Resources;
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
    public partial class Compras : Form
    {
        public Compras()
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

        private void btnCONSULTA_HISTORIAL_Click(object sender, EventArgs e)
        {
            gestionOpciones("CONSULTA");
            Consultas.consulta_historial_compras(this, EventArgs.Empty, this.datagridView1);
        }

        private void btn_CREAR_COMPRA_Click(object sender, EventArgs e)
        {
            gestionOpciones("CREAR");
        }

        private void btn_MODIFICAR_COMPRA_Click(object sender, EventArgs e)
        {
            gestionOpciones("MODIFICAR");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consultas.crear_compra(this, EventArgs.Empty, this.txtCrearNombreProveedor.Text, this.txtCrearNombreProducto.Text, this.txtCrearCantidadComprada.Text);
            
        }

        private void btn_confirmarModificacion_Click(object sender, EventArgs e)
        {
            Consultas.modificar_compra(this, EventArgs.Empty, this.txtCrearID.Text, this.txtModificarProveedor.Text, this.txtModificarProducto.Text, this.txtModificarCantidad.Text);
            
        }
    }
}
