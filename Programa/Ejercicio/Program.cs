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
            Console.WriteLine("Sebasrian\n20\nIng. Sistemas");

        }
        static void ejercicio4()
        {
            int num1, num2;

            Console.Write("Ingrese el primer numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el primer numero: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("La suma es: " +(num1+num2));
            Console.WriteLine("La resta es: "+(num1-num2));
            Console.WriteLine("La multiplicacion es: " + (num1 * num2));
            Console.WriteLine("La division es: " + (num1 /num2));
            Console.WriteLine("El modulo es: " + (num1 %num2));

        }


        }



    }
}
