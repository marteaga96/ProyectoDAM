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
            datagridINVENTARIO = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)datagridINVENTARIO).BeginInit();
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
            // datagridINVENTARIO
            // 
            datagridINVENTARIO.AllowUserToAddRows = false;
            datagridINVENTARIO.AllowUserToDeleteRows = false;
            datagridINVENTARIO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            datagridINVENTARIO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            datagridINVENTARIO.Location = new Point(716, 311);
            datagridINVENTARIO.MultiSelect = false;
            datagridINVENTARIO.Name = "datagridINVENTARIO";
            datagridINVENTARIO.ReadOnly = true;
            datagridINVENTARIO.RowHeadersVisible = false;
            datagridINVENTARIO.RowTemplate.Height = 25;
            datagridINVENTARIO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            datagridINVENTARIO.Size = new Size(790, 392);
            datagridINVENTARIO.TabIndex = 5;
            // 
            // Inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(datagridINVENTARIO);
            Controls.Add(btn_CONSULTA_INVENTARIO);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventario";
            Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)datagridINVENTARIO).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_CONSULTA_INVENTARIO;
        private DataGridView datagridINVENTARIO;
    }
}