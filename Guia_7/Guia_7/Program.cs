using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Guia_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ej01();
            ej02();
            //ej03();
            //ej04();
            //ej05();
          //  ej06();

        }

        static void ej01()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 20;  // alto de la ventana           
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Numero par o impar usando procedimientos";
            Console.Write("\n\tGuia#7 Ejemplo1");
            Console.WriteLine("\n");
            // Declaración de variables
            int num;
            // Entrada y Procesos
            Console.Write("\tDigitar un numero entero positivo: ");
            num = int.Parse(Console.ReadLine());
            Par(num);  // procedimiento con parametro
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void Par(int a)
        {
            int x;
            x = (a % 2);
            if (x == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\tEs par");
                Console.ForegroundColor = ConsoleColor.Black;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\tEs impar");
                Console.ForegroundColor = ConsoleColor.Black;
            }
        }

        static void ej02()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 25;  // alto de la ventana           
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Suma y Resta con procedimientos sin parametros";
            Console.Write("\n\tGuia#7 Ejemplo2");
            Console.WriteLine("\n");
            suma();
            Console.ReadKey();
            Console.WriteLine("\n\n");
            resta();
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void suma()
        {
            Double r, n1, n2;
            Console.Write("\tDigitar la primera cantidad : ");
            n1 = Double.Parse(Console.ReadLine());
            Console.Write("\tDigitar la segunda cantidad : ");
            n2 = Double.Parse(Console.ReadLine());
            r = n1 + n2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\tEl resultado de la suma es  : " + r);
            Console.ForegroundColor = ConsoleColor.Black;
        }
        static void resta()
        {
            Double r, n1, n2;
            Console.Write("\tDigitar la primera cantidad : ");
            n1 = Double.Parse(Console.ReadLine());
            Console.Write("\tDigitar la segunda cantidad : ");
            n2 = Double.Parse(Console.ReadLine());
            r = n1 - n2;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\tEl resultado de la resta es : " + r);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        static void ej03()
        {
            // Programa realizado por 
            // Día: 
            Console.WindowHeight = 25;  // alto de la ventana           
            Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Conversión de monedas usando Funciones";
            Console.Write("\n\tGuia#7 Ejemplo3");
            Console.WriteLine("\n");
            Double x, p, r;
            Console.Write("\tDigitar la cantidad en dólares: $ ");
            Console.ForegroundColor = ConsoleColor.Red;
            x = Double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            // llamadas a las funciones
            p = euros(x);
            Console.Write("\tLos ${0} dolares son {1} euros ", x, p);
            Console.WriteLine("\n");
            r = libras(x);
            Console.Write("\tLos ${0} dolares son {1} libras ", x, r);
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write(" \t");
            Console.ReadKey();
        }
        static Double euros(Double a)
        {
            Double g;
            g = a * 1.15;
            return g;
        }
        static Double libras(Double a)
        {
            Double v;
            v = a * 3.15;
            return v;
        }

        static void ej04()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 35;  // alto de la ventana           
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Menú matemático con ayuda de los procedimientos";
            Console.Write("\n\tGuia#7 Ejemplo4");
            Console.WriteLine("\n");
            int num1, num2;
            int opcion;
            Console.WriteLine("\n\tMENU PRINCIPAL DE OPERACIONES MATEMATICAS:");
            Console.WriteLine("\n");
            Console.Write("\tDigitar el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("\tDigitar el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("\n\tMENU PRINCIPAL DE OPERACIONES MATEMATICAS:");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n\t===============================================");
            Console.WriteLine("\n");
            Console.WriteLine("\t\t1) Mayor de los 2");
            Console.WriteLine("\t\t2) Multiplo");
            Console.WriteLine("\t\t3) Potencia");
            Console.WriteLine("\n\t===============================================");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n");
            Console.Write("\tDigitar la opción deseada [1..3]: ");
            opcion = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            switch (opcion)
            {
                case 1:
                    mayor(num1, num2);
                    break;
                case 2:
                    multiplo(num1, num2);
                    break;
                case 3:
                    potencia(num1, num2);
                    break;
                default:
                    Console.WriteLine("\tSe ha equivocado de opcion, solo acepta[1..3]");
                    break;
            }
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void mayor(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("\tEl numero {0} es mayor que {1} ", a, b);
            }
            else
            {
                Console.WriteLine("\tEl numero {0} es mayor que {1} ", b, a);
            }
        }
        static void multiplo(int a, int b)
        {
            int w;
            w = (a % b);
            if (w == 0)
            {
                Console.WriteLine("\tEl numero {0} es multiplo de {1} ", a, b);
            }
            else
            {
                Console.WriteLine("\tEl numero {0} no es multiplo de {1} ", b, a);
            }
        }
        static void potencia(int a, int b)
        {
            Double s;
            s = Math.Pow(a, b);
            Console.WriteLine("\tEl numero {0} a la potencia de {1} es: {2}", a, b, s);
        }

        static void ej05()
        {
            // Programa realizado por 
            // Día: 
            Console.WindowHeight = 25;  // alto de la ventana           
            Console.WindowWidth = 68; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Procedimiento sin parametros en un menú";
            int opcion, i;
            Console.WriteLine("\n\t----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\t   MENU PRINCIPAL DE TIPOS DE PAGOS");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            Console.WriteLine("\t  [1] Efectivo\t\t\t15%");
            Console.WriteLine("\t  [2] Tarjeta de Credito\t10%");
            Console.WriteLine("\t  [3] Cheque\t\t\t5%");
            Console.WriteLine("\t  [4] Tarjeta de Regalo\t\t20%");
            Console.WriteLine("\n\t----------------------------------------");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\tDigitar la opción deseada (1..4): ");
            Console.ForegroundColor = ConsoleColor.Black;
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    efectivo();
                    break;
                case 2:
                    credito();
                    break;
                case 3:
                    cheque();
                    break;
                case 4:
                    regalo();
                    break;
                default:
                    Console.WriteLine("\nSe ha equivocado de opcion, solo acepta[1..4]");
                    break;
            }
            Console.WriteLine("\n");
            Console.Write("\t-->Fin del programa, presiona Enter para continuar<--");
            Console.ReadKey();
            Console.Clear();
            Console.Write("\tA T E N C I O N");
            Console.Write("\n\n\tEste programa se destruirá en: ");
            for (i = 3; i >= 0; i--)
            {
                Console.Write("\n\t{0} segundos ", i);
                Thread.Sleep(1000);
                Console.Beep();
                // Saludos a Erick Noyola por su aporte
            }
            Environment.Exit(0);
            Console.ReadKey();
        }
        static void efectivo()
        {
            Double r, v1, iva, t;
            Console.Write("\n\tIngresar el total de la venta:  $");
            v1 = Double.Parse(Console.ReadLine());
            iva = v1 * 0.13;
            r = (v1 + iva) * 0.15;
            t = (v1 + iva) - r;
            Console.WriteLine("\n\tEl total a pagar es de \t\t$" + Math.Round(t, 2));
        }
        static void credito()
        {
            Double r, v1, iva, t;
            Console.Write("\n\tIngresar el total de la venta:  $");
            v1 = Double.Parse(Console.ReadLine());
            iva = v1 * 0.13;
            r = (v1 + iva) * 0.10;
            t = (v1 + iva) - r;
            Console.WriteLine("\n\tEl total a pagar es de \t\t$" + Math.Round(t, 2));
        }
        static void cheque()
        {
            Double r, v1, iva, t;
            Console.Write("\n\tIngresar el total de la venta:  $");
            v1 = Double.Parse(Console.ReadLine());
            iva = v1 * 0.13;
            r = (v1 + iva) * 0.05;
            t = (v1 + iva) - r;
            Console.WriteLine("\n\tEl total a pagar es de \t\t$" + Math.Round(t, 2));
        }
        static void regalo()
        {
            Double r, v1, iva, t;
            Console.Write("\n\tIngresar el total de la venta:  $");
            v1 = Double.Parse(Console.ReadLine());
            iva = v1 * 0.13;
            r = (v1 + iva) * 0.2;
            t = (v1 + iva) - r;
            Console.WriteLine("\n\tEl total a pagar es de \t\t$" + Math.Round(t, 2));
        }

        static void ej06()
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
