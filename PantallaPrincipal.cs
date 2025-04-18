using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

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
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ABM_Articulo))
                    return;
            }
            ABM_Articulo ventana = new ABM_Articulo();
            ventana.MdiParent = this;   
            ventana.Show();
        }

        private void aBMArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ABM_Marcas))
                    return;
            }
            ABM_Marcas ventana = new ABM_Marcas();
            ventana.MdiParent = this;
            ventana.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(ABM_Categorias))
                    return;
            }
            ABM_Categorias ventana = new ABM_Categorias();
            ventana.MdiParent = this;
            ventana.Show();
        }
    }
}
