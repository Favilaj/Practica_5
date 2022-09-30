using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaramos nuestras variables
            int option;
            string mensaje;
            string texto;

            Console.WriteLine("***** Menu de Programas *****");
            Console.WriteLine("1. Par o Impar");
            Console.WriteLine("2. Meses");
            Console.WriteLine("3. Estacionamiento");
            Console.Write("Seleccione una opción (1 - 3): ");
            // Guardamos la variable
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Escribe un número: ");
                    long numero = Convert.ToInt64(Console.ReadLine());
                    long sobrante = numero % 2;
                    if (sobrante == 0)
                    {
                        Console.WriteLine("El número es par");
                    }
                    else
                    {
                        Console.WriteLine("El número es impar");
                    }
                    Console.ReadLine();
                    break;
                case 2:
                    byte mes;
                    Console.WriteLine("Ingresa el numero del mes que quieres conocer: ");
                    mes = Convert.ToByte( Console.ReadLine());

                    switch (mes)
                    {
                        case 1: Console.WriteLine("Enero");
                            break;

                        case 2:
                            Console.WriteLine("Febrero");
                            break;

                        case 3:
                            Console.WriteLine("Marzo");
                            break;

                        case 4:
                            Console.WriteLine("Abril");
                            break;

                        case 5:
                            Console.WriteLine("Mayo");
                            break;

                        case 6:
                            Console.WriteLine("Junio");
                            break;

                        case 7:
                            Console.WriteLine("Julio");
                            break;

                        case 8:
                            Console.WriteLine("Agosto");
                            break;

                        case 9:
                            Console.WriteLine("Septiembre");
                            break;

                        case 10:
                            Console.WriteLine("Octubre");
                            break;

                        case 11:
                            Console.WriteLine("Noviembre");
                            break;

                        case 12:
                            Console.WriteLine("Diciembre");
                            break;

                        default: Console.WriteLine("Escribe un numero del 1 al 12");
                            break;
                    }    
                    
                    break;
                case 3:
                    int pago, tiempo;
                    Console.Write("Ingresa el valor de tiempo en horas: ");
                    tiempo = int.Parse(Console.ReadLine());
                    pago = 0;
                    if (tiempo == 1)
                        pago = 5;
                    if (tiempo == 2)
                        pago = 15;
                    if (tiempo > 2)
                        pago = 40;

                    Console.WriteLine("Tu total ha pagar es: " + pago);
                    Console.WriteLine();
                    Console.Write("Presiona enter para terminar . . . ");
                    Console.ReadKey();
                    break;

                default:
                    Console.WriteLine("Opcion Incorrecta elige de nuevo.");
                    Console.WriteLine();
                    break;
            }

            // Imprimimos el mensaje.
            Console.ReadLine();
        }
    }
}  