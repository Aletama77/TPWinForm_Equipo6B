using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPWinForm_Equipo6B
{
    internal class Articulo
    {
        private int Id;
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Idmarca { get; set; }
        public int Idcategoria { get; set; }
        public float Precio { get; set; }

        List<Imagen> Listadeimagenes { get; set; } = new List<Imagen>();  

    }
}
