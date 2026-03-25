using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ej01();
            //ej02();
            ej03();
            //ej04();
            //ej05();
        }

        static void ej01()
        {
            // Console.WindowHeight = 30; // alto de la ventana
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Manejo de datos en una matriz [3x3]";
            Console.Write("\nGuia#9 Ejemplo1");
            Console.WriteLine("\n");
            int filas, columnas;

            Console.Write("\tIngresa la cantidad de filas que quieres que tenga la matriz (por favor ingresa un numero mayor a cero): ");
            Console.ForegroundColor = ConsoleColor.Red;
            filas = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\tIngresa la cantidad de columnas que quieres que tenga la matriz (por favor ingresa un numero mayor a cero): ");
            Console.ForegroundColor = ConsoleColor.Red;
            columnas = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;


            int[,] Matrix = new int[filas, columnas];
            //Cargar y visualizar una matriz
            for (int x = 0; x < filas; x++) // for externo para filas
            {
                for (int y = 0; y < columnas; y++) // for interno para columnas
                {
                    Console.Write("\tIngrese el valor de la posición [" + x + "," + y + "]: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Matrix[x, y] = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            Console.Write("\n");
            Console.Write("\tAhora visualizamos la matrix digitada....");
            Console.WriteLine("\n");
            Imprimir(Matrix);
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }

        static void Imprimir(int[,] Matrix)
        {
            int filas = Matrix.GetLength(0);
            int columnas = Matrix.GetLength(1);
            for (int x = 0; x < filas; x++)
            {
                Console.Write("\n");
                for (int y = 0; y < columnas; y++)
                {
                    Console.Write("\t" + Matrix[x, y]);
                }
            }
        }

        static void ej02()
        {
            // Console.WindowHeight = 35; // alto de la ventana
            // Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Sumando los datos de 2 matrices de tamano 2x3";
            Console.Write("\nGuia#9 Ejemplo2");
            Console.WriteLine("\n");
            //Declarando las matrices
            int[,] Matriz1 = new int[2, 3];
            int[,] Matriz2 = new int[2, 3];
            int[,] Matriz3 = new int[2, 3];

            //Digitamos la primer matriz
            Console.Write("\tDigitamos la primer matriz [1]");
            Console.Write("\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\tIngrese el elemento [" + i + "," + j + "]: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Matriz1[i, j] = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            Console.Write("\n");

            //Digitamos la segunda matriz
            Console.Write("\tDigitamos la segunda matriz [2]");
            Console.Write("\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\tIngrese el elemento [" + i + "," + j + "]: ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Matriz2[i, j] = int.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Black;
                }
            }
            Console.Write("\n");

            //Realizamos el cálculo de la suma de las 2 matrices
            Console.Write("\tSumando las 2 matrices anteriores");
            Console.Write("\n");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Matriz3[i, j] = Matriz1[i, j] + Matriz2[i, j];
                }
            }
            //Llamamos a un procedimiento para visualizar el resultado
            Mostrar(Matriz3);
            Console.WriteLine("\n");
            Console.WriteLine("\t--> Fin del Programa");
            Console.ReadKey();
        }

        static void Mostrar(int[,] Matriz3)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + Matriz3[i, j]);
                }
            }
        }

        static void ej03()
        { // Programa realizado por 
          // Día: 
          // Console.WindowHeight = 45; // alto de la ventana
          // Console.WindowWidth = 80; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Manejo de matrices y vectores para pagos de empleados";
            Console.Write("\nGuia#9 Ejemplo3");
            Console.WriteLine("\n");
            int empleadosnum, sueldosnum;
            Console.Write("\tIngrese la cantidad de empleados a registrar (por favor ingresa un numero mayor a cero): ");
            Console.ForegroundColor = ConsoleColor.Red;
            empleadosnum = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\tIngrese la cantidad de sueldos a registrar por cada empleado (por favor ingresa un numero mayor a cero): ");
            Console.ForegroundColor = ConsoleColor.Red;
            sueldosnum = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            String[] empleados = new String[empleadosnum];
            int[,] sueldos = new int[empleadosnum, sueldosnum];
            int[] sueldostot = new int[empleadosnum];
            //Primera Parte
            for (int f = 0; f < empleadosnum; f++)
            {
                Console.Write("\tIngrese el nombre del operario " + (f + 1) + ": ");
                empleados[f] = Console.ReadLine();
                for (int c = 0; c < sueldosnum; c++)
                {
                    Console.Write("\tIngrese sueldo " + (c + 1) + ": ");
                    sueldos[f, c] = int.Parse(Console.ReadLine());
                }
            }
            //Segunda Parte
            int z = sueldos.GetLength(0);  // devuelve el tamaño de la fila
            for (int f = 0; f < z; f++)
            {
                int suma = 0;
                int e = sueldos.GetLength(1);
                for (int c = 0; c < e; c++)
                {
                    suma = suma + sueldos[f, c];
                }
                sueldostot[f] = suma;
            }
            Console.WriteLine("\n");

            Console.WriteLine("\t-----Resumen de sueldos ingresados para cada empleado-----");

            for (int f = 0; f < empleadosnum; f++)
            {
                               
                Console.Write($"\n\t{empleados[f]}");
                for (int c = 0; c < sueldosnum; c++)
                {

                    Console.Write($"\t ${sueldos[f, c]}");
                }
            }

            //Tercera Parte
            Console.WriteLine("\n");
            Console.WriteLine("\t-----Estadistica de Sueldos-----");
            Console.WriteLine("\tTotal de sueldos pagados por Operario.");
            for (int f = 0; f < sueldostot.Length; f++)
            {
                Console.WriteLine("\t" + empleados[f] + " -> " + "\t $" + sueldostot[f]);
            }
            //Cuarta Parte
            int may = sueldostot[0];
            String nom = empleados[0];
            for (int f = 0; f < sueldostot.Length; f++)
            {
                if (sueldostot[f] > may)
                {
                    may = sueldostot[f];
                    nom = empleados[f];
                }
            }

           
            Console.Write("\tEl operario con mayor sueldo es " + nom + " con un valor de $" + may);
            Console.WriteLine("\n\n");
            Console.WriteLine("\t--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }

        static void ej04()
        { // Programa realizado por 
          // Día: 
          // Console.WindowHeight = 45; // alto de la ventana
          // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "El inicio de un juego divertido...";
            Console.Write("\nGuia#9 Ejemplo4");
            Console.WriteLine("\n");
            int f, c;
            int[,] M = new int[3, 3];
            Console.Write("\tDigitamos la matriz");
            Console.Write("\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\tIngrese el elemento [" + i + "," + j + "]: ");
                    M[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t\t");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\tIngrese la posicion del alumno a eliminar");
            Console.Write("\tIngresa fila    : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            f = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\tIngresa columna : ");
            Console.ForegroundColor = ConsoleColor.Red;
            c = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            M[f, c] = 0;
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t\t");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("\t--> Fin del Programa");
            Console.ReadKey();
        }

        static void ej05()
        {  // Programa realizado por 
            Console.Title = "Guia9 Ejemplo5 Jueguito X 0";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            //Declaracion de variables
            int f, c;
            int a = 0, g;
            String[,] M = new String[3, 3];
            Console.Write("\nJueguito del X - 0");
            Console.Write("\n");
            //Entrada de datos... digitar solo numeros 1
            Console.Write("Digitamos la matriz [3x3] ");
            Console.Write("\n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Ingrese el elemento [" + i + "," + j + "]: ");
                    M[i, j] = Console.ReadLine();
                }
            }
            Console.WriteLine("\n");

            //Visualizar la matriz con numeros 1
            for (int i = 0; i < 3; i++)
            {
                Console.Write("\t\t");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(M[i, j] + " ");
                }
                Console.WriteLine("\n");
            }
            int op1;
            do
            {
                Console.Clear();
                a = a + 1;
                //Eliminar un dato
                Console.WriteLine("Ingrese la posición del alumno a eliminar");
                Console.Write("Ingresa fila: ");
                f = int.Parse(Console.ReadLine());
                Console.Write("Ingresa columna: ");
                c = int.Parse(Console.ReadLine());
                g = a % 2;
                if (g == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    M[f, c] = "0";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n");
                    //Imprimimos la nueva matriz
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("\t\t");
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(M[i, j] + " ");
                        }
                        Console.WriteLine("\n");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    M[f, c] = "X";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("\n");
                    //Imprimimos la nueva matriz
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write("\t\t");
                        for (int j = 0; j < 3; j++)
                        {
                            Console.Write(M[i, j] + " ");
                        }
                        Console.WriteLine("\n");
                    }
                }
                Console.Write("-->Si desea seguir jugando, digite 1 sino 0: ");
                op1 = int.Parse(Console.ReadLine());
            }
            while (op1 == 1);
            Console.ReadKey();
            // Un saludo a Diana Alvarado
            Console.WriteLine("\t--> Fin del Programa");
            Console.ReadKey();
        }
    }
}
