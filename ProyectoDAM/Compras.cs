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

        private void btnCONSULTA_HISTORIAL_Click(object sender, EventArgs e)
        {
            Consultas.consulta_historial_compras(this, EventArgs.Empty, this.datagridView1);

            try
            {
                // Pasar datos de login a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "SELECT NOMBRE_USUARIO FROM USUARIOS", // Consulta para obtener NOMBRE_USUARIO
                    Connection = conexion.datos_conexion
                };

                if (conexion.conAbrir())
                {
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        // Hacer el DataTable para almacenar los resultados
                        DataTable dataTable = new DataTable();
                        dataTable.Load(Reader);  // Cargar los datos del SqlDataReader al DataTable

                        // Limpiar el ComboBox antes de llenarlo
                        comboBox1.Items.Clear();

                        // Rellenar el ComboBox con los nombres de usuario
                        foreach (DataRow row in dataTable.Rows)
                        {
                            comboBox1.Items.Add(row["NOMBRE_USUARIO"].ToString());
                        }
                    }
                    conexion.conCerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_CREAR_COMPRA_Click(object sender, EventArgs e)
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
                comando.Parameters.AddWithValue("@nombreProveedor", txtNombreProveedor.Text); // Suponiendo que tienes un TextBox llamado txtNombreProveedor
                comando.Parameters.AddWithValue("@nombreProducto", txtNombreProducto.Text); // Suponiendo que tienes un TextBox llamado txtNombreProducto
                comando.Parameters.AddWithValue("@cantidadComprada", int.Parse(txtCantidadComprada.Text)); // Suponiendo que tienes un TextBox llamado txtCantidadComprada

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

        private void btn_MODIFICAR_COMPRA_Click(object sender, EventArgs e)
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

                comando.Parameters.AddWithValue("@txtID", int.Parse(txtID.Text));

                // Agregar parámetros para los campos que se desean actualizar
                comando.Parameters.AddWithValue("@nombreProveedor", txtNombreProveedor.Text); // Suponiendo que tienes un TextBox llamado txtNombreProveedor
                comando.Parameters.AddWithValue("@nombreProducto", txtNombreProducto.Text); // Suponiendo que tienes un TextBox llamado txtNombreProducto
                comando.Parameters.AddWithValue("@cantidadComprada", int.Parse(txtCantidadComprada.Text)); // Suponiendo que tienes un TextBox llamado txtCantidadComprada

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

        private void Compras_Load(object sender, EventArgs e)
        {

        }
    }
}
