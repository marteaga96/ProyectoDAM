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
            pnlCONSULTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridPROVEEDORES).BeginInit();
            pnlCREAR.SuspendLayout();
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
    }
}