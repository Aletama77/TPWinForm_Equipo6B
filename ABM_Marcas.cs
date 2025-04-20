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

        private void button4_Click(object sender, EventArgs e)
        {
            string marcaBuscada = textMarca.Text.Trim();
            if (string.IsNullOrEmpty(marcaBuscada))
            {
                MessageBox.Show("Por favor ingrese un nombre de categoría para buscar.");
                return;
            }

            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "SELECT Id, Descripcion FROM MARCAS WHERE Descripcion LIKE @descripcion";
                datos.setearConsulta(consulta);
                datos.agregarParametro("@descripcion", "%" + marcaBuscada + "%");
                datos.ejecutarLectura();

                DataTable tabla = new DataTable();
                tabla.Load(datos.Lector);
                // Asignar el DataTable al DataGridView
                dataGridViewMarca.DataSource = tabla;
                dataGridViewMarca.Columns["Id"].Visible = false; // Ocultar la columna Id
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

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {
            button4.Enabled = !string.IsNullOrWhiteSpace(textMarca.Text);
        }

        private void dataGridViewMarca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dataGridViewMarca.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                AccesoDatos datos = new AccesoDatos();
                int idMarca = Convert.ToInt32(dataGridViewMarca.Rows[e.RowIndex].Cells["Id"].Value);

                try
                {

                    datos.setearConsulta("DELETE FROM MARCAS WHERE Id = @id");
                    datos.agregarParametro("@id", idMarca);
                    datos.ejecutarAccion();


                    // Eliminar la fila del DataGridView sin recargar todo
                    dataGridViewMarca.Rows.RemoveAt(e.RowIndex);

                    MessageBox.Show("Marca eliminada correctamente." + idMarca);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar la marca: " + ex.Message);
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }else if (dataGridViewMarca.Columns[e.ColumnIndex].Name == "Editar")
            {
                int idMarca = Convert.ToInt32(dataGridViewMarca.Rows[e.RowIndex].Cells["Id"].Value);

                EditarMarca editarMarca = new EditarMarca(idMarca); // envio el Id al const
                editarMarca.Show();

            }


        }
    }
}
