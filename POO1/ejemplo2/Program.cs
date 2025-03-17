using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*primer lote con 10 registro de productos, cada producto tiene:
             -codigo articulo (3 digitos no correlativos)
             -precio
             -codigo de marca (1 a 10)
            segundo lote con las ventas de la semna cada venta tiene:
             -codigo articulo
             -cantidad
             -codigo cliente (1 a 100)
            este lote corta con codigo de cliente cero*/

            Articulo[] articulos = new Articulo[10];

            //articulos[6].CodigoMarca = 3;

            for (int i = 0; i < 10; i++)
            {
                articulos[i] = new Articulo();
                Console.WriteLine("Ingrese los datos del producto: ");
                Console.WriteLine("Codigo: ");
                articulos[i].CodigoArticulo = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Precio");
                articulos[i].Precio = int.Parse(Console.ReadLine());

                Console.WriteLine("Marca (1 a 10)");
                articulos[i].CodigoMarca = int.Parse(Console.ReadLine());
                Console.WriteLine(" \n ");
            }

            //cargando el vector completo con los 10
            Venta venta = new Venta();
            Console.WriteLine("Ingrese la venta: ");
            Console.WriteLine("Codigo de cliente: ");
            venta.CodigoCliente = int.Parse(Console.ReadLine());

            while (venta.CodigoCliente != 0)
            {
                Console.WriteLine("Codigo Articulo: ");
                venta.CodigoArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Cantidad: ");
                venta.Cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la venta: ");
                Console.WriteLine("Codigo de cliente: ");
                venta.CodigoCliente = int.Parse(Console.ReadLine());
            }
        }
    }
}
