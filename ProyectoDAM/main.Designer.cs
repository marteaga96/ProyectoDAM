﻿namespace ProyectoDAM
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
            panelNAV = new Panel();
            btnCERRARSESION = new Button();
            button1 = new Button();
            lblBIENVENIDA = new Label();
            btnINVENTARIO = new Button();
            btnVENTAS = new Button();
            btnCOMPRAS = new Button();
            btnPERFIL = new Button();
            panelNAV.SuspendLayout();
            SuspendLayout();
            // 
            // panelNAV
            // 
            panelNAV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNAV.BackColor = Color.FromArgb(32, 43, 54);
            panelNAV.Controls.Add(btnCERRARSESION);
            panelNAV.Controls.Add(button1);
            panelNAV.Controls.Add(lblBIENVENIDA);
            panelNAV.Controls.Add(btnINVENTARIO);
            panelNAV.Controls.Add(btnVENTAS);
            panelNAV.Controls.Add(btnCOMPRAS);
            panelNAV.Controls.Add(btnPERFIL);
            panelNAV.Location = new Point(0, 0);
            panelNAV.Margin = new Padding(3, 2, 3, 2);
            panelNAV.Name = "panelNAV";
            panelNAV.Size = new Size(1680, 90);
            panelNAV.TabIndex = 0;
            // 
            // btnCERRARSESION
            // 
            btnCERRARSESION.Location = new Point(1460, 51);
            btnCERRARSESION.Name = "btnCERRARSESION";
            btnCERRARSESION.Size = new Size(153, 23);
            btnCERRARSESION.TabIndex = 8;
            btnCERRARSESION.Text = "Cerrar sesión";
            btnCERRARSESION.UseVisualStyleBackColor = true;
            btnCERRARSESION.Click += btnCERRARSESION_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.BackColor = Color.Transparent;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 63, 74);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 63, 74);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(959, 0);
            button1.Name = "button1";
            button1.Size = new Size(147, 90);
            button1.TabIndex = 7;
            button1.Text = "INVENTARIO";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblBIENVENIDA
            // 
            lblBIENVENIDA.Anchor = AnchorStyles.Top;
            lblBIENVENIDA.AutoSize = true;
            lblBIENVENIDA.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblBIENVENIDA.ForeColor = SystemColors.ButtonHighlight;
            lblBIENVENIDA.Location = new Point(1330, 19);
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
            btnINVENTARIO.Location = new Point(765, 0);
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
            btnVENTAS.Location = new Point(600, 0);
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
            btnCOMPRAS.Location = new Point(400, 0);
            btnCOMPRAS.Name = "btnCOMPRAS";
            btnCOMPRAS.Size = new Size(133, 90);
            btnCOMPRAS.TabIndex = 3;
            btnCOMPRAS.Text = "COMPRAS";
            btnCOMPRAS.UseVisualStyleBackColor = false;
            // 
            // btnPERFIL
            // 
            btnPERFIL.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnPERFIL.BackColor = Color.Transparent;
            btnPERFIL.Cursor = Cursors.Hand;
            btnPERFIL.FlatAppearance.BorderColor = SystemColors.ActiveCaption;
            btnPERFIL.FlatAppearance.BorderSize = 0;
            btnPERFIL.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 63, 74);
            btnPERFIL.FlatAppearance.MouseOverBackColor = Color.FromArgb(52, 63, 74);
            btnPERFIL.FlatStyle = FlatStyle.Flat;
            btnPERFIL.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPERFIL.ForeColor = SystemColors.ButtonHighlight;
            btnPERFIL.Location = new Point(200, 0);
            btnPERFIL.Name = "btnPERFIL";
            btnPERFIL.Size = new Size(113, 90);
            btnPERFIL.TabIndex = 2;
            btnPERFIL.Text = "PERFIL";
            btnPERFIL.UseVisualStyleBackColor = false;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1664, 775);
            Controls.Add(panelNAV);
            Name = "main";
            Text = "main";
            panelNAV.ResumeLayout(false);
            panelNAV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNAV;
        private Button btnPERFIL;
        private Button btnVENTAS;
        private Button btnCOMPRAS;
        private Button btnINVENTARIO;
        private Label lblBIENVENIDA;
        private Button button1;
        private Button btnCERRARSESION;
    }
}