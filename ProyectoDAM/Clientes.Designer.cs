namespace ProyectoDAM
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_MODIFICAR_CLIENTE = new Button();
            btn_CREAR_CLIENTE = new Button();
            btn_CONSULTA_CLIENTES = new Button();
            pnlCONSULTA = new Panel();
            datagridCLIENTES = new DataGridView();
            lblTituloConsulta = new Label();
            pnlCREAR = new Panel();
            lbl_poblacion_cliente = new Label();
            txtCrearPoblacionCliente = new TextBox();
            lbl_ciudad_cliente = new Label();
            txtCrearCiudadCliente = new TextBox();
            lbl_pais_cliente = new Label();
            txtCrearPaisCliente = new TextBox();
            lbl_email_cliente = new Label();
            txtCrearEmailCliente = new TextBox();
            lbl_direccion_cliente = new Label();
            txtCrearDireccionCliente = new TextBox();
            lbl_telefono_cliente = new Label();
            txtCrearTelefonoCliente = new TextBox();
            lblDescCrearCompra = new Label();
            btn_confirmarCliente = new Button();
            lbl_apellido_cliente = new Label();
            lbl_nombre_cliente = new Label();
            lbl_dnicif_cliente = new Label();
            lblTitutloCrearCompra = new Label();
            txtCrearDNICliente = new TextBox();
            txtCrearApellidosCliente = new TextBox();
            txtCrearNombreCliente = new TextBox();
            pnlCONSULTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridCLIENTES).BeginInit();
            pnlCREAR.SuspendLayout();
            SuspendLayout();
            // 
            // btn_MODIFICAR_CLIENTE
            // 
            btn_MODIFICAR_CLIENTE.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MODIFICAR_CLIENTE.Location = new Point(226, 646);
            btn_MODIFICAR_CLIENTE.Name = "btn_MODIFICAR_CLIENTE";
            btn_MODIFICAR_CLIENTE.Size = new Size(484, 126);
            btn_MODIFICAR_CLIENTE.TabIndex = 6;
            btn_MODIFICAR_CLIENTE.Text = "MODIFICAR CLIENTE";
            btn_MODIFICAR_CLIENTE.UseVisualStyleBackColor = true;
            btn_MODIFICAR_CLIENTE.Click += btn_MODIFICAR_CLIENTE_Click;
            // 
            // btn_CREAR_CLIENTE
            // 
            btn_CREAR_CLIENTE.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CREAR_CLIENTE.Location = new Point(226, 372);
            btn_CREAR_CLIENTE.Name = "btn_CREAR_CLIENTE";
            btn_CREAR_CLIENTE.Size = new Size(484, 126);
            btn_CREAR_CLIENTE.TabIndex = 5;
            btn_CREAR_CLIENTE.Text = "CREAR CLIENTE";
            btn_CREAR_CLIENTE.UseVisualStyleBackColor = true;
            btn_CREAR_CLIENTE.Click += btn_CREAR_CLIENTE_Click;
            // 
            // btn_CONSULTA_CLIENTES
            // 
            btn_CONSULTA_CLIENTES.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CONSULTA_CLIENTES.Location = new Point(226, 118);
            btn_CONSULTA_CLIENTES.Name = "btn_CONSULTA_CLIENTES";
            btn_CONSULTA_CLIENTES.Size = new Size(484, 126);
            btn_CONSULTA_CLIENTES.TabIndex = 4;
            btn_CONSULTA_CLIENTES.Text = "CONSULTAR CLIENTES";
            btn_CONSULTA_CLIENTES.UseVisualStyleBackColor = true;
            btn_CONSULTA_CLIENTES.Click += btn_CONSULTA_CLIENTES_Click;
            // 
            // pnlCONSULTA
            // 
            pnlCONSULTA.BackColor = SystemColors.Control;
            pnlCONSULTA.Controls.Add(datagridCLIENTES);
            pnlCONSULTA.Controls.Add(lblTituloConsulta);
            pnlCONSULTA.Location = new Point(759, 53);
            pnlCONSULTA.Name = "pnlCONSULTA";
            pnlCONSULTA.Size = new Size(1150, 896);
            pnlCONSULTA.TabIndex = 12;
            pnlCONSULTA.Visible = false;
            // 
            // datagridCLIENTES
            // 
            datagridCLIENTES.AllowUserToAddRows = false;
            datagridCLIENTES.AllowUserToDeleteRows = false;
            datagridCLIENTES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridCLIENTES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridCLIENTES.Location = new Point(27, 243);
            datagridCLIENTES.MultiSelect = false;
            datagridCLIENTES.Name = "datagridCLIENTES";
            datagridCLIENTES.ReadOnly = true;
            datagridCLIENTES.RowHeadersVisible = false;
            datagridCLIENTES.RowTemplate.Height = 25;
            datagridCLIENTES.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridCLIENTES.Size = new Size(1100, 392);
            datagridCLIENTES.TabIndex = 4;
            // 
            // lblTituloConsulta
            // 
            lblTituloConsulta.AutoSize = true;
            lblTituloConsulta.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTituloConsulta.Location = new Point(519, 65);
            lblTituloConsulta.Name = "lblTituloConsulta";
            lblTituloConsulta.Size = new Size(184, 52);
            lblTituloConsulta.TabIndex = 0;
            lblTituloConsulta.Text = "CLIENTES";
            // 
            // pnlCREAR
            // 
            pnlCREAR.Controls.Add(lbl_poblacion_cliente);
            pnlCREAR.Controls.Add(txtCrearPoblacionCliente);
            pnlCREAR.Controls.Add(lbl_ciudad_cliente);
            pnlCREAR.Controls.Add(txtCrearCiudadCliente);
            pnlCREAR.Controls.Add(lbl_pais_cliente);
            pnlCREAR.Controls.Add(txtCrearPaisCliente);
            pnlCREAR.Controls.Add(lbl_email_cliente);
            pnlCREAR.Controls.Add(txtCrearEmailCliente);
            pnlCREAR.Controls.Add(lbl_direccion_cliente);
            pnlCREAR.Controls.Add(txtCrearDireccionCliente);
            pnlCREAR.Controls.Add(lbl_telefono_cliente);
            pnlCREAR.Controls.Add(txtCrearTelefonoCliente);
            pnlCREAR.Controls.Add(lblDescCrearCompra);
            pnlCREAR.Controls.Add(btn_confirmarCliente);
            pnlCREAR.Controls.Add(lbl_apellido_cliente);
            pnlCREAR.Controls.Add(lbl_nombre_cliente);
            pnlCREAR.Controls.Add(lbl_dnicif_cliente);
            pnlCREAR.Controls.Add(lblTitutloCrearCompra);
            pnlCREAR.Controls.Add(txtCrearDNICliente);
            pnlCREAR.Controls.Add(txtCrearApellidosCliente);
            pnlCREAR.Controls.Add(txtCrearNombreCliente);
            pnlCREAR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pnlCREAR.Location = new Point(759, 53);
            pnlCREAR.Name = "pnlCREAR";
            pnlCREAR.Size = new Size(1005, 896);
            pnlCREAR.TabIndex = 13;
            pnlCREAR.Visible = false;
            // 
            // lbl_poblacion_cliente
            // 
            lbl_poblacion_cliente.AutoSize = true;
            lbl_poblacion_cliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_poblacion_cliente.Location = new Point(772, 378);
            lbl_poblacion_cliente.Name = "lbl_poblacion_cliente";
            lbl_poblacion_cliente.Size = new Size(99, 25);
            lbl_poblacion_cliente.TabIndex = 26;
            lbl_poblacion_cliente.Text = "Población:";
            // 
            // txtCrearPoblacionCliente
            // 
            txtCrearPoblacionCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearPoblacionCliente.Location = new Point(876, 376);
            txtCrearPoblacionCliente.Name = "txtCrearPoblacionCliente";
            txtCrearPoblacionCliente.Size = new Size(100, 32);
            txtCrearPoblacionCliente.TabIndex = 25;
            // 
            // lbl_ciudad_cliente
            // 
            lbl_ciudad_cliente.AutoSize = true;
            lbl_ciudad_cliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ciudad_cliente.Location = new Point(560, 377);
            lbl_ciudad_cliente.Name = "lbl_ciudad_cliente";
            lbl_ciudad_cliente.Size = new Size(76, 25);
            lbl_ciudad_cliente.TabIndex = 24;
            lbl_ciudad_cliente.Text = "Ciudad:";
            // 
            // txtCrearCiudadCliente
            // 
            txtCrearCiudadCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearCiudadCliente.Location = new Point(652, 376);
            txtCrearCiudadCliente.Name = "txtCrearCiudadCliente";
            txtCrearCiudadCliente.Size = new Size(100, 32);
            txtCrearCiudadCliente.TabIndex = 23;
            // 
            // lbl_pais_cliente
            // 
            lbl_pais_cliente.AutoSize = true;
            lbl_pais_cliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pais_cliente.Location = new Point(372, 375);
            lbl_pais_cliente.Name = "lbl_pais_cliente";
            lbl_pais_cliente.Size = new Size(49, 25);
            lbl_pais_cliente.TabIndex = 22;
            lbl_pais_cliente.Text = "País:";
            // 
            // txtCrearPaisCliente
            // 
            txtCrearPaisCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearPaisCliente.Location = new Point(426, 374);
            txtCrearPaisCliente.Name = "txtCrearPaisCliente";
            txtCrearPaisCliente.Size = new Size(100, 32);
            txtCrearPaisCliente.TabIndex = 21;
            // 
            // lbl_email_cliente
            // 
            lbl_email_cliente.AutoSize = true;
            lbl_email_cliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_email_cliente.Location = new Point(46, 376);
            lbl_email_cliente.Name = "lbl_email_cliente";
            lbl_email_cliente.Size = new Size(63, 25);
            lbl_email_cliente.TabIndex = 20;
            lbl_email_cliente.Text = "eMail:";
            // 
            // txtCrearEmailCliente
            // 
            txtCrearEmailCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearEmailCliente.Location = new Point(114, 373);
            txtCrearEmailCliente.Name = "txtCrearEmailCliente";
            txtCrearEmailCliente.Size = new Size(250, 32);
            txtCrearEmailCliente.TabIndex = 19;
            // 
            // lbl_direccion_cliente
            // 
            lbl_direccion_cliente.AutoSize = true;
            lbl_direccion_cliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_direccion_cliente.Location = new Point(45, 458);
            lbl_direccion_cliente.Name = "lbl_direccion_cliente";
            lbl_direccion_cliente.Size = new Size(157, 25);
            lbl_direccion_cliente.TabIndex = 18;
            lbl_direccion_cliente.Text = "Dirección cliente:";
            // 
            // txtCrearDireccionCliente
            // 
            txtCrearDireccionCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearDireccionCliente.Location = new Point(205, 456);
            txtCrearDireccionCliente.Name = "txtCrearDireccionCliente";
            txtCrearDireccionCliente.Size = new Size(234, 32);
            txtCrearDireccionCliente.TabIndex = 17;
            // 
            // lbl_telefono_cliente
            // 
            lbl_telefono_cliente.AutoSize = true;
            lbl_telefono_cliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_telefono_cliente.Location = new Point(775, 291);
            lbl_telefono_cliente.Name = "lbl_telefono_cliente";
            lbl_telefono_cliente.Size = new Size(88, 25);
            lbl_telefono_cliente.TabIndex = 16;
            lbl_telefono_cliente.Text = "Teléfono:";
            // 
            // txtCrearTelefonoCliente
            // 
            txtCrearTelefonoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearTelefonoCliente.Location = new Point(875, 287);
            txtCrearTelefonoCliente.Name = "txtCrearTelefonoCliente";
            txtCrearTelefonoCliente.Size = new Size(100, 29);
            txtCrearTelefonoCliente.TabIndex = 15;
            // 
            // lblDescCrearCompra
            // 
            lblDescCrearCompra.AutoSize = true;
            lblDescCrearCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescCrearCompra.Location = new Point(369, 106);
            lblDescCrearCompra.Name = "lblDescCrearCompra";
            lblDescCrearCompra.Size = new Size(314, 21);
            lblDescCrearCompra.TabIndex = 14;
            lblDescCrearCompra.Text = "Introduce los datos para crear el cliente:";
            // 
            // btn_confirmarCliente
            // 
            btn_confirmarCliente.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_confirmarCliente.Location = new Point(427, 686);
            btn_confirmarCliente.Name = "btn_confirmarCliente";
            btn_confirmarCliente.Size = new Size(201, 87);
            btn_confirmarCliente.TabIndex = 14;
            btn_confirmarCliente.Text = "CREAR CLIENTE";
            btn_confirmarCliente.UseVisualStyleBackColor = true;
            // 
            // lbl_apellido_cliente
            // 
            lbl_apellido_cliente.AutoSize = true;
            lbl_apellido_cliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_apellido_cliente.Location = new Point(553, 289);
            lbl_apellido_cliente.Name = "lbl_apellido_cliente";
            lbl_apellido_cliente.Size = new Size(94, 25);
            lbl_apellido_cliente.TabIndex = 13;
            lbl_apellido_cliente.Text = "Apellidos:";
            // 
            // lbl_nombre_cliente
            // 
            lbl_nombre_cliente.AutoSize = true;
            lbl_nombre_cliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombre_cliente.Location = new Point(335, 288);
            lbl_nombre_cliente.Name = "lbl_nombre_cliente";
            lbl_nombre_cliente.Size = new Size(85, 25);
            lbl_nombre_cliente.TabIndex = 12;
            lbl_nombre_cliente.Text = "Nombre:";
            // 
            // lbl_dnicif_cliente
            // 
            lbl_dnicif_cliente.AutoSize = true;
            lbl_dnicif_cliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_dnicif_cliente.Location = new Point(46, 287);
            lbl_dnicif_cliente.Name = "lbl_dnicif_cliente";
            lbl_dnicif_cliente.Size = new Size(142, 25);
            lbl_dnicif_cliente.TabIndex = 11;
            lbl_dnicif_cliente.Text = "DNI/CIF cliente:";
            // 
            // lblTitutloCrearCompra
            // 
            lblTitutloCrearCompra.AutoSize = true;
            lblTitutloCrearCompra.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitutloCrearCompra.Location = new Point(379, 23);
            lblTitutloCrearCompra.Name = "lblTitutloCrearCompra";
            lblTitutloCrearCompra.Size = new Size(289, 52);
            lblTitutloCrearCompra.TabIndex = 0;
            lblTitutloCrearCompra.Text = "CREAR CLIENTE";
            // 
            // txtCrearDNICliente
            // 
            txtCrearDNICliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearDNICliente.Location = new Point(204, 287);
            txtCrearDNICliente.Name = "txtCrearDNICliente";
            txtCrearDNICliente.Size = new Size(100, 32);
            txtCrearDNICliente.TabIndex = 7;
            // 
            // txtCrearApellidosCliente
            // 
            txtCrearApellidosCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearApellidosCliente.Location = new Point(653, 287);
            txtCrearApellidosCliente.Name = "txtCrearApellidosCliente";
            txtCrearApellidosCliente.Size = new Size(100, 29);
            txtCrearApellidosCliente.TabIndex = 9;
            // 
            // txtCrearNombreCliente
            // 
            txtCrearNombreCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearNombreCliente.Location = new Point(427, 287);
            txtCrearNombreCliente.Name = "txtCrearNombreCliente";
            txtCrearNombreCliente.Size = new Size(100, 32);
            txtCrearNombreCliente.TabIndex = 8;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(pnlCREAR);
            Controls.Add(pnlCONSULTA);
            Controls.Add(btn_MODIFICAR_CLIENTE);
            Controls.Add(btn_CREAR_CLIENTE);
            Controls.Add(btn_CONSULTA_CLIENTES);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Clientes";
            Text = "Clientes";
            pnlCONSULTA.ResumeLayout(false);
            pnlCONSULTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridCLIENTES).EndInit();
            pnlCREAR.ResumeLayout(false);
            pnlCREAR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_MODIFICAR_CLIENTE;
        private Button btn_CREAR_CLIENTE;
        private Button btn_CONSULTA_CLIENTES;
        private Panel pnlCONSULTA;
        private DataGridView datagridCLIENTES;
        private Label lblTituloConsulta;
        private Panel pnlCREAR;
        private Label lbl_telefono_cliente;
        private TextBox txtCrearTelefonoCliente;
        private Label lblDescCrearCompra;
        private Button btn_confirmarCliente;
        private Label lbl_apellido_cliente;
        private Label lbl_nombre_cliente;
        private Label lbl_dnicif_cliente;
        private Label lblTitutloCrearCompra;
        private TextBox txtCrearDNICliente;
        private TextBox txtCrearApellidosCliente;
        private TextBox txtCrearNombreCliente;
        private Label lbl_poblacion_cliente;
        private TextBox txtCrearPoblacionCliente;
        private Label lbl_ciudad_cliente;
        private TextBox txtCrearCiudadCliente;
        private Label lbl_pais_cliente;
        private TextBox txtCrearPaisCliente;
        private Label lbl_email_cliente;
        private TextBox txtCrearEmailCliente;
        private Label lbl_direccion_cliente;
        private TextBox txtCrearDireccionCliente;
    }
}