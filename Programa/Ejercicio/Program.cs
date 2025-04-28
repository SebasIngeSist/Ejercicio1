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
            ejercicio6();
            ejerciciofor1();
            ejerciciofor2();
            ejerciciofor3();
            ejerciciofor4();
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

        static void ejercicio6()
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Seleccione una opción para calcular el área de una figura geométrica:");
                Console.WriteLine("1. Cuadrado");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Círculo");

                int opcion = Convert.ToInt32(Console.ReadLine());
                bool repetirMismaFigura = true;

                while (repetirMismaFigura)
                {
                    double area = 0;

                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("Ingrese el valor del lado del cuadrado:");
                            double lado = Convert.ToDouble(Console.ReadLine());
                            area = lado * lado;
                            Console.WriteLine($"El área del cuadrado es: {area} unidades cuadradas.");
                            break;

                        case 2:
                            Console.WriteLine("Ingrese el valor del largo del rectángulo:");
                            double largo = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor del ancho del rectángulo:");
                            double ancho = Convert.ToDouble(Console.ReadLine());
                            area = largo * ancho;
                            Console.WriteLine($"El área del rectángulo es: {area} unidades cuadradas.");
                            break;

                        case 3:
                            Console.WriteLine("Ingrese el valor de la base del triángulo:");
                            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Ingrese el valor de la altura del triángulo:");
                            double altura = Convert.ToDouble(Console.ReadLine());
                            area = (baseTriangulo * altura) / 2;
                            Console.WriteLine($"El área del triángulo es: {area} unidades cuadradas.");
                            break;

                        case 4:
                            Console.WriteLine("Ingrese el valor del radio del círculo:");
                            double radio = Convert.ToDouble(Console.ReadLine());
                            area = Math.PI * radio * radio;
                            Console.WriteLine($"El área del círculo es: {Math.Round(area, 2)} unidades cuadradas.");
                            break;

                        default:
                            Console.WriteLine("Valor ingresado incorrecto. Por favor seleccione una opción válida.");
                            repetirMismaFigura = false;
                            break;
                    }

                    Console.WriteLine("\n¿Qué desea hacer ahora?");
                    Console.WriteLine("1. Calcular otra vez la MISMA figura.");
                    Console.WriteLine("2. Calcular una figura DIFERENTE.");

                    string respuesta = Console.ReadLine();

                    if (respuesta == "1")
                    {
                        repetirMismaFigura = true; 
                    }
                    else if (respuesta == "2")
                    {
                        repetirMismaFigura = false; 
                        Console.Clear();
                        break; 
                    }
                }
            }
        }
        static void ejerciciofor1()
        {
           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Java");
            }


        }
        static void ejerciciofor2()
        {
            
            int numero = 5;

            Console.WriteLine($"Tabla de multiplicar del {numero}:");

           
            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }
        static void ejerciciofor3()
        {

            int numero;

            Console.WriteLine("Ingresa el # para generar su tabal de multiplicar:");
            numero =int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabla de multiplicar del {numero}:");


            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }

        }
        static void ejerciciofor4()
        {
            Console.WriteLine("Números impares entre 1 y 100:");

            for (int i = 1; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

        }







    }



}
