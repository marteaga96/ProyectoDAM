﻿using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDAM
{
    public partial class main : Form
    {
        private float originalFontSize;
        private bool isIncreasing;
        private float fontStep = 1.0f;
        public main()
        {

            InitializeComponent();
            DialogResult = DialogResult.OK;
            originalFontSize = btnPERFIL.Font.Size;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnPERFIL_Click(object sender, EventArgs e)
        {
            panelNAV.BackColor = Color.FromArgb(255, 32, 43, 54);

        }

        public main(string usuario)
        {
            //Texto de bienvenida.
            InitializeComponent();
            lblBIENVENIDA.Text = $"Bienvenid@ {usuario}";
        }

        private void btnCERRARSESION_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sesión cerrada con éxito.");
            Application.Exit();
        }

    }
}
