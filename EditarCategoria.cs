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
    public partial class EditarCategoria : Form
    {

        private int _idCategoria;
        public EditarCategoria(int idCategoria)
        {
            InitializeComponent();
            _idCategoria = idCategoria;
            CargarDatosCategoria();
        }


        private void CargarDatosCategoria()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM CATEGORIAS WHERE Id = @id");
                datos.agregarParametro("@id", _idCategoria);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {

                    textBox1.Text = datos.Lector["Descripcion"].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la categoria: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE CATEGORIAS SET Descripcion = @descripcion WHERE Id = @id");
                datos.agregarParametro("@descripcion", textBox1.Text);
                datos.agregarParametro("@id", _idCategoria);

                datos.ejecutarAccion();

                MessageBox.Show("Categoria actualizada correctamente.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la categoria: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
