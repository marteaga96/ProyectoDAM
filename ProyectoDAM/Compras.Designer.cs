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
            label1 = new Label();
            btnCONSULTA_HISTORIAL = new Button();
            btn_CREAR_COMPRA = new Button();
            btn_MODIFICAR_COMPRA = new Button();
            datagridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            txtNombreProveedor = new TextBox();
            txtNombreProducto = new TextBox();
            txtCantidadComprada = new TextBox();
            txtID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)datagridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(845, 192);
            label1.Name = "label1";
            label1.Size = new Size(200, 52);
            label1.TabIndex = 0;
            label1.Text = "COMPRAS";
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
            // datagridView1
            // 
            datagridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridView1.Location = new Point(845, 268);
            datagridView1.MultiSelect = false;
            datagridView1.Name = "datagridView1";
            datagridView1.ReadOnly = true;
            datagridView1.RowHeadersVisible = false;
            datagridView1.RowTemplate.Height = 25;
            datagridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridView1.Size = new Size(787, 143);
            datagridView1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(227, 38);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(875, 97);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(100, 23);
            txtNombreProveedor.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(880, 143);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 8;
            // 
            // txtCantidadComprada
            // 
            txtCantidadComprada.Location = new Point(887, 180);
            txtCantidadComprada.Name = "txtCantidadComprada";
            txtCantidadComprada.Size = new Size(100, 23);
            txtCantidadComprada.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Location = new Point(856, 493);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 10;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(txtID);
            Controls.Add(txtCantidadComprada);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtNombreProveedor);
            Controls.Add(comboBox1);
            Controls.Add(datagridView1);
            Controls.Add(btn_MODIFICAR_COMPRA);
            Controls.Add(btn_CREAR_COMPRA);
            Controls.Add(btnCONSULTA_HISTORIAL);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras";
            Text = "Compras";
            ((System.ComponentModel.ISupportInitialize)datagridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCONSULTA_HISTORIAL;
        private Button btn_CREAR_COMPRA;
        private Button btn_MODIFICAR_COMPRA;
        private DataGridView datagridView1;
        private ComboBox comboBox1;
        private TextBox txtNombreProveedor;
        private TextBox txtNombreProducto;
        private TextBox txtCantidadComprada;
        private TextBox txtID;
    }
}