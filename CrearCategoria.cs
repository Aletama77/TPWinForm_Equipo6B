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
    public partial class CrearCategoria : Form
    {
        public CrearCategoria()
        {
            InitializeComponent();
        }

private void btnAgregarCategoria_Click(object sender, EventArgs e)
{

    MessageBox.Show("Confirmado");

    string descripcion = TxtDescripcioncategorias.Text.Trim();

    if (string.IsNullOrEmpty(descripcion))
    {
        MessageBox.Show("Por favor, ingrese una descripción.");
        return;
    }

    AccesoDatos datos = new AccesoDatos();

    try
    {
        MessageBox.Show("Procediendo a insertar en la base de datos...");

        datos.setearConsulta("INSERT INTO CATEGORIAS (Descripcion) VALUES (@descripcion)");
        datos.agregarParametro("@descripcion", descripcion);
        datos.ejecutarAccion();

        MessageBox.Show("Categoría agregada correctamente.");
        this.Close();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Error al agregar la categoría: " + ex.Message);
    }
    finally
    {
        datos.cerrarConexion();
    }
}

    }
}

