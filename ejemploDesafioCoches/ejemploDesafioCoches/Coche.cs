using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ejemploDesafioCoches
{
    internal class Coche
    {

        public string Marca { get; }
        public string Modelo { get; }
        public int Año { get; }
        public int kilometraje { get; set; }

        public Coche(string marca, string modelo, int año) {
            Marca = marca;
            Modelo = modelo;
            Año = año;
            kilometraje = 0;
        }
        
        public int Conducir(int kilometros)
        {
            kilometraje += kilometros;
            return kilometraje;
        }

        public string Conducir( string destino, int kilometros)
        {
            kilometraje += kilometros;
            string leyenda = "Conduciendo a " + destino + " durante " + kilometraje + " KM.";
            return leyenda;
        }
    }
}
