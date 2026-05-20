using System;
using System.IO;
using System.Diagnostics;

namespace DesafioPractico3
{
    class Program
    {
        struct clientes
        {
            public int numero_factura;
            public int fecha;
            public String nombres_cliente;
            public String direccion;
            public String nombre_vendedor;
        }

        struct detalle_factura
        {
            public String producto1, producto2, producto3;
            public int cantidad1, cantidad2, cantidad3;
            public Double precio1, precio2, precio3;
            public Double d1, d2, d3, sub, iva, total;
        }

     
        static StreamWriter Escribir;
        static StreamReader Leer;

        static void Main(string[] args)
        {
            
            Console.Clear();
            Console.Title = "Sistema de Generación de Factura";

            clientes c = new clientes();
            detalle_factura dt = new detalle_factura();

            String opcion_menu;
            String continuar = "S";
            String abrir_archivo;

            do
            {
                Console.Clear();
                Console.WriteLine("\n\tMenu principal\n");
                Console.WriteLine("\t1. Crear factura");
                Console.WriteLine("\t2. Guardar en archivo");
                Console.WriteLine("\t3. Leer el archivo (Abrir en Bloc de Notas)");
                Console.WriteLine("\t4. Salir");
                Console.Write("\n\tDigite una opcion del menu: ");
                opcion_menu = Console.ReadLine();

                switch (opcion_menu)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("\n\t--- DATOS DEL CLIENTE ---");
                        Console.Write("\tNumero de factura                 : ");
                        c.numero_factura = int.Parse(Console.ReadLine());
                        Console.Write("\tFecha (ej. formato YYYYMMDD || 20260518)      : ");
                        c.fecha = int.Parse(Console.ReadLine());
                        Console.Write("\tNombre del cliente                : ");
                        c.nombres_cliente = Console.ReadLine();
                        Console.Write("\tDireccion                         : ");
                        c.direccion = Console.ReadLine();
                        Console.Write("\tNombre del vendedor               : ");
                        c.nombre_vendedor = Console.ReadLine();

                        Console.WriteLine("\n\t--- DETALLE DE FACTURA ---");
                        Console.Write("\tDigite el nombre del primer producto    : ");
                        dt.producto1 = Console.ReadLine();
                        Console.Write("\tDigite el precio del primer producto    : ");
                        dt.precio1 = Double.Parse(Console.ReadLine());
                        Console.Write("\tDigite la cantidad del primer producto  : ");
                        dt.cantidad1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("\n");
                        Console.Write("\tDigite el nombre del segundo producto   : ");
                        dt.producto2 = Console.ReadLine();
                        Console.Write("\tDigite el precio del segundo producto   : ");
                        dt.precio2 = Double.Parse(Console.ReadLine());
                        Console.Write("\tDigite la cantidad del segundo producto : ");
                        dt.cantidad2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("\n");
                        Console.Write("\tDigite el nombre del tercer producto    : ");
                        dt.producto3 = Console.ReadLine();
                        Console.Write("\tDigite el precio del tercer producto    : ");
                        dt.precio3 = Double.Parse(Console.ReadLine());
                        Console.Write("\tDigite la cantidad del tercer producto  : ");
                        dt.cantidad3 = int.Parse(Console.ReadLine());

                        dt.d1 = dt.cantidad1 * dt.precio1;
                        dt.d2 = dt.cantidad2 * dt.precio2;
                        dt.d3 = dt.cantidad3 * dt.precio3;
                        dt.sub = dt.d1 + dt.d2 + dt.d3;
                        dt.iva = dt.sub * 0.13;
                        dt.total = dt.sub + dt.iva;

                        Console.WriteLine("\n\tFactura creada exitosamente");
                        Console.WriteLine("\n\tPresiona ENTER para continuar");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.Clear();
                        try
                        {
                            Escribir = new StreamWriter("factura.txt", true);

                            Escribir.WriteLine("\t---------------------------------------------------------------");
                            Escribir.WriteLine("\tFactura No: " + c.numero_factura + " | Fecha: " + c.fecha);
                            Escribir.WriteLine("\tCliente: " + c.nombres_cliente + " | Dirección: " + c.direccion);
                            Escribir.WriteLine("\tVendedor: " + c.nombre_vendedor);
                            Escribir.WriteLine("\t---------------------------------------------------------------");
                            Escribir.WriteLine("\tCantidad \tProducto \tPrecio \t\tTotalitos");
                            Escribir.WriteLine("\t" + dt.cantidad1 + "\t\t" + dt.producto1 + "\t\t" + dt.precio1 + "\t\t" + dt.d1);
                            Escribir.WriteLine("\t" + dt.cantidad2 + "\t\t" + dt.producto2 + "\t\t" + dt.precio2 + "\t\t" + dt.d2);
                            Escribir.WriteLine("\t" + dt.cantidad3 + "\t\t" + dt.producto3 + "\t\t" + dt.precio3 + "\t\t" + dt.d3);
                            Escribir.WriteLine("\t\t\t\t\t\tSubTot\t" + Math.Round(dt.sub, 2));
                            Escribir.WriteLine("\t\t\t\t\t\tIVA\t" + Math.Round(dt.iva, 2));
                            Escribir.WriteLine("\t\t\t\t\t\tTotal\t" + Math.Round(dt.total, 2));
                            Escribir.WriteLine("\t---------------------------------------------------------------\n");

                            Escribir.Close();
                            Console.WriteLine("\n\tEscritura exitosa en 'factura.txt'...");

                            Console.Write("\tDesea abrir el archivo de texto en Bloc de Notas? (s/n): ");
                            abrir_archivo = Console.ReadLine();

                            if (abrir_archivo == "S" || abrir_archivo == "s")
                            {
                                Process.Start("factura.txt");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n\t¡ERROR! " + e.Message);
                        }
                        break;

                    case "3":
                        Console.Clear();
                        try
                        {
                            if (File.Exists("factura.txt"))
                            {
                                Console.WriteLine("\n\tAbriendo factura en el Bloc de Notas");
                                Process.Start("factura.txt");
                                Console.WriteLine("\n\tFactura abierta");
                                Console.WriteLine("\n\tPresiona ENTER para continuar");
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("\tEl archivo no existe. Por favor, guarde una factura primero.");
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("\n\terror al abrir el archivo " + e.Message);
                        }
                       
                        break;

                    case "4":
                        continuar = "N";
                        break;

                    default:
                        Console.WriteLine("\n\tOpcion no valida. Presione ENTER e intente nuevamente.");
                        Console.ReadKey();
                        break;
                }

                Console.Clear();
                Console.Write("\n\t¿Desea regresar al menu principal? (S o s / N o n): ");
                continuar = Console.ReadLine();

            } while (continuar == "S" || continuar == "s");

            Console.Clear();
            Console.Write("\n\tFin del Programa");
            Console.Write("\n\tPresiona Cualquier Tecla para Terminar");
            Console.ReadKey();
        }
    }
}