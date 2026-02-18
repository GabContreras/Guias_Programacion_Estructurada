using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ej1();
            //ej2();
            //ej3();
            //ej4();
            //ej5();
            //ej6();
        }

        static void ej1()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 32;  // alto de la ventana           
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Calcular el cubo de varios numeros enteros con FOR";
            Console.Write("\nGuia#5 Ejemplo1");
            Console.WriteLine("\n");
            // Declaracion de variables
            Double cubo;
            int cantidad;
            int i;  // variable del FOR
                    // Entrada de datos
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\t<< Calculo de Cubos >>\n");
            Console.ForegroundColor = ConsoleColor.Black;


            int cantDeNumeros; // cantidad de numeros a ingresar

            Console.Write("\tCuantos numeros enteros desea calcular? (Ingresar número entero): ");



            cantDeNumeros = int.Parse(Console.ReadLine());
            for (i = 1; i <= cantDeNumeros; i++)
            {
                Console.Write($"\n\tExcelente, calculando cubo número {i}\n");

                //Entrada de datos
                Console.Write("\tEscriba un numero entero: ");
                cantidad = int.Parse(Console.ReadLine());
                //Procesos
                cubo = Math.Pow(cantidad, 3);
                //Salida
                Console.Write("                      su cubo es: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(cubo);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write("\n\n");
            }
            Console.Write("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej2()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 25;  // alto de la ventana           
            // Console.WindowWidth = 65; //ancho de la ventana

            // Configuración de colores y ventana de consola
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Promedio de Notas de Cafetin Empresarial II";
            Console.Write("\n\tGuia#5 Ejemplo2");
            Console.WriteLine("\n");

            // Declaracion de variables
            String nombre, apellido;  // Nombre del estudiante
            int x;          // Variable de control del ciclo for
            Double nota, sum, prom;  // nota individual, suma de notas y promedio
            sum = 0;  // Inicializamos el acumulador en cero

            // Entrada de datos - Nombre del estudiante
            Console.Write("\tDigitar el/los nombres del estudiante: ");
            nombre = Console.ReadLine();
            Console.Write("\tDigitar el/los apellidos del estudiante: ");
            apellido = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine($"\tEl nombre del estudiante es: {nombre} {apellido} ");
            Console.WriteLine("\n");

            int Cant;

            Console.Write("\tDigitar la cantidad de notas a ingresar: ");
            Cant = int.Parse(Console.ReadLine());

            Console.Write("\tRecuerde poner valores entre 0 y 10 para poder calcular bien el promedio\n");

            // Ciclo for para ingresar 5 notas
            for (x = 1; x <= Cant; x = x + 1)
            {
                Console.Write($"\tDigitar la nota {x}: ");
                Console.ForegroundColor = ConsoleColor.Blue;
                nota = Double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Black;
                sum = sum + nota;// aki se van sumando las notas (acumulador)
            }

            // Procesos fuera del ciclo for
            // Calcular el promedio dividiendo la suma entre 5
            prom = sum / 5;

            // Salida de datos - Mostrar el promedio redondeado a 2 decimales
            Console.WriteLine("\n");
            if (prom <= 5.9)
            {
                Console.WriteLine($"\tEl promedio de {nombre} {apellido} es de: {Math.Round(prom, 2)}, por tal motivo reprobó la materia");
            }
            else
            {
                Console.WriteLine($"\tEl promedio de {nombre} {apellido} es de: {Math.Round(prom, 2)}, por tal motivo aprobó la materia");
            }
            Console.WriteLine($"\tLa cantidad de notas ingresadas fue de: {Cant} ");

            Console.Write("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }

        static void ej3()
        {   // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 30;  // alto de la ventana           
            // Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Mayor, Menor y Sumatoria sde una lista de enteros";
            Console.Write("\n\tGuia#5 Ejemplo3");
            Console.WriteLine("\n");
            // Declaracion de variables
            int i, n;
            int max = 0, min = 0, sum = 0;
            // Entrada de datos
            Console.WriteLine("\tIngresaremos 7 numeros enteros....");
            for (i = 1; i <= 7; i = i + 1)
            {
                Console.Write("\tEl numero [" + i + "] es : ");
                n = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    max = n;
                    min = n;
                }
                if (n > max)
                {
                    max = n;
                }
                if (n < min)
                {
                    min = n;
                }
                if ((n >= 15) && (n <= 30)) // los que se estan en el rango
                {
                    sum = sum + n;
                }
            }
            Console.Write("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\tEl numero mayor es: " + max);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\tEl numero menor es: " + min);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\tLa suma de los que estan entre 15 y 30 es: " + sum);
            Console.WriteLine("\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej4()
        {  // Programa realizado por 
           // Día: 
           // Console.WindowHeight = 22;  // alto de la ventana           
           // Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Secuencia de numeros";
            Console.Write("\n\tGuia#5 Ejemplo4");
            Console.WriteLine("\n");
            // Declaracion de variables
            int n1, n2, i, a, b;
            // Entrada de datos
            Console.Write("\tDigitar el primer numero [menor]  : ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("\tDigitar el segundo numero [mayor] : ");
            n2 = int.Parse(Console.ReadLine());
            // Procesos
            a = n1 + 1;
            b = n2 - 1;
            Console.WriteLine("\n");
            Console.Write("\tLa secuencia de numeros resultante es...");
            Console.WriteLine("\n");
            Console.Write("\t");
            for (i = a; i <= b; i = i + 1)
            {
                Console.Write(" " + i + " ");
            }
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej5()
        { // Programa realizado por Gloria Diaz
          // Día: 
          // Console.WindowHeight = 32;  // alto de la ventana           
          // Console.WindowWidth = 67; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa que contabiliza varios calculos";
            Console.Write("\nGuia#5 Ejemplo5");
            Console.WriteLine("\n");
            // Declaracion de variables
            int n, valor, ceros, positivos, negativos, pares, impares;
            ceros = 0;
            positivos = 0;
            negativos = 0;
            pares = 0;
            impares = 0;
            // Entrada de datos;
            Console.Write("\tIngrese la cantidad de numeros a digitar [entero]: ");
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("\tIngrese numero [" + i + "]: ");
                valor = int.Parse(Console.ReadLine());
                if (valor == 0)
                {
                    ceros++;
                }
                if (valor > 0)
                {
                    positivos++;
                }
                else
                {
                    if (valor < 0)
                    {
                        negativos++;
                    }
                }
                if (valor % 2 == 0 && valor != 0)
                {
                    pares++;
                }
                else
                {
                    if ((valor % 2) != 0)
                    {
                        impares++;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("\tCantidad de numeros negativos...: " + negativos);
            Console.WriteLine("\tCantidad de numeros positivos...: " + positivos);
            Console.WriteLine("\tCantidad de numeros pares.......: " + pares);
            Console.WriteLine("\tCantidad de numeros impares.....: " + impares);
            Console.WriteLine("\tCantidad de ceros...............: " + ceros);
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej6()
        { // Programa realizado por Jorge Rivera
          // Día: 
          // Console.WindowHeight = 30;  // alto de la ventana           
          // Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa de notas de varios alumnos...";
            Console.Write("\nGuia#5 Ejemplo6");
            Console.WriteLine("\n");
            // Declaracion de variables
            Double nota;
            int i;
            int mayor = 0, menor = 0;
            String linea;
            //Procesos
            Console.Write("\tSe ingresaran las notas finales de 10 estudiantes...");
            Console.WriteLine("\n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("\tIngrese la nota [" + i + "]: ");
                linea = Console.ReadLine();
                nota = Double.Parse(linea);
                if (nota >= 7.5)
                {
                    mayor = mayor + 1;
                }
                else
                {
                    menor = menor + 1;
                }
            }
            Console.WriteLine("\n");
            Console.Write("\tCantidad de mayores......: " + mayor);
            Console.WriteLine("\n");
            Console.Write("\tCantidad de menores......: " + menor);
            Console.WriteLine("\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }

    }
}
