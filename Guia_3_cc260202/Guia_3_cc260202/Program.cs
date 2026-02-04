using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_3_cc260202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejemplo1();
            //ejemplo2();
            ejemplo3();
            //ejemplo4();

        }
        static void ejemplo1()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 25;  // alto de la ventana           
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Cual es el numero mayor entre 2 numeros";
            Console.Write("\n\tGuia#3 Ejemplo1");
            Console.Write("\n\n");
            // Declaracion de variables
            Double x = 0, y = 0;
            bool entradaValida = false;

            // Entrada
            Console.Write("\tAveriguaremos cual es el mayor de 2 numeros...");
            Console.Write("\n\n");

            // Lectura del primer número con validación
            while (!entradaValida)
            {
                try
                {
                    Console.Write("\tDigitar el primer número  : ");
                    x = Double.Parse(Console.ReadLine());
                    entradaValida = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número válido.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError inesperado: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }

            // Lectura del segundo número con validación
            entradaValida = false;
            while (!entradaValida)
            {
                try
                {
                    Console.Write("\tDigitar el segundo número : ");
                    y = Double.Parse(Console.ReadLine());
                    entradaValida = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número válido.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError inesperado: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }

            Console.Write("\n");
            //Procesos
            if (x > y)
            {
                Console.WriteLine("\tEl numero " + x + " es mayor que " + y); // v
            }
            else
            {
                Console.WriteLine("\tEl numero " + y + " es mayor que " + x); // f
            }
            Console.Write("\n\n");
            //Pantalla opcional
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*            Diego Maradona                 *");
            Console.WriteLine("\t*                                           *");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ejemplo2()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 25;  // alto de la ventana           
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa de uso de condicionales";
            Console.Write("\nGuia#3 Ejemplo2");
            Console.Write("\n\n");
            // Declaracion de variables
            Double x = 0, y = 0, z, w;
            bool entradaValida = false;

            // Entrada
            Console.Write("\tOperaciones matematicas con condicionales...");
            Console.Write("\n\n");

            // Lectura del primer número con validación
            while (!entradaValida)
            {
                try
                {
                    Console.Write("\tDigitar primer numero  : ");
                    x = Double.Parse(Console.ReadLine());
                    entradaValida = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número válido.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError inesperado: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            Console.Write("\n");

            // Lectura del segundo número con validación
            entradaValida = false;
            while (!entradaValida)
            {
                try
                {
                    Console.Write("\tDigitar segundo numero : ");
                    y = Double.Parse(Console.ReadLine());
                    entradaValida = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número válido.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError inesperado: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            Console.Write("\n");

            //Procesos
            if (x > y)
            {
                z = x + y;
                w = x - y;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\tMOSTRANDO RESULTADOS");
                Console.WriteLine("\tLa suma es  : " + Math.Round(z, 2));
                Console.WriteLine("\tLa resta es : " + Math.Round(w, 2));
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                z = x * y;
                if (y == 0)
                {
                    Console.WriteLine("\tNo se puede dividir entre CERO");
                }
                else
                {
                    w = x / y;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tMOSTRANDO RESULTADOS");
                    Console.WriteLine("\tLa multiplicación es : " + z);
                    Console.WriteLine("\tLa división es       : " + Math.Round(w, 2));
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            Console.Write("\n\n");
            //Pantalla opcional
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*               P e l é                     *");
            Console.WriteLine("\t*                                           *");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ejemplo3()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 20;  // alto de la ventana           
            // Console.WindowWidth = 70; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = ("Programa que calcule las raíces de una ecuación de 2do grado");
            // Declaracion de variables           
            Double a = 0, b = 0, c = 0, disc, x1, x2;
            bool entradaValida = false;

            // Entrada de datos 
            Console.WriteLine("\n");

            // Lectura del coeficiente a con validación
            while (!entradaValida)
            {
                try
                {
                    Console.Write("\tIngresa el coeficiente cuadratico [a]...: ");
                    a = Double.Parse(Console.ReadLine());
                    entradaValida = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número válido.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError inesperado: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }

            // Lectura del coeficiente b con validación
            entradaValida = false;
            while (!entradaValida)
            {
                try
                {
                    Console.Write("\tIngresa el coeficiente lineal [b].......: ");
                    b = Double.Parse(Console.ReadLine());
                    entradaValida = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número válido.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError inesperado: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }

            // Lectura de la constante c con validación
            entradaValida = false;
            while (!entradaValida)
            {
                try
                {
                    Console.Write("\tIngresa la constante [c]................: ");
                    c = Double.Parse(Console.ReadLine());
                    entradaValida = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número válido.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError inesperado: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }

            // Procesos
            Console.WriteLine("\n\tLa solución es:");
            disc = (Math.Pow(b, 2) - 4 * a * c);
            if (a != 0)
            {
                if (disc < 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\tTiene raices imaginarias!!!");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                    x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\tx1 = " + Math.Round(x1, 3));
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tx2 = " + Math.Round(x2, 3));
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("\tEl coeficiente cuadratico debe ser diferente de 0");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.Write("\n\n");
            //Pantalla opcional
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*               Johan Cruyff                *");
            Console.WriteLine("\t*                                           *");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();

        }
        static void ejemplo4()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 25;  // alto de la ventana           
            // Console.WindowWidth = 70; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = " El sexo de una persona ";
            // Declaracion de variables
            int edad = 0;
            String nombre, sexo;
            bool entradaValida = false;

            // Entrada de datos
            Console.WriteLine("\n");
            Console.Write("\tDigitar tu nombre........................: ");
            nombre = Console.ReadLine();

            // Lectura de la edad con validación
            while (!entradaValida)
            {
                try
                {
                    Console.Write("\tDigitar tu edad..........................: ");
                    edad = int.Parse(Console.ReadLine());
                    entradaValida = true;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número entero válido.");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError inesperado: " + ex.Message);
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }

            Console.Write("\tDigitar tu sexo ( Hombre=M y Mujer=F )...: ");
            sexo = Console.ReadLine();

            // Procesos
            Console.WriteLine("\n\n");
            if (sexo == "M" || sexo == "m") // instruccion lógica OR
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\tEl Sr {0} ha sido registrado", nombre); // v
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tLa Sra {0} ha sido registrada", nombre); // f
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine("\n\n");
            //Pantalla opcional
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*               Mario Kempes                *");
            Console.WriteLine("\t*                                           *");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("*********************************************");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();

        }
    }
}