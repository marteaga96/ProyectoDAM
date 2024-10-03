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
            lblTITULO = new Label();
            btnCONSULTA_HISTORIAL = new Button();
            btn_CREAR_COMPRA = new Button();
            btn_MODIFICAR_COMPRA = new Button();
            comboBox1 = new ComboBox();
            txtNombreProveedor = new TextBox();
            txtNombreProducto = new TextBox();
            txtCantidadComprada = new TextBox();
            txtID = new TextBox();
            datagridView1 = new DataGridView();
            pnlCONSULTA = new Panel();
            ((System.ComponentModel.ISupportInitialize)datagridView1).BeginInit();
            pnlCONSULTA.SuspendLayout();
            SuspendLayout();
            // 
            // lblTITULO
            // 
            lblTITULO.AutoSize = true;
            lblTITULO.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            lblTITULO.Location = new Point(1035, 192);
            lblTITULO.Name = "lblTITULO";
            lblTITULO.Size = new Size(0, 52);
            lblTITULO.TabIndex = 0;
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
            txtNombreProveedor.Location = new Point(1035, 60);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(100, 23);
            txtNombreProveedor.TabIndex = 7;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(1189, 60);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(100, 23);
            txtNombreProducto.TabIndex = 8;
            // 
            // txtCantidadComprada
            // 
            txtCantidadComprada.Location = new Point(1323, 60);
            txtCantidadComprada.Name = "txtCantidadComprada";
            txtCantidadComprada.Size = new Size(100, 23);
            txtCantidadComprada.TabIndex = 9;
            // 
            // txtID
            // 
            txtID.Location = new Point(901, 60);
            txtID.Name = "txtID";
            txtID.Size = new Size(100, 23);
            txtID.TabIndex = 10;
            // 
            // datagridView1
            // 
            datagridView1.AllowUserToAddRows = false;
            datagridView1.AllowUserToDeleteRows = false;
            datagridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridView1.Location = new Point(59, 43);
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
            pnlCONSULTA.Location = new Point(773, 192);
            pnlCONSULTA.Name = "pnlCONSULTA";
            pnlCONSULTA.Size = new Size(1005, 896);
            pnlCONSULTA.TabIndex = 11;
            pnlCONSULTA.Visible = false;
            // 
            // Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(pnlCONSULTA);
            Controls.Add(txtID);
            Controls.Add(txtCantidadComprada);
            Controls.Add(txtNombreProducto);
            Controls.Add(txtNombreProveedor);
            Controls.Add(comboBox1);
            Controls.Add(btn_MODIFICAR_COMPRA);
            Controls.Add(btn_CREAR_COMPRA);
            Controls.Add(btnCONSULTA_HISTORIAL);
            Controls.Add(lblTITULO);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Compras";
            Text = "m";
            ((System.ComponentModel.ISupportInitialize)datagridView1).EndInit();
            pnlCONSULTA.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTITULO;
        private Button btnCONSULTA_HISTORIAL;
        private Button btn_CREAR_COMPRA;
        private Button btn_MODIFICAR_COMPRA;
        private ComboBox comboBox1;
        private TextBox txtNombreProveedor;
        private TextBox txtNombreProducto;
        private TextBox txtCantidadComprada;
        private TextBox txtID;
        private DataGridView datagridView1;
        private Panel pnlCONSULTA;
    }
}