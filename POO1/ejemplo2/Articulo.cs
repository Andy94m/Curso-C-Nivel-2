﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Articulo
    {
        // codigo articulo(3 digitos no correlativos)
        // precio
        // codigo de marca(1 a 10)

        public int CodigoArticulo { get; set; }

        public int Precio { get; set; }

        private int codMarca;
        public int CodigoMarca
        {
            get { return codMarca; }
            set
            {
                if (value > 0 && value < 11)
                    codMarca = value;
                else
                    codMarca = -1;
            }
        }
    }
}
