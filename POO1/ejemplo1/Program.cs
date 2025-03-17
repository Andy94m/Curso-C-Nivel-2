using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int edad;
            float sueldo;
            string nombre;
            int[] edades = new int[10];
            float[] sueldos = new float[10];
            string[] nombres = new string[10];*/

            Persona p1 = new Persona("pepe");
            p1.setEdad(20);
            Console.WriteLine(p1.saludar());
            Console.WriteLine(p1.saludar("JORGE"));
            Console.WriteLine("la edad de la persona es: " + p1.getEdad());

            Perro dogi = new Perro();
            dogi.Nombre = "guido";
            string nombre = dogi.Nombre;
            Console.WriteLine("El nombre del perro es: " + nombre);

            //int algo = b1.Capacidad;
            //Console.WriteLine("la capacidad de la botella es: " + algo);


            Botella b1 = new Botella("rojo", "Plastico");
            Console.WriteLine("Capacidad botella " + b1.Capacidad);
            Console.WriteLine("La canditdad actual es: " + b1.CapacidadActual);

            b1.recargar(20);
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CapacidadActual);

            b1.recargar();
            Console.WriteLine("Luego de recargar, la cantidad actual es: " + b1.CapacidadActual);

            Console.ReadKey();
        }
    }
}
