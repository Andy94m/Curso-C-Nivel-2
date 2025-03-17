using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Persona
    {
        //Persona: edad, sueldo, nombre
        //atributos o miembros, variables

        private int edad;
        private float sueldo;
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public void setEdad(int e)
        {
            edad = e;
        }

        public int getEdad()
        {
            return edad;
        }

        //metodos
        public string saludar()
        {
            return "hola soy " + nombre;
        }

        public string saludar(string personaje)
        {
            return "hola " + personaje +  ", soy " + this.nombre;
        }
    }
}
