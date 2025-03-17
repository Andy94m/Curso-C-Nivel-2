using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    abstract class Persona //abstract hace que la clase no se puede instanciar pero si heredar de la misma.
    //sealed class Persona //Hace que la clase no pueda ser heredada
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Legajo { get; set; }

        
    }
}
