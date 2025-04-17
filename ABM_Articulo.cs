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
    public partial class ABM_Articulo : Form
    {
        public ABM_Articulo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(CrearArticulo))
                    return;
            }
            CrearArticulo ventana = new CrearArticulo();
            ventana.ShowDialog();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
