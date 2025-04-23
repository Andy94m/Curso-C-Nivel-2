using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Articulo
    {
        public int Id { get; set; }
        public int Cod { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marcas Compania { get; set; }
        public Categorias Tipo { get; set; }
        public string UrlImagen { get; set; }
        public int Precio { get; set; }
    }
}
