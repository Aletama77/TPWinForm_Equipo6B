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
    public partial class CrearArticulo : Form
    {
        public CrearArticulo()
        {
            InitializeComponent();
            CargarComboMarcas();
            CargarComboCategorias();
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

                comboBox1.DataSource = tabla;
                comboBox1.DisplayMember = "Descripcion"; 
                comboBox1.ValueMember = "Id"; 
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

                comboBox2.DataSource = tabla;
                comboBox2.DisplayMember = "Descripcion";
                comboBox2.ValueMember = "Id";
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


        private void ConfirArticuloBoton_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta(@"
            INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, Precio, IdCategoria, IdMarca)
            VALUES (@codigo, @nombre, @descripcion, @precio, @idCategoria, @idMarca)");

                datos.agregarParametro("@codigo", textBox5.Text.Trim());
                datos.agregarParametro("@nombre", textBox4.Text.Trim());
                datos.agregarParametro("@descripcion", textNombre.Text.Trim());

                
                if (decimal.TryParse(textBox3.Text.Trim(), out decimal precio))
                {
                    datos.agregarParametro("@precio", precio);
                }
                else
                {
                    MessageBox.Show("El precio ingresado no es válido.");
                    return;
                }

                datos.agregarParametro("@idCategoria", (int)comboBox2.SelectedValue);
                datos.agregarParametro("@idMarca", (int)comboBox1.SelectedValue);

                datos.ejecutarAccion();

                MessageBox.Show("Artículo creado correctamente.");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el artículo: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }









        }
    }
}
