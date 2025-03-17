using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploDesafioCoches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Desafío 1: Clase Coche
            Crear un proyecto de consola .Net Framework.
            Crear la clase Coche
            Agregar los siguientes atributos:
            Marca (string)
            Modelo (string)
            Año (int)
            Kilometraje (int)

            Agregar las propiedades correspondientes.
            Marca: solo lectura.
            Modelo: solo lectura.
            Año: solo lectura.
            Kilometraje: lectura y escritura.

            Agregar un constructor que reciba Marca, Modelo y Año.
            Crear un método Conducir(int kilometros) que aumente el kilometraje del coche.
            Sobrecargar el método Conducir(int kilometros, string destino) que además de aumentar el kilometraje, reciba un destino y devuelva un string con la leyenda "Conduciendo a {destino} durante {kilometros} km.".

            Crear objetos de la clase Coche en el main del programa y probar los métodos. */

            string marca, modelo;
            int año, kilometraje;

            int viaje, opcion;
            string ciudad;

            Console.WriteLine("Ingrese la marca de su coche: ");
            marca = Console.ReadLine();

            Console.WriteLine("Ingrese el modelo de su coche: ");
            modelo = Console.ReadLine();

            Console.WriteLine("Ingrese el año de su coche: ");
            año = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el kilometraje de su coche: ");
            kilometraje = int.Parse(Console.ReadLine());


            Coche coche1 = new Coche(marca, modelo, año);
            coche1.kilometraje = kilometraje;

            Console.WriteLine("Ingrese: \n 1 - Iniciar su viaje en auto. \n 0 - Para finalizar. \n");
            viaje = int.Parse(Console.ReadLine());

            while (viaje ==1) 
            {
                Console.WriteLine("Seleccione la opcion correspondiente: \n 1 - Ir a una ciudad. \n 2 - Actualizar kilometros recorridos. \n 0 - Salir.");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1) 
                {
                    Console.WriteLine("A que ciudad desea ir?");
                    ciudad = Console.ReadLine();

                    Console.WriteLine("Cuantos KM hay de distancia?");
                    kilometraje = int.Parse(Console.ReadLine());
                    Console.WriteLine("ANTES DE LA ASIGNACION " + kilometraje);

                    Console.WriteLine(coche1.Conducir(ciudad, kilometraje));

                    Console.WriteLine("DESPUES DE LA ASIGNACION " + kilometraje);
                }
                else if (opcion == 2)
                {
                    Console.WriteLine("Ingrese la cantidad de km recorridos");
                    kilometraje = int.Parse(Console.ReadLine());
                    Console.WriteLine("ANTES DE ASIGNAR" + coche1.kilometraje);
                    coche1.Conducir(kilometraje);
                    Console.WriteLine("\n");
                    Console.WriteLine("DESPUES DE ASIGNAR" + coche1.kilometraje);
                }
                else
                {
                    Console.WriteLine("Actualización finalizada.");
                    viaje = 0;
                }

                Console.WriteLine("Desea volver a actualizar su información? \n 1 - SI \n 0 - Finalizar. ");
                opcion = int.Parse(Console.ReadLine());
                if(opcion == 0)
                {
                    viaje = opcion;
                }
            }

            Console.WriteLine("El estado del su auto es: \n Marca: " + coche1.Marca + " \n Modelo: " + coche1.Modelo + " \n  Año: " + coche1.Año + " \n Kilometraje: " + coche1.kilometraje);
        }
    }
}
