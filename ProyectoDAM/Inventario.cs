﻿using ProyectoDAM.DDBB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDAM
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void btn_CONSULTA_INVENTARIO_Click(object sender, EventArgs e)
        {
            Consultas.consulta_inventario(this, EventArgs.Empty, this.datagridView1);
        }
    }
}
