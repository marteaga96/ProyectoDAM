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
            label1 = new Label();
            btn_MODIFICAR_PRODUCTO = new Button();
            btnCREAR_PRODUCTO = new Button();
            btn_CONSULTAR_HISTORIAL = new Button();
            pnlCONSULTA = new Panel();
            lblDescHistorialCompra = new Label();
            datagridPRODUCTOS = new DataGridView();
            lblTituloConsulta = new Label();
            pnlCREAR = new Panel();
            lblDescCrearProducto = new Label();
            btn_confirmarCompra = new Button();
            lbl_compra_cantidad = new Label();
            lbl_compra_producto = new Label();
            lbl_nombre_producto = new Label();
            lblTitutloCrearProducto = new Label();
            txtCrearNombreProveedor = new TextBox();
            txtCrearCantidadComprada = new TextBox();
            txtCrearNombreProducto = new TextBox();
            pnlCONSULTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridPRODUCTOS).BeginInit();
            pnlCREAR.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(328, 28);
            label1.Name = "label1";
            label1.Size = new Size(242, 52);
            label1.TabIndex = 0;
            label1.Text = "PRODUCTOS";
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
            pnlCONSULTA.Location = new Point(936, 1004);
            pnlCONSULTA.Name = "pnlCONSULTA";
            pnlCONSULTA.Size = new Size(1005, 896);
            pnlCONSULTA.TabIndex = 12;
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
            pnlCREAR.Controls.Add(lblDescCrearProducto);
            pnlCREAR.Controls.Add(btn_confirmarCompra);
            pnlCREAR.Controls.Add(lbl_compra_cantidad);
            pnlCREAR.Controls.Add(lbl_compra_producto);
            pnlCREAR.Controls.Add(lbl_nombre_producto);
            pnlCREAR.Controls.Add(lblTitutloCrearProducto);
            pnlCREAR.Controls.Add(txtCrearNombreProveedor);
            pnlCREAR.Controls.Add(txtCrearCantidadComprada);
            pnlCREAR.Controls.Add(txtCrearNombreProducto);
            pnlCREAR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pnlCREAR.Location = new Point(960, 47);
            pnlCREAR.Name = "pnlCREAR";
            pnlCREAR.Size = new Size(1005, 896);
            pnlCREAR.TabIndex = 13;
            pnlCREAR.Visible = false;
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
            // btn_confirmarCompra
            // 
            btn_confirmarCompra.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_confirmarCompra.Location = new Point(427, 508);
            btn_confirmarCompra.Name = "btn_confirmarCompra";
            btn_confirmarCompra.Size = new Size(201, 87);
            btn_confirmarCompra.TabIndex = 14;
            btn_confirmarCompra.Text = "CONFIRMAR COMPRA";
            btn_confirmarCompra.UseVisualStyleBackColor = true;
            // 
            // lbl_compra_cantidad
            // 
            lbl_compra_cantidad.AutoSize = true;
            lbl_compra_cantidad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_compra_cantidad.Location = new Point(642, 287);
            lbl_compra_cantidad.Name = "lbl_compra_cantidad";
            lbl_compra_cantidad.Size = new Size(92, 25);
            lbl_compra_cantidad.TabIndex = 13;
            lbl_compra_cantidad.Text = "Cantidad:";
            // 
            // lbl_compra_producto
            // 
            lbl_compra_producto.AutoSize = true;
            lbl_compra_producto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_compra_producto.Location = new Point(406, 287);
            lbl_compra_producto.Name = "lbl_compra_producto";
            lbl_compra_producto.Size = new Size(93, 25);
            lbl_compra_producto.TabIndex = 12;
            lbl_compra_producto.Text = "Producto:";
            // 
            // lbl_nombre_producto
            // 
            lbl_nombre_producto.AutoSize = true;
            lbl_nombre_producto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nombre_producto.Location = new Point(46, 287);
            lbl_nombre_producto.Name = "lbl_nombre_producto";
            lbl_nombre_producto.Size = new Size(198, 25);
            lbl_nombre_producto.TabIndex = 11;
            lbl_nombre_producto.Text = "Nombre del Producto:";
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
            // txtCrearNombreProveedor
            // 
            txtCrearNombreProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearNombreProveedor.Location = new Point(255, 284);
            txtCrearNombreProveedor.Name = "txtCrearNombreProveedor";
            txtCrearNombreProveedor.Size = new Size(100, 32);
            txtCrearNombreProveedor.TabIndex = 7;
            // 
            // txtCrearCantidadComprada
            // 
            txtCrearCantidadComprada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearCantidadComprada.Location = new Point(735, 284);
            txtCrearCantidadComprada.Name = "txtCrearCantidadComprada";
            txtCrearCantidadComprada.Size = new Size(100, 29);
            txtCrearCantidadComprada.TabIndex = 9;
            // 
            // txtCrearNombreProducto
            // 
            txtCrearNombreProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearNombreProducto.Location = new Point(500, 284);
            txtCrearNombreProducto.Name = "txtCrearNombreProducto";
            txtCrearNombreProducto.Size = new Size(100, 32);
            txtCrearNombreProducto.TabIndex = 8;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(pnlCREAR);
            Controls.Add(pnlCONSULTA);
            Controls.Add(btn_MODIFICAR_PRODUCTO);
            Controls.Add(btnCREAR_PRODUCTO);
            Controls.Add(btn_CONSULTAR_HISTORIAL);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            pnlCONSULTA.ResumeLayout(false);
            pnlCONSULTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridPRODUCTOS).EndInit();
            pnlCREAR.ResumeLayout(false);
            pnlCREAR.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_MODIFICAR_PRODUCTO;
        private Button btnCREAR_PRODUCTO;
        private Button btn_CONSULTAR_HISTORIAL;
        private Panel pnlCONSULTA;
        private Label lblDescHistorialCompra;
        private DataGridView datagridPRODUCTOS;
        private Label lblTituloConsulta;
        private Panel pnlCREAR;
        private Label lblDescCrearProducto;
        private Button btn_confirmarCompra;
        private Label lbl_compra_cantidad;
        private Label lbl_compra_producto;
        private Label lbl_nombre_producto;
        private Label lblTitutloCrearProducto;
        private TextBox txtCrearNombreProveedor;
        private TextBox txtCrearCantidadComprada;
        private TextBox txtCrearNombreProducto;
    }
}