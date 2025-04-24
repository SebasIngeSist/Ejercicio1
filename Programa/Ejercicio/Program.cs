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
            ejercicio4();
            ejercicio3();
            ejercicio5();
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

        static void ejercicio3()
        {
            Console.Write("Ingrese el sueldo base: ");
            double sueldoBase = Convert.ToDouble(Console.ReadLine());

        
            double sueldoMaria = sueldoBase - (sueldoBase * 0.05) - 25;
            double sueldoJuan = sueldoBase + (sueldoBase * 0.23) + 72;
            double sueldoPatricio = sueldoBase + (sueldoBase * 0.05) - 56;

        
            double sumaSueldos = sueldoMaria + sueldoJuan + sueldoPatricio;

        
            Console.WriteLine($"\nSueldo de María: {sueldoMaria:C}");
            Console.WriteLine($"Sueldo de Juan: {sueldoJuan:C}");
            Console.WriteLine($"Sueldo de Patricio: {sueldoPatricio:C}");
            Console.WriteLine($"Suma total de sueldos: {sumaSueldos:C}");




        }
        static void ejercicio5()
        {
            Console.WriteLine("Ingrese el monto en soles peruanos (PEN): ");
            double montoPEN = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nSeleccione la moneda a la que desea convertir:");
            Console.WriteLine("1. Dólares (USD)");
            Console.WriteLine("2. Euros (EUR)");
            int opcion = Convert.ToInt32(Console.ReadLine());

            // Variable para almacenar el resultado
            double montoConvertido = 0;

            // Usar switch para determinar la opción seleccionada
            switch (opcion)
            {
                case 1:
                    // Convertir a dólares
                    montoConvertido = montoPEN / 3.75;
                    Console.WriteLine($"\n{montoPEN} soles peruanos (PEN) son {montoConvertido:F2} dólares (USD).");
                    break;
                case 2:
                    // Convertir a euros
                    montoConvertido = montoPEN / 4.05;
                    Console.WriteLine($"\n{montoPEN} soles peruanos (PEN) son {montoConvertido:F2} euros (EUR).");
                    break;
                default:
                    // Opción no válida
                    Console.WriteLine("Opción no válida. Por favor seleccione 1 o 2.");
                    break;





            }
        }


    }
}
