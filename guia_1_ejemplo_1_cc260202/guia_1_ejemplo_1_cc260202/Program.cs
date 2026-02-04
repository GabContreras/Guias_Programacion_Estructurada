using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_1_ejemplo_1_cc260202
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ejemplo1();
            //ejemplo2(); 
            //ejemplo3();


        }
        static void ejemplo1()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 25;  // alto de la ventana           
            // Console.WindowWidth = 70; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa con operadores matematicos - numeros enteros";

            bool continuar = true;

            do
            {
                Console.Write("\n\tGuia#1 Ejemplo1");
                // Declaracion de variables
                int n1, n2, s, r, m, d, mo;
                // Entrada de datos
                Console.Write("\n\n");

                try
                {
                    Console.Write("\tDigitar el primer número  : ");
                    n1 = int.Parse(Console.ReadLine());
                    Console.Write("\tDigitar el segundo número : ");
                    n2 = int.Parse(Console.ReadLine());
                    Console.Write("\n");
                    // Proceso de los datos
                    s = n1 + n2;   // calculamos la suma
                    r = n1 - n2;   // calculamos la resta
                    m = n1 * n2;   // calculamos la multiplicacion
                    d = n1 / n2;   // calculamos la division entera
                    mo = n1 % n2;   // calculamos el modulo de la division
                    // Salida de los datos
                    Console.WriteLine("\t************************************************");
                    Console.WriteLine("\t************************************************");

                    Console.WriteLine("\t  La suma de los numeros es.............: " + s);
                    Console.WriteLine("\t  La resta de los numeros es............: " + r);
                    Console.WriteLine("\t  La multiplicacion de los numeros es.. : " + m);
                    Console.WriteLine("\t  La division de los numeros es.........: " + d);
                    Console.WriteLine("\t  El modulo de los numeros es...........: " + mo);
                    Console.WriteLine("\t*************************************************");
                    Console.Write("\n\n");
                    continuar = false;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número entero válido.");
                    Console.WriteLine("\tIntentando nuevamente...\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (DivideByZeroException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: No se puede dividir entre cero.");
                    Console.WriteLine("\tIntentando nuevamente...\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: El número es demasiado grande.");
                    Console.WriteLine("\tIntentando nuevamente...\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: " + ex.Message);
                    Console.WriteLine("\tIntentando nuevamente...\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            } while (continuar);

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
            Console.WriteLine("\t*            Tu     Nombre                  *");
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
        static void ejemplo2()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 25;  // alto de la ventana           
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa de Promedio de ventas de un vendedor";

            bool continuar = true;

            do
            {
                Console.Write("\n\tGuia#1 Ejemplo2");
                Console.Write("\n\n");
                // Declaracion de variables
                String nomb, ape;
                Double v1, v2, v3, prom;
                // Entrada
                Console.Write("\tEmpresa ADOC...");
                Console.Write("\n");

                try
                {
                    Console.Write("\tDigitar el nombre del vendedor......: ");
                    nomb = (Console.ReadLine());
                    Console.Write("\tDigitar el apellido del vendedor....: ");
                    ape = (Console.ReadLine());
                    Console.Write("\tDigitar la primer venta.............: $ ");
                    v1 = Double.Parse(Console.ReadLine());
                    Console.Write("\tDigitar la segunda venta............: $ ");
                    v2 = Double.Parse(Console.ReadLine());
                    Console.Write("\tDigitar la tercer venta.............: $ ");
                    v3 = Double.Parse(Console.ReadLine());
                    // Procesos
                    prom = (v1 + v2 + v3) / 3;
                    // Salida
                    Console.Write("\n");
                    Console.WriteLine("\t------------------------------------------------");
                    Console.WriteLine("\tEl promedio de " + nomb + " " + ape + " es $ " + Math.Round(prom, 2));
                    Console.WriteLine("\t------------------------------------------------");
                    Console.Write("\n\n");
                    continuar = false;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número decimal válido.");
                    Console.WriteLine("\tIntentando nuevamente...\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: El número es demasiado grande.");
                    Console.WriteLine("\tIntentando nuevamente...\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: " + ex.Message);
                    Console.WriteLine("\tIntentando nuevamente...\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            } while (continuar);

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
            Console.WriteLine("\t*              Tu    Nombre                 *");
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
            // Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa de Calculo de descuentos de un salario base";

            bool continuar = true;

            do
            {
                Console.Write("\n\tGuia#1 Ejemplo3");
                Console.Write("\n\n");
                // Declaracion de variables
                Double sal, d1, d2, d3, s, total;
                // Entrada
                Console.Write("\tLibreria SanRey...");
                Console.Write("\n");

                try
                {
                    Console.Write("\tDigitar el salario base.....:  $");
                    sal = Double.Parse(Console.ReadLine());
                    // Procesos
                    d1 = sal * 0.10;  // calculo de la renta
                    d2 = sal * 0.07;  // calculo del afp
                    d3 = sal * 0.05;  // calculo del seguro social
                    s = d1 + d2 + d3;
                    total = sal - s;
                    // Salida
                    Console.Write("\n");
                    Console.WriteLine("\t---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\tEl salario total es de......:  $" + Math.Round(total, 2));
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\t---------------------------------------");
                    Console.Write("\n");
                    continuar = false;
                }
                catch (FormatException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: Debe ingresar un número decimal válido.");
                    Console.WriteLine("\tIntentando nuevamente...\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (OverflowException)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: El número es demasiado grande.");
                    Console.WriteLine("\tIntentando nuevamente...\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n\tError: " + ex.Message);
                    Console.WriteLine("\tIntentando nuevamente...\n");
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            } while (continuar);

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
            Console.WriteLine("\t*             Tu     Nombre                 *");
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


    }
}
