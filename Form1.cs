using System;
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

        private void verArtículoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Articulo ventana = new ABM_Articulo();
            ventana.MdiParent = this;   
            ventana.Show();
        }

        private void aBMArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Marcas ventana = new ABM_Marcas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABM_Categorias ventana = new ABM_Categorias();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
