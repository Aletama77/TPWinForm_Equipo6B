﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo6B
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void aBMArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Articulo ventana = new ABM_Articulo();
            ventana.ShowDialog();
        }
    }
}
