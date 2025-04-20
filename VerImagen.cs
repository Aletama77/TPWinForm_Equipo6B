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

        public VerImagen(int idArticulo)
        {
            InitializeComponent();
            CargarImagenes(idArticulo);
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
                    MessageBox.Show("Este artículo no tiene imágenes.");
                    this.Close();
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
    }
}
