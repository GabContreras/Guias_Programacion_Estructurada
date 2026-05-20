using System;
namespace Guia7ejemplo6
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Programa realizado por 
            // Día: 
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Calculadora Cientifica";
            int opcion;
            int a = 0, b = 0, c = 0, d = 0, e = 0, f = 0, g = 0, h = 0, i = 0, j = 0;
            int op2;
            do
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\t*************************************");
                Console.WriteLine("\t*      Calculadora Cientifica       *");
                Console.WriteLine("\t*************************************");
                Console.WriteLine("\n\t          Menu Principal           ");
                Console.WriteLine("\t*************************************");
                Console.WriteLine("\t*     [1] Suma                      *");
                Console.WriteLine("\t*     [2] Resta                     *");
                Console.WriteLine("\t*     [3] Multiplicacion            *");
                Console.WriteLine("\t*     [4] Division                  *");
                Console.WriteLine("\t*     [5] Potencia n-esima          *");
                Console.WriteLine("\t*     [6] Raíz n-esima              *");
                Console.WriteLine("\t*     [7] Seno                      *");
                Console.WriteLine("\t*     [8] Coseno                    *");
                Console.WriteLine("\t*     [9] Tangente                  *");
                Console.WriteLine("\t*     [10] Operacion Modulo         *");
                Console.WriteLine("\t*     [11] Mostrar resultados       *");
                Console.WriteLine("\t*     [12] Salir                    *");
                Console.WriteLine("\t*************************************");
                Console.WriteLine("\n");
                Console.Write("\tDigitar la opcion deseada (1..12): ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        a = a + 1;
                        Suma();
                        break;
                    case 2:
                        b = b + 1;
                        Resta();
                        break;
                    case 3:
                        c = c + 1;
                        Multiplicacion();
                        break;
                    case 4:
                        d = d + 1;
                        Division();
                        break;
                    case 5:
                        e = e + 1;
                        Potencia();
                        break;
                    case 6:
                        f = f + 1;
                        Raiz();
                        break;
                    case 7:
                        g = g + 1;
                        Seno();
                        break;
                    case 8:
                        h = h + 1;
                        Coseno();
                        break;
                    case 9:
                        i = i + 1;
                        Tangente();
                        break;
                    case 10:
                        j = j + 1;
                        Modulo();
                        break;
                    case 11:
                        Console.WriteLine("\n\tLa opcion 1 se ha usado " + a + " veces");
                        Console.WriteLine("\n\tLa opcion 2 se ha usado " + b + " veces");
                        Console.WriteLine("\n\tLa opcion 3 se ha usado " + c + " veces");
                        Console.WriteLine("\n\tLa opcion 4 se ha usado " + d + " veces");
                        Console.WriteLine("\n\tLa opcion 5 se ha usado " + e + " veces");
                        Console.WriteLine("\n\tLa opcion 6 se ha usado " + f + " veces");
                        Console.WriteLine("\n\tLa opcion 7 se ha usado " + g + " veces");
                        Console.WriteLine("\n\tLa opcion 8 se ha usado " + h + " veces");
                        Console.WriteLine("\n\tLa opcion 9 se ha usado " + i + " veces");
                        Console.WriteLine("\n\tLa opcion 10 se ha usado " + j + " veces");
                        break;
                    case 12:
                        Salir();
                        break;
                    default:
                        Console.WriteLine("\n\tSe ha equivocado de opcion, solo acepta[1...12]");
                        break;
                }
                Console.Write("\n\tPara continuar digitar el 1 ó el 0 para terminar: ");
                op2 = int.Parse(Console.ReadLine());
            } while (op2 == 1);
            Console.WriteLine("\n");
            Console.Write("\t-->Fin del programa");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t*********************************************");
            Console.WriteLine("\t*     Este programa fue diseñado por:       *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*            Sara Marcela Saballos          *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*********************************************");
            Console.ReadKey();
        }
        static void Suma()
        {
            try
            {
                Double a, b, resultado;
                Console.Write("\tDigite el primer valor....:");
                a = Double.Parse(Console.ReadLine());
                Console.Write("\tDigite el segundo valor...:");
                b = Double.Parse(Console.ReadLine());
                resultado = a + b;
                Console.WriteLine("\tEl resultado es...........:" + resultado);
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
        static void Resta()
        {
            try
            {
                Double c, d, resultado;
                Console.Write("\tDigite el primer valor....:");
                c = Double.Parse(Console.ReadLine());
                Console.Write("\tDigite el segundo valor...:");
                d = Double.Parse(Console.ReadLine());
                resultado = c - d;
                Console.WriteLine("\tEl resultado es...........:" + resultado);
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
        static void Multiplicacion()
        {
            try
            {
                Double e, f, resultado;
                Console.Write("\tDigite el primer valor....:");
                e = Double.Parse(Console.ReadLine());
                Console.Write("\tDigite el segundo valor...:");
                f = Double.Parse(Console.ReadLine());
                resultado = e * f;
                Console.WriteLine("\tEl resultado es.......:" + resultado);
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
        static void Division()
        {
            try
            {
                Double g, h, resultado;
                Console.Write("\tDigite el primer valor.....:");
                g = Double.Parse(Console.ReadLine());
                Console.Write("\tDigite el segundo valor....:");
                h = Double.Parse(Console.ReadLine());
                resultado = g / h;
                if (h == 0)
                {
                    Console.WriteLine("\tNo se puede dividir entre cero");
                }
                else
                {
                    Console.WriteLine("\tEl resultado es.....:" + resultado);
                }
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
        static void Potencia()
        {
            try
            {
                Double num1, num2, resultado;
                Console.Write("\tIntroduzca la base........: ");
                num1 = Double.Parse(Console.ReadLine());
                Console.Write("\tIntroduzca el exponente...: ");
                num2 = Double.Parse(Console.ReadLine());
                resultado = Math.Pow(num1, num2);
                Console.WriteLine("\tEl resultado es.......: " + resultado);
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
        static void Raiz()
        {
            try
            {
                Double radic, indice, resultado;
                Console.Write("\tEscriba el valor del radicando...:");
                radic = Double.Parse(Console.ReadLine());
                Console.Write("\tEscriba el valor del indice......:");
                indice = Double.Parse(Console.ReadLine());
                resultado = Math.Pow(radic, 1 / indice);
                if (indice == 0)
                {
                    Console.WriteLine("\tError matemático, intente otra vez");
                }
                else
                {
                    Console.WriteLine("\tEl resultado es............: " + resultado);
                }
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
        static void Seno()
        {
            try
            {
                Double m, resultado1, resultado2, resultado3;
                Console.Write("\tDigite el valor del ángulo.....:");
                m = Double.Parse(Console.ReadLine());
                resultado1 = Math.Sin(m * Math.PI / 180);
                resultado2 = Math.PI / 180;
                resultado3 = resultado1 * resultado2;
                Console.WriteLine("\tEl resultado del seno es...: " + Math.Round(resultado3, 2) + "radianes");
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
        static void Coseno()
        {
            try
            {
                Double n, resultado1, resultado2, resultado3;
                Console.Write("\tDigite el valor del ángulo......: ");
                n = Double.Parse(Console.ReadLine());
                resultado1 = Math.Cos(n);
                resultado2 = Math.PI / 180;
                resultado3 = resultado1 * resultado2;
                Console.WriteLine("\tEl resultado del coseno es..:" + Math.Round(resultado3, 2) + "radianes");
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
        static void Tangente()
        {
            try
            {
                Double h, resultado1, resultado2, resultado3;
                Console.Write("\tDigite el  valor del ángulo.........:");
                h = Double.Parse(Console.ReadLine());
                resultado1 = Math.Tan(h);
                resultado2 = Math.PI / 180;
                resultado3 = resultado1 * resultado2;
                Console.WriteLine("\tEl resultado de la tangente es..:" + Math.Round(resultado3, 2) + "radianes ");
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
        static void Modulo()
        {
            try
            {
                int a, b, z;
                Console.Write("\tIngresar el primer valor............: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("\tIngresar el segundo valor...........: ");
                b = int.Parse(Console.ReadLine());
                z = a % b;
                if (z == 0)
                {
                    Console.WriteLine("\tNo se puede dividir entre cero");
                }
                else
                {
                    Console.WriteLine("\tEl residuo de la división es.: " + z);
                }
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
        static void Salir()
        {
            try
            {
                Console.Write("\tHa decidido salir de la calculadora, presionar Enter");
                Console.ReadKey();
                Environment.Exit(0);
            }
            catch (Exception error)
            {
                Console.Write("\t");
                Console.WriteLine(error.Message);
            }
        }
    }
}