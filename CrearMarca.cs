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
    public partial class CrearMarca : Form
    {
        public CrearMarca()
        {
            InitializeComponent();
        }

        private void botonAgregarMarca_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                if (string.IsNullOrWhiteSpace(textDescripcion.Text))
                {
                    MessageBox.Show("El nombre de la marca no puede estar vacío.");
                    return;
                }

                datos.setearConsulta("INSERT INTO MARCAS (Descripcion) VALUES (@Descripcion)");
                datos.agregarParametro("@Descripcion", textDescripcion.Text);

                datos.ejecutarAccion();

                MessageBox.Show("Marca creada correctamente.");
                this.Close(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear la marca: " + ex.Message);
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
