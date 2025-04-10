using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejercicio1();
            ejercicio2();
            Console.ReadKey();
        }

        static void ejercicio1()
        {

            string nombre;

            Console.Write("Ingresa su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine("\n"+nombre + " Bienvenido al curso de fundamentos");
        }
        static void ejercicio2()
        {
            Console.WriteLine("Sebasrian\n 20 \nIng. Sistemas");

        }

    }
}
