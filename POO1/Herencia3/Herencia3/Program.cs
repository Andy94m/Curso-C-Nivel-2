using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AnimalDomestico a1 = new AnimalDomestico();
            a1.Nombre = "Jorge";

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a1.comunicarse());

            Console.WriteLine("\n");

            Gato g1 = new Gato();
            g1.Nombre = "Pepe";
            Console.WriteLine(g1.Nombre);
            Console.WriteLine(g1.comunicarse());

            Console.WriteLine("\n");

            Perro p1 = new Perro();
            p1.Nombre = "Negrito";
            Console.WriteLine(p1.Nombre);
            Console.WriteLine(p1.comunicarse());

            List<Animal> animales = new List<Animal>();
            animales.Add(p1);
            animales.Add(g1);
            //agregamos animales sin instanciar el objeto previamente.
            //Se instanacia el objeto directamente en la lista y solo se puede acceder dentro de ella.
            //Salvo que se especifique y se asigne a una variable como lo hariamos normalmente.
            animales.Add(new Pez());
            animales.Add(new Canario());
            animales.Add(new Aguila());

            Console.WriteLine("\n");

            Animal a2 = g1;//Guardo la referencia de gato en una variable animal. 
            //En este punto la variable animal no conoce las propiedades explicitas de gato y le son inaccesibles
            Gato g8 = (Gato) a2; //a una variable gato le asigno el valor de a2, vuelve a reconocer las propiedades de gato
            g8.Nombre = "Blanquito"; //se asigna un nombre e imprimimos como prueba

            Console.Write(g8.Nombre);

            Console.WriteLine("\n");


            //Ejemplo de polimorfismo. A un mismo estimulo cada objeto reacciona distinto.
            foreach (Animal item in animales)
            {
                Console.WriteLine(item.comunicarse());
            }

            Console.WriteLine("\n");

            //Se crea una lista de animales que implementen la interfaz Flyable
            List<Flyable> listaVoladores = new List<Flyable>();
            listaVoladores.Add(new Canario()); //se agregan las clases que tengan implementadas la interfaz
            listaVoladores.Add(new Aguila());
            //listaVoladores.Add(new Perro()); //no se pueden listar animales que no implementen la interfaz
            

            //Se recorre los elementos que implementen flyable en la listaVoladores
            //Se escribe en consola el metodo volar() de cada objeto listado:
            Console.WriteLine("Animales voladores:");
            foreach (Flyable item in listaVoladores)
            {
                Console.WriteLine(item.volar());
            }




            Console.ReadKey();
        }
    }
}
