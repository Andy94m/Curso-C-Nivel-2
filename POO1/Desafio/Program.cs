using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Crear un proyecto de consola.Net Framework.
                2.Crear la clase Telefono(recordemos que una clase va en un archivo nuevo; click 
                    derecho en el proyecto, agregar, class).
                    Agregale los siguientes atributos:
                        Modelo string.
                        Marca string.
                        NumeroTelefonico string.
                        CodigoOperador int (1, 2 o 3).
                        Agregale las propiedades correspondientes.Podés hacer el formato largo o el corto.
                        Modelo: solo lectura. Es decir, solo get.
                        Marca: solo lectura.
                        NumeroTelefonico: lectura y escritura.
                        CodigoOperador: lectura y escritura.Validar escritura que solo admita 1, 2 o 3, 
                        caso contrario escribir un cero.
                3. Agregar Constructor que reciba Modelo y Marca.
                4. Crear algunos objetos en el main de Program y probar escribirle datos y 
                    mostrar en pantalla el estado del Telefono.
                5. Agregar método Llamar() sin parámetros que devuelva un string con la 
                    leyenda "Realizando llamada...".
                6. Sobrecargar el método Llamar(string contacto) para que reciba un contacto y devuelva 
                    un string con la leyenda "Llamando a " + contacto
                7. Probar métodos en el main mostrando en pantalla el comportamiento de los objetos.*/

            string user;
            
            Telefono tel0 = new Telefono("premium", "siemens" );

            Console.WriteLine("Ingrese su numero telefonico: ");
            tel0.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo operador: ");
            tel0.CodigoOperador = int.Parse( Console.ReadLine() );

            Console.WriteLine("Sus datos telefonicos son: ");

            Console.WriteLine("Marca y modelo: " + tel0.Marca + "\t " + tel0.Modelo);
            Console.WriteLine("Nro: " + tel0.NumeroTelefonico);
            Console.WriteLine("Cod: " + tel0.CodigoOperador);
            Console.WriteLine("\n");
            
            //---------------------------------------------------------
            
            Telefono tel1 = new Telefono("silver", "Nokia");

            Console.WriteLine("Ingrese su numero telefonico: ");
            tel1.NumeroTelefonico = Console.ReadLine();
            Console.WriteLine("Ingrese el codigo operador: ");
            tel1.CodigoOperador = int.Parse(Console.ReadLine());

            Console.WriteLine("Sus datos telefonicos son: ");

            Console.WriteLine("Marca y modelo: " + tel1.Marca + "\t " + tel1.Modelo);
            Console.WriteLine("Nro: " + tel1.NumeroTelefonico);
            Console.WriteLine("Cod: " + tel1.CodigoOperador);
            Console.WriteLine("\n");

            Llamar();

            Console.WriteLine("Ingresar contacto a llamar: ");
            user = Console.ReadLine();

            Llamar(user);

            Console.ReadKey();
        }

        static void Llamar()
        {
            Console.WriteLine("Llamando... ");
        }

        static void Llamar(string contacto)
        {
            Console.WriteLine("Llamando a " + contacto);
        }
    }
}
