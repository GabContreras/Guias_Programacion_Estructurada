using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Practico_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Area, Base, Altura, Radio, lado, X = 0;
            double radioCubo;
            double pi = 3.1415;
            String Problema = "";

            Console.WriteLine("Primer Desafío Práctico");
            Console.WriteLine("Opciones:");
            Console.WriteLine("a) Calcular el área de un triángulo.");
            Console.WriteLine("b) Encontrar X de una ecuación");
            Console.WriteLine("c) Calcular Área de un Triangulo equilátero");
            Console.WriteLine("d) Salir del programa");

            Console.Write("Ingrese la opción del problema que quiera resolver (a-c): ");
            Problema = Console.ReadLine();
            switch (Problema)
            {
                case "A":
                case "a":
                    Console.Write("Ingrese la base del rectangulo: ");
                    Base = double.Parse(Console.ReadLine());

                    Console.Write("Ingrese la altura del rectángulo: ");
                    Altura = double.Parse(Console.ReadLine());

                    Console.WriteLine($"Base escrita: {Base}");
                    Console.WriteLine($"Altura escrita: {Altura}");

                    Area = (Base * Altura) / 2;

                    Console.WriteLine($"El área del triángulo es de: {Math.Round(Area, 2)}cm^2");

                    break;

                case "B":
                case "b":
                    Console.WriteLine("Este a servirá para encontrar un lado X de una esfera, basado en su radio");
                    Console.Write("Ingrese el valor del radio de la esfera: ");
                    Radio = double.Parse(Console.ReadLine());
                    X = ( (1.333333333) * pi * Math.Pow(Radio, 3));

                    Console.WriteLine($"EL valor de X es {Math.Round(X,2)}cm^3");

                    break;
               
                case "C":
                case "c":
                    Console.WriteLine("Este a servirá para encontrar el área de un triángulo equilátero");
                    Console.Write("Ingrese el valor del lado: ");
                    lado = double.Parse(Console.ReadLine());
                    Area = (Math.Pow(lado, 2) * Math.Sqrt(3)) / 4;
                    Console.WriteLine($"El área del triángulo equilátero es: {Math.Round(Area,2)}cm^2");
                    break;

                case "D":
                case "d":
                        Console.WriteLine("Saliendo del programa");
                        Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Opción no válida. Por favor, ingrese 'a', 'b' 'c' o 'd'.");
                    break;
            }
            Console.WriteLine("Gracias por usar el programa, vuelva pronto");
            Console.ReadKey();

        }
    }
}
