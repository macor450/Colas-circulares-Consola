using System;
using System.Collections.Generic;
using System.Text;

namespace Colas_circulares_Consola
{
    class Circular
    {
        int Ultimo;
        int Primero;
        int Maximo;
        string[] Arreglo;

        public Circular(int tamaño)
        {
            Maximo = tamaño;
            Arreglo = new string[Maximo];
            Ultimo = Primero = -1;
        }
        //AUXILIARES
        public bool Vacia()
        {
            if (Primero == -1)
                return true;
            else
                return false;
        }

        public bool Llena()
        {
            if (Ultimo == Maximo - 1 && Primero == 0 || Ultimo + 1 == Primero)
                return true;
            else
                return false;
        }
        //METODO
        public void Agregar(string elemento)
        {
            if (Llena())
                Console.WriteLine("Desbordamiento");
            else
            {
                if (Ultimo == Maximo - 1)
                    Ultimo = 0;
                else
                    Ultimo++;
                Arreglo[Ultimo] = elemento;
                if (Primero == -1)
                    Primero = 0;
            }
        }
        public void Eliminar()
        {
            if (Vacia())
                Console.WriteLine("Subdesbordamiento");
            else
            {
                if (Primero == Ultimo)
                {
                    Arreglo[Primero] = null;
                    Ultimo = Primero = -1;
                }
                else
                {
                    if (Primero == Maximo - 1)
                    {
                        Arreglo[Primero] = null;
                        Primero = 0;
                    }
                    else
                    {
                        Arreglo[Primero] = null;
                        Primero++;
                    }
                }

            }
        }
        public int ObtenerPrimero()
        {
            return Primero + 1;
        }
        public int ObtenerUltimo()
        {
            return Ultimo + 1;
        }
        public int ObtenerMaximo()
        {
            return Maximo;
        }
        public string[] ObtenerArreglo()
        {
            return Arreglo;
        }
    }
}
