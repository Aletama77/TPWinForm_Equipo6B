using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_Equipo6B
{
    public partial class VerImagen : Form
    {
        private List<(int Id, string Url)> imagenes;
        private int indiceActual = 0;
        private int _idarticulo;
        private int _idArticulo;

        public VerImagen(int idArticulo)
        {
            InitializeComponent();
            CargarImagenes(idArticulo);
            _idarticulo=idArticulo;
        }

        private void CargarImagenes(int idArticulo)
        {
            imagenes = new List<(int, string)>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, ImagenUrl FROM IMAGENES WHERE IdArticulo = @idArticulo");
                datos.agregarParametro("@idArticulo", idArticulo);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    int id = Convert.ToInt32(datos.Lector["Id"]);
                    string url = datos.Lector["ImagenUrl"].ToString();
                    imagenes.Add((id, url));
                }

                if (imagenes.Count > 0)
                {
                    MostrarImagen(0);
                }
                else
                {
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar imágenes: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void MostrarImagen(int indice)
        {
            try
            {
                pictureBox1.Load(imagenes[indice].Url);
                txtUrlActual.Text = imagenes[indice].Url;
            }
            catch
            {
                pictureBox1.Image = null;
                txtUrlActual.Text = "URL inválida";
                MessageBox.Show("No se pudo cargar la imagen.");
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                MostrarImagen(indiceActual);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (indiceActual < imagenes.Count - 1)
            {
                indiceActual++;
                MostrarImagen(indiceActual);
            }
        }

        

        private void btnconfirmar_Click_1(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE IMAGENES SET ImagenUrl = @url WHERE Id = @id");
                datos.agregarParametro("@url", txtUrlActual.Text.Trim());
                datos.agregarParametro("@id", imagenes[indiceActual].Id);

                datos.ejecutarAccion();

                imagenes[indiceActual] = (imagenes[indiceActual].Id, txtUrlActual.Text.Trim());

                // Volver a mostrar la imagen (actualizada)
                MostrarImagen(indiceActual);

                MessageBox.Show("La URL de la imagen fue actualizada correctamente.");
                imagenes[indiceActual] = (imagenes[indiceActual].Id, txtUrlActual.Text.Trim()); // actualizar en memoria
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la URL de la imagen: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            if (indiceActual < imagenes.Count - 1)
            {
                indiceActual++;
                MostrarImagen(indiceActual);
            }
            else
            {
                MessageBox.Show("Ya estás en la última imagen.");
            }
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (indiceActual > 0)
            {
                indiceActual--;
                MostrarImagen(indiceActual);
            }
            else
            {
                MessageBox.Show("Ya estás en la primera imagen.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NuevaImagen nuevaImagen = new NuevaImagen(_idarticulo);
            nuevaImagen.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (imagenes == null || imagenes.Count == 0)
            {
                MessageBox.Show("No hay imágenes para eliminar.");
                return;
            }

            var imagen = imagenes[indiceActual];

            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro que querés eliminar esta imagen?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("DELETE FROM IMAGENES WHERE Id = @id");
                datos.agregarParametro("@id", imagen.Id);
                datos.ejecutarAccion();

                MessageBox.Show("Imagen eliminada correctamente.");

                // Eliminar de la lista local y actualizar vista
                imagenes.RemoveAt(indiceActual);

                if (imagenes.Count == 0)
                {
                    pictureBox1.Image = null;
                    txtUrlActual.Text = "";
                    MessageBox.Show("No quedan más imágenes.");
                    return;
                }

                // Ajustar el índice y mostrar siguiente disponible
                if (indiceActual >= imagenes.Count)
                    indiceActual = imagenes.Count - 1;

                MostrarImagen(indiceActual);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la imagen: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
