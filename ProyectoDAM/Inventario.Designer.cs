namespace ProyectoDAM
{
    partial class Inventario
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
            btn_CONSULTA_INVENTARIO = new Button();
            datagridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datagridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(858, 119);
            label1.Name = "label1";
            label1.Size = new Size(238, 52);
            label1.TabIndex = 0;
            label1.Text = "INVENTARIO";
            // 
            // btn_CONSULTA_INVENTARIO
            // 
            btn_CONSULTA_INVENTARIO.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CONSULTA_INVENTARIO.Location = new Point(61, 451);
            btn_CONSULTA_INVENTARIO.Name = "btn_CONSULTA_INVENTARIO";
            btn_CONSULTA_INVENTARIO.Size = new Size(484, 126);
            btn_CONSULTA_INVENTARIO.TabIndex = 2;
            btn_CONSULTA_INVENTARIO.Text = "CONSULTAR INVENTARIO";
            btn_CONSULTA_INVENTARIO.UseVisualStyleBackColor = true;
            btn_CONSULTA_INVENTARIO.Click += btn_CONSULTA_INVENTARIO_Click;
            // 
            // datagridView1
            // 
            datagridView1.AllowUserToAddRows = false;
            datagridView1.AllowUserToDeleteRows = false;
            datagridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridView1.Location = new Point(716, 311);
            datagridView1.MultiSelect = false;
            datagridView1.Name = "datagridView1";
            datagridView1.ReadOnly = true;
            datagridView1.RowHeadersVisible = false;
            datagridView1.RowTemplate.Height = 25;
            datagridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridView1.Size = new Size(790, 392);
            datagridView1.TabIndex = 5;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(datagridView1);
            Controls.Add(btn_CONSULTA_INVENTARIO);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)datagridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_CONSULTA_INVENTARIO;
        private DataGridView datagridView1;
    }
}