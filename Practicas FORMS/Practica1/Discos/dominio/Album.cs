using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Album
    {
        [DisplayName("Número")]
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        //[DisplayName("Cant Canciones")]
        public int Canciones { get; set; }
        public string UrlImagen { get; set; }
        public Estilos Genero { get; set; }
        public Edicion Formato{ get; set; }
    }
}
