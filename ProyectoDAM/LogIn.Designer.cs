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
            imgUSUARIO = new PictureBox();
            imgPASS = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)imgUSUARIO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPASS).BeginInit();
            SuspendLayout();
            // 
            // btnConexion
            // 
            btnConexion.Font = new Font("Segoe UI", 45F, FontStyle.Regular, GraphicsUnit.Point);
            btnConexion.Location = new Point(459, 328);
            btnConexion.Name = "btnConexion";
            btnConexion.Size = new Size(246, 92);
            btnConexion.TabIndex = 0;
            btnConexion.Text = "CHECK CONNECTION";
            btnConexion.UseVisualStyleBackColor = true;
            btnConexion.Click += btnConexion_Click;
            // 
            // lblOK
            // 
            lblOK.AutoSize = true;
            lblOK.BackColor = Color.Transparent;
            lblOK.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblOK.ForeColor = Color.FromArgb(0, 192, 0);
            lblOK.Location = new Point(349, 491);
            lblOK.Name = "lblOK";
            lblOK.Size = new Size(193, 37);
            lblOK.TabIndex = 1;
            lblOK.Text = "CONEXION OK";
            // 
            // lblNOK
            // 
            lblNOK.AutoSize = true;
            lblNOK.BackColor = Color.Transparent;
            lblNOK.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblNOK.ForeColor = Color.Red;
            lblNOK.Location = new Point(604, 491);
            lblNOK.Name = "lblNOK";
            lblNOK.Size = new Size(213, 37);
            lblNOK.TabIndex = 2;
            lblNOK.Text = "CONEXION NOK";
            // 
            // lblUSUARIO
            // 
            lblUSUARIO.AutoSize = true;
            lblUSUARIO.BackColor = Color.Transparent;
            lblUSUARIO.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblUSUARIO.ForeColor = Color.FromArgb(41, 128, 185);
            lblUSUARIO.Location = new Point(492, 119);
            lblUSUARIO.Name = "lblUSUARIO";
            lblUSUARIO.Size = new Size(80, 22);
            lblUSUARIO.TabIndex = 3;
            lblUSUARIO.Text = "Usuario:";
            // 
            // lblCONTRASEÑA
            // 
            lblCONTRASEÑA.AutoSize = true;
            lblCONTRASEÑA.BackColor = Color.Transparent;
            lblCONTRASEÑA.Font = new Font("Century Gothic", 13F, FontStyle.Bold, GraphicsUnit.Point);
            lblCONTRASEÑA.ForeColor = Color.FromArgb(41, 128, 185);
            lblCONTRASEÑA.Location = new Point(492, 193);
            lblCONTRASEÑA.Name = "lblCONTRASEÑA";
            lblCONTRASEÑA.Size = new Size(118, 22);
            lblCONTRASEÑA.TabIndex = 4;
            lblCONTRASEÑA.Text = "Contraseña:";
            // 
            // txtUSUARIO
            // 
            txtUSUARIO.BackColor = Color.White;
            txtUSUARIO.Cursor = Cursors.IBeam;
            txtUSUARIO.ForeColor = SystemColors.MenuHighlight;
            txtUSUARIO.Location = new Point(492, 147);
            txtUSUARIO.Name = "txtUSUARIO";
            txtUSUARIO.Size = new Size(176, 23);
            txtUSUARIO.TabIndex = 5;
            // 
            // txtCONTRASEÑA
            // 
            txtCONTRASEÑA.Location = new Point(492, 218);
            txtCONTRASEÑA.Name = "txtCONTRASEÑA";
            txtCONTRASEÑA.Size = new Size(176, 23);
            txtCONTRASEÑA.TabIndex = 6;
            txtCONTRASEÑA.UseSystemPasswordChar = true;
            // 
            // imgUSUARIO
            // 
            imgUSUARIO.BackColor = Color.Transparent;
            imgUSUARIO.Image = Properties.Resources.usuario;
            imgUSUARIO.Location = new Point(435, 120);
            imgUSUARIO.Name = "imgUSUARIO";
            imgUSUARIO.Size = new Size(36, 40);
            imgUSUARIO.SizeMode = PictureBoxSizeMode.Zoom;
            imgUSUARIO.TabIndex = 7;
            imgUSUARIO.TabStop = false;
            // 
            // imgPASS
            // 
            imgPASS.BackColor = Color.Transparent;
            imgPASS.Image = Properties.Resources.password;
            imgPASS.Location = new Point(434, 201);
            imgPASS.Name = "imgPASS";
            imgPASS.Size = new Size(37, 40);
            imgPASS.SizeMode = PictureBoxSizeMode.Zoom;
            imgPASS.TabIndex = 8;
            imgPASS.TabStop = false;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MintCream;
            BackgroundImage = Properties.Resources.fondo;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(902, 558);
            Controls.Add(imgPASS);
            Controls.Add(imgUSUARIO);
            Controls.Add(txtCONTRASEÑA);
            Controls.Add(txtUSUARIO);
            Controls.Add(lblCONTRASEÑA);
            Controls.Add(lblUSUARIO);
            Controls.Add(lblNOK);
            Controls.Add(lblOK);
            Controls.Add(btnConexion);
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicia sesion";
            ((System.ComponentModel.ISupportInitialize)imgUSUARIO).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPASS).EndInit();
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
        private PictureBox imgUSUARIO;
        private PictureBox imgPASS;


    }


}

