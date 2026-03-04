using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ej01();
            //ej02();
            //ej05();
            ej06();
            //ej07();
            //ej08();
            //ej09();
        }
        static void ej01()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 30;  // alto de la ventana           
            // Console.WindowWidth = 70; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Sumatoria y Promedio de goles de un futbolista";
            Console.Write("\n\tGuia#6 Ejemplo1");
            Console.WriteLine("\n");
            // Declaracion de variables
            int x = 1;
            Double suma = 0;
            int N;
            Double prom;
            String juga;
            // Entrada y Procesos de datos
            Console.Write("\tDigita el nombre del jugador de futbol : ");
            juga = Console.ReadLine();
            Console.WriteLine("\n");
            while (x <= 5)
            {
                Console.Write("\tIngrese una cantidad de goles [" + x + "]: ");
                N = int.Parse(Console.ReadLine());
                suma = suma + N;
                x = x + 1;
            }
            Console.WriteLine("\n");
            Console.Write("\tLa sumatoria de goles es de: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(suma);
            Console.ForegroundColor = ConsoleColor.Black;
            prom = suma / 5;
            Console.WriteLine("\n\n");
            Console.Write("\tEl promedio de goles de " + juga + " es de: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(Math.Round(prom, 2));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej02() {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 30;  // alto de la ventana           
            // Console.WindowWidth = 63; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            // Titulo
            Console.Title = "Conjunto de 9 numeros con while";
            Console.Write("\n\tGuia#6 Ejemplo2");
            // Declaración de variables
            int num;   // los 2 numeros
            int a = 1, x = 0, y = 0, z = 0;
            // Entrada y Proceso de datos
            Console.Write("\n\tEscribiremos 9 numeros enteros");
            Console.WriteLine("\n");
            while (a <= 9)
            {
                Console.Write("\tEl numero [" + a + "] es:  ");
                num = int.Parse(Console.ReadLine());
                if (num < 15)
                {
                    x = x + 1;
                }
                if (num > 85)
                {
                    y = y + 1;
                }
                if ((num >= 50) && (num <= 150))
                {
                    z = z + 1;
                }
                a = a + 1;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\t*********************************************");
            Console.WriteLine("\t   Los numeros menores a 15 son   : " + x);
            Console.WriteLine("\t   Los numeros mayores a 85 son   : " + y);
            Console.WriteLine("\t   Los numeros entre 50 y 150 son : " + z);
            Console.WriteLine("\t*********************************************");
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        
        }
        static void ej05() {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 40;  // alto de la ventana           
            // Console.WindowWidth = 80; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            // Titulo
            Console.Title = "Total de dinero y conversión de dólares";
            // Declaracion de variables
            int salir = 0;
            int saliryesno;
            // Entrada y proceso
            while (salir == 0)
            {
                Console.Clear();
                int cambiarmoneda;
                Double total_bill1, total_bill5, total_bill10, total_bill20;
                Double total_bill50, total_bill100;
                Double total_cent1, total_cent5, total_cent10, total_cent25;
                Double total_bill, total_cent;
                Double total_dinero, quetzal, lempira, euro;
                // Entrada 1
                Console.Write("\n\tCantidad de billetes de un dolar..........: $");
                total_bill1 = Double.Parse(Console.ReadLine());
                Console.Write("\n\tCantidad de billetes de cinco dolares.....: $");
                total_bill5 = Double.Parse(Console.ReadLine());
                Console.Write("\n\tCantidad de billetes de diez dolares......: $");
                total_bill10 = Double.Parse(Console.ReadLine());
                Console.Write("\n\tCantidad de billetes de veinte dolares....: $");
                total_bill20 = Double.Parse(Console.ReadLine());
                Console.Write("\n\tCantidad de billetes de cincuenta dolares.: $");
                total_bill50 = Double.Parse(Console.ReadLine());
                Console.Write("\n\tCantidad de billetes de cien dolares......: $");
                total_bill100 = Double.Parse(Console.ReadLine());
                // Procesos 1
                total_bill = (total_bill1 * (1) + total_bill5 * (5) + total_bill10 * (10) + total_bill20 * (20) + total_bill50 * (50) + total_bill100 * (100));
                // Entrada 2
                Console.Write("\n\tCantidad de monedas de un centavo.........: ");
                total_cent1 = Double.Parse(Console.ReadLine());
                Console.Write("\n\tCantidad de monedas de cinco centavos.....: ");
                total_cent5 = Double.Parse(Console.ReadLine());
                Console.Write("\n\tCantidad de monedas de diez centavos......: ");
                total_cent10 = Double.Parse(Console.ReadLine());
                Console.Write("\n\tCantidad de monedas de veinticinco........: ");
                total_cent25 = Double.Parse(Console.ReadLine());
                // Procesos 2
                total_cent = (total_cent1 * (0.01) + total_cent5 * (0.05) + total_cent10 * (0.10) + total_cent25 * (0.25));
                // Salidas
                Console.Write("\n\tLa cantidad de dinero que hay en billetes es: $" + total_bill);
                Console.Write("\n\tLa cantidad de dinero que hay en monedas es : $" + total_cent);
                total_dinero = (total_bill + total_cent);
                Console.Write("\n\tLa cantidad total de dinero que hay es      : $" + total_dinero);
                // Conversión de dólares
                Console.Write("\n\n\tCONVERSION DE MONEDAS");
                Console.Write("\n\n\tMoneda\t\tCodigo\n");
                Console.Write("\tQuetzal\t\t 1\n");
                Console.Write("\tLempira\t\t 2\n");
                Console.Write("\tEuro\t\t 3\n\n");
                Console.Write("\n\tIntroduzca el codigo de la moneda a la que desea convertir los $: ");
                cambiarmoneda = int.Parse(Console.ReadLine());
                quetzal = total_dinero * 7.95270;
                lempira = total_dinero * 19.71674;
                euro = total_dinero * 0.82396;
                if (cambiarmoneda == 1)
                {
                    Console.Write("\n\t ${0} equivale a {1} Quetzales\n\n", total_dinero, Math.Round(quetzal, 2));
                    Console.Write("\n\tSi desea salir presione 1 ó de lo contrario presione otro numero: ");
                    saliryesno = int.Parse(Console.ReadLine());
                    if (saliryesno == 1)
                    {
                        salir = 1;
                    }
                }
                else
                {
                    if (cambiarmoneda == 2)
                    {
                        Console.Write("\n\t  ${0} equivale a {1} Lempiras\n\n", total_dinero, Math.Round(lempira, 2));
                        Console.Write("\n\tSi desea salir presione 1 ó de lo contrario presione otro numero: ");
                        saliryesno = int.Parse(Console.ReadLine());
                        if (saliryesno == 1)
                        {
                            salir = 1;
                        }
                    }
                    else
                    {/*cambiarmoneda==3*/
                        Console.Write("\n\t ${0} equivale a {1} Euros\n\n", total_dinero, Math.Round(euro, 2));
                        Console.Write("\n\tSi desea salir presione 1 ó de lo contrario presione otro numero: ");
                        saliryesno = int.Parse(Console.ReadLine());
                        if (saliryesno == 1)
                        {
                            salir = 1;
                        }
                    }
                    Console.WriteLine("\n\n");
                    Console.Write("\t");
                    Console.WriteLine("--> Fin del Programa");
                    Console.Write("\t");
                    Console.ReadKey();
                }
            }
        }

        static void ej06()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 25;  // alto de la ventana           
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            // Titulo
            Console.Title = ("Cantidad de n piezas con DoWhile");
            Console.Write("\n\tGuia#6 Ejemplo6");
            // Declaracion de variables
            int x, cantidad, n;
            Double largo;
            x = 1;
            cantidad = 0;
            // Entrada de datos
            Console.Write("\n\tCuantas piezas va a digitar...: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // Proceso
            do
            {
                Console.Write("\tIngrese la medida de la pieza [1.0 – 2.0] cmts: ");
                largo = Double.Parse(Console.ReadLine());
                if (largo >= 1.2 && largo <= 1.3)
                {
                    cantidad = cantidad + 1;
                }
                x = x + 1;
            } while (x <= n);
            // Salida
            Console.WriteLine("\n\tResultados....");
            Console.Write("\tLa cantidad de piezas aptas son: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write(cantidad);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
   
        static void ej07()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 35;  // alto de la ventana           
            // Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Total de sueldos de trabajadores";
            Console.Write("\n\tGuia#6 Ejemplo7");
            Console.WriteLine("\n");
            // Declaracion de variables
            int op, i, cantidad;
            String nombre, ocupacion;
            Double sueldo;
            Double total = 0;
            // Entrada y Procesos de datos
            do
            {
                Console.Clear();
                Console.Write("\n\tCuantos empleados va a registrar? : ");
                cantidad = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                for (i = 1; i <= cantidad; i = i + 1)
                {
                    Console.Write("\tIngrese el nombre del empleado[{0}]: ", i);
                    nombre = Console.ReadLine();
                    Console.Write("\tIngrese la ocupacion del empleado: ");
                    ocupacion = Console.ReadLine();
                    Console.Write("\tIngrese el sueldo: $ ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    sueldo = Double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Black;
                    total = total + sueldo;
                    Console.WriteLine("\n");
                }
                Console.Write("\tEl total de dinero invertido en sueldos es: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("$ " + total);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");
                Console.Write("\tSi desea continuar, presione 1 sino presione 0 ? ");
                op = int.Parse(Console.ReadLine());
            } while (op == 1);
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }

        static void ej08()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 20;  // alto de la ventana           
            // Console.WindowWidth = 58; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            // Titulo
            Console.Title = "DoWhile, usando centinela con letra...";
            Console.Write("\n\tGuia#6 Ejemplo8");
            // Declaracion de variables
            Double x, y, suma;
            String resp;
            // Entrada y proceso
            do
            {
                // Console.Clear();
                Console.Write("\n\tDigitar el primer número.....: ");
                x = Double.Parse(Console.ReadLine()); ;
                Console.Write("\tDigitar el segundo numero....: ");
                y = Double.Parse(Console.ReadLine()); ;
                suma = x + y;
                Console.Write("\n\tLa suma de ambos es..........: " + suma);
                Console.WriteLine("\n");
                Console.Write("\n\t   Desea continuar (s/n): ");
                resp = Console.ReadLine();
            } while (resp != "n" && resp != "N");// se sale cuando la condicion es FALSA
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }

        static void ej09()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 30;  // alto de la ventana           
            // Console.WindowWidth = 75; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Estadio el Manguito - Soyacity";
            Console.Write("\n\tGuia#6 Ejemplo9");
            // Declaracion de variables
            int op2;
            int cantidad = 0;
            String op;
            Double precio = 0, total = 0;
            // Entrada y Procesos de datos
            do
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("\t***************************************************");
                Console.WriteLine("\t*       BIENVENIDO AL ESTADIO EL MANGUITO         *");
                Console.WriteLine("\t***************************************************");
                Console.WriteLine("\t*                                                 *");
                Console.WriteLine("\t*               SECTORES DEL ESTADIO              *");
                Console.WriteLine("\t*                                                 *");
                Console.WriteLine("\t*            A- SOL CANDENTE          $3          *");
                Console.WriteLine("\t*            B- SOL LUMINOSO          $5          *");
                Console.WriteLine("\t*            C- SOMBRITA              $8          *");
                Console.WriteLine("\t*            D- TRIBUNITA             $15         *");
                Console.WriteLine("\t*            E- SILLA PLASTICA        $20         *");
                Console.WriteLine("\t*                                                 *");
                Console.WriteLine("\t***************************************************");
                Console.Write("\tSelecciona la letra del sector del estadio : ");
                Console.ForegroundColor = ConsoleColor.Blue;
                op = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("\n");
                switch (op)
                {
                    case "A":
                    case "a":
                        Console.WriteLine("\tSector seleccionado...: Sol Candente");
                        Console.Write("\tCantidad de entradas..: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        cantidad = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Black;
                        precio = 3;
                        break;
                    case "B":
                    case "b":
                        Console.WriteLine("\tSector seleccionado...: Sol Luminoso");
                        Console.Write("\tCantidad de entradas..: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        cantidad = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Black;
                        precio = 5;
                        break;
                    case "C":
                    case "c":
                        Console.WriteLine("\tSector seleccionado...: Sombrita");
                        Console.Write("\tCantidad de entradas..: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        cantidad = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Black;
                        precio = 8;
                        break;
                    case "D":
                    case "d":
                        Console.WriteLine("\tSector seleccionado...: Tribunita");
                        Console.Write("\tCantidad de entradas..: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        cantidad = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Black;
                        precio = 15;
                        break;
                    case "E":
                    case "e":
                        Console.WriteLine("\tSector seleccionado...: Silla Plastica");
                        Console.Write("\tCantidad de entradas..: ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        cantidad = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.Black;
                        precio = 20;
                        break;
                    default:
                        Console.WriteLine("\tERROR: El sector seleccionado no existe");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                }
                total = precio * cantidad;
                Console.WriteLine("\tPrecio Unitario.......: $" + precio);
                Console.WriteLine("\tTotal a pagar.........: $" + total);
                Console.WriteLine("\n");
                Console.WriteLine("\tGracias por visitar el Manguito!");
                Console.WriteLine("\n\n");
                Console.Write("\tSi desea continuar presionar 1, sino 0 para salirse: ");
                op2 = int.Parse(Console.ReadLine());
            } while (op2 != 0);
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();

        }
    }
}
