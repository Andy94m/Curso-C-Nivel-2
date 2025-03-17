using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asociación por agregación:
            Auto a1 = new Auto();
            a1.Motor = new Motor();
        }
    }
}
