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
            lblCONSULTA = new Label();
            btnCONSULTA_HISTORIAL = new Button();
            btn_CREAR_COMPRA = new Button();
            btn_MODIFICAR_COMPRA = new Button();
            txtCrearNombreProveedor = new TextBox();
            txtCrearNombreProducto = new TextBox();
            txtCrearCantidadComprada = new TextBox();
            datagridView1 = new DataGridView();
            pnlCONSULTA = new Panel();
            pnlCREAR = new Panel();
            btn_confirmarCompra = new Button();
            lbl_compra_cantidad = new Label();
            lbl_compra_producto = new Label();
            lbl_compra_proveedor = new Label();
            label1 = new Label();
            label2 = new Label();
            txtCrearID = new TextBox();
            btn_confirmarModificacion = new Button();
            label3 = new Label();
            label4 = new Label();
            txtModificarProveedor = new TextBox();
            lblModificarProducto = new Label();
            txtModificarProducto = new TextBox();
            lblModificarCantidad = new Label();
            txtModificarCantidad = new TextBox();
            pnlMODIFICAR = new Panel();
            ((System.ComponentModel.ISupportInitialize)datagridView1).BeginInit();
            pnlCONSULTA.SuspendLayout();
            pnlCREAR.SuspendLayout();
            pnlMODIFICAR.SuspendLayout();
            SuspendLayout();
            // 
            // lblCONSULTA
            // 
            lblCONSULTA.AutoSize = true;
            lblCONSULTA.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            lblCONSULTA.Location = new Point(291, 24);
            lblCONSULTA.Name = "lblCONSULTA";
            lblCONSULTA.Size = new Size(451, 52);
            lblCONSULTA.TabIndex = 0;
            lblCONSULTA.Text = "HISTORIAL DE COMPRAS";
            // 
            // btnCONSULTA_HISTORIAL
            // 
            btnCONSULTA_HISTORIAL.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btnCONSULTA_HISTORIAL.Location = new Point(226, 118);
            btnCONSULTA_HISTORIAL.Name = "btnCONSULTA_HISTORIAL";
            btnCONSULTA_HISTORIAL.Size = new Size(484, 126);
            btnCONSULTA_HISTORIAL.TabIndex = 1;
            btnCONSULTA_HISTORIAL.Text = "CONSULTAR HISTORIAL DE COMPRAS";
            btnCONSULTA_HISTORIAL.UseVisualStyleBackColor = true;
            btnCONSULTA_HISTORIAL.Click += btnCONSULTA_HISTORIAL_Click;
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
            // datagridView1
            // 
            datagridView1.AllowUserToAddRows = false;
            datagridView1.AllowUserToDeleteRows = false;
            datagridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridView1.Location = new Point(106, 113);
            datagridView1.MultiSelect = false;
            datagridView1.Name = "datagridView1";
            datagridView1.ReadOnly = true;
            datagridView1.RowHeadersVisible = false;
            datagridView1.RowTemplate.Height = 25;
            datagridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridView1.Size = new Size(790, 392);
            datagridView1.TabIndex = 4;
            // 
            // pnlCONSULTA
            // 
            pnlCONSULTA.Controls.Add(datagridView1);
            pnlCONSULTA.Controls.Add(lblCONSULTA);
            pnlCONSULTA.Location = new Point(805, 119);
            pnlCONSULTA.Name = "pnlCONSULTA";
            pnlCONSULTA.Size = new Size(1005, 896);
            pnlCONSULTA.TabIndex = 11;
            pnlCONSULTA.Visible = false;
            // 
            // pnlCREAR
            // 
            pnlCREAR.Controls.Add(btn_confirmarCompra);
            pnlCREAR.Controls.Add(lbl_compra_cantidad);
            pnlCREAR.Controls.Add(lbl_compra_producto);
            pnlCREAR.Controls.Add(lbl_compra_proveedor);
            pnlCREAR.Controls.Add(label1);
            pnlCREAR.Controls.Add(txtCrearNombreProveedor);
            pnlCREAR.Controls.Add(txtCrearCantidadComprada);
            pnlCREAR.Controls.Add(txtCrearNombreProducto);
            pnlCREAR.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            pnlCREAR.Location = new Point(803, 118);
            pnlCREAR.Name = "pnlCREAR";
            pnlCREAR.Size = new Size(1005, 896);
            pnlCREAR.TabIndex = 12;
            pnlCREAR.Visible = false;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(379, 23);
            label1.Name = "label1";
            label1.Size = new Size(305, 52);
            label1.TabIndex = 0;
            label1.Text = "CREAR COMPRA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(336, 24);
            label2.Name = "label2";
            label2.Size = new Size(392, 52);
            label2.TabIndex = 0;
            label2.Text = "MODIFICAR COMPRA";
            // 
            // txtCrearID
            // 
            txtCrearID.Location = new Point(176, 287);
            txtCrearID.Name = "txtCrearID";
            txtCrearID.Size = new Size(100, 23);
            txtCrearID.TabIndex = 10;
            // 
            // btn_confirmarModificacion
            // 
            btn_confirmarModificacion.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_confirmarModificacion.Location = new Point(455, 574);
            btn_confirmarModificacion.Name = "btn_confirmarModificacion";
            btn_confirmarModificacion.Size = new Size(227, 98);
            btn_confirmarModificacion.TabIndex = 14;
            btn_confirmarModificacion.Text = "CONFIRMAR MODIFICACIÓN";
            btn_confirmarModificacion.UseVisualStyleBackColor = true;
            btn_confirmarModificacion.Click += btn_confirmarModificacion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(46, 284);
            label3.Name = "label3";
            label3.Size = new Size(129, 25);
            label3.TabIndex = 15;
            label3.Text = "ID de compra:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(281, 284);
            label4.Name = "label4";
            label4.Size = new Size(208, 25);
            label4.TabIndex = 16;
            label4.Text = "Nombre del proveedor:";
            // 
            // txtModificarProveedor
            // 
            txtModificarProveedor.Location = new Point(488, 287);
            txtModificarProveedor.Name = "txtModificarProveedor";
            txtModificarProveedor.Size = new Size(100, 23);
            txtModificarProveedor.TabIndex = 17;
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
            // txtModificarProducto
            // 
            txtModificarProducto.Location = new Point(684, 287);
            txtModificarProducto.Name = "txtModificarProducto";
            txtModificarProducto.Size = new Size(100, 23);
            txtModificarProducto.TabIndex = 19;
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
            // txtModificarCantidad
            // 
            txtModificarCantidad.Location = new Point(879, 287);
            txtModificarCantidad.Name = "txtModificarCantidad";
            txtModificarCantidad.Size = new Size(100, 23);
            txtModificarCantidad.TabIndex = 21;
            // 
            // pnlMODIFICAR
            // 
            pnlMODIFICAR.Controls.Add(txtModificarCantidad);
            pnlMODIFICAR.Controls.Add(lblModificarCantidad);
            pnlMODIFICAR.Controls.Add(txtModificarProducto);
            pnlMODIFICAR.Controls.Add(lblModificarProducto);
            pnlMODIFICAR.Controls.Add(txtModificarProveedor);
            pnlMODIFICAR.Controls.Add(label4);
            pnlMODIFICAR.Controls.Add(label3);
            pnlMODIFICAR.Controls.Add(btn_confirmarModificacion);
            pnlMODIFICAR.Controls.Add(txtCrearID);
            pnlMODIFICAR.Controls.Add(label2);
            pnlMODIFICAR.Location = new Point(803, 117);
            pnlMODIFICAR.Name = "pnlMODIFICAR";
            pnlMODIFICAR.Size = new Size(1007, 917);
            pnlMODIFICAR.TabIndex = 13;
            pnlMODIFICAR.Visible = false;
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
            Controls.Add(btnCONSULTA_HISTORIAL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras";
            Text = "m";
            ((System.ComponentModel.ISupportInitialize)datagridView1).EndInit();
            pnlCONSULTA.ResumeLayout(false);
            pnlCONSULTA.PerformLayout();
            pnlCREAR.ResumeLayout(false);
            pnlCREAR.PerformLayout();
            pnlMODIFICAR.ResumeLayout(false);
            pnlMODIFICAR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblCONSULTA;
        private Button btnCONSULTA_HISTORIAL;
        private Button btn_CREAR_COMPRA;
        private Button btn_MODIFICAR_COMPRA;
        private TextBox txtCrearNombreProveedor;
        private TextBox txtCrearNombreProducto;
        private TextBox txtCrearCantidadComprada;
        private DataGridView datagridView1;
        private Panel pnlCONSULTA;
        private Panel pnlCREAR;
        private Label label1;
        private Label lbl_compra_proveedor;
        private Label lbl_compra_producto;
        private Label lbl_compra_cantidad;
        private Button btn_confirmarCompra;
        private Label label2;
        private TextBox txtCrearID;
        private Button btn_confirmarModificacion;
        private Label label3;
        private Label label4;
        private TextBox txtModificarProveedor;
        private Label lblModificarProducto;
        private TextBox txtModificarProducto;
        private Label lblModificarCantidad;
        private TextBox txtModificarCantidad;
        private Panel pnlMODIFICAR;
    }
}