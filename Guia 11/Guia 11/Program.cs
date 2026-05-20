using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_11
{
    struct Numeritos
    {
        public Double n1, n2, n3;
        public Double x, y, z;
    }
    struct vendedor
    {
        public String producto1, producto2, producto3;
        public int cantidad1, cantidad2, cantidad3;
        public Double precio1, precio2, precio3;
        public Double d1, d2, d3, sub, iva, total;
    }
    struct tipopersona
    {
        public String nombre;
        public String inicial;
        public int edad;
        public Double nota;
    }
    struct persona
    {
        public String Nombre;
        public int Edad;
        public String Direccion;
    }
    struct programa
    {
        public String universidad;
        public String carrera;
    }
    struct estudiante
    {
        public String nombre;
        public int edad;
        public programa p1; // palabra de acceso de la primer estructura
    }
    struct direccion
    {
        public String calle;
        public String numero;
    }
    struct agenda
    {
        public String nombre;
        public String telefono;
        public direccion d; // palabra de acceso de la primer estructura
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //ej01();
            ej02();
            //ej03();
            //ej04();
            //ej05();
            //ej06();
        }
        static void ej01()
        {
            Console.WindowHeight = 25; // alto de la ventana
            Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Operaciones matemáticas usando estructuras...";
            Console.Write("\n\tGuia#11 Ejemplo1");
            Console.WriteLine("\n");
            Numeritos tim = new Numeritos(); // tim palabra de acceso de la estructura
                                             // Entrada de datos
            Console.Write("\tDigitar el primer numero  : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            tim.n1 = Double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\tDigitar el segundo numero : ");
            Console.ForegroundColor = ConsoleColor.Red;
            tim.n2 = Double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\tDigitar el tercer numero  : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            tim.n3 = Double.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            // Procesos
            Console.WriteLine("\n");
            tim.x = Math.Pow(tim.n1, 2);
            tim.y = 5 * tim.n2;
            tim.z = 10 * Math.Sqrt(tim.n3);
            // Salidas
            Console.Write("\tEl resultado usando el número " + tim.n1 + " es de:" + Math.Round(tim.x, 2));
            Console.WriteLine("\n");
            Console.Write("\tEl resultado usando el número " + tim.n2 + " es de:" + Math.Round(tim.y, 2));
            Console.WriteLine("\n");
            Console.Write("\tEl resultado usando el número " + tim.n3 + " es de:" + Math.Round(tim.z, 2));
            Console.WriteLine("\n");
            Console.ReadKey();

        }
        static void ej02()
        {
            Console.WindowHeight = 25; // alto de la ventana
            Console.WindowWidth = 80; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = " Almacen Aqui todo es barato baratus brother ";
            Console.Write("\n\tGuia#11 Ejemplo2");
            Console.WriteLine("\n");
            vendedor c = new vendedor();
            Console.Write("\tDigite el nombre del primer producto    : ");
            c.producto1 = Console.ReadLine();
            Console.Write("\tDigite el precio del primer producto    : ");
            c.precio1 = Double.Parse(Console.ReadLine());
            Console.Write("\tDigite la cantidad del primer producto  : ");
            c.cantidad1 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("\tDigite el nombre del segundo producto   : ");
            c.producto2 = Console.ReadLine();
            Console.Write("\tDigite el precio del segundo producto   : ");
            c.precio2 = Double.Parse(Console.ReadLine());
            Console.Write("\tDigite la cantidad del segundo producto : ");
            c.cantidad2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            Console.Write("\tDigite el nombre del tercer producto    : ");
            c.producto3 = Console.ReadLine();
            Console.Write("\tDigite el precio del tercer producto    : ");
            c.precio3 = Double.Parse(Console.ReadLine());
            Console.Write("\tDigite la cantidad del tercer producto  : ");
            c.cantidad3 = int.Parse(Console.ReadLine());
            Console.WriteLine("\n");
            c.d1 = c.cantidad1 * c.precio1;
            c.d2 = c.cantidad2 * c.precio2;
            c.d3 = c.cantidad3 * c.precio3;
            c.sub = c.d1 + c.d2 + c.d3;
            c.iva = c.sub * 0.13;
            c.total = c.sub + c.iva;
            Console.Write("\tVamos a imprimir los resultados de las ventas, ENTER para seguir ");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\t---------------------------------------------------------------");
            Console.WriteLine("\t--                   *   Impresión de datos                   --");
            Console.Write("\tCantidad \tProducto \tPrecio \t\tTotalitos   ");
            Console.Write("\n");
            Console.Write("\t" + c.cantidad1 + "\t\t" + c.producto1 + "\t\t" + c.precio1 + "\t\t" + c.d1);
            Console.Write("\n");
            Console.Write("\t" + c.cantidad2 + "\t\t" + c.producto2 + "\t\t" + c.precio2 + "\t\t" + c.d2);
            Console.Write("\n");
            Console.Write("\t" + c.cantidad3 + "\t\t" + c.producto3 + "\t\t" + c.precio3 + "\t\t" + c.d3);
            Console.Write("\n");
            Console.Write("\t\t\t\t\t\tSubTot" + "\t" + Math.Round(c.sub, 2));
            Console.Write("\n");
            Console.Write("\t\t\t\t\t\tIVA" + "\t" + Math.Round(c.iva, 2));
            Console.Write("\n");
            Console.Write("\t\t\t\t\t\tTotal" + "\t" + Math.Round(c.total, 2));
            Console.WriteLine("\n\n\n");
            Console.ReadKey();

        }
        static void ej03()
        {
            Console.WindowHeight = 35; // alto de la ventana
            Console.WindowWidth = 55; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = " Manejo de un vector de estructura de tamaño fijo";
            tipopersona[] p = new tipopersona[3];
            Console.WriteLine("\n\tControl de Datos - Registro Academico");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\tPersona con ID:[" + (i + 1) + "]");
                Console.Write("\tNombre    : ");
                p[i].nombre = Console.ReadLine();
                Console.Write("\tInicial   : ");
                p[i].inicial = Console.ReadLine();
                Console.Write("\tEdad      : ");
                p[i].edad = int.Parse(Console.ReadLine());
                Console.Write("\tNota final: ");
                p[i].nota = Double.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n\tVamos a conocer ciertos datos... dar ENTER");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("\n");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("\tLa edad de " + p[i].nombre + " es de: " + p[i].edad);
            }
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
        static void ej04()
        {
            Console.WindowHeight = 30; // alto de la ventana
            Console.WindowWidth = 60; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = " Manejo de un vector de estructura ";
            Console.Write("\n\tGuia#11 Ejemplo4");
            Console.WriteLine("\n");
            int max;
            Console.Write("\t¿Digitar la cantidad de personas? ");
            Console.ForegroundColor = ConsoleColor.Red;
            max = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            persona[] A = new persona[max];   // la letra A es la palabra de acceso
            Console.WriteLine("\n");
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("\tPersona con ID:[" + (i + 1) + "]");
                Console.Write("\tNombre    : ");
                A[i].Nombre = Console.ReadLine();
                Console.Write("\tEdad      : ");
                A[i].Edad = int.Parse(Console.ReadLine());
                Console.Write("\tDireccion : ");
                A[i].Direccion = Console.ReadLine();
                Console.WriteLine("\n");
            }
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\tLas personas digitadas son:");
            Console.WriteLine("\n");
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine("\tPersona con ID:[" + (i + 1) + "]");
                Console.WriteLine("\tNombre    : " + A[i].Nombre);
                Console.WriteLine("\tEdad      : " + A[i].Edad);
                Console.WriteLine("\tDireccion : " + A[i].Direccion);
                Console.WriteLine("\t--------------------------------------");
            }
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
        static void ej05()
        {
            Console.WindowHeight = 20; // alto de la ventana
            Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa con estructuras anidadas: programa y estudiante";
            Console.Write("\n\tGuia#11 Ejemplo5");
            Console.WriteLine("\n");
            estudiante e1 = new estudiante(); // palabra de acceso de la segunda estructura  
                                              //Entrada de datos
            Console.Write("\tIngrese Nombre : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            e1.nombre = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\tEdad           : ");
            Console.ForegroundColor = ConsoleColor.Blue;
            e1.edad = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            //Accedemos a miembros de otra estructura
            Console.Write("\tCarrera        : ");
            Console.ForegroundColor = ConsoleColor.Red;
            e1.p1.carrera = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("\tUniversidad    : ");
            Console.ForegroundColor = ConsoleColor.Red;
            e1.p1.universidad = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.WriteLine("\n");
            Console.WriteLine("\tMostrando datos: ");
            Console.WriteLine("\tEstudiante:   " + e1.nombre);
            Console.WriteLine("\tEdad:         " + e1.edad);
            Console.WriteLine("\tCarrera:      " + e1.p1.carrera);
            Console.WriteLine("\tUniversidad:  " + e1.p1.universidad);
            Console.WriteLine("\n\n");
            Console.ReadKey();
        }
        static void ej06()
        {
            Console.WindowHeight = 30; // alto de la ventana
            Console.WindowWidth = 65; //ancho de la ventana
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Title = "Programa con estructuras anidadas: direccion y agenda";
            Console.Write("\n\tGuia#11 Ejemplo6");
            Console.WriteLine("\n");
            int cantidad, i;
            Console.WriteLine("\tRegistro de contactos en la colonia...");
            Console.Write("\tCuantos contactos desea guardar? ");
            cantidad = int.Parse(Console.ReadLine());
            agenda[] con = new agenda[cantidad]; // palabra de acceso 2da estructura
            for (i = 0; i < cantidad; i++)
            {
                Console.Write("\tNombre---->");
                con[i].nombre = Console.ReadLine();
                Console.Write("\n\tResidencial Calle o Colonia-->");
                con[i].d.calle = Console.ReadLine();
                Console.Write("\n\tNo. de Casa-->");
                con[i].d.numero = Console.ReadLine();
                Console.Write("\n\tTeléfono-->");
                con[i].telefono = Console.ReadLine();
                Console.WriteLine();
            }
            Console.Clear();
            Console.WriteLine("\tLista de Contactos\n");
            for (i = 0; i < cantidad; i++)
            {
                Console.WriteLine("\tNombre-----> " + con[i].nombre);
                Console.WriteLine("\tDirección--> " + con[i].d.calle + " No." + con[i].d.numero);
                Console.WriteLine("\tTeléfono---> " + con[i].telefono);
                Console.WriteLine();
            }
            Console.WriteLine("\n");
            Console.ReadKey();

        }
    }
}
