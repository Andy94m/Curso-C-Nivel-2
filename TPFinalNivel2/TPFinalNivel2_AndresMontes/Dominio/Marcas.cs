﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    internal class Marcas
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }

        //Sobrescribe el metodo ToString para que devuelva el valor de descripcion en vez del namespace
        public override string ToString()
        {
            return Descripcion;
        }
    }
}
