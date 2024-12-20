namespace ProyectoDAM
{
    partial class Compras
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
            lblTituloConsulta = new Label();
            btn_CONSULTA_HISTORIAL = new Button();
            btn_CREAR_COMPRA = new Button();
            btn_MODIFICAR_COMPRA = new Button();
            txtCrearNombreProveedor = new TextBox();
            txtCrearNombreProducto = new TextBox();
            txtCrearCantidadComprada = new TextBox();
            datagridCOMPRAS = new DataGridView();
            pnlCONSULTA = new Panel();
            lblDescHistorialCompra = new Label();
            pnlCREAR = new Panel();
            pnlMODIFICAR = new Panel();
            lblDescModificarCompra = new Label();
            txtModificarCantidad = new TextBox();
            lblModificarCantidad = new Label();
            txtModificarProducto = new TextBox();
            lblModificarProducto = new Label();
            txtModificarProveedor = new TextBox();
            lblModificarNombreProveedor = new Label();
            lblModificarIDCompra = new Label();
            btn_confirmarModificacion = new Button();
            txtCrearID = new TextBox();
            lblTituloModificarCompra = new Label();
            lblDescCrearCompra = new Label();
            btn_confirmarCompra = new Button();
            lbl_compra_cantidad = new Label();
            lbl_compra_producto = new Label();
            lbl_compra_proveedor = new Label();
            lblTitutloCrearCompra = new Label();
            ((System.ComponentModel.ISupportInitialize)datagridCOMPRAS).BeginInit();
            pnlCONSULTA.SuspendLayout();
            pnlCREAR.SuspendLayout();
            pnlMODIFICAR.SuspendLayout();
            SuspendLayout();
            // 
            // lblTituloConsulta
            // 
            lblTituloConsulta.AutoSize = true;
            lblTituloConsulta.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTituloConsulta.Location = new Point(291, 24);
            lblTituloConsulta.Name = "lblTituloConsulta";
            lblTituloConsulta.Size = new Size(451, 52);
            lblTituloConsulta.TabIndex = 0;
            lblTituloConsulta.Text = "HISTORIAL DE COMPRAS";
            // 
            // btn_CONSULTA_HISTORIAL
            // 
            btn_CONSULTA_HISTORIAL.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CONSULTA_HISTORIAL.Location = new Point(226, 118);
            btn_CONSULTA_HISTORIAL.Name = "btn_CONSULTA_HISTORIAL";
            btn_CONSULTA_HISTORIAL.Size = new Size(484, 126);
            btn_CONSULTA_HISTORIAL.TabIndex = 1;
            btn_CONSULTA_HISTORIAL.Text = "CONSULTAR HISTORIAL DE COMPRAS";
            btn_CONSULTA_HISTORIAL.UseVisualStyleBackColor = true;
            btn_CONSULTA_HISTORIAL.Click += btnCONSULTA_HISTORIAL_Click;
            // 
            // btn_CREAR_COMPRA
            // 
            btn_CREAR_COMPRA.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CREAR_COMPRA.Location = new Point(226, 372);
            btn_CREAR_COMPRA.Name = "btn_CREAR_COMPRA";
            btn_CREAR_COMPRA.Size = new Size(484, 126);
            btn_CREAR_COMPRA.TabIndex = 2;
            btn_CREAR_COMPRA.Text = "CREAR COMPRA";
            btn_CREAR_COMPRA.UseVisualStyleBackColor = true;
            btn_CREAR_COMPRA.Click += btn_CREAR_COMPRA_Click;
            // 
            // btn_MODIFICAR_COMPRA
            // 
            btn_MODIFICAR_COMPRA.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MODIFICAR_COMPRA.Location = new Point(226, 646);
            btn_MODIFICAR_COMPRA.Name = "btn_MODIFICAR_COMPRA";
            btn_MODIFICAR_COMPRA.Size = new Size(484, 126);
            btn_MODIFICAR_COMPRA.TabIndex = 3;
            btn_MODIFICAR_COMPRA.Text = "MODIFICAR COMPRA";
            btn_MODIFICAR_COMPRA.UseVisualStyleBackColor = true;
            btn_MODIFICAR_COMPRA.Click += btn_MODIFICAR_COMPRA_Click;
            // 
            // txtCrearNombreProveedor
            // 
            txtCrearNombreProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearNombreProveedor.Location = new Point(255, 284);
            txtCrearNombreProveedor.Name = "txtCrearNombreProveedor";
            txtCrearNombreProveedor.Size = new Size(100, 32);
            txtCrearNombreProveedor.TabIndex = 7;
            // 
            // txtCrearNombreProducto
            // 
            txtCrearNombreProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearNombreProducto.Location = new Point(500, 284);
            txtCrearNombreProducto.Name = "txtCrearNombreProducto";
            txtCrearNombreProducto.Size = new Size(100, 32);
            txtCrearNombreProducto.TabIndex = 8;
            // 
            // txtCrearCantidadComprada
            // 
            txtCrearCantidadComprada.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearCantidadComprada.Location = new Point(735, 284);
            txtCrearCantidadComprada.Name = "txtCrearCantidadComprada";
            txtCrearCantidadComprada.Size = new Size(100, 29);
            txtCrearCantidadComprada.TabIndex = 9;
            // 
            // datagridCOMPRAS
            // 
            datagridCOMPRAS.AllowUserToAddRows = false;
            datagridCOMPRAS.AllowUserToDeleteRows = false;
            datagridCOMPRAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridCOMPRAS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridCOMPRAS.Location = new Point(106, 243);
            datagridCOMPRAS.MultiSelect = false;
            datagridCOMPRAS.Name = "datagridCOMPRAS";
            datagridCOMPRAS.ReadOnly = true;
            datagridCOMPRAS.RowHeadersVisible = false;
            datagridCOMPRAS.RowTemplate.Height = 25;
            datagridCOMPRAS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridCOMPRAS.Size = new Size(790, 392);
            datagridCOMPRAS.TabIndex = 4;
            // 
            // pnlCONSULTA
            // 
            pnlCONSULTA.Controls.Add(lblDescHistorialCompra);
            pnlCONSULTA.Controls.Add(datagridCOMPRAS);
            pnlCONSULTA.Controls.Add(lblTituloConsulta);
            pnlCONSULTA.Location = new Point(805, 119);
            pnlCONSULTA.Name = "pnlCONSULTA";
            pnlCONSULTA.Size = new Size(1005, 896);
            pnlCONSULTA.TabIndex = 11;
            pnlCONSULTA.Visible = false;
            // 
            // lblDescHistorialCompra
            // 
            lblDescHistorialCompra.AutoSize = true;
            lblDescHistorialCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescHistorialCompra.Location = new Point(294, 106);
            lblDescHistorialCompra.Name = "lblDescHistorialCompra";
            lblDescHistorialCompra.Size = new Size(438, 21);
            lblDescHistorialCompra.TabIndex = 5;
            lblDescHistorialCompra.Text = "Introduce los datos para mostrar el historial de compras:";
            // 
            // pnlCREAR
            // 
            pnlCREAR.Controls.Add(lblDescCrearCompra);
            pnlCREAR.Controls.Add(btn_confirmarCompra);
            pnlCREAR.Controls.Add(lbl_compra_cantidad);
            pnlCREAR.Controls.Add(lbl_compra_producto);
            pnlCREAR.Controls.Add(lbl_compra_proveedor);
            pnlCREAR.Controls.Add(lblTitutloCrearCompra);
            pnlCREAR.Controls.Add(txtCrearNombreProveedor);
            pnlCREAR.Controls.Add(txtCrearCantidadComprada);
            pnlCREAR.Controls.Add(txtCrearNombreProducto);
            pnlCREAR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pnlCREAR.Location = new Point(805, 119);
            pnlCREAR.Name = "pnlCREAR";
            pnlCREAR.Size = new Size(1005, 896);
            pnlCREAR.TabIndex = 12;
            pnlCREAR.Visible = false;
            // 
            // pnlMODIFICAR
            // 
            pnlMODIFICAR.Controls.Add(lblDescModificarCompra);
            pnlMODIFICAR.Controls.Add(txtModificarCantidad);
            pnlMODIFICAR.Controls.Add(lblModificarCantidad);
            pnlMODIFICAR.Controls.Add(txtModificarProducto);
            pnlMODIFICAR.Controls.Add(lblModificarProducto);
            pnlMODIFICAR.Controls.Add(txtModificarProveedor);
            pnlMODIFICAR.Controls.Add(lblModificarNombreProveedor);
            pnlMODIFICAR.Controls.Add(lblModificarIDCompra);
            pnlMODIFICAR.Controls.Add(btn_confirmarModificacion);
            pnlMODIFICAR.Controls.Add(txtCrearID);
            pnlMODIFICAR.Controls.Add(lblTituloModificarCompra);
            pnlMODIFICAR.Location = new Point(805, 118);
            pnlMODIFICAR.Name = "pnlMODIFICAR";
            pnlMODIFICAR.Size = new Size(1007, 916);
            pnlMODIFICAR.TabIndex = 13;
            pnlMODIFICAR.Visible = false;
            // 
            // lblDescModificarCompra
            // 
            lblDescModificarCompra.AutoSize = true;
            lblDescModificarCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescModificarCompra.Location = new Point(352, 106);
            lblDescModificarCompra.Name = "lblDescModificarCompra";
            lblDescModificarCompra.Size = new Size(356, 21);
            lblDescModificarCompra.TabIndex = 22;
            lblDescModificarCompra.Text = "Introduce los datos para modificar la compra:";
            // 
            // txtModificarCantidad
            // 
            txtModificarCantidad.Location = new Point(879, 287);
            txtModificarCantidad.Name = "txtModificarCantidad";
            txtModificarCantidad.Size = new Size(100, 23);
            txtModificarCantidad.TabIndex = 21;
            // 
            // lblModificarCantidad
            // 
            lblModificarCantidad.AutoSize = true;
            lblModificarCantidad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificarCantidad.Location = new Point(791, 284);
            lblModificarCantidad.Name = "lblModificarCantidad";
            lblModificarCantidad.Size = new Size(92, 25);
            lblModificarCantidad.TabIndex = 20;
            lblModificarCantidad.Text = "Cantidad:";
            // 
            // txtModificarProducto
            // 
            txtModificarProducto.Location = new Point(684, 287);
            txtModificarProducto.Name = "txtModificarProducto";
            txtModificarProducto.Size = new Size(100, 23);
            txtModificarProducto.TabIndex = 19;
            // 
            // lblModificarProducto
            // 
            lblModificarProducto.AutoSize = true;
            lblModificarProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificarProducto.Location = new Point(591, 284);
            lblModificarProducto.Name = "lblModificarProducto";
            lblModificarProducto.Size = new Size(93, 25);
            lblModificarProducto.TabIndex = 18;
            lblModificarProducto.Text = "Producto:";
            // 
            // txtModificarProveedor
            // 
            txtModificarProveedor.Location = new Point(488, 287);
            txtModificarProveedor.Name = "txtModificarProveedor";
            txtModificarProveedor.Size = new Size(100, 23);
            txtModificarProveedor.TabIndex = 17;
            // 
            // lblModificarNombreProveedor
            // 
            lblModificarNombreProveedor.AutoSize = true;
            lblModificarNombreProveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificarNombreProveedor.Location = new Point(281, 284);
            lblModificarNombreProveedor.Name = "lblModificarNombreProveedor";
            lblModificarNombreProveedor.Size = new Size(208, 25);
            lblModificarNombreProveedor.TabIndex = 16;
            lblModificarNombreProveedor.Text = "Nombre del proveedor:";
            // 
            // lblModificarIDCompra
            // 
            lblModificarIDCompra.AutoSize = true;
            lblModificarIDCompra.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificarIDCompra.Location = new Point(46, 284);
            lblModificarIDCompra.Name = "lblModificarIDCompra";
            lblModificarIDCompra.Size = new Size(129, 25);
            lblModificarIDCompra.TabIndex = 15;
            lblModificarIDCompra.Text = "ID de compra:";
            // 
            // btn_confirmarModificacion
            // 
            btn_confirmarModificacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_confirmarModificacion.Location = new Point(427, 508);
            btn_confirmarModificacion.Name = "btn_confirmarModificacion";
            btn_confirmarModificacion.Size = new Size(227, 98);
            btn_confirmarModificacion.TabIndex = 14;
            btn_confirmarModificacion.Text = "CONFIRMAR MODIFICACIÓN";
            btn_confirmarModificacion.UseVisualStyleBackColor = true;
            btn_confirmarModificacion.Click += btn_confirmarModificacion_Click;
            // 
            // txtCrearID
            // 
            txtCrearID.Location = new Point(176, 287);
            txtCrearID.Name = "txtCrearID";
            txtCrearID.Size = new Size(100, 23);
            txtCrearID.TabIndex = 10;
            // 
            // lblTituloModificarCompra
            // 
            lblTituloModificarCompra.AutoSize = true;
            lblTituloModificarCompra.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTituloModificarCompra.Location = new Point(336, 24);
            lblTituloModificarCompra.Name = "lblTituloModificarCompra";
            lblTituloModificarCompra.Size = new Size(392, 52);
            lblTituloModificarCompra.TabIndex = 0;
            lblTituloModificarCompra.Text = "MODIFICAR COMPRA";
            // 
            // lblDescCrearCompra
            // 
            lblDescCrearCompra.AutoSize = true;
            lblDescCrearCompra.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescCrearCompra.Location = new Point(369, 106);
            lblDescCrearCompra.Name = "lblDescCrearCompra";
            lblDescCrearCompra.Size = new Size(320, 21);
            lblDescCrearCompra.TabIndex = 14;
            lblDescCrearCompra.Text = "Introduce los datos para crear la compra:";
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
            btn_confirmarCompra.Click += button1_Click;
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
            // lbl_compra_proveedor
            // 
            lbl_compra_proveedor.AutoSize = true;
            lbl_compra_proveedor.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_compra_proveedor.Location = new Point(46, 287);
            lbl_compra_proveedor.Name = "lbl_compra_proveedor";
            lbl_compra_proveedor.Size = new Size(208, 25);
            lbl_compra_proveedor.TabIndex = 11;
            lbl_compra_proveedor.Text = "Nombre del Proveedor:";
            // 
            // lblTitutloCrearCompra
            // 
            lblTitutloCrearCompra.AutoSize = true;
            lblTitutloCrearCompra.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTitutloCrearCompra.Location = new Point(379, 23);
            lblTitutloCrearCompra.Name = "lblTitutloCrearCompra";
            lblTitutloCrearCompra.Size = new Size(305, 52);
            lblTitutloCrearCompra.TabIndex = 0;
            lblTitutloCrearCompra.Text = "CREAR COMPRA";
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(pnlMODIFICAR);
            Controls.Add(pnlCREAR);
            Controls.Add(pnlCONSULTA);
            Controls.Add(btn_MODIFICAR_COMPRA);
            Controls.Add(btn_CREAR_COMPRA);
            Controls.Add(btn_CONSULTA_HISTORIAL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras";
            Text = "m";
            ((System.ComponentModel.ISupportInitialize)datagridCOMPRAS).EndInit();
            pnlCONSULTA.ResumeLayout(false);
            pnlCONSULTA.PerformLayout();
            pnlCREAR.ResumeLayout(false);
            pnlCREAR.PerformLayout();
            pnlMODIFICAR.ResumeLayout(false);
            pnlMODIFICAR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTituloConsulta;
        private Button btn_CONSULTA_HISTORIAL;
        private Button btn_CREAR_COMPRA;
        private Button btn_MODIFICAR_COMPRA;
        private TextBox txtCrearNombreProveedor;
        private TextBox txtCrearNombreProducto;
        private TextBox txtCrearCantidadComprada;
        private DataGridView datagridCOMPRAS;
        private Panel pnlCONSULTA;
        private Panel pnlCREAR;
        private Label lblTitutloCrearCompra;
        private Label lbl_compra_proveedor;
        private Label lbl_compra_producto;
        private Label lbl_compra_cantidad;
        private Button btn_confirmarCompra;
        private Label lblTituloModificarCompra;
        private TextBox txtCrearID;
        private Button btn_confirmarModificacion;
        private Label lblModificarIDCompra;
        private Label lblModificarNombreProveedor;
        private TextBox txtModificarProveedor;
        private Label lblModificarProducto;
        private TextBox txtModificarProducto;
        private Label lblModificarCantidad;
        private TextBox txtModificarCantidad;
        private Panel pnlMODIFICAR;
        private Label lblDescModificarCompra;
        private Label lblDescCrearCompra;
        private Label lblDescHistorialCompra;
    }
}