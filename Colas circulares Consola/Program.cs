using System;
using System.Threading; 

namespace Colas_circulares_Consola
{
    class Program
    {
        static Circular circular;
        static void MostrarCircular()
        {
            Console.Write("\n\n");
            for (int i = 0; i < circular.ObtenerMaximo(); i++)
            {
                if (circular.ObtenerArreglo()[i] == null)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("| * |\t");
                    Thread.Sleep(30);
                    Console.Beep();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("| {0} |\t", circular.ObtenerArreglo()[i]);
                    Thread.Sleep(30);
                    Console.Beep();
                }
            }
            Console.Write("\n\n");
        }
        static void Main(string[] args)
        {
            //Variables
            int CantidadElementos = 0; 
            char Respuesta = ' ';

            Console.Title = "Colas Circulares";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Tamaño de la cola:");
            int Tamaño = int.Parse(Console.ReadLine());
            circular = new Circular(Tamaño);//Instancia de las colas
            Console.Beep();
            Console.Clear();
            do
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("<<<<<<<<<<<<Operaciones Circulares>>>>>>>>>>>");
                Console.WriteLine("1.Agregar");
                Console.WriteLine("2.Eliminar");
                Console.WriteLine("3.Ver Primero");
                Console.WriteLine("4.Ver Ultimo");
                Console.WriteLine("5.Salir");
                int Opcion = int.Parse(Console.ReadLine());
                switch(Opcion)
                {
                    case 1://Agregar
                        Console.Write("Cantidad de elementos a agregar");
                        CantidadElementos = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (CantidadElementos > circular.ObtenerMaximo())
                            Console.Write("no se puede agregar mas de { 0 } elementos", CantidadElementos);
                        else if (CantidadElementos < 0)
                            Console.Write("No pueden ser numero negaivos. intentalo nuevamete.");
                        else
                        {
                            for (int i=0; i < CantidadElementos; i++)
                            {
                                Console.Write("Elemento #{0}:", i + 1);
                                string element = Console.ReadLine();
                                circular.Agregar(element);
                            }
                        }
                        MostrarCircular();
                        break;

                    case 2://Eliminar
                        Console.Write("Cantidad de elementos a eliminar");
                        CantidadElementos = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (CantidadElementos > circular.ObtenerMaximo())
                            Console.Write("no se puede eliminar mas de { 0 } elementos", CantidadElementos);
                        else if (CantidadElementos < 0)
                            Console.Write("No pueden ser numero negaivos. intentalo nuevamete.");
                        else
                        {
                            for (int i = 0; i < CantidadElementos; i++)
                            {
                                circular.Eliminar();
                            }
                        }
                        MostrarCircular();
                        break;

                    case 3://Ver el Primero 
                        Console.WriteLine("El frente actual de la cola es: { 0 }.", circular.ObtenerPrimero());
                        break;

                    case 4://Para ver el Ultimo
                        Console.WriteLine("El final actual de la cola es: { 0 }.", circular.ObtenerUltimo());

                        break;

                    case 5://Para Salir
                        Console.WriteLine("presione cualquier tecla para salir");
                        break;
                    default:// por defecto
                        Console.Write("la opcion no es valida por favor intentelo");
                        break;

                }
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("¿Desea continuar con otra operacion}? [s/n]:");
                Respuesta = char.Parse(Console.ReadLine());
                Console.Clear();
            } while (Respuesta.Equals('s'));
        }
    }
}
