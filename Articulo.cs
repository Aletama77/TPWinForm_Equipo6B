using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_Equipo6B
{
    internal class Articulos
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IDMarca { get; set; }
        public int IDCategoria { get; set; }
        public float Precio { get; set; }

    }
}
