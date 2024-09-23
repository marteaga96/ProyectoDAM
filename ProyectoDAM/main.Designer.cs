namespace ProyectoDAM
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            panelNAV = new Panel();
            groupHOME = new GroupBox();
            pictureBox1 = new PictureBox();
            btnCERRARSESION = new Button();
            btnGESTION = new Button();
            lblBIENVENIDA = new Label();
            btnINVENTARIO = new Button();
            btnVENTAS = new Button();
            btnCOMPRAS = new Button();
            btnHOME = new Button();
            groupGESTION = new GroupBox();
            btnEDITAR_DATOS_PERSONALES = new Button();
            lblROL = new Label();
            lblDEPARTAMENTO = new Label();
            lblFECHA_NACIMIENTO = new Label();
            lblAPELLIDOS = new Label();
            label1 = new Label();
            lblDATOS_PERSONALES = new Label();
            btnEDITAR_USUARIO = new Button();
            btnANADIR_USUARIO = new Button();
            panelNAV.SuspendLayout();
            groupHOME.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupGESTION.SuspendLayout();
            SuspendLayout();
            // 
            // panelNAV
            // 
            panelNAV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNAV.BackColor = Color.FromArgb(32, 43, 54);
            panelNAV.Controls.Add(groupHOME);
            panelNAV.Controls.Add(btnCERRARSESION);
            panelNAV.Controls.Add(btnGESTION);
            panelNAV.Controls.Add(lblBIENVENIDA);
            panelNAV.Controls.Add(btnINVENTARIO);
            panelNAV.Controls.Add(btnVENTAS);
            panelNAV.Controls.Add(btnCOMPRAS);
            panelNAV.Controls.Add(btnHOME);
            panelNAV.Location = new Point(0, 0);
            panelNAV.Margin = new Padding(3, 2, 3, 2);
            panelNAV.Name = "panelNAV";
            panelNAV.Size = new Size(1386, 90);
            panelNAV.TabIndex = 0;
            // 
            // groupHOME
            // 
            groupHOME.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupHOME.BackgroundImageLayout = ImageLayout.None;
            groupHOME.Controls.Add(pictureBox1);
            groupHOME.FlatStyle = FlatStyle.Flat;
            groupHOME.Location = new Point(1349, 67);
            groupHOME.Name = "groupHOME";
            groupHOME.Size = new Size(1368, 653);
            groupHOME.TabIndex = 1;
            groupHOME.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(441, 75);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(473, 448);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnCERRARSESION
            // 
            btnCERRARSESION.Location = new Point(1650, 54);
            btnCERRARSESION.Name = "btnCERRARSESION";
            btnCERRARSESION.Size = new Size(153, 23);
            btnCERRARSESION.TabIndex = 8;
            btnCERRARSESION.Text = "Cerrar sesión";
            btnCERRARSESION.UseVisualStyleBackColor = true;
            btnCERRARSESION.Click += btnCERRARSESION_Click;
            // 
            // btnGESTION
            // 
            btnGESTION.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnGESTION.BackColor = Color.Transparent;
            btnGESTION.Cursor = Cursors.Hand;
            btnGESTION.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnGESTION.FlatAppearance.BorderSize = 0;
            btnGESTION.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 63, 74);
            btnGESTION.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 63, 74);
            btnGESTION.FlatStyle = FlatStyle.Flat;
            btnGESTION.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnGESTION.ForeColor = SystemColors.ButtonHighlight;
            btnGESTION.Location = new Point(812, 0);
            btnGESTION.Name = "btnGESTION";
            btnGESTION.Size = new Size(147, 90);
            btnGESTION.TabIndex = 7;
            btnGESTION.Text = "GESTIÓN";
            btnGESTION.UseVisualStyleBackColor = false;
            // 
            // lblBIENVENIDA
            // 
            lblBIENVENIDA.Anchor = AnchorStyles.Top;
            lblBIENVENIDA.AutoSize = true;
            lblBIENVENIDA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBIENVENIDA.ForeColor = SystemColors.ButtonHighlight;
            lblBIENVENIDA.Location = new Point(1183, 19);
            lblBIENVENIDA.Margin = new Padding(0);
            lblBIENVENIDA.Name = "lblBIENVENIDA";
            lblBIENVENIDA.Size = new Size(0, 20);
            lblBIENVENIDA.TabIndex = 6;
            // 
            // btnINVENTARIO
            // 
            btnINVENTARIO.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnINVENTARIO.BackColor = Color.Transparent;
            btnINVENTARIO.Cursor = Cursors.Hand;
            btnINVENTARIO.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnINVENTARIO.FlatAppearance.BorderSize = 0;
            btnINVENTARIO.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 63, 74);
            btnINVENTARIO.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 63, 74);
            btnINVENTARIO.FlatStyle = FlatStyle.Flat;
            btnINVENTARIO.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnINVENTARIO.ForeColor = SystemColors.ButtonHighlight;
            btnINVENTARIO.Location = new Point(618, 0);
            btnINVENTARIO.Name = "btnINVENTARIO";
            btnINVENTARIO.Size = new Size(147, 90);
            btnINVENTARIO.TabIndex = 5;
            btnINVENTARIO.Text = "INVENTARIO";
            btnINVENTARIO.UseVisualStyleBackColor = false;
            // 
            // btnVENTAS
            // 
            btnVENTAS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnVENTAS.BackColor = Color.Transparent;
            btnVENTAS.Cursor = Cursors.Hand;
            btnVENTAS.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnVENTAS.FlatAppearance.BorderSize = 0;
            btnVENTAS.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 63, 74);
            btnVENTAS.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 63, 74);
            btnVENTAS.FlatStyle = FlatStyle.Flat;
            btnVENTAS.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnVENTAS.ForeColor = SystemColors.ButtonHighlight;
            btnVENTAS.Location = new Point(453, 0);
            btnVENTAS.Name = "btnVENTAS";
            btnVENTAS.Size = new Size(113, 90);
            btnVENTAS.TabIndex = 4;
            btnVENTAS.Text = "VENTAS";
            btnVENTAS.UseVisualStyleBackColor = false;
            // 
            // btnCOMPRAS
            // 
            btnCOMPRAS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnCOMPRAS.BackColor = Color.Transparent;
            btnCOMPRAS.Cursor = Cursors.Hand;
            btnCOMPRAS.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnCOMPRAS.FlatAppearance.BorderSize = 0;
            btnCOMPRAS.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 63, 74);
            btnCOMPRAS.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 63, 74);
            btnCOMPRAS.FlatStyle = FlatStyle.Flat;
            btnCOMPRAS.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnCOMPRAS.ForeColor = SystemColors.ButtonHighlight;
            btnCOMPRAS.Location = new Point(253, 0);
            btnCOMPRAS.Name = "btnCOMPRAS";
            btnCOMPRAS.Size = new Size(133, 90);
            btnCOMPRAS.TabIndex = 3;
            btnCOMPRAS.Text = "COMPRAS";
            btnCOMPRAS.UseVisualStyleBackColor = false;
            // 
            // btnHOME
            // 
            btnHOME.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnHOME.BackColor = Color.Transparent;
            btnHOME.Cursor = Cursors.Hand;
            btnHOME.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnHOME.FlatAppearance.BorderSize = 0;
            btnHOME.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 63, 74);
            btnHOME.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 63, 74);
            btnHOME.FlatStyle = FlatStyle.Flat;
            btnHOME.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnHOME.ForeColor = SystemColors.ButtonHighlight;
            btnHOME.Location = new Point(53, 0);
            btnHOME.Name = "btnHOME";
            btnHOME.Size = new Size(113, 90);
            btnHOME.TabIndex = 2;
            btnHOME.Text = "HOME";
            btnHOME.UseVisualStyleBackColor = false;
            // 
            // groupGESTION
            // 
            groupGESTION.Controls.Add(btnEDITAR_DATOS_PERSONALES);
            groupGESTION.Controls.Add(lblROL);
            groupGESTION.Controls.Add(lblDEPARTAMENTO);
            groupGESTION.Controls.Add(lblFECHA_NACIMIENTO);
            groupGESTION.Controls.Add(lblAPELLIDOS);
            groupGESTION.Controls.Add(label1);
            groupGESTION.Controls.Add(lblDATOS_PERSONALES);
            groupGESTION.Controls.Add(btnEDITAR_USUARIO);
            groupGESTION.Controls.Add(btnANADIR_USUARIO);
            groupGESTION.Location = new Point(0, 95);
            groupGESTION.Name = "groupGESTION";
            groupGESTION.Size = new Size(1800, 1080);
            groupGESTION.TabIndex = 1;
            groupGESTION.TabStop = false;
            groupGESTION.Text = "GESTIÓN";
            // 
            // btnEDITAR_DATOS_PERSONALES
            // 
            btnEDITAR_DATOS_PERSONALES.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            btnEDITAR_DATOS_PERSONALES.Location = new Point(329, 523);
            btnEDITAR_DATOS_PERSONALES.Name = "btnEDITAR_DATOS_PERSONALES";
            btnEDITAR_DATOS_PERSONALES.Size = new Size(360, 60);
            btnEDITAR_DATOS_PERSONALES.TabIndex = 8;
            btnEDITAR_DATOS_PERSONALES.Text = "EDITAR DATOS PERSONALES";
            btnEDITAR_DATOS_PERSONALES.UseVisualStyleBackColor = true;
            // 
            // lblROL
            // 
            lblROL.AutoSize = true;
            lblROL.Location = new Point(1105, 411);
            lblROL.Name = "lblROL";
            lblROL.Size = new Size(32, 15);
            lblROL.TabIndex = 7;
            lblROL.Text = "ROL:";
            // 
            // lblDEPARTAMENTO
            // 
            lblDEPARTAMENTO.AutoSize = true;
            lblDEPARTAMENTO.Location = new Point(1105, 367);
            lblDEPARTAMENTO.Name = "lblDEPARTAMENTO";
            lblDEPARTAMENTO.Size = new Size(97, 15);
            lblDEPARTAMENTO.TabIndex = 6;
            lblDEPARTAMENTO.Text = "DEPARTAMENTO:";
            // 
            // lblFECHA_NACIMIENTO
            // 
            lblFECHA_NACIMIENTO.AutoSize = true;
            lblFECHA_NACIMIENTO.Location = new Point(1105, 324);
            lblFECHA_NACIMIENTO.Name = "lblFECHA_NACIMIENTO";
            lblFECHA_NACIMIENTO.Size = new Size(138, 15);
            lblFECHA_NACIMIENTO.TabIndex = 5;
            lblFECHA_NACIMIENTO.Text = "FECHA DE NACIMIENTO:";
            // 
            // lblAPELLIDOS
            // 
            lblAPELLIDOS.AutoSize = true;
            lblAPELLIDOS.Location = new Point(1105, 277);
            lblAPELLIDOS.Name = "lblAPELLIDOS";
            lblAPELLIDOS.Size = new Size(69, 15);
            lblAPELLIDOS.TabIndex = 4;
            lblAPELLIDOS.Text = "APELLIDOS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1105, 231);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 3;
            label1.Text = "NOMBRE:";
            // 
            // lblDATOS_PERSONALES
            // 
            lblDATOS_PERSONALES.AutoSize = true;
            lblDATOS_PERSONALES.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            lblDATOS_PERSONALES.Location = new Point(1089, 114);
            lblDATOS_PERSONALES.Name = "lblDATOS_PERSONALES";
            lblDATOS_PERSONALES.Size = new Size(254, 36);
            lblDATOS_PERSONALES.TabIndex = 2;
            lblDATOS_PERSONALES.Text = "DATOS PERSONALES";
            // 
            // btnEDITAR_USUARIO
            // 
            btnEDITAR_USUARIO.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            btnEDITAR_USUARIO.Location = new Point(329, 322);
            btnEDITAR_USUARIO.Name = "btnEDITAR_USUARIO";
            btnEDITAR_USUARIO.Size = new Size(360, 60);
            btnEDITAR_USUARIO.TabIndex = 1;
            btnEDITAR_USUARIO.Text = "EDITAR USUARIO";
            btnEDITAR_USUARIO.UseVisualStyleBackColor = true;
            // 
            // btnANADIR_USUARIO
            // 
            btnANADIR_USUARIO.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            btnANADIR_USUARIO.Location = new Point(329, 114);
            btnANADIR_USUARIO.Name = "btnANADIR_USUARIO";
            btnANADIR_USUARIO.Size = new Size(360, 60);
            btnANADIR_USUARIO.TabIndex = 0;
            btnANADIR_USUARIO.Text = "AÑADIR USUARIO";
            btnANADIR_USUARIO.UseVisualStyleBackColor = true;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1370, 749);
            Controls.Add(groupGESTION);
            Controls.Add(panelNAV);
            Name = "main";
            Text = "main";
            panelNAV.ResumeLayout(false);
            panelNAV.PerformLayout();
            groupHOME.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupGESTION.ResumeLayout(false);
            groupGESTION.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNAV;
        private Button btnHOME;
        private Button btnVENTAS;
        private Button btnCOMPRAS;
        private Button btnINVENTARIO;
        private Label lblBIENVENIDA;
        private Button btnGESTION;
        private Button btnCERRARSESION;
        private GroupBox groupHOME;
        private PictureBox pictureBox1;
        private GroupBox groupGESTION;
        private Label lblDATOS_PERSONALES;
        private Button btnEDITAR_USUARIO;
        private Button btnANADIR_USUARIO;
        private Label lblROL;
        private Label lblDEPARTAMENTO;
        private Label lblFECHA_NACIMIENTO;
        private Label lblAPELLIDOS;
        private Label label1;
        private Button btnEDITAR_DATOS_PERSONALES;
    }
}