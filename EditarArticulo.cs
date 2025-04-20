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
            CargarDatosArticulo();
        }

        private void CargarDatosArticulo()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT M.Descripcion, A.Descripcion, A.Codigo, A.Nombre, A.Precio, C.Descripcion  FROM ARTICULOS A LEFT JOIN MARCAS M ON A.IdMarca = M.Id LEFT JOIN CATEGORIAS C ON A.IdCategoria = C.Id WHERE C.Descripcion LIKE @descripcion\"");
                datos.agregarParametro("@id", _idArticulo);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {

                    editarArtCodigo.Text = datos.Lector["A.Codigo"].ToString();
                    editarArtNombre.Text = datos.Lector["A.Nombre"].ToString();
                    editarArtDesc.Text = datos.Lector["A.Descripcion"].ToString();
                    editarArtIDCat.SelectedValue = datos.Lector["C.IdCategoria"];
                    editarArtPrecio.Text = datos.Lector["A.Precio"].ToString();
                    editarArtIDMarca.SelectedValue = datos.Lector["M.IdMarca"];

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
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, Precio = @precio WHERE Id = @id");
                datos.agregarParametro("@codigo", editarArtCodigo.Text);
                datos.agregarParametro("@nombre", editarArtNombre.Text);
                datos.agregarParametro("@descripcion", editarArtDesc.Text);
                datos.agregarParametro("@idmarca", editarArtIDMarca.Text);
                datos.agregarParametro("@idcategoria", editarArtIDCat.Text);
                datos.agregarParametro("@precio", editarArtPrecio.Text);
                datos.agregarParametro("@id", _idArticulo);
                datos.ejecutarAccion();
                MessageBox.Show("Articulo editado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar el articulo: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

    }
}
