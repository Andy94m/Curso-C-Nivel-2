using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesafioEjemploLibro
{
    internal class Libro
    {
        /* Agregar los siguientes atributos:

                Titulo (string)
                Autor (string)
                ISBN (string)
                Paginas (int)
                PaginasLeidas (int)

                Agregar las propiedades correspondientes.
                Titulo: solo lectura.
                Autor: solo lectura.
                ISBN: solo lectura.
                Paginas: solo lectura.
                PaginasLeidas: lectura y escritura.

                Agregar un constructor que reciba Titulo, Autor, ISBN y Paginas.
                Crear un método Leer(int paginas) que aumente las PaginasLeidas del libro.
                Sobrecargar el método Leer(int paginas, string comentario) que además de aumentar las PaginasLeidas, 
                reciba un comentario y devuelva un string con la leyenda "Leyendo {paginas} páginas - {comentario}".
        */
        //propiedades
        public string titulo { get; }
        public string autor{ get;}
        public string isbn { get;}
        public int paginas { get;}
        public int paginasLeidas { get;}

        //constructor
        public Libro(string titulo, string autor, string isbn, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            this.paginas = paginas;
            this.paginasLeidas = 0;
        }

        public void Leer(int paginas)
        {
            this.paginas += paginas;
        }

    }
}
