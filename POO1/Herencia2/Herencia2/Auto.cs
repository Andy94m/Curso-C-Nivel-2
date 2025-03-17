using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Auto : Vehiculo
    {
        public Auto() 
        {
            Chasis = new Chasis();
        }
        public int Anio { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        //Composición: El objeto auto debe nacer con un chasis
        public Chasis Chasis { get; set; }


        //Agregación: El objeto auto puede nacer sin el objeto motor o puede asignarse luego
        public Motor Motor { get; set; }
    }
}
