﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Album
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public int Canciones { get; set; }
        public string UrlImagen { get; set; }
        public Estilos Genero { get; set; }
        public Edicion Formato{ get; set; }
    }
}
