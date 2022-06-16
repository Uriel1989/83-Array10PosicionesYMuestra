using System;

//Crea un array de 10 posiciones, con valores puestos por ti y muestra el array.

namespace _83_Array10PosicionesYMuestra
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[10];

            array[0] = 25;
            array[1] = 2;
            array[2] = 3;
            array[3] = 35;
            array[4] = 5;
            array[5] = 6;
            array[6] = 7;
            array[7] = 8;
            array[8] = 9;
            array[9] = 10;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("El numero de la posicion " + i + " es: " + array[i]);
            }
        }
    }
}
