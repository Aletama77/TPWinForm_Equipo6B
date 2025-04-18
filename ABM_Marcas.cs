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
    public partial class ABM_Marcas : Form
    {
        public ABM_Marcas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in Application.OpenForms)
            {
                if (item.GetType() == typeof(CrearMarca))
                    return;
            }
            CrearMarca ventana = new CrearMarca();
            ventana.ShowDialog();
        }
    }
}
