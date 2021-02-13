using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
               int Cantidad = (10 * 10);
            int x = Cantidad + 20 ;
            int contador = Cantidad;

            while (contador <= x)
            {
                if (contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
                contador = contador + 1;
            }
            Console.ReadKey();
        }
    }
}
