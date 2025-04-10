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
        }

        static void ejercicio1()
        {

            string nombre;

            Console.Write("Ingresa su nombre: ");
            nombre = Console.ReadLine();

            Console.WriteLine(nombre + " Bienvenido al curso de fundamentos");
        }

    }
}
