namespace ProyectoDAM
{
    partial class LogIn
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
            lblUSUARIO = new Label();
            lblCONTRASEÑA = new Label();
            txtUSUARIO = new TextBox();
            txtCONTRASEÑA = new TextBox();
            SuspendLayout();
            // 
            // btnConexion
            // 
            btnConexion.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            btnConexion.Location = new Point(277, 22);
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
            // lblUSUARIO
            // 
            lblUSUARIO.AutoSize = true;
            lblUSUARIO.Location = new Point(109, 181);
            lblUSUARIO.Name = "lblUSUARIO";
            lblUSUARIO.Size = new Size(50, 15);
            lblUSUARIO.TabIndex = 3;
            lblUSUARIO.Text = "Usuario:";
            // 
            // lblCONTRASEÑA
            // 
            lblCONTRASEÑA.AutoSize = true;
            lblCONTRASEÑA.Location = new Point(109, 234);
            lblCONTRASEÑA.Name = "lblCONTRASEÑA";
            lblCONTRASEÑA.Size = new Size(70, 15);
            lblCONTRASEÑA.TabIndex = 4;
            lblCONTRASEÑA.Text = "Contraseña:";
            // 
            // txtUSUARIO
            // 
            txtUSUARIO.Location = new Point(212, 173);
            txtUSUARIO.Name = "txtUSUARIO";
            txtUSUARIO.Size = new Size(100, 23);
            txtUSUARIO.TabIndex = 5;
            // 
            // txtCONTRASEÑA
            // 
            txtCONTRASEÑA.Location = new Point(212, 226);
            txtCONTRASEÑA.Name = "txtCONTRASEÑA";
            txtCONTRASEÑA.Size = new Size(100, 23);
            txtCONTRASEÑA.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCONTRASEÑA);
            Controls.Add(txtUSUARIO);
            Controls.Add(lblCONTRASEÑA);
            Controls.Add(lblUSUARIO);
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
        private Label lblUSUARIO;
        private Label lblCONTRASEÑA;
        private TextBox txtUSUARIO;
        private TextBox txtCONTRASEÑA;
    }
}
