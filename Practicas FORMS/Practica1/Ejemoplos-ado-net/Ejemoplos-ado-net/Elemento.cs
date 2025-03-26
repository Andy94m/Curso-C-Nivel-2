using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemoplos_ado_net
{
    internal class Elemento
    {
        public int id{ get; set; }
        public string Descripcion{ get; set; }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
