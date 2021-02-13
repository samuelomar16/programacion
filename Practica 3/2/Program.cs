using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int Numeros = 1;

           do 
           {
               Console.Write(Numeros);
               Console.Write(", ");

               Numeros = Numeros + 1;

            }while(Numeros <= 10); 
            Console.ReadKey();
        }
    }
}
