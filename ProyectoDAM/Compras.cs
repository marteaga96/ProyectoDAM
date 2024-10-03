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
            try
            {
                // Crear una nueva conexión usando las credenciales del login
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "INSERT INTO COMPRAS (COMPRADO_POR, NOMBRE_PROVEEDOR, NOMBRE_PRODUCTO, CANTIDAD_COMPRADA) " +
                                  "VALUES (@compradoPor, @nombreProveedor, @nombreProducto, @cantidadComprada)",
                    Connection = conexion.datos_conexion
                };

                // Agregar parámetros a la consulta
                comando.Parameters.AddWithValue("@compradoPor", variablesGlobales.usuario); // Suponiendo que tienes un TextBox llamado txtCompradoPor
                comando.Parameters.AddWithValue("@nombreProveedor", txtCrearNombreProveedor.Text); // Suponiendo que tienes un TextBox llamado txtNombreProveedor
                comando.Parameters.AddWithValue("@nombreProducto", txtCrearNombreProducto.Text); // Suponiendo que tienes un TextBox llamado txtNombreProducto
                comando.Parameters.AddWithValue("@cantidadComprada", int.Parse(txtCrearCantidadComprada.Text)); // Suponiendo que tienes un TextBox llamado txtCantidadComprada

                if (conexion.conAbrir())
                {
                    // Ejecutar la consulta de inserción
                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Compra insertada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar la compra.");
                    }
                    conexion.conCerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_confirmarModificacion_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear una nueva conexión usando las credenciales del login
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "UPDATE COMPRAS SET " +
                                  "NOMBRE_PROVEEDOR = @nombreProveedor, " +
                                  "NOMBRE_PRODUCTO = @nombreProducto, " +
                                  "CANTIDAD_COMPRADA = @cantidadComprada " +
                                  "WHERE ID_COMPRA = @txtID",// Condición para actualizar
                    Connection = conexion.datos_conexion
                };

                // Usar la variable global para el campo "COMPRADO_POR" e   n la condición WHERE
                comando.Parameters.AddWithValue("@compradoPor", variablesGlobales.usuario);

                comando.Parameters.AddWithValue("@txtID", int.Parse(txtCrearID.Text));

                // Agregar parámetros para los campos que se desean actualizar
                comando.Parameters.AddWithValue("@nombreProveedor", txtModificarProveedor.Text); // Suponiendo que tienes un TextBox llamado txtNombreProveedor
                comando.Parameters.AddWithValue("@nombreProducto", txtModificarProducto.Text); // Suponiendo que tienes un TextBox llamado txtNombreProducto
                comando.Parameters.AddWithValue("@cantidadComprada", int.Parse(txtModificarCantidad.Text)); // Suponiendo que tienes un TextBox llamado txtCantidadComprada

                if (conexion.conAbrir())
                {
                    // Ejecutar la consulta de actualización
                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Compra actualizada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la compra.");
                    }
                    conexion.conCerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
