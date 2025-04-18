﻿using System;
using System.Data;
using System.Windows.Forms;

namespace TPWinForm_Equipo6B
{
    public partial class ABM_Categorias : Form
    {
        public ABM_Categorias()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearCategoria ventana = new CrearCategoria();
            ventana.Show();
        }

        private void dataGridViewCat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evitamos errores si se hace clic en el encabezado
            if (e.RowIndex < 0)
                return;

            // Si se hizo clic en la columna "Eliminar"
            if (dataGridViewCat.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                int idCategoria = Convert.ToInt32(dataGridViewCat.Rows[e.RowIndex].Cells["Id"].Value);

                DialogResult confirmacion = MessageBox.Show("¿Estás seguro que querés eliminar esta categoría?", "Eliminar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacion == DialogResult.Yes)
                {
                    try
                    {
                        AccesoDatos datos = new AccesoDatos();
                        datos.setearConsulta("DELETE FROM CATEGORIAS WHERE Id = @id");
                        datos.agregarParametro("@id", idCategoria);
                        datos.ejecutarAccion();
                        datos.cerrarConexion();

                        // Eliminar la fila del DataGridView sin recargar todo
                        dataGridViewCat.Rows.RemoveAt(e.RowIndex);

                        MessageBox.Show("Categoría eliminada correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar la categoría: " + ex.Message);
                    }
                }
            }
        }


        private void botonBuscarCategoria_Click(object sender, EventArgs e)
        {
            string categoriaBuscada = textCategoria.Text.Trim();
            if (string.IsNullOrEmpty(categoriaBuscada))
            {
                MessageBox.Show("Por favor ingrese un nombre de categoría para buscar.");
                return;
            }

            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT Id, Descripcion FROM CATEGORIAS WHERE Descripcion LIKE @descripcion";
                datos.setearConsulta(consulta);
                datos.agregarParametro("@descripcion", "%" + categoriaBuscada + "%");
                datos.ejecutarLectura();

                DataTable tabla = new DataTable();
                tabla.Load(datos.Lector);
                // Asignar el DataTable al DataGridView
                dataGridViewCat.DataSource = tabla;
                dataGridViewCat.Columns["Id"].Visible = false; // Ocultar la columna Id
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar la categoría: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void textCategoria_TextChanged(object sender, EventArgs e)
        {
            botonBuscarCategoria.Enabled = !string.IsNullOrWhiteSpace(textCategoria.Text);
        }

        private void CargarCategorias()
        {
            // Método para cargar las categorías al cargar la pantalla
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "SELECT Id, Descripcion FROM CATEGORIAS";
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                DataTable tabla = new DataTable();
                tabla.Load(datos.Lector);
                dataGridViewCat.DataSource = tabla;
                dataGridViewCat.Columns["Id"].Visible = false; // Ocultar la columna Id
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las categorías: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}


