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
    public partial class EditarArticulo : Form
    {
         private int _idArticulo;
        public EditarArticulo(int idArticulo)
        {
            InitializeComponent();
            _idArticulo = idArticulo;
            CargarComboMarcas();
            CargarComboCategorias();
            CargarDatosArticulo();
        }

        private void CargarComboMarcas()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                datos.ejecutarLectura();

                DataTable tabla = new DataTable();
                tabla.Load(datos.Lector);

                editarArtIDMarca.DataSource = tabla;
                editarArtIDMarca.DisplayMember = "Descripcion";
                editarArtIDMarca.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar marcas: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void CargarComboCategorias()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                datos.ejecutarLectura();

                DataTable tabla = new DataTable();
                tabla.Load(datos.Lector);

                editarArtIDCat.DataSource = tabla;
                editarArtIDCat.DisplayMember = "Descripcion";
                editarArtIDCat.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }


        private void CargarDatosArticulo()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"
            SELECT 
                A.Id,
                A.Codigo,
                A.Nombre,
                A.Descripcion,
                A.Precio,
                A.IdMarca,
                A.IdCategoria,
                M.Descripcion AS MarcaNombre,
                C.Descripcion AS CategoriaNombre
            FROM ARTICULOS A
            LEFT JOIN MARCAS M ON A.IdMarca = M.Id
            LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id
            WHERE A.Id = @id");

                datos.agregarParametro("@id", _idArticulo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {
                    editarArtCodigo.Text = datos.Lector["Codigo"].ToString();
                    editarArtNombre.Text = datos.Lector["Nombre"].ToString();
                    editarArtDesc.Text = datos.Lector["Descripcion"].ToString();
                    editarArtPrecio.Text = datos.Lector["Precio"].ToString();

                    // Asignar los valores a los combo boxes
                    editarArtIDCat.SelectedValue = Convert.ToInt32(datos.Lector["IdCategoria"]);
                    editarArtIDMarca.SelectedValue = Convert.ToInt32(datos.Lector["IdMarca"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos del articulo: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void ConfirArticuloBoton_Click(object sender, EventArgs e)
        {
            
        }

        private void ConfirArticuloBoton_Click_1(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta(@"
            UPDATE ARTICULOS
            SET 
                Codigo = @codigo,
                Nombre = @nombre,
                Descripcion = @descripcion,
                Precio = @precio,
                IdCategoria = @idCategoria,
                IdMarca = @idMarca
            WHERE Id = @id");

                datos.agregarParametro("@codigo", editarArtCodigo.Text.Trim());
                datos.agregarParametro("@nombre", editarArtNombre.Text.Trim());
                datos.agregarParametro("@descripcion", editarArtDesc.Text.Trim());

                // Convertir precio
                if (decimal.TryParse(editarArtPrecio.Text.Trim(), out decimal precio))
                {
                    datos.agregarParametro("@precio", precio);
                }
                else
                {
                    MessageBox.Show("El precio ingresado no es válido.");
                    return;
                }

                datos.agregarParametro("@idCategoria", (int)editarArtIDCat.SelectedValue);
                datos.agregarParametro("@idMarca", (int)editarArtIDMarca.SelectedValue);
                datos.agregarParametro("@id", _idArticulo); // Recordá que este ID lo pasás al constructor

                datos.ejecutarAccion();

                MessageBox.Show("Artículo actualizado correctamente.");
                this.Close(); // Cerrar el formulario si todo salió bien
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el artículo: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
