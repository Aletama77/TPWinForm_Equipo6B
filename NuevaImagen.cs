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
    public partial class NuevaImagen : Form
    {

        private int _idArticulo;
        public NuevaImagen(int idArticulo)
        {

            InitializeComponent();
            _idArticulo = idArticulo;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nuevaUrl = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(nuevaUrl))
            {
                MessageBox.Show("La URL de la nueva imagen no puede estar vacía.");
                return;
            }

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO IMAGENES (IdArticulo, ImagenUrl) VALUES (@idArticulo, @url)");
                datos.agregarParametro("@idArticulo", _idArticulo);
                datos.agregarParametro("@url", nuevaUrl);
                datos.ejecutarAccion();

                MessageBox.Show("Imagen agregada correctamente.");

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la imagen: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
