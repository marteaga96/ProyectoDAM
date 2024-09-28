namespace ProyectoDAM
{
    partial class ucCOMPRAS
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnCONSULTA_HISTORIAL = new Button();
            btn_CREAR_COMPRA = new Button();
            btn_MODIFICAR_COMPRA = new Button();
            DatagridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)DatagridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(845, 192);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(240, 52);
            label1.TabIndex = 0;
            label1.Text = "ucCOMPRAS";
            // 
            // btnCONSULTA_HISTORIAL
            // 
            btnCONSULTA_HISTORIAL.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btnCONSULTA_HISTORIAL.Location = new Point(226, 268);
            btnCONSULTA_HISTORIAL.Name = "btnCONSULTA_HISTORIAL";
            btnCONSULTA_HISTORIAL.Size = new Size(484, 126);
            btnCONSULTA_HISTORIAL.TabIndex = 1;
            btnCONSULTA_HISTORIAL.Text = "CONSULTAR HISTORIAL DE COMPRAS";
            btnCONSULTA_HISTORIAL.UseVisualStyleBackColor = true;
            btnCONSULTA_HISTORIAL.Click += CONSULTA_Click;
            // 
            // btn_CREAR_COMPRA
            // 
            btn_CREAR_COMPRA.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CREAR_COMPRA.Location = new Point(226, 522);
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
            btn_MODIFICAR_COMPRA.Location = new Point(226, 796);
            btn_MODIFICAR_COMPRA.Name = "btn_MODIFICAR_COMPRA";
            btn_MODIFICAR_COMPRA.Size = new Size(484, 126);
            btn_MODIFICAR_COMPRA.TabIndex = 3;
            btn_MODIFICAR_COMPRA.Text = "MODIFICAR COMPRA";
            btn_MODIFICAR_COMPRA.UseVisualStyleBackColor = true;
            // 
            // DatagridView1
            // 
            DatagridView1.AccessibleRole = AccessibleRole.None;
            DatagridView1.AllowUserToAddRows = false;
            DatagridView1.AllowUserToDeleteRows = false;
            DatagridView1.AllowUserToResizeRows = false;
            DatagridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            DatagridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DatagridView1.Cursor = Cursors.Hand;
            DatagridView1.Location = new Point(845, 268);
            DatagridView1.Name = "DatagridView1";
            DatagridView1.RowTemplate.Height = 25;
            DatagridView1.Size = new Size(873, 170);
            DatagridView1.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.Items.AddRange(new object[] { "MARIO", "PRUEBA", "PRUEBA2" });
            comboBox1.Location = new Point(260, 143);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // ucCOMPRAS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(DatagridView1);
            Controls.Add(btn_MODIFICAR_COMPRA);
            Controls.Add(btn_CREAR_COMPRA);
            Controls.Add(btnCONSULTA_HISTORIAL);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ucCOMPRAS";
            Size = new Size(1920, 1080);
            ((System.ComponentModel.ISupportInitialize)DatagridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnCONSULTA_HISTORIAL;
        private Button btn_CREAR_COMPRA;
        private Button btn_MODIFICAR_COMPRA;
        public DataGridView DatagridView1;
        private ComboBox comboBox1;
    }
}
