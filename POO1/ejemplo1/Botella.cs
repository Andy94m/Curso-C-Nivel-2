using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Botella
    {
        //capacidad maxima: 100
        //capacidadActual: inicia en cero
        //metodo recarga: carga al 100 y vuelve el costo de recargar. 50 cada 100.

        //constructor
        public Botella(string color, string material)
        {
            this.color = color;
            this.material = material;
            capacidad = 100;
            cantidadActual = 0;
        }

        //sobrecarga del constructor
        public Botella() { }

        //Destructor
        ~Botella() 
        {
            //logica
        }

        //botella: capacidad, color, material
        private int capacidad;
        private string color;
        private string material;
        private int cantidadActual;

        public int Capacidad
        {
            get { return capacidad; }
        }

        public int CapacidadActual
        {
            get { return cantidadActual; }
        }

        public string Material
        {
            get { return material; }
        }

        //propiedad
        /*public int Capacidad
        {
            get { return capacidad; }
            set { capacidad = value; }
        }*/

        //metodos
        public float recargar()
        {
            if (cantidadActual > 0)
            {
                int dif = capacidad - cantidadActual;
                float monto = dif * 50 / 100;
                cantidadActual += dif;
                return monto;
            }
            cantidadActual = 100;
            return 50;
        }

        public float recargar(int cantidad)
        {
            cantidadActual -= cantidad;
            return cantidad * 50 / 100;
        }
    }
}
