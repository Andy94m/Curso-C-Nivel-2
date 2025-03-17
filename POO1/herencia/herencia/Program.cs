using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Persona p1 = new Persona(); //No se pueden instanciar clases abstractas.
            Developer d1 = new Developer();
            //Lider l1 = new Lider(); //No se pueden instanciar clases static
            AnalistaFuncional a1 = new AnalistaFuncional();
            
            Tester t1 = new Tester();
            Tester t2 = new Tester();
            Tester t3 = new Tester();

            //p1.Nombre = "jorge";
            
            d1.Nombre = "Maxi"; //Hereda de persona
            d1.seniority = "ssr"; //propiedad exclusiva de la clase

            //l1.Apellido = "Garcia"; //Hereda de persona
            //l1.rango = "gerente"; //propiedad exclusiva
            Lider.algo(); //Se puede usar la clase static directamente sin instanciarla


            a1.Nombre = "luis"; //hereda de persona
            a1.plicaciones = "spac"; //propiedad exclusiva

            t1.Legajo = 13; //Hereda de persona
            
            t1.pruebas = "muchas a uno"; //propiedad exclusiva
            t2.pruebas = "solo una";
            t3.pruebas = "varias";
            
            
            //objeto lista de testers
            //List<Tester> listaTesters; //Se crea la variable pero no tiene referencia asignada
            List<Tester> listaTesters = new List<Tester>(); //se crea el objeto lista de testers a

            listaTesters.Add(t1); //añadimos los objetos a la lista
            listaTesters.Add(t2);
            listaTesters.Add(t3);

            Console.WriteLine("los elementos en la lista son: " + listaTesters.Count); //metodo para contar elementos en la lista

            //Comportamiento de valores, se referencian y se modifican:
            Console.WriteLine(listaTesters[1].pruebas);

            listaTesters[1].pruebas = "otra";
            Console.WriteLine(listaTesters[1].pruebas);

            t2.pruebas = "prueba nueva";
            Console.WriteLine(listaTesters[1].pruebas);

            //remover elementos
            listaTesters.Remove(t1);
            Console.WriteLine("se removieron elementos. Los elementos en la lista son: " + listaTesters.Count + "\n");


            //Ciclo foreach, recorre la coleccion y guarda la propiedad especificada en item
            foreach (Tester item in listaTesters)
            {
                Console.WriteLine(item.pruebas);
            }


            Console.ReadKey();
        }
    }
}
