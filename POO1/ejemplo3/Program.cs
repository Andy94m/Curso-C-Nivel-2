using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "andy";

            nombre = "hola como estas??? " + nombre;

            int cantidad = nombre.Length;
            Console.WriteLine(cantidad);

            string mayus = nombre.ToUpper();
            Console.Write(mayus);

            string minus = nombre.ToLower();
            Console.WriteLine(minus);

            string remp = nombre.Replace('a', 'e');
            Console.WriteLine(remp);
        }
    }
}
