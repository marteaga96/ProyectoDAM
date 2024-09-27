using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using ProyectoDAM.DDBB;
using ProyectoDAM.Resources;

namespace ProyectoDAM
{
    public partial class ucCOMPRAS : UserControl
    {
        public ucCOMPRAS()
        {
            InitializeComponent();
        }

        private void CONSULTA_Click(object sender, EventArgs e)
        {
            Consultas.consulta_historial_compras(this, EventArgs.Empty);
        }

    }
}
