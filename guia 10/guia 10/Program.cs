using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ej01();
            //ej02();
            //ej03();
            //ej04();
            ej05();
        }

        static void ej01() {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 45; // alto de la ventana
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.Title = "Guia10 Ejemplo1 Como poner un Login";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Login();
            Console.ReadKey();
        }
        static void Login()
        {
            String Usuario = "user";
            String Password = "123456";
            // Con la siguiente funcion mostramos fecha y hora del sistema
            Console.WriteLine("\n");
            Console.WriteLine("Fecha y hora del sistema: [" + DateTime.Now.ToString() + "]");
            Console.WriteLine("Bienvenidos al Sistema Contable v3...");
            Console.ReadKey();
            for (int i = 0; i < 3; i++)
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.WriteLine("Intento: [" + (i + 1) + "]");
                Console.Write("Usuario: ");
                String User = Console.ReadLine();
                Console.Write("Contraseña: ");
                String Pass = Console.ReadLine();
                if ((User.Equals(Usuario)) && (Pass.Equals(Password)))
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("BIENVENID@ AL SISTEMA.... ");
                    Console.WriteLine("Presiona ENTER para continuar.... ");
                    break;
                }
                else
                {
                    Console.WriteLine("\n");
                    Console.WriteLine("Saliendo del programa...Intente más tarde...");
                }
            }
        }
   
        static void ej02()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 45; // alto de la ventana
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.Title = "Guia10 Ejemplo2 Como reemplazar un caracter";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            String cadena, cambio, opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("\n");
                Console.Write("\tEscribe una oracion: ");
                cadena = Console.ReadLine();
                cambio = cadena.Replace("a", "*").Replace("e", "*");
                Console.WriteLine("\t" + cambio);
                Console.WriteLine("\n");
                Console.WriteLine("\tDesea ingresar otra oración? (s/n)");
                opcion = Console.ReadLine();
            } while (opcion == "S" || opcion == "s");
            Console.ReadKey();

        }

        static void ej03()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 45; // alto de la ventana
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.Title = "Guia10 Ejemplo3 Oracion palindroma";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            String op;
            do
            {
                Console.Clear();
                Palindroma();
                Console.WriteLine("\n");
                Console.Write("\tDesea verificar otra frase? (s/n): ");
                op = Console.ReadLine();
            } while (op == "S" || op == "s");
            Console.ReadKey();
        }
        static void Palindroma()
        {
            String cadena1 = "", cadena2 = "";
            Console.WriteLine("\n");
            Console.Write("\tEscribe una palabra: ");
            cadena1 = Console.ReadLine();
            for (int i = cadena1.Length - 1; i >= 0; i--)
            {
                cadena2 = cadena2 + cadena1[i];
            }
            Console.WriteLine("\tLa cadena invertida es: " + cadena2);
            if (String.Equals(cadena1, cadena2))
            {
                Console.WriteLine("\tLa cadena " + cadena1 + " es palindroma...");
            }
            else
            {
                Console.WriteLine("\tLa cadena " + cadena1 + " no es palindroma...");
            }
        }
        static void ej04()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 35; // alto de la ventana
            // Console.WindowWidth = 70; //ancho de la ventana
            Console.Title = "Guia10 Ejemplo4 Convierte una oración";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            String cad1, cad2, cad3;
            int largo;
            Console.WriteLine("\n");
            Console.WriteLine("Digitar una frase que tenga letras mayúsculas y minúsculas: ");
            cad1 = Console.ReadLine();
            Console.WriteLine("\n");
            // la siguiente función calcula el número de caracteres
            largo = cad1.Length;
            Console.WriteLine("\tLa frase [" + cad1 + "] tiene [" + largo + "] caracteres.");
            // la siguiente función convierte la frase a letras minúsculas
            cad2 = cad1.ToLower();
            Console.WriteLine("\tLa frase en letras minúsculas es : ");
            Console.WriteLine("\t" + cad2);
            // la siguiente función convierte la frase a letras minúsculas
            cad3 = cad1.ToUpper();
            Console.WriteLine("\tLa frase en letras mayúsculas es : ");
            Console.WriteLine("\t" + cad3);
            Console.WriteLine("\n\tPresione ENTER para terminar...");
            Console.ReadKey();
        }
        static void ej05()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 35; // alto de la ventana
            // Console.WindowWidth = 70; //ancho de la ventana
            Console.Title = "Guia10 Ejemplo5 Saludo a un amigo";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            // Declaracion de variables
            String saludo = "Hola";
            String segundoSaludo, nombre, despedida;
            char letra, caracter;
            int i;
            segundoSaludo = "Que tal?";
            // Entrada de datos
            Console.WriteLine("Dime tu nombre... ");
            nombre = Console.ReadLine();
            Console.Write("\n");
            Console.WriteLine("{0} {1}", saludo, nombre);
            Console.WriteLine(segundoSaludo);
            if (nombre == "Alberto")
            {
                Console.WriteLine("Dices que eres Alberto?");
            }
            else
            {
                Console.WriteLine("Así que no eres Alberto?");
            }
            despedida = "Adios " + nombre + "!";
            Console.WriteLine(despedida);
            Console.Write("\n");
            for (i = 0; i < nombre.Length; i++)
            {
                caracter = char.Parse(nombre.Substring(i, 1));
                if (i == 0)
                {
                    letra = caracter;
                    Console.WriteLine("La primer letra de tu nombre es: " + letra);
                }
                Console.Write("  " + caracter);
            }
            Console.ReadKey();

        }
    }

}
    

