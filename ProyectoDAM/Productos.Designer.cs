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
            btn_MODIFICAR_VENTA = new Button();
            btnCREAR_VENTA = new Button();
            btn_CONSULTAR_HISTORIAL = new Button();
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
            // btn_MODIFICAR_VENTA
            // 
            btn_MODIFICAR_VENTA.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_MODIFICAR_VENTA.Location = new Point(226, 646);
            btn_MODIFICAR_VENTA.Name = "btn_MODIFICAR_VENTA";
            btn_MODIFICAR_VENTA.Size = new Size(484, 126);
            btn_MODIFICAR_VENTA.TabIndex = 6;
            btn_MODIFICAR_VENTA.Text = "MODIFICAR VENTA";
            btn_MODIFICAR_VENTA.UseVisualStyleBackColor = true;
            // 
            // btnCREAR_VENTA
            // 
            btnCREAR_VENTA.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btnCREAR_VENTA.Location = new Point(226, 372);
            btnCREAR_VENTA.Name = "btnCREAR_VENTA";
            btnCREAR_VENTA.Size = new Size(484, 126);
            btnCREAR_VENTA.TabIndex = 5;
            btnCREAR_VENTA.Text = "CREAR VENTA";
            btnCREAR_VENTA.UseVisualStyleBackColor = true;
            // 
            // btn_CONSULTAR_HISTORIAL
            // 
            btn_CONSULTAR_HISTORIAL.Font = new Font("Segoe UI", 29F, FontStyle.Regular, GraphicsUnit.Point);
            btn_CONSULTAR_HISTORIAL.Location = new Point(226, 118);
            btn_CONSULTAR_HISTORIAL.Name = "btn_CONSULTAR_HISTORIAL";
            btn_CONSULTAR_HISTORIAL.Size = new Size(484, 126);
            btn_CONSULTAR_HISTORIAL.TabIndex = 4;
            btn_CONSULTAR_HISTORIAL.Text = "CONSULTAR HISTORIAL DE VENTAS";
            btn_CONSULTAR_HISTORIAL.UseVisualStyleBackColor = true;
            // 
            // Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1841, 1089);
            Controls.Add(btn_MODIFICAR_VENTA);
            Controls.Add(btnCREAR_VENTA);
            Controls.Add(btn_CONSULTAR_HISTORIAL);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Productos";
            Text = "Productos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_MODIFICAR_VENTA;
        private Button btnCREAR_VENTA;
        private Button btn_CONSULTAR_HISTORIAL;
    }
}