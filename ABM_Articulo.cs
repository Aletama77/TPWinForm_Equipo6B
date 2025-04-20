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



        private void button4_Click(object sender, EventArgs e)
        {
            string categoriaBuscada = textBox2.Text.Trim();
            string marcaBuscada = textBox1.Text.Trim();
            string descripcionBuscada = textNombre.Text.Trim();
            string codigoBuscada = textBox5.Text.Trim();
            string nombreBuscada = textBox4.Text.Trim();
            string precioBuscada = textBox3.Text.Trim();

            AccesoDatos datos = new AccesoDatos();
            if (string.IsNullOrEmpty(marcaBuscada) && string.IsNullOrEmpty(categoriaBuscada) && string.IsNullOrEmpty(descripcionBuscada) && string.IsNullOrEmpty(codigoBuscada)&& string.IsNullOrEmpty(nombreBuscada)&& string.IsNullOrEmpty(precioBuscada))
            {

                try
                {
                    string consulta = "SELECT A.Id, M.Descripcion, A.Descripcion, A.Codigo, A.Nombre, A.Precio, C.Descripcion  FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id"; 
                    datos.setearConsulta(consulta);

                    datos.ejecutarLectura();

                    DataTable tabla = new DataTable();
                    tabla.Load(datos.Lector);
                    // Asignar el DataTable al DataGridView
                    dataGridViewArt.DataSource = tabla;
                    dataGridViewArt.Columns["Id"].Visible = false; // Ocultar la columna Id
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el Articulo: " + ex.Message);
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }

            if (!string.IsNullOrEmpty(marcaBuscada))
            {
                try
                {
                    string consulta = "SELECT A.Id, M.Descripcion, A.Descripcion, A.Codigo, A.Nombre, A.Precio, C.Descripcion  FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE M.Descripcion LIKE @descripcion";
                    datos.setearConsulta(consulta);
                    datos.agregarParametro("@descripcion", "%" + marcaBuscada + "%");
                    datos.ejecutarLectura();

                    DataTable tabla = new DataTable();
                    tabla.Load(datos.Lector);
                    // Asignar el DataTable al DataGridView
                    dataGridViewArt.DataSource = tabla;
                    //dataGridViewArt.Columns["Id"].Visible = false; // Ocultar la columna Id
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar la marca: " + ex.Message);
                }
                finally
                {
                    datos.cerrarConexion();
                }
            } else if (!string.IsNullOrEmpty(descripcionBuscada))
            {
                try
                {
                    string consulta = "SELECT A.Id, M.Descripcion, A.Descripcion, A.Codigo, A.Nombre, A.Precio, C.Descripcion  FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE A.Descripcion LIKE @descripcion";
                    datos.setearConsulta(consulta);
                    datos.agregarParametro("@descripcion", "%" + descripcionBuscada + "%");
                    datos.ejecutarLectura();

                    DataTable tabla = new DataTable();
                    tabla.Load(datos.Lector);
                    // Asignar el DataTable al DataGridView
                    dataGridViewArt.DataSource = tabla;
                    //dataGridViewArt.Columns["Id"].Visible = false; // Ocultar la columna Id
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar la descripcion: " + ex.Message);
                }
                finally
                {
                    datos.cerrarConexion();
                }
            } else if (!string.IsNullOrEmpty(codigoBuscada))
            {
                try
                {
                    string consulta = "SELECT A.Id, M.Descripcion, A.Descripcion, A.Codigo, A.Nombre, A.Precio, C.Descripcion  FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE A.Codigo LIKE @descripcion";
                    datos.setearConsulta(consulta);
                    datos.agregarParametro("@descripcion", "%" + codigoBuscada + "%");
                    datos.ejecutarLectura();

                    DataTable tabla = new DataTable();
                    tabla.Load(datos.Lector);
                    // Asignar el DataTable al DataGridView
                    dataGridViewArt.DataSource = tabla;
                    //dataGridViewArt.Columns["Id"].Visible = false; // Ocultar la columna Id
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el codigo: " + ex.Message);
                }
                finally
                {
                    datos.cerrarConexion();
                }
            } else if (!string.IsNullOrEmpty(nombreBuscada))
            {
                try
                {
                    string consulta = "SELECT A.Id, M.Descripcion, A.Descripcion, A.Codigo, A.Nombre, A.Precio, C.Descripcion  FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE A.Nombre LIKE @descripcion";
                    datos.setearConsulta(consulta);
                    datos.agregarParametro("@descripcion", "%" + nombreBuscada + "%");
                    datos.ejecutarLectura();

                    DataTable tabla = new DataTable();
                    tabla.Load(datos.Lector);
                    // Asignar el DataTable al DataGridView
                    dataGridViewArt.DataSource = tabla;
                    //dataGridViewArt.Columns["Id"].Visible = false; // Ocultar la columna Id
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el nombre: " + ex.Message);
                }
                finally
                {
                    datos.cerrarConexion();
                }
            } else if (!string.IsNullOrEmpty(precioBuscada))
            {
                try
                {
                    string consulta = "SELECT A.Id, M.Descripcion, A.Descripcion, A.Codigo, A.Nombre, A.Precio, C.Descripcion  FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE A.Precio LIKE @descripcion";
                    datos.setearConsulta(consulta);
                    datos.agregarParametro("@descripcion", "%" + precioBuscada + "%");
                    datos.ejecutarLectura();

                    DataTable tabla = new DataTable();
                    tabla.Load(datos.Lector);
                    // Asignar el DataTable al DataGridView
                    dataGridViewArt.DataSource = tabla;
                    //dataGridViewArt.Columns["Id"].Visible = false; // Ocultar la columna Id

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el precio: " + ex.Message);
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }else if (!string.IsNullOrEmpty(categoriaBuscada))
            {
                try
                {
                    string consulta = "SELECT A.Id, M.Descripcion, A.Descripcion, A.Codigo, A.Nombre, A.Precio, C.Descripcion  FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE C.Descripcion LIKE @descripcion";
                    datos.setearConsulta(consulta);
                    datos.agregarParametro("@descripcion", "%" + categoriaBuscada + "%");
                    datos.ejecutarLectura();

                    DataTable tabla = new DataTable();
                    tabla.Load(datos.Lector);
                    // Asignar el DataTable al DataGridView
                    dataGridViewArt.DataSource = tabla;
                    dataGridViewArt.Columns["Id"].Visible = false; // Ocultar la columna Id
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar el precio: " + ex.Message);
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }

        }

        private void dataGridViewArt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dataGridViewArt.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                AccesoDatos datos = new AccesoDatos();
                int idArticulo = Convert.ToInt32(dataGridViewArt.Rows[e.RowIndex].Cells["Id"].Value);

                try
                {

                    datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id");
                    datos.agregarParametro("@Id", idArticulo);
                    datos.ejecutarAccion();


                    // Eliminar la fila del DataGridView sin recargar todo
                    dataGridViewArt.Rows.RemoveAt(e.RowIndex);

                    MessageBox.Show("Articulo eliminado correctamente." + idArticulo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el Artículo: " + ex.Message);
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }
            else if (dataGridViewArt.Columns[e.ColumnIndex].Name == "Editar")
            {
                int idArticulo = Convert.ToInt32(dataGridViewArt.Rows[e.RowIndex].Cells["Id"].Value);

                EditarArticulo editararticulo = new EditarArticulo(idArticulo);
                editararticulo.Show();

            }
        }
    }
}
