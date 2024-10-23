namespace ProyectoDAM
{
    partial class Ventas
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
            btn_CONSULTAR_HISTORIAL = new Button();
            btnCREAR_VENTA = new Button();
            btn_MODIFICAR_VENTA = new Button();
            pnlCONSULTA = new Panel();
            datagridVENTAS = new DataGridView();
            lblHISTORIAL = new Label();
            pnlCREAR = new Panel();
            btn_confirmarVenta = new Button();
            lbl_compra_cantidad = new Label();
            lbl_compra_producto = new Label();
            lbl_compra_cliente = new Label();
            txtCrearNombreCliente = new TextBox();
            txtCrearCantidadVendida = new TextBox();
            txtCrearNombreProducto = new TextBox();
            label1 = new Label();
            lblCREAR = new Label();
            pnlMODIFICAR = new Panel();
            lblDescModificarVenta = new Label();
            txtModificarCantidad = new TextBox();
            lblModificarCantidad = new Label();
            txtModificarProducto = new TextBox();
            lblModificarProducto = new Label();
            txtModificarCliente = new TextBox();
            lblModificarNombreCliente = new Label();
            lblModificarIDVenta = new Label();
            btn_confirmarModificacion = new Button();
            txtCrearID = new TextBox();
            lblTituloModificarVenta = new Label();
            pnlCONSULTA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)datagridVENTAS).BeginInit();
            pnlCREAR.SuspendLayout();
            pnlMODIFICAR.SuspendLayout();
            SuspendLayout();
            // 
            // btn_CONSULTAR_HISTORIAL
            // 
            btn_CONSULTAR_HISTORIAL.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CONSULTAR_HISTORIAL.Location = new Point(226, 118);
            btn_CONSULTAR_HISTORIAL.Name = "btn_CONSULTAR_HISTORIAL";
            btn_CONSULTAR_HISTORIAL.Size = new Size(484, 126);
            btn_CONSULTAR_HISTORIAL.TabIndex = 1;
            btn_CONSULTAR_HISTORIAL.Text = "CONSULTAR HISTORIAL DE VENTAS";
            btn_CONSULTAR_HISTORIAL.UseVisualStyleBackColor = true;
            btn_CONSULTAR_HISTORIAL.Click += btn_CONSULTAR_HISTORIAL_Click;
            // 
            // btnCREAR_VENTA
            // 
            btnCREAR_VENTA.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btnCREAR_VENTA.Location = new Point(226, 372);
            btnCREAR_VENTA.Name = "btnCREAR_VENTA";
            btnCREAR_VENTA.Size = new Size(484, 126);
            btnCREAR_VENTA.TabIndex = 2;
            btnCREAR_VENTA.Text = "CREAR VENTA";
            btnCREAR_VENTA.UseVisualStyleBackColor = true;
            btnCREAR_VENTA.Click += btnCREAR_VENTA_Click;
            // 
            // btn_MODIFICAR_VENTA
            // 
            btn_MODIFICAR_VENTA.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MODIFICAR_VENTA.Location = new Point(226, 646);
            btn_MODIFICAR_VENTA.Name = "btn_MODIFICAR_VENTA";
            btn_MODIFICAR_VENTA.Size = new Size(484, 126);
            btn_MODIFICAR_VENTA.TabIndex = 3;
            btn_MODIFICAR_VENTA.Text = "MODIFICAR VENTA";
            btn_MODIFICAR_VENTA.UseVisualStyleBackColor = true;
            btn_MODIFICAR_VENTA.Click += btn_MODIFICAR_VENTA_Click;
            // 
            // pnlCONSULTA
            // 
            pnlCONSULTA.Controls.Add(datagridVENTAS);
            pnlCONSULTA.Controls.Add(lblHISTORIAL);
            pnlCONSULTA.Location = new Point(807, 121);
            pnlCONSULTA.Name = "pnlCONSULTA";
            pnlCONSULTA.Size = new Size(1007, 916);
            pnlCONSULTA.TabIndex = 4;
            pnlCONSULTA.Visible = false;
            // 
            // datagridVENTAS
            // 
            datagridVENTAS.AllowUserToAddRows = false;
            datagridVENTAS.AllowUserToDeleteRows = false;
            datagridVENTAS.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridVENTAS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridVENTAS.Location = new Point(108, 262);
            datagridVENTAS.MultiSelect = false;
            datagridVENTAS.Name = "datagridVENTAS";
            datagridVENTAS.ReadOnly = true;
            datagridVENTAS.RowHeadersVisible = false;
            datagridVENTAS.RowTemplate.Height = 25;
            datagridVENTAS.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridVENTAS.Size = new Size(790, 392);
            datagridVENTAS.TabIndex = 6;
            // 
            // lblHISTORIAL
            // 
            lblHISTORIAL.AutoSize = true;
            lblHISTORIAL.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblHISTORIAL.Location = new Point(334, 48);
            lblHISTORIAL.Name = "lblHISTORIAL";
            lblHISTORIAL.Size = new Size(409, 52);
            lblHISTORIAL.TabIndex = 0;
            lblHISTORIAL.Text = "HISTORIAL DE VENTAS";
            // 
            // pnlCREAR
            // 
            pnlCREAR.Controls.Add(btn_confirmarVenta);
            pnlCREAR.Controls.Add(lbl_compra_cantidad);
            pnlCREAR.Controls.Add(lbl_compra_producto);
            pnlCREAR.Controls.Add(lbl_compra_cliente);
            pnlCREAR.Controls.Add(txtCrearNombreCliente);
            pnlCREAR.Controls.Add(txtCrearCantidadVendida);
            pnlCREAR.Controls.Add(txtCrearNombreProducto);
            pnlCREAR.Controls.Add(label1);
            pnlCREAR.Controls.Add(lblCREAR);
            pnlCREAR.Location = new Point(808, 122);
            pnlCREAR.Name = "pnlCREAR";
            pnlCREAR.Size = new Size(1006, 915);
            pnlCREAR.TabIndex = 5;
            pnlCREAR.Visible = false;
            // 
            // btn_confirmarVenta
            // 
            btn_confirmarVenta.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_confirmarVenta.Location = new Point(437, 521);
            btn_confirmarVenta.Name = "btn_confirmarVenta";
            btn_confirmarVenta.Size = new Size(227, 98);
            btn_confirmarVenta.TabIndex = 20;
            btn_confirmarVenta.Text = "CONFIRMAR VENTA";
            btn_confirmarVenta.UseVisualStyleBackColor = true;
            btn_confirmarVenta.Click += btn_confirmarVenta_Click;
            // 
            // lbl_compra_cantidad
            // 
            lbl_compra_cantidad.AutoSize = true;
            lbl_compra_cantidad.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_compra_cantidad.Location = new Point(715, 370);
            lbl_compra_cantidad.Name = "lbl_compra_cantidad";
            lbl_compra_cantidad.Size = new Size(92, 25);
            lbl_compra_cantidad.TabIndex = 19;
            lbl_compra_cantidad.Text = "Cantidad:";
            // 
            // lbl_compra_producto
            // 
            lbl_compra_producto.AutoSize = true;
            lbl_compra_producto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_compra_producto.Location = new Point(481, 370);
            lbl_compra_producto.Name = "lbl_compra_producto";
            lbl_compra_producto.Size = new Size(93, 25);
            lbl_compra_producto.TabIndex = 18;
            lbl_compra_producto.Text = "Producto:";
            // 
            // lbl_compra_cliente
            // 
            lbl_compra_cliente.AutoSize = true;
            lbl_compra_cliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_compra_cliente.Location = new Point(151, 370);
            lbl_compra_cliente.Name = "lbl_compra_cliente";
            lbl_compra_cliente.Size = new Size(180, 25);
            lbl_compra_cliente.TabIndex = 17;
            lbl_compra_cliente.Text = "Nombre del Cliente:";
            // 
            // txtCrearNombreCliente
            // 
            txtCrearNombreCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearNombreCliente.Location = new Point(345, 367);
            txtCrearNombreCliente.Name = "txtCrearNombreCliente";
            txtCrearNombreCliente.Size = new Size(100, 32);
            txtCrearNombreCliente.TabIndex = 14;
            // 
            // txtCrearCantidadVendida
            // 
            txtCrearCantidadVendida.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearCantidadVendida.Location = new Point(808, 367);
            txtCrearCantidadVendida.Name = "txtCrearCantidadVendida";
            txtCrearCantidadVendida.Size = new Size(100, 29);
            txtCrearCantidadVendida.TabIndex = 16;
            // 
            // txtCrearNombreProducto
            // 
            txtCrearNombreProducto.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            txtCrearNombreProducto.Location = new Point(577, 367);
            txtCrearNombreProducto.Name = "txtCrearNombreProducto";
            txtCrearNombreProducto.Size = new Size(100, 32);
            txtCrearNombreProducto.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(351, 157);
            label1.Name = "label1";
            label1.Size = new Size(356, 21);
            label1.TabIndex = 1;
            label1.Text = "Introduce los datos para modificar la compra:";
            // 
            // lblCREAR
            // 
            lblCREAR.AutoSize = true;
            lblCREAR.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblCREAR.Location = new Point(403, 58);
            lblCREAR.Name = "lblCREAR";
            lblCREAR.Size = new Size(263, 52);
            lblCREAR.TabIndex = 0;
            lblCREAR.Text = "CREAR VENTA";
            // 
            // pnlMODIFICAR
            // 
            pnlMODIFICAR.Controls.Add(lblDescModificarVenta);
            pnlMODIFICAR.Controls.Add(txtModificarCantidad);
            pnlMODIFICAR.Controls.Add(lblModificarCantidad);
            pnlMODIFICAR.Controls.Add(txtModificarProducto);
            pnlMODIFICAR.Controls.Add(lblModificarProducto);
            pnlMODIFICAR.Controls.Add(txtModificarCliente);
            pnlMODIFICAR.Controls.Add(lblModificarNombreCliente);
            pnlMODIFICAR.Controls.Add(lblModificarIDVenta);
            pnlMODIFICAR.Controls.Add(btn_confirmarModificacion);
            pnlMODIFICAR.Controls.Add(txtCrearID);
            pnlMODIFICAR.Controls.Add(lblTituloModificarVenta);
            pnlMODIFICAR.Location = new Point(809, 123);
            pnlMODIFICAR.Name = "pnlMODIFICAR";
            pnlMODIFICAR.Size = new Size(1007, 916);
            pnlMODIFICAR.TabIndex = 14;
            pnlMODIFICAR.Visible = false;
            // 
            // lblDescModificarVenta
            // 
            lblDescModificarVenta.AutoSize = true;
            lblDescModificarVenta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblDescModificarVenta.Location = new Point(340, 106);
            lblDescModificarVenta.Name = "lblDescModificarVenta";
            lblDescModificarVenta.Size = new Size(341, 21);
            lblDescModificarVenta.TabIndex = 22;
            lblDescModificarVenta.Text = "Introduce los datos para modificar la venta:";
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
            // txtModificarCliente
            // 
            txtModificarCliente.Location = new Point(488, 287);
            txtModificarCliente.Name = "txtModificarCliente";
            txtModificarCliente.Size = new Size(100, 23);
            txtModificarCliente.TabIndex = 17;
            // 
            // lblModificarNombreCliente
            // 
            lblModificarNombreCliente.AutoSize = true;
            lblModificarNombreCliente.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificarNombreCliente.Location = new Point(281, 284);
            lblModificarNombreCliente.Name = "lblModificarNombreCliente";
            lblModificarNombreCliente.Size = new Size(177, 25);
            lblModificarNombreCliente.TabIndex = 16;
            lblModificarNombreCliente.Text = "Nombre del cliente:";
            // 
            // lblModificarIDVenta
            // 
            lblModificarIDVenta.AutoSize = true;
            lblModificarIDVenta.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblModificarIDVenta.Location = new Point(46, 284);
            lblModificarIDVenta.Name = "lblModificarIDVenta";
            lblModificarIDVenta.Size = new Size(111, 25);
            lblModificarIDVenta.TabIndex = 15;
            lblModificarIDVenta.Text = "ID de venta:";
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
            // lblTituloModificarVenta
            // 
            lblTituloModificarVenta.AutoSize = true;
            lblTituloModificarVenta.Font = new Font("Segoe UI", 29F, FontStyle.Underline, GraphicsUnit.Point);
            lblTituloModificarVenta.Location = new Point(336, 24);
            lblTituloModificarVenta.Name = "lblTituloModificarVenta";
            lblTituloModificarVenta.Size = new Size(350, 52);
            lblTituloModificarVenta.TabIndex = 0;
            lblTituloModificarVenta.Text = "MODIFICAR VENTA";
            // 
            // Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(pnlMODIFICAR);
            Controls.Add(pnlCREAR);
            Controls.Add(pnlCONSULTA);
            Controls.Add(btn_MODIFICAR_VENTA);
            Controls.Add(btnCREAR_VENTA);
            Controls.Add(btn_CONSULTAR_HISTORIAL);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ventas";
            Text = "Ventas";
            pnlCONSULTA.ResumeLayout(false);
            pnlCONSULTA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)datagridVENTAS).EndInit();
            pnlCREAR.ResumeLayout(false);
            pnlCREAR.PerformLayout();
            pnlMODIFICAR.ResumeLayout(false);
            pnlMODIFICAR.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_CONSULTAR_HISTORIAL;
        private Button btnCREAR_VENTA;
        private Button btn_MODIFICAR_VENTA;
        private Panel pnlCONSULTA;
        private Label lblHISTORIAL;
        private DataGridView datagridVENTAS;
        private Panel pnlCREAR;
        private Label lblCREAR;
        private Label label1;
        private Label lbl_compra_cantidad;
        private Label lbl_compra_producto;
        private Label lbl_compra_cliente;
        private TextBox txtCrearNombreCliente;
        private TextBox txtCrearCantidadVendida;
        private TextBox txtCrearNombreProducto;
        private Button btn_confirmarVenta;
        private Panel pnlMODIFICAR;
        private Label lblDescModificarVenta;
        private TextBox txtModificarCantidad;
        private Label lblModificarCantidad;
        private TextBox txtModificarProducto;
        private Label lblModificarProducto;
        private TextBox txtModificarCliente;
        private Label lblModificarNombreCliente;
        private Label lblModificarIDVenta;
        private Button btn_confirmarModificacion;
        private TextBox txtCrearID;
        private Label lblTituloModificarVenta;
    }
}