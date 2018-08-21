using System;
using System.Collections;

namespace Pedidos_restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] listado_platos = new string[5];
            Console.WriteLine("Bienvenido al restaurante\n");
            Console.WriteLine("¿Cuantos comensales son?\n");
            int cant_comensales = int.Parse(Console.ReadLine());
            Console.WriteLine("\nEstupendo, serán "+ cant_comensales +" personas. Tenemos esto en el menú\n");
            Console.ReadKey();
        }
    }
}
