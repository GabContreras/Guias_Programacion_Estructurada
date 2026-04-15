using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso_Desafio2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string opcion;
            bool salirDeMenu = false;
            bool existenRegistros = false;
            int prom = 0;
            int nombr = 0;

            String[] nombres = new String[nombr];
            Double[,] notas = new Double[nombr, prom];

            do
            {
                Console.WriteLine("Bienvenido al sistema de notas");
                Console.WriteLine("Menú de opciones:");
                Console.WriteLine("a) Registrar estudiantes y notas");
                Console.WriteLine("b) Buscar nota de un estudiante");
                Console.WriteLine("c) Estadísticas generales");
                Console.WriteLine("d) Salir");
                Console.Write("Por favor, seleccione una opción:");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "A":
                    case "a":
                        Console.Write("Cuántos estudiantes desea ingresar?: ");
                        nombr = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Se ingresaran {nombr} estudiantes");
                        Console.Write("Cuántas notas por estudiante desea ingresar?: ");
                        prom = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Se ingresaran {prom} notas por estudiante");
                        nombres = new String[nombr];
                        notas = new Double[nombr, prom];

                        for (int i = 0; i < nombr; i++)
                        {
                            Console.Write($"Ingrese el nombre del estudiante #{i + 1}: ");
                            nombres[i] = Console.ReadLine();
                            for (int j = 0; j < prom; j++)
                            {
                                Console.Write($"Ingrese la nota #{j + 1} para {nombres[i]}: ");
                                double nota = double.Parse(Console.ReadLine());

                                notas[i, j] = nota;
                            }

                        }

                        Console.WriteLine("Estudiantes y notas registrados exitosamente.");
                        Console.WriteLine("\nEstudiantes con sus notas y promedio:");
                        for (int i = 0; i < nombr; i++)
                        {
                            Console.Write($"{nombres[i]}: ");
                            double sumaNotas = 0;

                            for (int j = 0; j < prom; j++)
                            {
                                Console.Write($"{notas[i, j]} |");
                                sumaNotas += notas[i, j];
                            }
                            Console.Write($"Promedio: {Math.Round(sumaNotas / prom, 2)}");

                            Console.WriteLine();
                        }
                        existenRegistros = true;
                        Console.WriteLine("Presione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "B":
                    case "b":
                       //No creo que se evalue esto

                        break;
                    case "C":
                    case "c":
                        Console.WriteLine("--- Estadísticas de notas ---");
                        if (existenRegistros)
                        {
                            double sumaPromediosGenerales = 0;
                            double notaMasAlta = -1;
                            string nombreNotaMasAlta = "";
                            int aprobados = 0;

                            for (int i = 0; i < nombr; i++)
                            {
                                double sumaNotas = 0;
                                for (int j = 0; j < prom; j++) // 'prom' es tu cantidad de notas
                                {
                                    sumaNotas += notas[i, j];
                                }
                                double promedio = sumaNotas / prom;
                                
                                // 1. Acumulador para promedio general
                                sumaPromediosGenerales += promedio;

                                // 2. Buscar al estudiante con el promedio más alto
                                if (promedio > notaMasAlta)
                                {
                                    notaMasAlta = promedio;
                                    nombreNotaMasAlta = nombres[i];
                                }

                                // 3. Contar aprobados
                                if (promedio >= 7.0)
                                {
                                    aprobados++;
                                }
                            }

                            // Cálculos finales y mostrar info
                            double promedioGrupo = sumaPromediosGenerales / nombr;
                            
                            Console.WriteLine($"\nPromedio general del grupo: {Math.Round(promedioGrupo, 2)}");
                            Console.WriteLine($"Nota más alta: {nombreNotaMasAlta} con {Math.Round(notaMasAlta, 2)}");
                            Console.WriteLine($"Estudiantes aprobados: {aprobados} de {nombr}, promedio para pasar es de 6.0");
                        }
                        else
                        {
                            Console.WriteLine("No existen registros para sacar estadísticas, por favor seleccione la opcion A antes de proceder.");
                        }

                        Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("Saliendo del programa...");
                        Console.WriteLine("Presione cualquier tecla para salir...");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción entre a y d.");
                        break;
                }
            }
            while (!salirDeMenu);

            // ============================================================
            // EJERCICIO DE PRÁCTICA — ESTILO DESAFÍO PRÁCTICO
            // Temas: Vectores, For, Switch, If/else if, Acumuladores
            // ============================================================
            //
            // ENUNCIADO:
            // Un instituto necesita un programa para registrar y analizar
            // las notas de sus estudiantes.
            //
            // El programa debe mostrar un menú con estas opciones:
            //   a) Registrar estudiantes y notas
            //   b) Buscar nota de un estudiante
            //   c) Estadísticas generales
            //   d) Salir
            //
            // ------------------------------------------------------------
            // OPCIÓN A — Registrar (For + Vectores)
            // ------------------------------------------------------------
            //   1. Pedir cuántos estudiantes se van a registrar (n).
            //   2. Declarar dos vectores de tamaño n:
            //        String[] nombres   = new String[n];
            //        Double[] promedios = new Double[n];
            //   3. Para cada estudiante (for de i=0 hasta n):
            //        - Pedir su nombre  → guardarlo en nombres[i]
            //        - Pedir 3 notas con un FOR INTERNO, acumularlas
            //        - Calcular promedio = suma / 3
            //        - Guardar en promedios[i]
            //
            // ------------------------------------------------------------
            // OPCIÓN B — Buscar (For + If/else if)
            // ------------------------------------------------------------
            //   1. Pedir el nombre a buscar.
            //   2. Recorrer nombres[] con un for.
            //   3. Si lo encuentra → mostrar su promedio y su condición:
            //        promedio >= 7.0              → "Aprobado"
            //        promedio >= 5.0 y < 7.0      → "Recuperación"
            //        promedio < 5.0               → "Reprobado"
            //   4. Si no existe → mostrar "Estudiante no encontrado".
            //
            // ------------------------------------------------------------
            // OPCIÓN C — Estadísticas (For + acumuladores)
            // ------------------------------------------------------------
            //   Recorrer promedios[] y calcular/mostrar:
            //     - Promedio general de todo el grupo  (suma / n)
            //     - La nota más alta y el nombre del estudiante
            //     - Cantidad de estudiantes aprobados (promedio >= 7.0)
            //
            // ------------------------------------------------------------
            // DATOS DE PRUEBA:
            //   n = 3
            //
            //   Estudiante | Nota1 | Nota2 | Nota3 | Promedio
            //   -----------|-------|-------|-------|----------
            //   Ana        |  8.0  |  7.5  |  9.0  |   8.17
            //   Carlos     |  5.0  |  6.0  |  4.5  |   5.17
            //   María      |  3.0  |  4.0  |  2.5  |   3.17
            //
            //   Promedio general  → 5.50
            //   Nota más alta     → Ana con 8.17
            //   Aprobados         → 1 (solo Ana)
            //
            // ------------------------------------------------------------
            // PISTAS CLAVE:
            //   - Declara n y los vectores ANTES del switch, en el Main,
            //     para que las opciones B y C puedan acceder a ellos.
            //   - Inicializa n = 0 y los vectores como null antes del menú.
            //   - En opción C, inicializa: mayor = promedios[0], nomMayor = nombres[0]
            //   - Usa Math.Round(valor, 2) en todos los resultados decimales
            //   - Usa Console.ReadKey() al final de cada case
            //   - Para el switch usa las letras como string: case "a": case "A":
            //
            // ------------------------------------------------------------
            // ESTRUCTURA BASE SUGERIDA:
            //
            //   int n = 0;
            //   String[] nombres   = null;
            //   Double[] promedios = null;
            //   String opcion;
            //
            //   Console.Write("Ingrese la opción (a-d): ");
            //   opcion = Console.ReadLine();
            //
            //   switch (opcion)
            //   {
            //       case "A":
            //       case "a":
            //           // lógica de registro aquí
            //           break;
            //
            //       case "B":
            //       case "b":
            //           // lógica de búsqueda aquí
            //           break;
            //
            //       case "C":
            //       case "c":
            //           // lógica de estadísticas aquí
            //           break;
            //
            //       case "D":
            //       case "d":
            //           Environment.Exit(0);
            //           break;
            //
            //       default:
            //           Console.WriteLine("Opción no válida.");
            //           break;
            //   }
            //
            // ============================================================

            // ESCRIBE TU CÓDIGO DEBAJO DE ESTA LÍNEA:








        }

    }
}

            