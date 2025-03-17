using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Telefono
    {
        /*Agregale los siguientes atributos:
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
            Agregar Constructor que reciba Modelo y Marca.*/

        //constructor
        public Telefono(string modelo, string marca) {
            //atributos
            Modelo = modelo;
            Marca = marca;
            NumeroTelefonico = "Desconocido";
            CodigoOperador = 0;
        }
        
        //En las propiedades se puede especificar directamente el tipo de dato y la accesibilidad.
        //si se declararan los campos se deberia especificar THIS.modelo etcs en el constructor.
        //private string modelo;
        //private string marca;
        //private string numeroTelefonico;
        //private int codigoOperador debe especificarse si la propiedad va a setear datos con logica;

        //Propiedades:
        public string Modelo { get;}
        public string Marca { get;}
        public string NumeroTelefonico { get; set; }

        private int codigoOperador = 0;
        
        public int CodigoOperador
        {
            get {  return codigoOperador; }
            set
            {
                if (value > 0 && value < 4)
                    codigoOperador = value;
                else
                    codigoOperador = 0;
            }
        }

        //Funcion llamar
        public void Llamar()
        {
            Console.WriteLine("Llamando...");
        }
    }
}
