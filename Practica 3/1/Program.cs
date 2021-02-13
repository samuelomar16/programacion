using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
           
           int num, suma=0;
            do{
                    Console.Write("Ingrese numero positivo, programa dejara de funcionar si ingresa un numero negativo o cero.\n");
                    num = int.Parse(Console.ReadLine());
                    suma = suma+num;
                    if(num < 0){
                        Console.Write("El numero ingresado: "+num+" es negativo, por lo cual el programa terminara su ejecucion.\n");
                        break;
                    }
                    else{
                         Console.WriteLine(" La Suma de valor ingresado es igual a: " + suma + " \n");
                    }
                    
            }while (num >=1);
            
        }
    }
}
