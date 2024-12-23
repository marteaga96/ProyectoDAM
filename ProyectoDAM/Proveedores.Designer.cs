namespace ProyectoDAM
{
    partial class Proveedores
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
            btn_MODIFICAR_PROVEEDORES = new Button();
            btn_CREAR_PROVEEDORES = new Button();
            btn_CONSULTA_PROVEEDORES = new Button();
            pnlCONSULTA = new Panel();
            datagridPROVEEDORES = new DataGridView();
            lblTituloConsulta = new Label();
            pnlCREAR = new Panel();
            lbl_poblacion_proveedor = new Label();
            txtCrearPoblacionProveedor = new TextBox();
            lbl_ciudad_proveedor = new Label();
            txtCrearCiudadProveedor = new TextBox();
            lbl_pais_proveedor = new Label();
            txtCrearPaisProveedor = new TextBox();
            lbl_email_proveedor = new Label();
            txtCrearEmailProveedor = new TextBox();
            lbl_direccion_proveedor = new Label();
            txtCrearDireccionProveedor = new TextBox();
            lbl_telefono_proveedor = new Label();
            txtCrearTelefonoProveedor = new TextBox();
            lblDescCrearProveedor = new Label();
            btn_confirmarProveedor = new Button();
            lbl_apellido_proveedor = new Label();
            lbl_nombre_proveedor = new Label();
            lbl_dnicif_proveedor = new Label();
            lblTitutloCrearProveedor = new Label();
            txtCrearDNIProveedor = new TextBox();
            txtCrearApellidosProveedor = new TextBox();
            txtCrearNombreProveedor = new TextBox();
            panel1 = new Panel();
            lbl_MODIFICAR_POBLACION = new Label();
            txtModificarPoblacion = new TextBox();
            lbl_MODIFICAR_CIUDAD = new Label();
            txtModificarCiudad = new TextBox();
            lbl_MODIFICAR_PAIS = new Label();
            txtModificarPais = new TextBox();
            lbl_MODIFICAR_EMAIL = new Label();
            txtModificarEmail = new TextBox();
            lbl_MODIFICAR_DIRECCION = new Label();
            txtModificarDireccion = new TextBox();
            lbl_MODIFICAR_TELEFONO = new Label();
            txtModificarTelefono = new TextBox();
            lbl_DESCRIPCION_MODIFICAR = new Label();
            btn_CONFIRMAR_MODIFICAR_PROVEEDOR = new Button();
            lbl_MODIFICAR_APELLIDOS = new Label();
            lbl_MODIFICAR_NOMBRE = new Label();
            lbl_MODIFICAR_DNICIF = new Label();
            lbl_MODIFICAR_PROVEEDOR = new Label();
            txtModificarDNICIF = new TextBox();
            txtModificarApellidos = new TextBox();
            txtModificarNombre = new TextBox();
            lbl_IDProveedor = new Label();
            txtIDProveedor = new TextBox();
            pnlCONSULTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridPROVEEDORES).BeginInit();
            pnlCREAR.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_MODIFICAR_PROVEEDORES
            // 
            btn_MODIFICAR_PROVEEDORES.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MODIFICAR_PROVEEDORES.Location = new Point(226, 646);
            btn_MODIFICAR_PROVEEDORES.Name = "btn_MODIFICAR_PROVEEDORES";
            btn_MODIFICAR_PROVEEDORES.Size = new Size(484, 126);
            btn_MODIFICAR_PROVEEDORES.TabIndex = 9;
            btn_MODIFICAR_PROVEEDORES.Text = "MODIFICAR PROVEEDOR";
            btn_MODIFICAR_PROVEEDORES.UseVisualStyleBackColor = true;
            // 
            // btn_CREAR_PROVEEDORES
            // 
            btn_CREAR_PROVEEDORES.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CREAR_PROVEEDORES.Location = new Point(226, 372);
            btn_CREAR_PROVEEDORES.Name = "btn_CREAR_PROVEEDORES";
            btn_CREAR_PROVEEDORES.Size = new Size(484, 126);
            btn_CREAR_PROVEEDORES.TabIndex = 8;
            btn_CREAR_PROVEEDORES.Text = "CREAR PROVEEDOR";
            btn_CREAR_PROVEEDORES.UseVisualStyleBackColor = true;
            btn_CREAR_PROVEEDORES.Click += btn_CREAR_PROVEEDORES_Click;
            // 
            // btn_CONSULTA_PROVEEDORES
            // 
            btn_CONSULTA_PROVEEDORES.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CONSULTA_PROVEEDORES.Location = new Point(226, 118);
            btn_CONSULTA_PROVEEDORES.Name = "btn_CONSULTA_PROVEEDORES";
            btn_CONSULTA_PROVEEDORES.Size = new Size(484, 126);
            btn_CONSULTA_PROVEEDORES.TabIndex = 7;
            btn_CONSULTA_PROVEEDORES.Text = "CONSULTAR PROVEEDORES";
            btn_CONSULTA_PROVEEDORES.UseVisualStyleBackColor = true;
            btn_CONSULTA_PROVEEDORES.Click += btn_CONSULTA_CLIENTES_Click;
            // 
            // pnlCONSULTA
            // 
            pnlCONSULTA.BackColor = SystemColors.Control;
            pnlCONSULTA.Controls.Add(datagridPROVEEDORES);
            pnlCONSULTA.Controls.Add(lblTituloConsulta);
            pnlCONSULTA.Location = new Point(759, 50);
            pnlCONSULTA.Name = "pnlCONSULTA";
            pnlCONSULTA.Size = new Size(1150, 896);
            pnlCONSULTA.TabIndex = 13;
            pnlCONSULTA.Visible = false;
            // 
            // datagridPROVEEDORES
            // 
            datagridPROVEEDORES.AllowUserToAddRows = false;
            datagridPROVEEDORES.AllowUserToDeleteRows = false;
            datagridPROVEEDORES.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridPROVEEDORES.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridPROVEEDORES.Location = new Point(27, 243);
            datagridPROVEEDORES.MultiSelect = false;
            datagridPROVEEDORES.Name = "datagridPROVEEDORES";
            datagridPROVEEDORES.ReadOnly = true;
            datagridPROVEEDORES.RowHeadersVisible = false;
            datagridPROVEEDORES.RowTemplate.Height = 25;
            datagridPROVEEDORES.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridPROVEEDORES.Size = new Size(1100, 392);
            datagridPROVEEDORES.TabIndex = 4;
            // 
            // lblTituloConsulta
            // 
            lblTituloConsulta.AutoSize = true;
            lblTituloConsulta.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTituloConsulta.Location = new Point(519, 65);
            lblTituloConsulta.Name = "lblTituloConsulta";
            lblTituloConsulta.Size = new Size(279, 52);
            lblTituloConsulta.TabIndex = 0;
            lblTituloConsulta.Text = "PROVEEDORES";
            // 
            // pnlCREAR
            // 
            pnlCREAR.Controls.Add(panel1);
            pnlCREAR.Controls.Add(lbl_poblacion_proveedor);
            pnlCREAR.Controls.Add(txtCrearPoblacionProveedor);
            pnlCREAR.Controls.Add(lbl_ciudad_proveedor);
            pnlCREAR.Controls.Add(txtCrearCiudadProveedor);
            pnlCREAR.Controls.Add(lbl_pais_proveedor);
            pnlCREAR.Controls.Add(txtCrearPaisProveedor);
            pnlCREAR.Controls.Add(lbl_email_proveedor);
            pnlCREAR.Controls.Add(txtCrearEmailProveedor);
            pnlCREAR.Controls.Add(lbl_direccion_proveedor);
            pnlCREAR.Controls.Add(txtCrearDireccionProveedor);
            pnlCREAR.Controls.Add(lbl_telefono_proveedor);
            pnlCREAR.Controls.Add(txtCrearTelefonoProveedor);
            pnlCREAR.Controls.Add(lblDescCrearProveedor);
            pnlCREAR.Controls.Add(btn_confirmarProveedor);
            pnlCREAR.Controls.Add(lbl_apellido_proveedor);
            pnlCREAR.Controls.Add(lbl_nombre_proveedor);
            pnlCREAR.Controls.Add(lbl_dnicif_proveedor);
            pnlCREAR.Controls.Add(lblTitutloCrearProveedor);
            pnlCREAR.Controls.Add(txtCrearDNIProveedor);
            pnlCREAR.Controls.Add(txtCrearApellidosProveedor);
            pnlCREAR.Controls.Add(txtCrearNombreProveedor);
            pnlCREAR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pnlCREAR.Location = new Point(759, 50);
            pnlCREAR.Name = "pnlCREAR";
            pnlCREAR.Size = new Size(1005, 896);
            pnlCREAR.TabIndex = 14;
            pnlCREAR.Visible = false;
            // 
            // lbl_poblacion_proveedor
            // 
            lbl_poblacion_proveedor.AutoSize = true;
            lbl_poblacion_proveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_poblacion_proveedor.Location = new Point(772, 378);
            lbl_poblacion_proveedor.Name = "lbl_poblacion_proveedor";
            lbl_poblacion_proveedor.Size = new Size(99, 25);
            lbl_poblacion_proveedor.TabIndex = 26;
            lbl_poblacion_proveedor.Text = "Población:";
            // 
            // txtCrearPoblacionProveedor
            // 
            txtCrearPoblacionProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearPoblacionProveedor.Location = new Point(876, 376);
            txtCrearPoblacionProveedor.Name = "txtCrearPoblacionProveedor";
            txtCrearPoblacionProveedor.Size = new Size(100, 32);
            txtCrearPoblacionProveedor.TabIndex = 25;
            // 
            // lbl_ciudad_proveedor
            // 
            lbl_ciudad_proveedor.AutoSize = true;
            lbl_ciudad_proveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_ciudad_proveedor.Location = new Point(560, 377);
            lbl_ciudad_proveedor.Name = "lbl_ciudad_proveedor";
            lbl_ciudad_proveedor.Size = new Size(76, 25);
            lbl_ciudad_proveedor.TabIndex = 24;
            lbl_ciudad_proveedor.Text = "Ciudad:";
            // 
            // txtCrearCiudadProveedor
            // 
            txtCrearCiudadProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearCiudadProveedor.Location = new Point(652, 376);
            txtCrearCiudadProveedor.Name = "txtCrearCiudadProveedor";
            txtCrearCiudadProveedor.Size = new Size(100, 32);
            txtCrearCiudadProveedor.TabIndex = 23;
            // 
            // lbl_pais_proveedor
            // 
            lbl_pais_proveedor.AutoSize = true;
            lbl_pais_proveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_pais_proveedor.Location = new Point(372, 375);
            lbl_pais_proveedor.Name = "lbl_pais_proveedor";
            lbl_pais_proveedor.Size = new Size(49, 25);
            lbl_pais_proveedor.TabIndex = 22;
            lbl_pais_proveedor.Text = "País:";
            // 
            // txtCrearPaisProveedor
            // 
            txtCrearPaisProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearPaisProveedor.Location = new Point(426, 374);
            txtCrearPaisProveedor.Name = "txtCrearPaisProveedor";
            txtCrearPaisProveedor.Size = new Size(100, 32);
            txtCrearPaisProveedor.TabIndex = 21;
            // 
            // lbl_email_proveedor
            // 
            lbl_email_proveedor.AutoSize = true;
            lbl_email_proveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_email_proveedor.Location = new Point(46, 376);
            lbl_email_proveedor.Name = "lbl_email_proveedor";
            lbl_email_proveedor.Size = new Size(63, 25);
            lbl_email_proveedor.TabIndex = 20;
            lbl_email_proveedor.Text = "eMail:";
            // 
            // txtCrearEmailProveedor
            // 
            txtCrearEmailProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearEmailProveedor.Location = new Point(114, 373);
            txtCrearEmailProveedor.Name = "txtCrearEmailProveedor";
            txtCrearEmailProveedor.Size = new Size(250, 32);
            txtCrearEmailProveedor.TabIndex = 19;
            // 
            // lbl_direccion_proveedor
            // 
            lbl_direccion_proveedor.AutoSize = true;
            lbl_direccion_proveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_direccion_proveedor.Location = new Point(45, 458);
            lbl_direccion_proveedor.Name = "lbl_direccion_proveedor";
            lbl_direccion_proveedor.Size = new Size(188, 25);
            lbl_direccion_proveedor.TabIndex = 18;
            lbl_direccion_proveedor.Text = "Dirección proveedor:";
            // 
            // txtCrearDireccionProveedor
            // 
            txtCrearDireccionProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearDireccionProveedor.Location = new Point(238, 456);
            txtCrearDireccionProveedor.Name = "txtCrearDireccionProveedor";
            txtCrearDireccionProveedor.Size = new Size(234, 32);
            txtCrearDireccionProveedor.TabIndex = 17;
            // 
            // lbl_telefono_proveedor
            // 
            lbl_telefono_proveedor.AutoSize = true;
            lbl_telefono_proveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_telefono_proveedor.Location = new Point(775, 291);
            lbl_telefono_proveedor.Name = "lbl_telefono_proveedor";
            lbl_telefono_proveedor.Size = new Size(88, 25);
            lbl_telefono_proveedor.TabIndex = 16;
            lbl_telefono_proveedor.Text = "Teléfono:";
            // 
            // txtCrearTelefonoProveedor
            // 
            txtCrearTelefonoProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearTelefonoProveedor.Location = new Point(875, 287);
            txtCrearTelefonoProveedor.Name = "txtCrearTelefonoProveedor";
            txtCrearTelefonoProveedor.Size = new Size(100, 29);
            txtCrearTelefonoProveedor.TabIndex = 15;
            // 
            // lblDescCrearProveedor
            // 
            lblDescCrearProveedor.AutoSize = true;
            lblDescCrearProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescCrearProveedor.Location = new Point(341, 96);
            lblDescCrearProveedor.Name = "lblDescCrearProveedor";
            lblDescCrearProveedor.Size = new Size(342, 21);
            lblDescCrearProveedor.TabIndex = 14;
            lblDescCrearProveedor.Text = "Introduce los datos para crear el proveedor:";
            // 
            // btn_confirmarProveedor
            // 
            btn_confirmarProveedor.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_confirmarProveedor.Location = new Point(427, 686);
            btn_confirmarProveedor.Name = "btn_confirmarProveedor";
            btn_confirmarProveedor.Size = new Size(201, 87);
            btn_confirmarProveedor.TabIndex = 14;
            btn_confirmarProveedor.Text = "CREAR PROVEEDOR";
            btn_confirmarProveedor.UseVisualStyleBackColor = true;
            btn_confirmarProveedor.Click += btn_confirmarProveedor_Click;
            // 
            // lbl_apellido_proveedor
            // 
            lbl_apellido_proveedor.AutoSize = true;
            lbl_apellido_proveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_apellido_proveedor.Location = new Point(553, 289);
            lbl_apellido_proveedor.Name = "lbl_apellido_proveedor";
            lbl_apellido_proveedor.Size = new Size(94, 25);
            lbl_apellido_proveedor.TabIndex = 13;
            lbl_apellido_proveedor.Text = "Apellidos:";
            // 
            // lbl_nombre_proveedor
            // 
            lbl_nombre_proveedor.AutoSize = true;
            lbl_nombre_proveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombre_proveedor.Location = new Point(335, 288);
            lbl_nombre_proveedor.Name = "lbl_nombre_proveedor";
            lbl_nombre_proveedor.Size = new Size(85, 25);
            lbl_nombre_proveedor.TabIndex = 12;
            lbl_nombre_proveedor.Text = "Nombre:";
            // 
            // lbl_dnicif_proveedor
            // 
            lbl_dnicif_proveedor.AutoSize = true;
            lbl_dnicif_proveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_dnicif_proveedor.Location = new Point(25, 290);
            lbl_dnicif_proveedor.Name = "lbl_dnicif_proveedor";
            lbl_dnicif_proveedor.Size = new Size(173, 25);
            lbl_dnicif_proveedor.TabIndex = 11;
            lbl_dnicif_proveedor.Text = "DNI/CIF proveedor:";
            // 
            // lblTitutloCrearProveedor
            // 
            lblTitutloCrearProveedor.AutoSize = true;
            lblTitutloCrearProveedor.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitutloCrearProveedor.Location = new Point(332, 25);
            lblTitutloCrearProveedor.Name = "lblTitutloCrearProveedor";
            lblTitutloCrearProveedor.Size = new Size(364, 52);
            lblTitutloCrearProveedor.TabIndex = 0;
            lblTitutloCrearProveedor.Text = "CREAR PROVEEDOR";
            // 
            // txtCrearDNIProveedor
            // 
            txtCrearDNIProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearDNIProveedor.Location = new Point(204, 287);
            txtCrearDNIProveedor.Name = "txtCrearDNIProveedor";
            txtCrearDNIProveedor.Size = new Size(100, 32);
            txtCrearDNIProveedor.TabIndex = 7;
            // 
            // txtCrearApellidosProveedor
            // 
            txtCrearApellidosProveedor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearApellidosProveedor.Location = new Point(653, 287);
            txtCrearApellidosProveedor.Name = "txtCrearApellidosProveedor";
            txtCrearApellidosProveedor.Size = new Size(100, 29);
            txtCrearApellidosProveedor.TabIndex = 9;
            // 
            // txtCrearNombreProveedor
            // 
            txtCrearNombreProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearNombreProveedor.Location = new Point(427, 287);
            txtCrearNombreProveedor.Name = "txtCrearNombreProveedor";
            txtCrearNombreProveedor.Size = new Size(100, 32);
            txtCrearNombreProveedor.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.Controls.Add(lbl_IDProveedor);
            panel1.Controls.Add(txtIDProveedor);
            panel1.Controls.Add(lbl_MODIFICAR_POBLACION);
            panel1.Controls.Add(txtModificarPoblacion);
            panel1.Controls.Add(lbl_MODIFICAR_CIUDAD);
            panel1.Controls.Add(txtModificarCiudad);
            panel1.Controls.Add(lbl_MODIFICAR_PAIS);
            panel1.Controls.Add(txtModificarPais);
            panel1.Controls.Add(lbl_MODIFICAR_EMAIL);
            panel1.Controls.Add(txtModificarEmail);
            panel1.Controls.Add(lbl_MODIFICAR_DIRECCION);
            panel1.Controls.Add(txtModificarDireccion);
            panel1.Controls.Add(lbl_MODIFICAR_TELEFONO);
            panel1.Controls.Add(txtModificarTelefono);
            panel1.Controls.Add(lbl_DESCRIPCION_MODIFICAR);
            panel1.Controls.Add(btn_CONFIRMAR_MODIFICAR_PROVEEDOR);
            panel1.Controls.Add(lbl_MODIFICAR_APELLIDOS);
            panel1.Controls.Add(lbl_MODIFICAR_NOMBRE);
            panel1.Controls.Add(lbl_MODIFICAR_DNICIF);
            panel1.Controls.Add(lbl_MODIFICAR_PROVEEDOR);
            panel1.Controls.Add(txtModificarDNICIF);
            panel1.Controls.Add(txtModificarApellidos);
            panel1.Controls.Add(txtModificarNombre);
            panel1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1005, 896);
            panel1.TabIndex = 27;
            panel1.Visible = false;
            // 
            // lbl_MODIFICAR_POBLACION
            // 
            lbl_MODIFICAR_POBLACION.AutoSize = true;
            lbl_MODIFICAR_POBLACION.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MODIFICAR_POBLACION.Location = new Point(772, 378);
            lbl_MODIFICAR_POBLACION.Name = "lbl_MODIFICAR_POBLACION";
            lbl_MODIFICAR_POBLACION.Size = new Size(99, 25);
            lbl_MODIFICAR_POBLACION.TabIndex = 26;
            lbl_MODIFICAR_POBLACION.Text = "Población:";
            // 
            // txtModificarPoblacion
            // 
            txtModificarPoblacion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarPoblacion.Location = new Point(876, 376);
            txtModificarPoblacion.Name = "txtModificarPoblacion";
            txtModificarPoblacion.Size = new Size(100, 32);
            txtModificarPoblacion.TabIndex = 25;
            // 
            // lbl_MODIFICAR_CIUDAD
            // 
            lbl_MODIFICAR_CIUDAD.AutoSize = true;
            lbl_MODIFICAR_CIUDAD.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MODIFICAR_CIUDAD.Location = new Point(560, 377);
            lbl_MODIFICAR_CIUDAD.Name = "lbl_MODIFICAR_CIUDAD";
            lbl_MODIFICAR_CIUDAD.Size = new Size(76, 25);
            lbl_MODIFICAR_CIUDAD.TabIndex = 24;
            lbl_MODIFICAR_CIUDAD.Text = "Ciudad:";
            // 
            // txtModificarCiudad
            // 
            txtModificarCiudad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarCiudad.Location = new Point(652, 376);
            txtModificarCiudad.Name = "txtModificarCiudad";
            txtModificarCiudad.Size = new Size(100, 32);
            txtModificarCiudad.TabIndex = 23;
            // 
            // lbl_MODIFICAR_PAIS
            // 
            lbl_MODIFICAR_PAIS.AutoSize = true;
            lbl_MODIFICAR_PAIS.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MODIFICAR_PAIS.Location = new Point(372, 375);
            lbl_MODIFICAR_PAIS.Name = "lbl_MODIFICAR_PAIS";
            lbl_MODIFICAR_PAIS.Size = new Size(49, 25);
            lbl_MODIFICAR_PAIS.TabIndex = 22;
            lbl_MODIFICAR_PAIS.Text = "País:";
            // 
            // txtModificarPais
            // 
            txtModificarPais.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarPais.Location = new Point(426, 374);
            txtModificarPais.Name = "txtModificarPais";
            txtModificarPais.Size = new Size(100, 32);
            txtModificarPais.TabIndex = 21;
            // 
            // lbl_MODIFICAR_EMAIL
            // 
            lbl_MODIFICAR_EMAIL.AutoSize = true;
            lbl_MODIFICAR_EMAIL.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MODIFICAR_EMAIL.Location = new Point(46, 376);
            lbl_MODIFICAR_EMAIL.Name = "lbl_MODIFICAR_EMAIL";
            lbl_MODIFICAR_EMAIL.Size = new Size(63, 25);
            lbl_MODIFICAR_EMAIL.TabIndex = 20;
            lbl_MODIFICAR_EMAIL.Text = "eMail:";
            // 
            // txtModificarEmail
            // 
            txtModificarEmail.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarEmail.Location = new Point(114, 373);
            txtModificarEmail.Name = "txtModificarEmail";
            txtModificarEmail.Size = new Size(250, 32);
            txtModificarEmail.TabIndex = 19;
            // 
            // lbl_MODIFICAR_DIRECCION
            // 
            lbl_MODIFICAR_DIRECCION.AutoSize = true;
            lbl_MODIFICAR_DIRECCION.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MODIFICAR_DIRECCION.Location = new Point(45, 458);
            lbl_MODIFICAR_DIRECCION.Name = "lbl_MODIFICAR_DIRECCION";
            lbl_MODIFICAR_DIRECCION.Size = new Size(188, 25);
            lbl_MODIFICAR_DIRECCION.TabIndex = 18;
            lbl_MODIFICAR_DIRECCION.Text = "Dirección proveedor:";
            // 
            // txtModificarDireccion
            // 
            txtModificarDireccion.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarDireccion.Location = new Point(238, 456);
            txtModificarDireccion.Name = "txtModificarDireccion";
            txtModificarDireccion.Size = new Size(234, 32);
            txtModificarDireccion.TabIndex = 17;
            // 
            // lbl_MODIFICAR_TELEFONO
            // 
            lbl_MODIFICAR_TELEFONO.AutoSize = true;
            lbl_MODIFICAR_TELEFONO.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MODIFICAR_TELEFONO.Location = new Point(775, 291);
            lbl_MODIFICAR_TELEFONO.Name = "lbl_MODIFICAR_TELEFONO";
            lbl_MODIFICAR_TELEFONO.Size = new Size(88, 25);
            lbl_MODIFICAR_TELEFONO.TabIndex = 16;
            lbl_MODIFICAR_TELEFONO.Text = "Teléfono:";
            // 
            // txtModificarTelefono
            // 
            txtModificarTelefono.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarTelefono.Location = new Point(875, 287);
            txtModificarTelefono.Name = "txtModificarTelefono";
            txtModificarTelefono.Size = new Size(100, 29);
            txtModificarTelefono.TabIndex = 15;
            // 
            // lbl_DESCRIPCION_MODIFICAR
            // 
            lbl_DESCRIPCION_MODIFICAR.AutoSize = true;
            lbl_DESCRIPCION_MODIFICAR.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DESCRIPCION_MODIFICAR.Location = new Point(302, 96);
            lbl_DESCRIPCION_MODIFICAR.Name = "lbl_DESCRIPCION_MODIFICAR";
            lbl_DESCRIPCION_MODIFICAR.Size = new Size(378, 21);
            lbl_DESCRIPCION_MODIFICAR.TabIndex = 14;
            lbl_DESCRIPCION_MODIFICAR.Text = "Introduce los datos para modificar el proveedor:";
            // 
            // btn_CONFIRMAR_MODIFICAR_PROVEEDOR
            // 
            btn_CONFIRMAR_MODIFICAR_PROVEEDOR.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CONFIRMAR_MODIFICAR_PROVEEDOR.Location = new Point(427, 686);
            btn_CONFIRMAR_MODIFICAR_PROVEEDOR.Name = "btn_CONFIRMAR_MODIFICAR_PROVEEDOR";
            btn_CONFIRMAR_MODIFICAR_PROVEEDOR.Size = new Size(201, 87);
            btn_CONFIRMAR_MODIFICAR_PROVEEDOR.TabIndex = 14;
            btn_CONFIRMAR_MODIFICAR_PROVEEDOR.Text = "MODIFICAR PROVEEDOR";
            btn_CONFIRMAR_MODIFICAR_PROVEEDOR.UseVisualStyleBackColor = true;
            btn_CONFIRMAR_MODIFICAR_PROVEEDOR.Click += btn_CONFIRMAR_MODIFICAR_PROVEEDOR_Click;
            // 
            // lbl_MODIFICAR_APELLIDOS
            // 
            lbl_MODIFICAR_APELLIDOS.AutoSize = true;
            lbl_MODIFICAR_APELLIDOS.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MODIFICAR_APELLIDOS.Location = new Point(553, 289);
            lbl_MODIFICAR_APELLIDOS.Name = "lbl_MODIFICAR_APELLIDOS";
            lbl_MODIFICAR_APELLIDOS.Size = new Size(94, 25);
            lbl_MODIFICAR_APELLIDOS.TabIndex = 13;
            lbl_MODIFICAR_APELLIDOS.Text = "Apellidos:";
            // 
            // lbl_MODIFICAR_NOMBRE
            // 
            lbl_MODIFICAR_NOMBRE.AutoSize = true;
            lbl_MODIFICAR_NOMBRE.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MODIFICAR_NOMBRE.Location = new Point(335, 288);
            lbl_MODIFICAR_NOMBRE.Name = "lbl_MODIFICAR_NOMBRE";
            lbl_MODIFICAR_NOMBRE.Size = new Size(85, 25);
            lbl_MODIFICAR_NOMBRE.TabIndex = 12;
            lbl_MODIFICAR_NOMBRE.Text = "Nombre:";
            // 
            // lbl_MODIFICAR_DNICIF
            // 
            lbl_MODIFICAR_DNICIF.AutoSize = true;
            lbl_MODIFICAR_DNICIF.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_MODIFICAR_DNICIF.Location = new Point(25, 290);
            lbl_MODIFICAR_DNICIF.Name = "lbl_MODIFICAR_DNICIF";
            lbl_MODIFICAR_DNICIF.Size = new Size(173, 25);
            lbl_MODIFICAR_DNICIF.TabIndex = 11;
            lbl_MODIFICAR_DNICIF.Text = "DNI/CIF proveedor:";
            // 
            // lbl_MODIFICAR_PROVEEDOR
            // 
            lbl_MODIFICAR_PROVEEDOR.AutoSize = true;
            lbl_MODIFICAR_PROVEEDOR.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lbl_MODIFICAR_PROVEEDOR.Location = new Point(287, 25);
            lbl_MODIFICAR_PROVEEDOR.Name = "lbl_MODIFICAR_PROVEEDOR";
            lbl_MODIFICAR_PROVEEDOR.Size = new Size(451, 52);
            lbl_MODIFICAR_PROVEEDOR.TabIndex = 0;
            lbl_MODIFICAR_PROVEEDOR.Text = "MODIFICAR PROVEEDOR";
            // 
            // txtModificarDNICIF
            // 
            txtModificarDNICIF.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarDNICIF.Location = new Point(204, 287);
            txtModificarDNICIF.Name = "txtModificarDNICIF";
            txtModificarDNICIF.Size = new Size(100, 32);
            txtModificarDNICIF.TabIndex = 7;
            // 
            // txtModificarApellidos
            // 
            txtModificarApellidos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarApellidos.Location = new Point(653, 287);
            txtModificarApellidos.Name = "txtModificarApellidos";
            txtModificarApellidos.Size = new Size(100, 29);
            txtModificarApellidos.TabIndex = 9;
            // 
            // txtModificarNombre
            // 
            txtModificarNombre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarNombre.Location = new Point(427, 287);
            txtModificarNombre.Name = "txtModificarNombre";
            txtModificarNombre.Size = new Size(100, 32);
            txtModificarNombre.TabIndex = 8;
            // 
            // lbl_IDProveedor
            // 
            lbl_IDProveedor.AutoSize = true;
            lbl_IDProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_IDProveedor.Location = new Point(330, 202);
            lbl_IDProveedor.Name = "lbl_IDProveedor";
            lbl_IDProveedor.Size = new Size(126, 25);
            lbl_IDProveedor.TabIndex = 28;
            lbl_IDProveedor.Text = "ID proveedor:";
            // 
            // txtIDProveedor
            // 
            txtIDProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDProveedor.Location = new Point(509, 199);
            txtIDProveedor.Name = "txtIDProveedor";
            txtIDProveedor.Size = new Size(100, 32);
            txtIDProveedor.TabIndex = 27;
            // 
            // Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(pnlCREAR);
            Controls.Add(pnlCONSULTA);
            Controls.Add(btn_MODIFICAR_PROVEEDORES);
            Controls.Add(btn_CREAR_PROVEEDORES);
            Controls.Add(btn_CONSULTA_PROVEEDORES);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Proveedores";
            Text = "Proveedores";
            pnlCONSULTA.ResumeLayout(false);
            pnlCONSULTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridPROVEEDORES).EndInit();
            pnlCREAR.ResumeLayout(false);
            pnlCREAR.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_MODIFICAR_PROVEEDORES;
        private Button btn_CREAR_PROVEEDORES;
        private Button btn_CONSULTA_PROVEEDORES;
        private Panel pnlCONSULTA;
        private DataGridView datagridPROVEEDORES;
        private Label lblTituloConsulta;
        private Panel pnlCREAR;
        private Label lbl_poblacion_proveedor;
        private TextBox txtCrearPoblacionProveedor;
        private Label lbl_ciudad_proveedor;
        private TextBox txtCrearCiudadProveedor;
        private Label lbl_pais_proveedor;
        private TextBox txtCrearPaisProveedor;
        private Label lbl_email_proveedor;
        private TextBox txtCrearEmailProveedor;
        private Label lbl_direccion_proveedor;
        private TextBox txtCrearDireccionProveedor;
        private Label lbl_telefono_proveedor;
        private TextBox txtCrearTelefonoProveedor;
        private Label lblDescCrearProveedor;
        private Button btn_confirmarProveedor;
        private Label lbl_apellido_proveedor;
        private Label lbl_nombre_proveedor;
        private Label lbl_dnicif_proveedor;
        private Label lblTitutloCrearProveedor;
        private TextBox txtCrearDNIProveedor;
        private TextBox txtCrearApellidosProveedor;
        private TextBox txtCrearNombreProveedor;
        private Panel panel1;
        private Label lbl_MODIFICAR_POBLACION;
        private TextBox txtModificarPoblacion;
        private Label lbl_MODIFICAR_CIUDAD;
        private TextBox txtModificarCiudad;
        private Label lbl_MODIFICAR_PAIS;
        private TextBox txtModificarPais;
        private Label lbl_MODIFICAR_EMAIL;
        private TextBox txtModificarEmail;
        private Label lbl_MODIFICAR_DIRECCION;
        private TextBox txtModificarDireccion;
        private Label lbl_MODIFICAR_TELEFONO;
        private TextBox txtModificarTelefono;
        private Label lbl_DESCRIPCION_MODIFICAR;
        private Button btn_CONFIRMAR_MODIFICAR_PROVEEDOR;
        private Label lbl_MODIFICAR_APELLIDOS;
        private Label lbl_MODIFICAR_NOMBRE;
        private Label lbl_MODIFICAR_DNICIF;
        private Label lbl_MODIFICAR_PROVEEDOR;
        private TextBox txtModificarDNICIF;
        private TextBox txtModificarApellidos;
        private TextBox txtModificarNombre;
        private Label lbl_IDProveedor;
        private TextBox txtIDProveedor;
    }
}