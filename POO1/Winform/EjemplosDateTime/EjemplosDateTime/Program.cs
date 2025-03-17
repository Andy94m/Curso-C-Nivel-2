using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = DateTime.Now;

            //int año = fecha.Year;

            //DateTime fecha = new DateTime(2004, 4, 1);

            Console.Write("La fecha es: " + fecha.ToString() + "\n");

            Console.Write("La fecha es: " + fecha.AddDays(5) + "\n");

            Console.Write("La fecha es: " + fecha.ToShortDateString() + "\n");

            Console.Write("La fecha es: " + fecha.ToShortTimeString() + "\n");

            Console.Write("La fecha es: " + fecha.ToString("dd/MM/yyyy") + "\n");

            Console.Write("La fecha es: " + fecha.ToString("dddd MMM yyyy") + "\n");

            Console.ReadKey();
        }
    }
}
