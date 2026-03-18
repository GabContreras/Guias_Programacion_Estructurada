using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ej01();
            //ej02();
            //ej03();
            //ej04();
            //ej05();
            ej06();
            //ej07();
            //ej08();
        }
        static void ej01()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 40; // alto de la ventana
            // Console.WindowWidth = 65; //ancho de la ventana
            int numEmpleados;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Control de sueldos de 6 empleados usando un vector";
            Console.Write("\nGuia#8 Ejemplo1");
            Console.WriteLine("\n");
           
            Console.Write("Ingrese la cantidad de empleados en su nómina: ");
            numEmpleados = int.Parse(Console.ReadLine());
            //Declaracion del vector, llamado Sueldos de tamaño 6
            //Ahora es tamaño escogido por el usuario (editado por Gabriel)
            Double[] Sueldos = new Double[numEmpleados];
            int i;
            Console.WriteLine("\t*********************************************");
            Console.WriteLine("\t*         EMPRESA LOS TULIPANES             *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*          Control de sueldos               *");
            Console.WriteLine("\t*                                           *");
            Console.WriteLine("\t*********************************************");
            Console.WriteLine("\n");
            for (i = 0; i < numEmpleados; i = i + 1)
            {
                Console.Write("\tIngrese el sueldo del empleado [" + i + "]:");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(" $");
                Sueldos[i] = Double.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine("\n");
            Console.WriteLine("\tLos sueldos ingresados son:");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\t");
            for (i = 0; i < numEmpleados; i++)
            {
                Console.Write("$" + Sueldos[i] + "  ");
            }
            Console.WriteLine($"\n\tCantidad de empleados en nómina: {numEmpleados}");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n");
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();

        }
        static void ej02()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 35; // alto de la ventana
            // Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Como inicializar un vector con datos, uso de Lenght";
            Console.Write("\nGuia#8 Ejemplo2");
            Console.WriteLine("\n");
            //Declaracion de variables
            Double SumaNotas = 0, Promedio;
            int i;
            // Aqui asignamos valores a los 2 vectores
            Double[] Notas = { 8, 7.2, 7.5, 8.1, 5 };
            String[] Alumnos = { "Juan", "Toño", "Chepe", "Rodrigo", "Marisol" };
            // Aqui verificaremos los datos en cada vector
            // la instruccion Notas.Lenght permite saber el tamaño del vector Notas
            for (i = 0; i < Notas.Length; i = i + 1)
            {
                Console.WriteLine("\n\tLa nota de " + Alumnos[i] + " es \t: " + Notas[i]);
            }
            for (i = 0; i < Notas.Length; i = i + 1)
            {
                SumaNotas = SumaNotas + Notas[i];
            }
            Promedio = (SumaNotas / 5);
            Console.WriteLine("\n\t-----------------------------------------");
            Console.Write("\n\tLa suma de todas las notas es \t: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(SumaNotas);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n\tEl promedio de las notas es \t: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Math.Round(Promedio, 2));
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n");
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();

        }
        static void ej03() {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 35; // alto de la ventana
            // Console.WindowWidth = 75; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "El numero mayor y menor en un vector";
            Console.Write("\nGuia#8 Ejemplo3");
            Console.WriteLine("\n");
            int tam;
            Double menor, mayor;
            Console.Write("\tDame el tamaño del vector: ");
            Console.ForegroundColor = ConsoleColor.Red;
            tam = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Double[] n = new Double[tam];
            Console.WriteLine("\n");
            // Aqui digitamos los datos del vector
            for (int i = 0; i < tam; i++)
            {
                Console.Write("\tDigite el elemento [" + i + "] : ");
                n[i] = Double.Parse(Console.ReadLine());
            }
            // Aqui encontraremos el mayor y el menor
            mayor = n[0];
            menor = n[0];
            int p1 = 0, p2 = 0;
            for (int i = 0; i < tam; i++)
            {
                if (n[i] > mayor)
                {
                    mayor = n[i];
                    p1 = i;
                }
                else if (n[i] < menor)
                {
                    menor = n[i];
                    p2 = i;
                }
            }
            Console.WriteLine("\n");
            Console.Write("\tEl numero mayor del vector es: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(mayor);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" y esta en la posición ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[" + p1 + "]");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n");
            Console.Write("\tEl numero menor del vector es: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(menor);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" y esta en la posición ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("[" + p2 + "]");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n");
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();

        }
        static void ej04()
        {
            // Programa realizado por 
            // Día: 
            Console.Title = "Programa que posee el método de la burbuja";
            Console.Write("\nGuia#8 Ejemplo4: ---> Se digitaran 5 numeros de ventas");
            Console.WriteLine("\n");
            Double[] ventas = new Double[5];
            int i, j;
            Double resp, encontrado, promedio, suma, buscar, mayor, menor, aux;
            //LLENADO DE VENTAS
            for (i = 0; i < 5; i++)
            {
                Console.Write("\tPosición número " + i + " de las ventas = $");
                ventas[i] = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n");
            //IMPRIME LOS DATOS AÑADIDOS
            for (i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\t $" + ventas[i]);
               // Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine("\n");
            //BUSCAR UNA VENTA 
            encontrado = 1;
            resp = 0;
            Console.Write("\n\tDigitar la venta a buscar: $");
            buscar = Double.Parse(Console.ReadLine());
            for (i = 0; i < 5; i++)
            {
                if (buscar == ventas[i])
                    resp = 1;
            }
            if (encontrado == resp)
            {
                Console.WriteLine("\n\tLa venta ${0} fue encontrada", buscar);
            }
            else
            {
                Console.WriteLine("\n\tLa venta ${0} no fue encontrada", buscar);
            }
            //MOSTRAR LA MAYOR Y LA MENOR VENTA
            mayor = 0;
            menor = 1000;
            for (i = 0; i < 5; i++)
            {
                if (mayor < ventas[i])
                    mayor = ventas[i];
                if (menor > ventas[i])
                    menor = ventas[i];
            }
            Console.WriteLine("\n\tLa mayor venta es\t: $" + mayor);
            Console.WriteLine("\n\tLa menor venta es\t: $" + menor);
            //LA SUMATORIA DE LAS VENTAS
            suma = 0;
            for (i = 0; i < 5; i++)
            {
                suma = suma + ventas[i];
            }
            Console.WriteLine("\n\tLa suma de las ventas es\t: $" + suma);
            promedio = suma / 5;
            Console.WriteLine("\n\tEl promedio de las ventas es\t: $" + Math.Round(promedio, 2));
            //REALIZA LA ORDENACION POR MEDIO DE LA BURBUJA
            for (i = 0; i < 5 - 1; i++)
            {//inicio de primer for
                for (j = 0; j < 5 - 1; j++)
                { //inicio del segundo for
                    if (ventas[j] > ventas[j + 1])
                    { // inicio del if
                        aux = ventas[j];
                        ventas[j] = ventas[j + 1];
                        ventas[j + 1] = aux;
                    }// fin del if
                }//fin del segundo for, el más interno, el de la j
            }//fin del primer for 
             //IMPRIME LAS VENTAS ORDENADAS
            Console.WriteLine("\n\tEl vector ordenado queda asi:");
            Console.WriteLine("\n");
            for (i = 0; i < 5; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\t $" + ventas[i]);
                Console.ForegroundColor = ConsoleColor.Black;
            }
            Console.WriteLine("\n\n");
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();

        }
        static void ej05()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 30; // alto de la ventana
            // Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Ejemplo de vectores con letras";
            Console.Write("\nGuia#8 Ejemplo5");
            Console.WriteLine("\n");
            // Escriba un programa que lea una cadena de texto  y como resultado que 
            // muestre el total de vocales y espacios en blanco que tiene la frase.
            String nombre;
            char caracter;
            int i, vocales, espacios;
            vocales = 0;
            espacios = 0;
            Console.Write("\n\tDigitar una frase motivadora: ");
            nombre = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("\tEl tamaño de la oración es de " + nombre.Length + " caracteres");
            Console.WriteLine("\n");
            Console.WriteLine("\t-------------------------------------------------");
            for (i = 0; i < nombre.Length; i++)
            {
                caracter = char.Parse(nombre.Substring(i, 1));
                //búsqueda de espacios en blanco
                if (caracter == ' ')
                    // al poner un espacio en blanco entre apostrofe significa espacio en blanco
                    espacios++;
                //busqueda de vocales
                if ((caracter == 'A') || (caracter == 'a'))
                    vocales++;
                if ((caracter == 'E') || (caracter == 'e'))
                    vocales++;
                if ((caracter == 'I') || (caracter == 'i'))
                    vocales++;
                if ((caracter == 'O') || (caracter == 'o'))
                    vocales++;
                if ((caracter == 'U') || (caracter == 'u'))
                    vocales++;
            }
            Console.Write("\n\tEl total de espacios en blanco son ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(espacios);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\n\tEl total de vocales son ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(vocales);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("\n\n");
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();


        }
        static void ej06()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 30;  // alto de la ventana          
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Super Selectos - Precios usando arreglos";
            Console.Write("\nGuia#8 Ejemplo6");
            Console.WriteLine("\n");
            int cantidadProductos;
            String nombreCliente;
            Console.Write("\nPor favor ingrese su nombre: ");
            nombreCliente = Console.ReadLine();
            Console.Write("\tBienvenido a Super Selectos, por favor ingresa la cantidad de productos que compraste: ");
            cantidadProductos = int.Parse(Console.ReadLine());

            Double[] precios = new Double[cantidadProductos];
            Double total = 0;
            int x;


            for (int i = 0; i < precios.Length; i++)
            {
                x = i + 1;
                Console.Write("\tIngresa el precio del producto [" + x + "]: $");
                precios[i] = Convert.ToDouble(Console.ReadLine());
                total += precios[i];
            }
            Console.WriteLine("\n\tDetalle de la compra:");
           
            Console.Write("\n");
            Console.WriteLine("\t===========================================");
            Console.WriteLine($"\tNombre del cliente: {nombreCliente}");
            for (int i = 0; i < precios.Length; i++)
            {
                x = i + 1;
                Console.WriteLine("\tProducto [" + x + "]: $" + precios[i]);
            }
            Console.WriteLine("\tPrecio total: $" + Math.Round(total, 2));
            Console.WriteLine($"\tCantidad de productos: {cantidadProductos}");
            Console.Write("\n");
            Console.WriteLine("\t===========================================");

            int metodoPago;
            Double cantDinero;
            Console.WriteLine("\n\tMétodos de pago:");
            Console.WriteLine("\t1. Tarjeta");
            Console.WriteLine("\t2. Efectivo");
            Console.Write("Elija su método de pago:");
            switch (Console.ReadLine())
            {
                case "1":
                    metodoPago = 1;
                    Console.WriteLine("\n\tUsted ha elegido pagar con tarjeta.");
                    break;
                case "2":
                    metodoPago = 2;
                    Console.WriteLine("\n\tUsted ha elegido pagar en efectivo.");
                    Console.WriteLine("\n\tRecuerde que al pagar en efectivo, el total a pagar es $" + Math.Round(total, 2));
                    Console.Write("Ingrese la cantidad de efectivo que va a entregar: $");
                    cantDinero = Double.Parse(Console.ReadLine());
                    if (cantDinero < total)
                    {
                       Console.WriteLine("\n\tLa cantidad de dinero ingresada es insuficiente para pagar la compra.");
                    }
                    Console.WriteLine("Su cambio es de: $");
                    break;
                default:
                    Console.WriteLine("\n\tOpción no válida, se asignará pago en efectivo por defecto.");
                    metodoPago = 2;
                    break;
            }
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();

        }
        static void ej07() {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 33;  // alto de la ventana          
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Biblioteca BINAES - Lo mejor en books";
            Console.Write("\nGuia#8 Ejemplo7");
            Console.WriteLine("\n");
            int n, i, m = 0;
            Console.Write("\tCuantos libros desea Registrar? ");
            n = int.Parse(Console.ReadLine());
            //Declaracion de arreglos
            string[] libros = new string[n];
            string[] autores = new string[n];
            Console.Write("\n");
            Console.WriteLine("\tIngrese la siguiente información de los libros");
            for (i = 0; i < n; i++)
            {
                m = m + 1;
                Console.WriteLine("\t******* Nombre del Libro " + m + " *******");
                Console.Write("\t");
                libros[i] = Console.ReadLine();
                Console.WriteLine("\t******* Autor del Libro " + m + " *******");
                Console.Write("\t");
                autores[i] = Console.ReadLine();
            }
            Console.WriteLine("\n");
            Console.WriteLine("\tInformación sobre los libros");
            for (i = 0; i < n; i++)
            {
                m = i + 1;
                Console.WriteLine("\tLibro " + m + ". " + libros[i] + " Autor(es) " + autores[i]);
            }
            Console.Write("\n\tHasta Luego . . . ");
            Console.Write("\n");
            Console.WriteLine("\n\t* Este programa fue diseñado por: Gloria Diaz *");
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();
        }
        static void ej08()
        {
            // Programa realizado por 
            // Día: 
            // Console.WindowHeight = 33;  // alto de la ventana          
            // Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Ferreteria - Tornillo Suelto pero baratus";
            Console.Write("\nGuia#8 Ejemplo8");
            Console.WriteLine("\n");
            int cantidad, num;
            Double total = 0.0;
            Console.Write("\tCuantos productos va a facturar? ");
            num = int.Parse(Console.ReadLine());
            String[] producto = new String[num];
            Double[] precio = new Double[num];
            for (int a = 0; a < num; a++)
            {
                Console.WriteLine("\tIngrese el nombre del {0}° producto", a + 1);
                Console.Write("\t");
                producto[a] = Console.ReadLine();
                Console.WriteLine("\tCual es el precio unitario " + producto[a]);
                Console.Write("\t");
                precio[a] = Double.Parse(Console.ReadLine());
                Console.WriteLine("\tCantidad que compro de " + producto[a]);
                Console.Write("\t");
                cantidad = int.Parse(Console.ReadLine());
                precio[a] = precio[a] * cantidad;
                total = total + precio[a];
            }
            Console.WriteLine("\n\tPresione ENTER para aceptar la compra");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t===========================================");
            Console.WriteLine("\t=======     Detalle de Factura     ========");
            Console.Write("\n");
            for (int a = 0; a < num; a++)
            {
                Console.WriteLine("\t " + producto[a] + " -----> " + precio[a]);
            }
            Console.Write("\n");
            Console.WriteLine("\t===========================================");
            Console.WriteLine("\tTotal a Pagar ============> $" + total);
            Console.Write("\n");
            Console.WriteLine("\n\t* Este programa fue diseñado por: Gloria Diaz *");
            Console.WriteLine("\n\tPresione ENTER para terminar");
            Console.ReadKey();

        }
    }
    }
