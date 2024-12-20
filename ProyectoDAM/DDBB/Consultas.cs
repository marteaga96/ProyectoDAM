using Microsoft.Data.SqlClient;
using ProyectoDAM.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDAM.DDBB
{
    public static class Consultas
    {
        public static void consulta_historial_compras(object sender, EventArgs e, DataGridView dataGridView1)
        {
            try
            {
                // Pasar datos de login a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = Properties.Resources.consultaCompras,
                    Connection = conexion.datos_conexion
                };

                if (conexion.conAbrir())
                {
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        // Crear un DataTable para almacenar los resultados
                        DataTable dataTable = new DataTable();
                        dataTable.Load(Reader);  // Cargar los datos del SqlDataReader al DataTable

                        // Asignar el DataTable como DataSource del DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    conexion.conCerrar();
                }
                else
                {
                    MessageBox.Show("Error al abrir la conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void crear_compra(object sender, EventArgs e, String txtCrearNombreProveedor, String txtCrearNombreProducto, String txtCrearCantidadComprada)
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
                comando.Parameters.AddWithValue("@nombreProveedor", txtCrearNombreProveedor); // Suponiendo que tienes un TextBox llamado txtNombreProveedor
                comando.Parameters.AddWithValue("@nombreProducto", txtCrearNombreProducto); // Suponiendo que tienes un TextBox llamado txtNombreProducto
                comando.Parameters.AddWithValue("@cantidadComprada", int.Parse(txtCrearCantidadComprada)); // Suponiendo que tienes un TextBox llamado txtCantidadComprada

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

        public static void modificar_compra(object sender, EventArgs e, String txtCrearID, String txtModificarProveedor, String txtModificarProducto, String txtModificarCantidad)
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

                comando.Parameters.AddWithValue("@txtID", int.Parse(txtCrearID));

                // Agregar parámetros para los campos que se desean actualizar
                comando.Parameters.AddWithValue("@nombreProveedor", txtModificarProveedor); // Suponiendo que tienes un TextBox llamado txtNombreProveedor
                comando.Parameters.AddWithValue("@nombreProducto", txtModificarProducto); // Suponiendo que tienes un TextBox llamado txtNombreProducto
                comando.Parameters.AddWithValue("@cantidadComprada", int.Parse(txtModificarCantidad)); // Suponiendo que tienes un TextBox llamado txtCantidadComprada

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

        public static void consulta_historial_ventas(object sender, EventArgs e, DataGridView dataGridView1)
        {
            try
            {
                // Pasar datos de login a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = Properties.Resources.consultaVentas,
                    Connection = conexion.datos_conexion
                };

                if (conexion.conAbrir())
                {
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        // Crear un DataTable para almacenar los resultados
                        DataTable dataTable = new DataTable();
                        dataTable.Load(Reader);  // Cargar los datos del SqlDataReader al DataTable

                        // Asignar el DataTable como DataSource del DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    conexion.conCerrar();
                }
                else
                {
                    MessageBox.Show("Error al abrir la conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void crear_venta(object sender, EventArgs e, String txtCrearNombreCliente, String txtCrearNombreProducto, String txtCrearCantidadVendida)
        {
            try
            {
                // Crear una nueva conexión usando las credenciales del login
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "INSERT INTO VENTAS (VENDIDO_POR, NOMBRE_CLIENTE, NOMBRE_PRODUCTO, CANTIDAD_VENDIDA) " +
                                  "VALUES (@vendidoPor, @nombreCliente, @nombreProducto, @cantidadVendida)",
                    Connection = conexion.datos_conexion
                };

                // Agregar parámetros a la consulta
                comando.Parameters.AddWithValue("@vendidoPor", variablesGlobales.usuario); // Suponiendo que tienes un TextBox llamado txtCompradoPor
                comando.Parameters.AddWithValue("@nombreCliente", txtCrearNombreCliente); // Suponiendo que tienes un TextBox llamado txtNombreProveedor
                comando.Parameters.AddWithValue("@nombreProducto", txtCrearNombreProducto); // Suponiendo que tienes un TextBox llamado txtNombreProducto
                comando.Parameters.AddWithValue("@cantidadVendida", int.Parse(txtCrearCantidadVendida)); // Suponiendo que tienes un TextBox llamado txtCantidadComprada

                if (conexion.conAbrir())
                {
                    // Ejecutar la consulta de inserción
                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Venta insertada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo insertar la venta.");
                    }
                    conexion.conCerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void consulta_inventario(object sender, EventArgs e, DataGridView dataGridView1)
        {
            try
            {
                // Pasar datos de login a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = Properties.Resources.consultaAlmacen,
                    Connection = conexion.datos_conexion
                };

                if (conexion.conAbrir())
                {
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        // Crear un DataTable para almacenar los resultados
                        DataTable dataTable = new DataTable();
                        dataTable.Load(Reader);  // Cargar los datos del SqlDataReader al DataTable

                        // Asignar el DataTable como DataSource del DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    conexion.conCerrar();
                }
                else
                {
                    MessageBox.Show("Error al abrir la conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void modificar_venta(object sender, EventArgs e, String txtCrearID, String txtModificarCliente, String txtModificarProducto, String txtModificarCantidad)
        {
            try
            {
                // Crear una nueva conexión usando las credenciales del login
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "UPDATE VENTAS SET " +
                                  "NOMBRE_CLIENTE = @nombreCliente, " +
                                  "NOMBRE_PRODUCTO = @nombreProducto, " +
                                  "CANTIDAD_VENDIDA = @cantidadVendida " +
                                  "WHERE ID_VENTA = @txtID",// Condición para actualizar
                    Connection = conexion.datos_conexion
                };

                // Usar la variable global para el campo "COMPRADO_POR" e   n la condición WHERE
                comando.Parameters.AddWithValue("@vendidoPor", variablesGlobales.usuario);

                comando.Parameters.AddWithValue("@txtID", int.Parse(txtCrearID));

                // Agregar parámetros para los campos que se desean actualizar
                comando.Parameters.AddWithValue("@nombreCliente", txtModificarCliente); // Suponiendo que tienes un TextBox llamado txtNombreProveedor
                comando.Parameters.AddWithValue("@nombreProducto", txtModificarProducto); // Suponiendo que tienes un TextBox llamado txtNombreProducto
                comando.Parameters.AddWithValue("@cantidadVendida", int.Parse(txtModificarCantidad)); // Suponiendo que tienes un TextBox llamado txtCantidadComprada

                if (conexion.conAbrir())
                {
                    // Ejecutar la consulta de actualización
                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Venta actualizada correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar la venta.");
                    }
                    conexion.conCerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void consulta_productos(object sender, EventArgs e, DataGridView dataGridView1)
        {
            try
            {
                // Pasar datos de login a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = Properties.Resources.consultaProductos,
                    Connection = conexion.datos_conexion
                };

                if (conexion.conAbrir())
                {
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        // Crear un DataTable para almacenar los resultados
                        DataTable dataTable = new DataTable();
                        dataTable.Load(Reader);  // Cargar los datos del SqlDataReader al DataTable

                        // Asignar el DataTable como DataSource del DataGridView
                        dataGridView1.DataSource = dataTable;
                    }
                    conexion.conCerrar();
                }
                else
                {
                    MessageBox.Show("Error al abrir la conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void crear_producto(object sender, EventArgs e, String txtCrearNombreProducto, String txtCrearIvaProducto, String txtCrearPrecioProducto)
        {
            try
            {
                // Crear una nueva conexión usando las credenciales del login
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "INSERT INTO PRODUCTOS (NOMBRE_PRODUCTO, IVA_PRODUCTO, PRECIO_SIN_IVA_PRODUCTO) " +
                                  "VALUES (@nombreProducto, @ivaProducto, @precioTotalProducto)",
                    Connection = conexion.datos_conexion
                };

                // Agregar parámetros a la consulta
                comando.Parameters.AddWithValue("@nombreProducto", txtCrearNombreProducto); // Suponiendo que tienes un TextBox llamado txtCompradoPor
                comando.Parameters.AddWithValue("@ivaProducto", txtCrearIvaProducto); // Suponiendo que tienes un TextBox llamado txtNombreProveedor
                comando.Parameters.AddWithValue("@precioTotalProducto", int.Parse(txtCrearPrecioProducto)); // Suponiendo que tienes un TextBox llamado txtNombreProducto

                if (conexion.conAbrir())
                {
                    // Ejecutar la consulta de inserción
                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto creado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo crear el producto.");
                    }
                    conexion.conCerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void modificar_producto(object sender, EventArgs e, String txtIDModificarProducto, String txtNombreModificarProducto, String txtModificarPrecioProducto, String txtModificarIVAProducto)
        {
            try
            {
                // Crear una nueva conexión usando las credenciales del login
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = "UPDATE PRODUCTOS SET " +
                                  "NOMBRE_PRODUCTO = @txtNombreModificarProducto, " +
                                  "IVA_PRODUCTO = @txtModificarIVAProducto, " +
                                  "PRECIO_SIN_IVA_PRODUCTO = @txtModificarPrecioProducto " +
                                  "WHERE ID_PRODUCTO = @txtIDModificarProducto",// Condición para actualizar
                    Connection = conexion.datos_conexion
                };

                comando.Parameters.AddWithValue("@txtIDModificarProducto", int.Parse(txtIDModificarProducto));

                // Agregar parámetros para los campos que se desean actualizar
                comando.Parameters.AddWithValue("@txtNombreModificarProducto", txtNombreModificarProducto); // Suponiendo que tienes un TextBox llamado txtNombreProveedor
                comando.Parameters.AddWithValue("@txtModificarIVAProducto", txtModificarIVAProducto); // Suponiendo que tienes un TextBox llamado txtNombreProducto
                comando.Parameters.AddWithValue("@txtModificarPrecioProducto", int.Parse(txtModificarPrecioProducto)); // Suponiendo que tienes un TextBox llamado txtCantidadComprada

                if (conexion.conAbrir())
                {
                    // Ejecutar la consulta de actualización
                    int rowsAffected = comando.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto actualizado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el producto.");
                    }
                    conexion.conCerrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        public static void consulta_clientes(object sender, EventArgs e, DataGridView datagridCLIENTES)
        {
            try
            {
                // Pasar datos de login a la clase Conexion
                DDBB.Conexion conexion = new DDBB.Conexion(variablesGlobales.usuario, variablesGlobales.password);
                SqlCommand comando = new SqlCommand
                {
                    CommandText = Properties.Resources.consultaClientes,
                    Connection = conexion.datos_conexion
                };

                if (conexion.conAbrir())
                {
                    using (SqlDataReader Reader = comando.ExecuteReader())
                    {
                        // Crear un DataTable para almacenar los resultados
                        DataTable dataTable = new DataTable();
                        dataTable.Load(Reader);  // Cargar los datos del SqlDataReader al DataTable

                        // Asignar el DataTable como DataSource del DataGridView
                        datagridCLIENTES.DataSource = dataTable;
                    }
                    conexion.conCerrar();
                }
                else
                {
                    MessageBox.Show("Error al abrir la conexión.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }



}
