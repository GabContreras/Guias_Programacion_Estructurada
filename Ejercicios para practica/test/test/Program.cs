using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ej01();
            ej02();
        }
        static void ej01()
        {
            // ============================================================
            // EJERCICIO DE PRÁCTICA - EVALUACIÓN CORTA
            // Temas: Guía 1 (Secuencial), Guía 2 (Operadores), Guía 3 (If/else)
            // ============================================================
            //
            // ENUNCIADO:
            // Una tienda de electrónica vende tres productos:
            //   - Laptop      → $850.00
            //   - Tablet      → $320.00
            //   - Auriculares → $75.00
            //
            // El programa debe:
            //
            //   1. Pedir el nombre del cliente y la cantidad de cada
            //      producto que desea comprar.
            //
            //   2. Calcular el subtotal de cada producto y el total general.
            //        subtotalLaptop     = cantLaptop     * 850
            //        subtotalTablet     = cantTablet     * 320
            //        subtotalAuric      = cantAuric      * 75
            //        total              = subtotalLaptop + subtotalTablet + subtotalAuric
            //
            //   3. Aplicar un descuento según el total:
            //        total >= 1000            → 15% de descuento
            //        total >= 500 y < 1000   →  8% de descuento
            //        total < 500              →  sin descuento (0%)
            //
            //   4. Mostrar en pantalla:
            //        - Subtotal de cada producto
            //        - El porcentaje que representa cada producto del total
            //          (usar regla de tres, ANTES de aplicar descuento)
            //              porcentaje = (subtotal * 100) / total
            //        - Monto del descuento
            //        - Total final a pagar (total - descuento)
            //
            // ------------------------------------------------------------
            // DATOS DE PRUEBA:
            //   nombre        = Ana
            //   cantLaptop    = 1   →  subtotal = $850
            //   cantTablet    = 2   →  subtotal = $640
            //   cantAuric     = 3   →  subtotal = $225
            //   total                            = $1715
            //   descuento (15%)                  = $257.25
            //   total final                      = $1457.75
            // ------------------------------------------------------------
            //
            // PISTAS CLAVE:
            //   - Usa Double para precios, subtotales y porcentajes
            //   - Usa int para las cantidades
            //   - Para el descuento: monto = total * (porcentaje / 100.0)
            //   - Redondea resultados con Math.Round(variable, 2)
            //   - Recuerda: else if para las condiciones del descuento
            //   - No olvides Console.ReadKey(); al final
            //
            // ============================================================

            // ESCRIBE TU CÓDIGO DEBAJO DE ESTA LÍNEA:
            string nombre;
            int cantLaptop, cantTablet, cantAuric;
            double precioLaptop = 850.00;
            double precioTablet = 320.00;
            double precioAuric = 75.00;
            double subtotalLaptop, subtotalTablet, subtotalAuric, total, descuento, totalFinal;

            Console.Write("Bienvenido a la tienda de electrónica. Por favor, ingresa tu nombre: ");
            nombre = Console.ReadLine();

            Console.Write("¿Cuántas laptops deseas comprar? ");
            cantLaptop = int.Parse(Console.ReadLine());
            Console.Write("¿Cuántas tablets deseas comprar? ");
            cantTablet = int.Parse(Console.ReadLine());
            Console.Write("¿Cuántos auriculares deseas comprar? ");
            cantAuric = int.Parse(Console.ReadLine());

            subtotalLaptop = cantLaptop * precioLaptop;
            subtotalAuric = cantAuric * precioAuric;
            subtotalTablet = cantTablet * precioTablet;

            total = subtotalLaptop + subtotalTablet + subtotalAuric;
            if (total >= 1000)
            {
                descuento = total * (15.0 / 100.0);
            }
            else if (total >= 500 && total < 1000)
            {
                descuento = total * (8.0 / 100.0);
            }
            else
            {
                descuento = 0;
            }
            totalFinal = total - descuento;

            Console.WriteLine($"\nHola {nombre}, aquí está el resumen de tu compra:");
            Console.WriteLine($"Subtotal Laptop: ${subtotalLaptop}");
            Console.WriteLine($"Subtotal Tablet: ${subtotalTablet}");
            Console.WriteLine($"Subtotal Auriculares: ${subtotalAuric}");
            Console.WriteLine($"Porcentaje Laptop: {Math.Round((subtotalLaptop * 100) / total, 2)}%");
            Console.WriteLine($"Porcentaje Tablet: {Math.Round((subtotalTablet * 100) / total, 2)}%");
            Console.WriteLine($"Porcentaje Auriculares: {Math.Round((subtotalAuric * 100) / total, 2)}%");
            Console.WriteLine($"Total antes de descuento: ${Math.Round(total, 2)}");
            Console.WriteLine($"Descuento aplicado: ${Math.Round(descuento, 2)}");
            Console.WriteLine($"Total a pagar: ${Math.Round(totalFinal, 2)}");
            Console.WriteLine($"Gracias por comprar en nuestra tienda!");
            Console.ReadKey();
        }
        static void ej02()
        {
            string nombreCliente, nombreMembresia = " ";
            double precioMensual = 0;
            double subtotal, total, descuento;
            double porcDescuento = 0;
            int numeroMembresia;
            int mesesPlan = 0;
            Console.Write("Bienvenido al gimnasio papu, por favor ingresa tu nombre: ");
            nombreCliente = Console.ReadLine();

            Console.WriteLine("Gracias por usar nuestro servicio, " + nombreCliente + ". Por favor, elige tu tipo de membresía:");
            Console.WriteLine("1 - Básica    -> $25/mes  (solo máquinas)");
            Console.WriteLine("2 - Estándar  -> $45/mes  (máquinas + clases grupales)");
            Console.WriteLine("3 - Premium   -> $80/mes  (todo + entrenador personal)");
            Console.Write("Ingresa el número de tu membresía (1, 2 o 3): ");
            numeroMembresia= int.Parse(Console.ReadLine());
            switch (numeroMembresia) { 
                case 1:
                    Console.WriteLine("Has elegido la membresía Básica. El precio mensual es de $25.");
                    precioMensual = 25;
                    Console.WriteLine("Recuerda que con esta membresía solo tienes acceso a las máquinas.");
                    nombreMembresia = "Básica";
                    break;
                case 2:
                    Console.WriteLine("Has elegido la membresía Estándar. El precio mensual es de $45.");
                    precioMensual = 45;
                    Console.WriteLine("Recuerda que con esta membresía tienes acceso a las máquinas y clases grupales.");
                    nombreMembresia = "Estándar";
                    break;
                case 3:
                    Console.WriteLine("Has elegido la membresía Premium. El precio mensual es de $80.");
                    precioMensual = 80;
                    Console.WriteLine("Recuerda que con esta membresía tienes acceso a todo, incluyendo entrenador personal.");
                    nombreMembresia= "Premium";
                    break;
                default:
                    Console.WriteLine("Error: Opción de membresía inválida. Por favor, elige 1, 2 o 3.");
                    return; 
                    // Salir del programa si la opción es inválida
                }

            Console.Write("Ingresa la cantidad de meses que deseas inscribirte");
            mesesPlan = int.Parse(Console.ReadLine());

            subtotal = precioMensual * mesesPlan;

            if (mesesPlan >= 12)
            {
                porcDescuento = 20;
            }
            else if (mesesPlan >= 6 )
            {
                porcDescuento = 10;
            }
            else
            { 
                porcDescuento = 0;
            }
            descuento = subtotal * (porcDescuento / 100.0);

            total = subtotal - descuento;

            Console.WriteLine($"\nResumen de tu inscripción, {nombreCliente}:");
            Console.WriteLine($"Plan elegido: {numeroMembresia}){nombreMembresia}");
            Console.WriteLine($"Precio mensual: ${precioMensual}");
            Console.WriteLine($"Meses contratados: {mesesPlan}");
            Console.WriteLine($"Total antes de descuento: ${Math.Round(subtotal, 2)}");
            Console.WriteLine($"Porcentaje de descuento aplicado: {porcDescuento}%");
            Console.WriteLine($"Monto del descuento: ${Math.Round(descuento, 2)}");
            Console.WriteLine($"Total con descuento aplicado ${Math.Round(total,2)}");
            Console.WriteLine($"¡Gracias por inscribirte en nuestro gimnasio, {nombreCliente}!");
            Console.ReadKey();
            // ============================================================
            // EJERCICIO 2 - GIMNASIO (Switch + If/else + Secuencial)
            // ============================================================
            //
            // ENUNCIADO:
            // Un gimnasio ofrece 3 tipos de membresía:
            //   Opción 1 - Básica    → $25/mes  (solo máquinas)
            //   Opción 2 - Estándar  → $45/mes  (máquinas + clases grupales)
            //   Opción 3 - Premium   → $80/mes  (todo + entrenador personal)
            //
            // El programa debe:
            //
            //   1. Pedir nombre del cliente y tipo de membresía (1, 2 o 3)
            //
            //   2. Usar SWITCH para determinar el nombre del plan y precio mensual
            //      Si el usuario ingresa un número inválido → mostrar error con default
            //
            //   3. Pedir cuántos meses desea inscribirse
            //
            //   4. Calcular el total antes de descuento:
            //        total = precioMensual * meses
            //
            //   5. Aplicar descuento con IF/ELSE IF según meses:
            //        meses >= 12          → 20% de descuento
            //        meses >= 6 y < 12   → 10% de descuento
            //        meses < 6            → sin descuento (0%)
            //
            //   6. Mostrar resumen:
            //        - Nombre del cliente
            //        - Plan elegido
            //        - Precio mensual
            //        - Meses contratados
            //        - Total antes de descuento
            //        - Porcentaje de descuento aplicado
            //        - Monto del descuento
            //        - Total final a pagar
            //
            // ------------------------------------------------------------
            // DATOS DE PRUEBA:
            //   nombre     = Carlos
            //   membresía  = 2  (Estándar, $45/mes)
            //   meses      = 12
            //
            //   total antes     = $540
            //   descuento (20%) = $108
            //   total final     = $432
            // ------------------------------------------------------------
            //
            // PISTAS CLAVE:
            //   - Usa String para guardar el nombre del plan dentro del switch
            //       String nombrePlan = "";
            //       double precioMensual = 0;
            //   - El switch evalúa la variable entera de membresía
            //   - No olvides break; en cada case
            //   - El default es para cuando el usuario ingresa 4, 5, etc.
            //   - Usa Math.Round(variable, 2) en todos los valores con decimales
            //   - Recuerda Console.ReadKey(); al final
            //
            // ============================================================

            // ESCRIBE TU CÓDIGO DEBAJO DE ESTA LÍNEA:


        }
        }
    }
