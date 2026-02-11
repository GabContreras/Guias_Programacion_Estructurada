using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_4_cc260202
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
            //ej06();
            //ej07();

        }
        static void ej01()
        {            // Programa realizado por 
                     // Día: 
                     // Console.WindowHeight = 35;  // alto de la ventana           
                     // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Menu matematico para 2 numeros";
            Console.Write("\nGuia#4 Ejemplo1");
            Console.WriteLine("\n");
            // Declaracion de variables
            int op;   // variable entera del switch
            Double x, y, z;
            // Entrada de datos
            Console.Write("\tDigitar el primer numero  : ");
            x = Double.Parse(Console.ReadLine());
            Console.Write("\tDigitar el segundo numero : ");
            y = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // Aqui diseñamos nuestro menú principal
            Console.WriteLine("\t=========================================");
            Console.WriteLine("\t  OPERACIONES MATEMATICAS");
            Console.WriteLine("\t    1. SUMAR");
            Console.WriteLine("\t    2. RESTAR");
            Console.WriteLine("\t    3. MULTIPLICAR");
            Console.WriteLine("\t    4. DIVIDIR");
            Console.WriteLine("\t    5. RAIZ CUADRADA  [Primer numero ]");
            Console.WriteLine("\t    6. POTENCIACION   [Segundo numero]");
            Console.WriteLine("\t    7. SALIR DEL PROGRAMA");
            Console.WriteLine("\t=========================================");
            Console.WriteLine("\n");
            Console.Write("\tDigite su opcion del [ 1 al 7 ]: ");
            op = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // Aqui funciona el switch con sus cases
            switch (op)
            {
                case 1:
                    z = x + y;
                    Console.WriteLine("\t--> El resultado de sumar " + x + " + " + y + " es: " + z);
                    break;
                case 2:
                    z = x - y;
                    Console.WriteLine("\t--> El resultado de restar " + x + " - " + y + " es: " + z);
                    break;
                case 3:
                    z = x * y;
                    Console.WriteLine("\t--> El resultado de multiplicar " + x + " * " + y + " es: " + z);
                    break;
                case 4:
                    if (y == 0)
                    {
                        Console.WriteLine("\t Division Invalida...");
                    }
                    else
                    {
                        z = x / y;
                        Console.WriteLine("\t--> El resultado de dividir " + x + " ÷ " + y + " es: " + z);
                    }
                    break;
                case 5:
                    z = Math.Sqrt(x);
                    Console.WriteLine("\t--> La raiz cuadrada de " + x + " es: " + Math.Round(z, 2));
                    break;
                case 6:
                    z = Math.Pow(y, 2);
                    Console.WriteLine("\t--> El cuadrado de " + y + " es: " + z);
                    break;
                case 7:
                    Environment.Exit(0); // esta instruccion se sale de un solo del programa
                    break;
                default:
                    Console.WriteLine("\t Opcion no definida.. intente de nuevo");
                    break;
            }
            Console.Write("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej02()
        { // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 20;  // alto de la ventana           
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Calculo del dia del año";
            Console.Write("\n\tGuia#4 Ejemplo2");
            Console.WriteLine("\n");
            // Declaracion de variables
            int Ndia, Nmes, DDA = 0;
            // Entrada de datos
            Console.Write("\tDigitar el dia [entero] : ");
            Ndia = int.Parse(Console.ReadLine());
            Console.Write("\tDigitar el mes [entero] : ");
            Nmes = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            if ((Ndia >= 1) && (Ndia <= 31) && (Nmes >= 1) && (Nmes <= 12))
            {
                switch (Nmes)
                {
                    case 1:
                        DDA = Ndia; //DDA es día del año
                        break;
                    case 2:
                        DDA = Ndia + 31;
                        break;
                    case 3:
                        DDA = Ndia + 59;
                        break;
                    case 4:
                        DDA = Ndia + 90;
                        break;
                    case 5:
                        DDA = Ndia + 120;
                        break;
                    case 6:
                        DDA = Ndia + 151;
                        break;
                    case 7:
                        DDA = Ndia + 181;
                        break;
                    case 8:
                        DDA = Ndia + 212;
                        break;
                    case 9:
                        DDA = Ndia + 243;
                        break;
                    case 10:
                        DDA = Ndia + 273;
                        break;
                    case 11:
                        DDA = Ndia + 304;
                        break;
                    case 12:
                        DDA = Ndia + 334;
                        break;
                }
                Console.Write("\tEl " + Ndia + " del " + Nmes + " es el día ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(DDA);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Write(" del año");
            }
            else
            {
                Console.Write("\tDatos proporcionados no válidos");
            }
            Console.Write("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej03()
        {// Programa realizado por
         // Día: 
         // Console.WindowHeight = 30; // alto de la ventana
         // Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Salarios en una empresa...";
            Console.Write("\n\tGuia#4 Ejemplo3");
            Console.WriteLine("\n");
            // Declaracion de variables
            Double Salario, NuevoSalario, Aumento = 0;
            int CantiAnio;
            String Nombre, Apellido;
            try
            {
                Console.Write("\tDigite el Nombre del empleado....: ");
                Nombre = Console.ReadLine();
                Console.Write("\tDigite el Apellido del empleado....: ");
                Apellido = Console.ReadLine();
                Console.Write("\tDigite el salario del empleado..:$ ");
                Salario = Double.Parse(Console.ReadLine());
                if (Salario > 0)
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("\t--------MENU DE AÑOS TRABAJADOS----------");
                    Console.WriteLine("\t\t1: Mas de 5 años");
                    Console.WriteLine("\t\t2: Mas de 10 años ");
                    Console.WriteLine("\t\t3: Más de 15 años");
                    Console.WriteLine("\t\t4: Más de 20 años");
                    Console.WriteLine("\t\t5: Menos de 5 años");
                    Console.WriteLine("\t-----------------------------------------");
                    Console.Write("\tDigite la opción del menú: ");
                    CantiAnio = int.Parse(Console.ReadLine());
                    switch (CantiAnio)
                    {
                        case 1:
                            Aumento = Salario * 0.075;
                            break;
                        case 2:
                            Aumento = Salario * 0.15;
                            break;
                        case 3:
                            Aumento = Salario * 0.20;
                            break;
                        case 4:
                            Aumento = Salario * 0.25;
                            break;
                        case 5: // no recibe aumento
                            break;
                        default:
                            break;
                    }
                    NuevoSalario = Aumento + Salario;
                    Console.WriteLine($"\n\tEl empleado {Nombre} {Apellido}");
                    Console.WriteLine("\tTiene un nuevo salario de: ${0:#,##0.00}", NuevoSalario);
                }
                else
                {
                    Console.WriteLine("\n\tLos datos ingresados son incorrectos");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("\n\tError: " + e.Message);
                Console.ReadKey();
            }
            Console.WriteLine("\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej04()
        { // Programa realizado por
          // Día: 
          // Console.WindowHeight = 35;
          // Console.WindowWidth = 60;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Title = "Conversor de longitudes...";
            Console.Write("\n\tGuia#4 Ejemplo4");
            int opcion;
            Double metro;
            Double mm, cm, km, pul, yar;
            Console.WriteLine("\n");
            Console.WriteLine("\t****Programa de conversor de longitudes**");
            Console.WriteLine("\t*                                      *");
            Console.WriteLine("\t*      [1] Milímetros                  *");
            Console.WriteLine("\t*      [2] Centímetros                 *");
            Console.WriteLine("\t*      [3] Kilometros                  *");
            Console.WriteLine("\t*      [4] Pulgada                     *");
            Console.WriteLine("\t*      [5] Yarda                       *");
            Console.WriteLine("\t*      [6] Salir                       *");
            Console.WriteLine("\t*                                      *");
            Console.WriteLine("\t****************************************");
            Console.Write("\n");
            Console.Write("\tElija la opcion del 1 al 6: ");
            Console.ForegroundColor = ConsoleColor.Red;
            opcion = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n");
            switch (opcion)
            {
                case 1:
                    Console.Write("\tIntroduzca la cantidad en metros: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    metro = Double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n");
                    mm = metro * 1000;
                    Console.WriteLine("\tLos {0} metros son {1} milímetros", metro, mm);
                    break;
                case 2:
                    Console.Write("\tIntroduzca la cantidad en metros: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    metro = Double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n");
                    cm = metro * 100;
                    Console.WriteLine("\tLos {0} metros son {1} centímetro", metro, cm);
                    break;
                case 3:
                    Console.Write("\tIntroduzca la cantidad en metros: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    metro = Double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n");
                    km = metro * 0.001;
                    Console.WriteLine("\tLos {0} metros son {1} Kilometro", metro, km);
                    break;
                case 4:
                    Console.Write("\tIntroduzca la cantidad en metros: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    metro = Double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n");
                    pul = metro * 39.37;
                    Console.WriteLine("\tLos {0} metros son {1} pulgadas", metro, pul);
                    break;
                case 5:
                    Console.Write("\tIntroduzca la cantidad en metros: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    metro = Double.Parse(Console.ReadLine());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n");
                    yar = metro * 1.094;
                    Console.WriteLine("\tLos {0} metros son {1} yardas", metro, yar);
                    break;
                default:
                    Console.Write("\tEsta opción no existe...");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej05()
        {// Programa realizado por 
         // Día: 
         // Console.WindowHeight = 30;  // alto de la ventana           
         // Console.WindowWidth = 70; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Menú de Funciones Trigonometicas ";
            Console.Write("\n\tGuia#4 Ejemplo5");
            Console.WriteLine("\n");
            //Declaracion de variables
            int opcion;
            Double angulo, anguloRadianes, resul;
            //menú principal
            Console.WriteLine("\t<<      C A L C U L A D O R A          >>");
            Console.WriteLine("\t<< FUNCIONES  TRIGONOMETRICAS  BASICAS >>");
            Console.WriteLine("\t\t1. Funcion Seno ");
            Console.WriteLine("\t\t2. Funcion Coseno ");
            Console.WriteLine("\t\t3. Funcion Tangente ");
            Console.WriteLine("\n");
            Console.Write("\tDigitar el número correspondiente a la función: ");
            opcion = int.Parse(Console.ReadLine());//Capturamos la seleccion del usuario
            Console.WriteLine("\n");
            switch (opcion)
            {
                case 1://Calcula el Seno
                    Console.Write("\tIngresa el valor del angulo (en grados sexagesimales): ");
                    angulo = Double.Parse(Console.ReadLine());//Capturamos el valor del angulo en grados
                    Console.WriteLine("\n");
                    anguloRadianes = angulo * (Math.PI / 180); //Convierte angulo a radianes
                    resul = Math.Sin(anguloRadianes);
                    Console.Write("\tEl Seno de " + angulo + "° es: " + Math.Round(resul, 3));
                    break;
                case 2://Calcula el Coseno
                    Console.Write("\tIngresa el valor del angulo (en grados sexagesimales): ");
                    angulo = Double.Parse(Console.ReadLine());//Capturamos el valor del angulo en grados
                    Console.WriteLine("\n");
                    anguloRadianes = angulo * (Math.PI / 180); //Convierte angulo a radianes
                    resul = Math.Cos(anguloRadianes);
                    Console.Write("\tEl Coseno de " + angulo + "° es: " + Math.Round(resul, 3));
                    break;
                case 3://Calcula la Tangente
                    Console.Write("\tIngresa el valor del angulo (en grados sexagesimales): ");
                    angulo = Double.Parse(Console.ReadLine());//Capturamos el valor del angulo en grados
                    Console.WriteLine("\n");
                    anguloRadianes = angulo * (Math.PI / 180); //Convierte angulo a radianes
                    resul = Math.Tan(anguloRadianes);
                    Console.Write("\tLa Tangente de " + angulo + "° es: " + Math.Round(resul, 3));
                    break;
                default:
                    Console.Write("\tOpción no válida, solo acepta del 1 al 3");
                    break;
            }
            Console.WriteLine("\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej06()
        {// Programa realizado por 
         // Día: 
         // Console.WindowHeight = 17;  // alto de la ventana           
         // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Los meses del año segun un numero entero..";
            Console.Write("\n\tGuia#4 Ejemplo6");
            Console.Write("\n\n");
            // Declaracion de variables
            int numero;
            Console.Write("\tIngresar numero entre 1 y 12: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("\n");
            switch (numero)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("\tEnero");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\tFebrero");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("\tMarzo");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 4:
                    Console.Write("\t");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Abril");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("\tMayo");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 6:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.Write("\tJunio");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 7:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write("\tJulio");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 8:
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\tAgosto");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 9:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("\tSeptiembre");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 10:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("\tOctubre");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 11:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.Write("\tNoviembre");
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case 12:
                    Console.Write("\t");
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("Diciembre");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.Write("\tNumero incorrecto");
                    break;
            }
            Console.WriteLine("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
        static void ej07()
        {  // Programa realizado por 
           // Día: 
           // Console.WindowHeight = 20; //Alto de la ventana
           // Console.WindowWidth = 90; //Ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa que calcula aumento en tarjeta de credito";
            Console.Write("\n\tGuia#4 Ejemplo7");
            Console.WriteLine("\n");
            // Declaracion de variables
            sbyte TipoTarj;
            Double LCreAct, AumCre, NueCre;
            Console.Write("\tIngrese el tipo de tarjeta de crédito del cliente [1..4] : ");
            TipoTarj = Convert.ToSByte(Console.ReadLine());
            Console.Write("\tIngrese el límite actual de crédito de la tarjeta que posee el cliente $: ");
            LCreAct = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            // Proceso
            switch (TipoTarj)
            {
                case 1:
                    AumCre = LCreAct * 0.25;
                    break;
                case 2:
                    AumCre = LCreAct * 0.35;
                    break;
                case 3:
                    AumCre = LCreAct * 0.40;
                    break;
                default:
                    AumCre = LCreAct * 0.50;
                    break;
            }
            NueCre = LCreAct + AumCre;
            Console.WriteLine("\tEl aumento de crédito es......: $" + (Math.Truncate(AumCre * 100) / 100));
            Console.Write("\n");
            Console.WriteLine("\tSu nuevo total de crédito es..: $" + (Math.Truncate(NueCre * 100) / 100));
            Console.Write("\n\n");
            Console.Write("\t");
            Console.WriteLine("--> Fin del Programa");
            Console.Write("\t");
            Console.ReadKey();
        }
            

    }
}
