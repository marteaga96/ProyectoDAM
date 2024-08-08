namespace ProyectoDAM
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConexion = new Button();
            lblOK = new Label();
            lblNOK = new Label();
            SuspendLayout();
            // 
            // btnConexion
            // 
            btnConexion.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            btnConexion.Location = new Point(276, 123);
            btnConexion.Name = "btnConexion";
            btnConexion.Size = new Size(247, 92);
            btnConexion.TabIndex = 0;
            btnConexion.Text = "CHECK CONNECTION";
            btnConexion.UseVisualStyleBackColor = true;
            btnConexion.Click += btnConexion_Click;
            // 
            // lblOK
            // 
            lblOK.AutoSize = true;
            lblOK.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOK.ForeColor = Color.FromArgb(0, 192, 0);
            lblOK.Location = new Point(130, 313);
            lblOK.Name = "lblOK";
            lblOK.Size = new Size(193, 37);
            lblOK.TabIndex = 1;
            lblOK.Text = "CONEXION OK";
            // 
            // lblNOK
            // 
            lblNOK.AutoSize = true;
            lblNOK.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNOK.ForeColor = Color.Red;
            lblNOK.Location = new Point(545, 322);
            lblNOK.Name = "lblNOK";
            lblNOK.Size = new Size(213, 37);
            lblNOK.TabIndex = 2;
            lblNOK.Text = "CONEXION NOK";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblNOK);
            Controls.Add(lblOK);
            Controls.Add(btnConexion);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConexion;
        private Label lblOK;
        private Label lblNOK;
    }
}
