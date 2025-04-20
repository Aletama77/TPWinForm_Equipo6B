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
    public partial class EditarMarca : Form
    {
        private int _idMarca;
        public EditarMarca(int idMarca)
        {
            InitializeComponent();
            _idMarca = idMarca;
            CargarDatosMarca();
        }

        



    private void CargarDatosMarca()
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM MARCAS WHERE Id = @id");
                datos.agregarParametro("@id", _idMarca);
                datos.ejecutarLectura();

                if (datos.Lector.Read())
                {

                    TxtMarca.Text = datos.Lector["Descripcion"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos de la marca: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        private void botonEditarMarca_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE MARCAS SET Descripcion = @descripcion WHERE Id = @id");
                datos.agregarParametro("@descripcion", TxtMarca.Text);
                datos.agregarParametro("@id", _idMarca);

                datos.ejecutarAccion();

                MessageBox.Show("Marca actualizada correctamente.");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la marca: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }


        }
    }
}
