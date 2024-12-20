namespace ProyectoDAM
{
    partial class Productos
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
            btn_MODIFICAR_PRODUCTO = new Button();
            btnCREAR_PRODUCTO = new Button();
            btn_CONSULTAR_HISTORIAL = new Button();
            pnlCONSULTA = new Panel();
            lblDescHistorialCompra = new Label();
            datagridPRODUCTOS = new DataGridView();
            lblTituloConsulta = new Label();
            pnlCREAR = new Panel();
            txtCrearPrecioProducto = new TextBox();
            lblDescCrearProducto = new Label();
            btn_crearProducto = new Button();
            lbl_productos_precio_sin_iva = new Label();
            lbl_productos_iva = new Label();
            lbl_productos_nombre = new Label();
            lblTitutloCrearProducto = new Label();
            txtCrearNombreProducto = new TextBox();
            txtCrearIvaProducto = new TextBox();
            pnlMODIFICAR = new Panel();
            lblPrecioProducto = new Label();
            txtModificarPrecioProducto = new TextBox();
            label2 = new Label();
            btnConfirmarModificarProducto = new Button();
            lblIVAModificarProducto = new Label();
            lblNombreModificarProducto = new Label();
            lblIDDelProducto = new Label();
            lblTitutloModificarProducto = new Label();
            txtIDModificarProducto = new TextBox();
            txtModificarIVAProducto = new TextBox();
            txtNombreModificarProducto = new TextBox();
            pnlCONSULTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridPRODUCTOS).BeginInit();
            pnlCREAR.SuspendLayout();
            pnlMODIFICAR.SuspendLayout();
            SuspendLayout();
            // 
            // btn_MODIFICAR_PRODUCTO
            // 
            btn_MODIFICAR_PRODUCTO.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MODIFICAR_PRODUCTO.Location = new Point(226, 646);
            btn_MODIFICAR_PRODUCTO.Name = "btn_MODIFICAR_PRODUCTO";
            btn_MODIFICAR_PRODUCTO.Size = new Size(484, 126);
            btn_MODIFICAR_PRODUCTO.TabIndex = 6;
            btn_MODIFICAR_PRODUCTO.Text = "MODIFICAR PRODUCTO";
            btn_MODIFICAR_PRODUCTO.UseVisualStyleBackColor = true;
            btn_MODIFICAR_PRODUCTO.Click += btn_MODIFICAR_PRODUCTO_Click;
            // 
            // btnCREAR_PRODUCTO
            // 
            btnCREAR_PRODUCTO.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btnCREAR_PRODUCTO.Location = new Point(226, 372);
            btnCREAR_PRODUCTO.Name = "btnCREAR_PRODUCTO";
            btnCREAR_PRODUCTO.Size = new Size(484, 126);
            btnCREAR_PRODUCTO.TabIndex = 5;
            btnCREAR_PRODUCTO.Text = "CREAR PRODUCTOS";
            btnCREAR_PRODUCTO.UseVisualStyleBackColor = true;
            btnCREAR_PRODUCTO.Click += btnCREAR_PRODUCTO_Click;
            // 
            // btn_CONSULTAR_HISTORIAL
            // 
            btn_CONSULTAR_HISTORIAL.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CONSULTAR_HISTORIAL.Location = new Point(226, 118);
            btn_CONSULTAR_HISTORIAL.Name = "btn_CONSULTAR_HISTORIAL";
            btn_CONSULTAR_HISTORIAL.Size = new Size(484, 126);
            btn_CONSULTAR_HISTORIAL.TabIndex = 4;
            btn_CONSULTAR_HISTORIAL.Text = "CONSULTAR LISTA DE PRODUCTOS";
            btn_CONSULTAR_HISTORIAL.UseVisualStyleBackColor = true;
            btn_CONSULTAR_HISTORIAL.Click += btn_CONSULTAR_HISTORIAL_Click;
            // 
            // pnlCONSULTA
            // 
            pnlCONSULTA.Controls.Add(lblDescHistorialCompra);
            pnlCONSULTA.Controls.Add(datagridPRODUCTOS);
            pnlCONSULTA.Controls.Add(lblTituloConsulta);
            pnlCONSULTA.Location = new Point(783, 51);
            pnlCONSULTA.Name = "pnlCONSULTA";
            pnlCONSULTA.Size = new Size(1005, 896);
            pnlCONSULTA.TabIndex = 12;
            pnlCONSULTA.Visible = false;
            // 
            // lblDescHistorialCompra
            // 
            lblDescHistorialCompra.AutoSize = true;
            lblDescHistorialCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescHistorialCompra.Location = new Point(294, 106);
            lblDescHistorialCompra.Name = "lblDescHistorialCompra";
            lblDescHistorialCompra.Size = new Size(368, 21);
            lblDescHistorialCompra.TabIndex = 5;
            lblDescHistorialCompra.Text = "Introduce los datos para mostrar los productos:";
            // 
            // datagridPRODUCTOS
            // 
            datagridPRODUCTOS.AllowUserToAddRows = false;
            datagridPRODUCTOS.AllowUserToDeleteRows = false;
            datagridPRODUCTOS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridPRODUCTOS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridPRODUCTOS.Location = new Point(106, 243);
            datagridPRODUCTOS.MultiSelect = false;
            datagridPRODUCTOS.Name = "datagridPRODUCTOS";
            datagridPRODUCTOS.ReadOnly = true;
            datagridPRODUCTOS.RowHeadersVisible = false;
            datagridPRODUCTOS.RowTemplate.Height = 25;
            datagridPRODUCTOS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridPRODUCTOS.Size = new Size(790, 392);
            datagridPRODUCTOS.TabIndex = 4;
            // 
            // lblTituloConsulta
            // 
            lblTituloConsulta.AutoSize = true;
            lblTituloConsulta.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTituloConsulta.Location = new Point(291, 24);
            lblTituloConsulta.Name = "lblTituloConsulta";
            lblTituloConsulta.Size = new Size(493, 52);
            lblTituloConsulta.TabIndex = 0;
            lblTituloConsulta.Text = "HISTORIAL DE PRODUCTOS";
            // 
            // pnlCREAR
            // 
            pnlCREAR.Controls.Add(txtCrearPrecioProducto);
            pnlCREAR.Controls.Add(lblDescCrearProducto);
            pnlCREAR.Controls.Add(btn_crearProducto);
            pnlCREAR.Controls.Add(lbl_productos_precio_sin_iva);
            pnlCREAR.Controls.Add(lbl_productos_iva);
            pnlCREAR.Controls.Add(lbl_productos_nombre);
            pnlCREAR.Controls.Add(lblTitutloCrearProducto);
            pnlCREAR.Controls.Add(txtCrearNombreProducto);
            pnlCREAR.Controls.Add(txtCrearIvaProducto);
            pnlCREAR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pnlCREAR.Location = new Point(783, 52);
            pnlCREAR.Name = "pnlCREAR";
            pnlCREAR.Size = new Size(1005, 896);
            pnlCREAR.TabIndex = 13;
            pnlCREAR.Visible = false;
            // 
            // txtCrearPrecioProducto
            // 
            txtCrearPrecioProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearPrecioProducto.Location = new Point(546, 287);
            txtCrearPrecioProducto.Name = "txtCrearPrecioProducto";
            txtCrearPrecioProducto.Size = new Size(100, 32);
            txtCrearPrecioProducto.TabIndex = 15;
            // 
            // lblDescCrearProducto
            // 
            lblDescCrearProducto.AutoSize = true;
            lblDescCrearProducto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescCrearProducto.Location = new Point(369, 106);
            lblDescCrearProducto.Name = "lblDescCrearProducto";
            lblDescCrearProducto.Size = new Size(332, 21);
            lblDescCrearProducto.TabIndex = 14;
            lblDescCrearProducto.Text = "Introduce los datos para crear el producto:";
            // 
            // btn_crearProducto
            // 
            btn_crearProducto.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_crearProducto.Location = new Point(427, 427);
            btn_crearProducto.Name = "btn_crearProducto";
            btn_crearProducto.Size = new Size(201, 87);
            btn_crearProducto.TabIndex = 14;
            btn_crearProducto.Text = "CREAR PRODUCTO";
            btn_crearProducto.UseVisualStyleBackColor = true;
            btn_crearProducto.Click += btn_crearProducto_Click;
            // 
            // lbl_productos_precio_sin_iva
            // 
            lbl_productos_precio_sin_iva.AutoSize = true;
            lbl_productos_precio_sin_iva.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_productos_precio_sin_iva.Location = new Point(407, 290);
            lbl_productos_precio_sin_iva.Name = "lbl_productos_precio_sin_iva";
            lbl_productos_precio_sin_iva.Size = new Size(133, 25);
            lbl_productos_precio_sin_iva.TabIndex = 13;
            lbl_productos_precio_sin_iva.Text = "Precio Sin IVA:";
            // 
            // lbl_productos_iva
            // 
            lbl_productos_iva.AutoSize = true;
            lbl_productos_iva.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_productos_iva.Location = new Point(683, 290);
            lbl_productos_iva.Name = "lbl_productos_iva";
            lbl_productos_iva.Size = new Size(65, 25);
            lbl_productos_iva.TabIndex = 12;
            lbl_productos_iva.Text = "% IVA:";
            // 
            // lbl_productos_nombre
            // 
            lbl_productos_nombre.AutoSize = true;
            lbl_productos_nombre.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_productos_nombre.Location = new Point(54, 290);
            lbl_productos_nombre.Name = "lbl_productos_nombre";
            lbl_productos_nombre.Size = new Size(198, 25);
            lbl_productos_nombre.TabIndex = 11;
            lbl_productos_nombre.Text = "Nombre del Producto:";
            // 
            // lblTitutloCrearProducto
            // 
            lblTitutloCrearProducto.AutoSize = true;
            lblTitutloCrearProducto.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitutloCrearProducto.Location = new Point(379, 23);
            lblTitutloCrearProducto.Name = "lblTitutloCrearProducto";
            lblTitutloCrearProducto.Size = new Size(347, 52);
            lblTitutloCrearProducto.TabIndex = 0;
            lblTitutloCrearProducto.Text = "CREAR PRODUCTO";
            // 
            // txtCrearNombreProducto
            // 
            txtCrearNombreProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearNombreProducto.Location = new Point(258, 287);
            txtCrearNombreProducto.Name = "txtCrearNombreProducto";
            txtCrearNombreProducto.Size = new Size(100, 32);
            txtCrearNombreProducto.TabIndex = 7;
            // 
            // txtCrearIvaProducto
            // 
            txtCrearIvaProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearIvaProducto.Location = new Point(754, 287);
            txtCrearIvaProducto.Name = "txtCrearIvaProducto";
            txtCrearIvaProducto.Size = new Size(100, 32);
            txtCrearIvaProducto.TabIndex = 8;
            // 
            // pnlMODIFICAR
            // 
            pnlMODIFICAR.Controls.Add(lblPrecioProducto);
            pnlMODIFICAR.Controls.Add(txtModificarPrecioProducto);
            pnlMODIFICAR.Controls.Add(label2);
            pnlMODIFICAR.Controls.Add(btnConfirmarModificarProducto);
            pnlMODIFICAR.Controls.Add(lblIVAModificarProducto);
            pnlMODIFICAR.Controls.Add(lblNombreModificarProducto);
            pnlMODIFICAR.Controls.Add(lblIDDelProducto);
            pnlMODIFICAR.Controls.Add(lblTitutloModificarProducto);
            pnlMODIFICAR.Controls.Add(txtIDModificarProducto);
            pnlMODIFICAR.Controls.Add(txtModificarIVAProducto);
            pnlMODIFICAR.Controls.Add(txtNombreModificarProducto);
            pnlMODIFICAR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pnlMODIFICAR.Location = new Point(783, 50);
            pnlMODIFICAR.Name = "pnlMODIFICAR";
            pnlMODIFICAR.Size = new Size(1005, 896);
            pnlMODIFICAR.TabIndex = 15;
            pnlMODIFICAR.Visible = false;
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblPrecioProducto.Location = new Point(666, 284);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(79, 25);
            lblPrecioProducto.TabIndex = 16;
            lblPrecioProducto.Text = "PRECIO:";
            // 
            // txtModificarPrecioProducto
            // 
            txtModificarPrecioProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarPrecioProducto.Location = new Point(754, 284);
            txtModificarPrecioProducto.Name = "txtModificarPrecioProducto";
            txtModificarPrecioProducto.Size = new Size(86, 29);
            txtModificarPrecioProducto.TabIndex = 15;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(369, 106);
            label2.Name = "label2";
            label2.Size = new Size(368, 21);
            label2.TabIndex = 14;
            label2.Text = "Introduce los datos para modificar el producto:";
            // 
            // btnConfirmarModificarProducto
            // 
            btnConfirmarModificarProducto.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btnConfirmarModificarProducto.Location = new Point(427, 508);
            btnConfirmarModificarProducto.Name = "btnConfirmarModificarProducto";
            btnConfirmarModificarProducto.Size = new Size(219, 87);
            btnConfirmarModificarProducto.TabIndex = 14;
            btnConfirmarModificarProducto.Text = "CONFIRMAR MODIFICACIÓN";
            btnConfirmarModificarProducto.UseVisualStyleBackColor = true;
            btnConfirmarModificarProducto.Click += btnConfirmarModificarProducto_Click;
            // 
            // lblIVAModificarProducto
            // 
            lblIVAModificarProducto.AutoSize = true;
            lblIVAModificarProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblIVAModificarProducto.Location = new Point(855, 284);
            lblIVAModificarProducto.Name = "lblIVAModificarProducto";
            lblIVAModificarProducto.Size = new Size(44, 25);
            lblIVAModificarProducto.TabIndex = 13;
            lblIVAModificarProducto.Text = "IVA:";
            // 
            // lblNombreModificarProducto
            // 
            lblNombreModificarProducto.AutoSize = true;
            lblNombreModificarProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreModificarProducto.Location = new Point(262, 287);
            lblNombreModificarProducto.Name = "lblNombreModificarProducto";
            lblNombreModificarProducto.Size = new Size(198, 25);
            lblNombreModificarProducto.TabIndex = 12;
            lblNombreModificarProducto.Text = "Nombre del producto:";
            // 
            // lblIDDelProducto
            // 
            lblIDDelProducto.AutoSize = true;
            lblIDDelProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblIDDelProducto.Location = new Point(26, 284);
            lblIDDelProducto.Name = "lblIDDelProducto";
            lblIDDelProducto.Size = new Size(147, 25);
            lblIDDelProducto.TabIndex = 11;
            lblIDDelProducto.Text = "ID del Producto:";
            // 
            // lblTitutloModificarProducto
            // 
            lblTitutloModificarProducto.AutoSize = true;
            lblTitutloModificarProducto.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitutloModificarProducto.Location = new Point(379, 23);
            lblTitutloModificarProducto.Name = "lblTitutloModificarProducto";
            lblTitutloModificarProducto.Size = new Size(434, 52);
            lblTitutloModificarProducto.TabIndex = 0;
            lblTitutloModificarProducto.Text = "MODIFICAR PRODUCTO";
            // 
            // txtIDModificarProducto
            // 
            txtIDModificarProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtIDModificarProducto.Location = new Point(175, 284);
            txtIDModificarProducto.Name = "txtIDModificarProducto";
            txtIDModificarProducto.Size = new Size(66, 32);
            txtIDModificarProducto.TabIndex = 7;
            // 
            // txtModificarIVAProducto
            // 
            txtModificarIVAProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtModificarIVAProducto.Location = new Point(902, 284);
            txtModificarIVAProducto.Name = "txtModificarIVAProducto";
            txtModificarIVAProducto.Size = new Size(55, 29);
            txtModificarIVAProducto.TabIndex = 9;
            // 
            // txtNombreModificarProducto
            // 
            txtNombreModificarProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtNombreModificarProducto.Location = new Point(465, 284);
            txtNombreModificarProducto.Name = "txtNombreModificarProducto";
            txtNombreModificarProducto.Size = new Size(175, 32);
            txtNombreModificarProducto.TabIndex = 8;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(pnlMODIFICAR);
            Controls.Add(pnlCREAR);
            Controls.Add(pnlCONSULTA);
            Controls.Add(btn_MODIFICAR_PRODUCTO);
            Controls.Add(btnCREAR_PRODUCTO);
            Controls.Add(btn_CONSULTAR_HISTORIAL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            pnlCONSULTA.ResumeLayout(false);
            pnlCONSULTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridPRODUCTOS).EndInit();
            pnlCREAR.ResumeLayout(false);
            pnlCREAR.PerformLayout();
            pnlMODIFICAR.ResumeLayout(false);
            pnlMODIFICAR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_MODIFICAR_PRODUCTO;
        private Button btnCREAR_PRODUCTO;
        private Button btn_CONSULTAR_HISTORIAL;
        private Panel pnlCONSULTA;
        private Label lblDescHistorialCompra;
        private DataGridView datagridPRODUCTOS;
        private Label lblTituloConsulta;
        private Panel pnlCREAR;
        private Label lblDescCrearProducto;
        private Button btn_crearProducto;
        private Label lbl_productos_precio_sin_iva;
        private Label lbl_productos_iva;
        private Label lbl_productos_nombre;
        private Label lblTitutloCrearProducto;
        private TextBox txtCrearNombreProducto;
        private TextBox txtCrearIvaProducto;
        private Panel pnlMODIFICAR;
        private Label label2;
        private Button btnConfirmarModificarProducto;
        private Label lblIVAModificarProducto;
        private Label lblNombreModificarProducto;
        private Label lblIDDelProducto;
        private Label lblTitutloModificarProducto;
        private TextBox txtIDModificarProducto;
        private TextBox txtModificarIVAProducto;
        private TextBox txtNombreModificarProducto;
        private TextBox txtCrearPrecioProducto;
        private Label lblPrecioProducto;
        private TextBox txtModificarPrecioProducto;
    }
}