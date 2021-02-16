using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cajero1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenido al cajero automatico");
            Console.WriteLine("Digite (1) si su banco es  banreservas");
            Console.WriteLine("Digite (2) si tiene otro banco");
            Console.WriteLine("Digite (3) para anular");
            string opcion;

            opcion = Console.ReadLine();

            long opcions = Convert.ToInt64(opcion);

            if (opcions == 1)
            {
                Console.Clear();
                Console.WriteLine("Digite el monto a retirar");

                string monto;
                monto = Console.ReadLine();

                long montos = Convert.ToInt64(monto);

                if (montos <= 20000)
                {
                    if (montos / 1000 == 1)
                    {
                        Console.WriteLine(montos / 1000 + " papeletas de 1000 pesos");
                    }
                    else if (montos / 1000 >= 1 && montos / 1000 <= 18)
                    {
                        Console.WriteLine(montos / 1000 + " papeletas de 1000 pesos");

                    }

                    else if (montos / 1000 >= 18)
                    {
                        Console.WriteLine(0 + " papeletas de 1000 pesos");

                    }
                    montos %= 1000;

                    if (montos / 500 == 1)
                    {
                        Console.WriteLine(montos / 500 + " papeletas de 500 pesos");
                    }
                    else if (montos / 500 >= 1 && montos / 500 <= 19)
                    {
                        Console.WriteLine(montos / 500 + " papeletas de 500 pesos");
                    }
                    else if (montos / 500 >= 19)
                    {
                        Console.WriteLine(0 + " papeletas de 500 pesos");
                    }
                    montos %= 500;
                    if (montos / 200 == 1)
                    {
                        Console.WriteLine(montos / 200 + " papeletas de 200 pesos");
                    }
                    else if (montos / 200 >= 1 && montos / 200 <= 23)
                    {
                        Console.WriteLine(montos / 200 + " papeletas de 200 pesos");
                    }
                    else if (montos / 200 >= 23)
                    {
                        Console.WriteLine(0 + " papeletas de 200 pesos");
                    }
                    montos %= 200;
                    if (montos / 100 == 1)
                    {
                        Console.WriteLine(montos / 100 + " papeletas de 100 pesos");
                    }
                    else if (montos / 100 >= 1 && montos / 100 <= 50)
                    {
                        Console.WriteLine(montos / 100 + " papeletas de 100 pesos");
                    }
                    else if (montos / 100 >= 50)
                    {
                        Console.WriteLine(0 + " papeletas de 100 pesos");
                    }
                    montos %= 100;
                }
                else
                {
                    Console.WriteLine("Usted no cuenta con fondos suficiente para realizar esta transacción");
                }
            }
            if (opcions == 2)
            {
                Console.Clear();
                Console.WriteLine("Digite la cantidad a retirar");
                string monto;
                monto = Console.ReadLine();
                long montos = Convert.ToInt64(monto);
                if (montos <= 10000)
                {
                    if (montos / 1000 == 1)
                    {
                        Console.WriteLine(montos / 1000 + " Billetes de 1000 pesos");
                    }
                    else if (montos / 1000 >= 1 && montos / 1000 <= 18)
                    {
                        Console.WriteLine(montos / 1000 + " Billetes de 1000 pesos");
                    }
                    else if (montos / 1000 >= 18)
                    {
                        Console.WriteLine(0 + " Billetes de 1000 pesos");
                    }
                    montos %= 1000;
                    if (montos / 500 == 1)
                    {
                        Console.WriteLine(montos / 500 + " Billetes de 500 pesos");
                    }
                    else if (montos / 500 >= 1 && montos / 500 <= 19)
                    {
                        Console.WriteLine(montos / 500 + " Billetes de 500 pesos");
                    }
                    else if (montos / 500 >= 19)
                    {
                        Console.WriteLine(0 + " Billetes de 500 pesos");
                    }
                    montos %= 500;
                    if (montos / 200 == 1)
                    {
                        Console.WriteLine(montos / 200 + " Billete de 200 pesos");
                    }
                    else if (montos / 200 >= 1 && montos / 200 <= 23)
                    {
                        Console.WriteLine(montos / 200 + " Billetes de 200 pesos");

                    }
                    else if (montos / 200 >= 23)
                    {
                        Console.WriteLine(0 + " Billetes de 200 pesos");

                    }
                    montos %= 200;
                    if (montos / 100 == 1)
                    {
                        Console.WriteLine(montos / 100 + " Billete de 100 pesos");
                    }
                    else if (montos / 100 >= 1 && montos / 100 <= 50)
                    {
                        Console.WriteLine(montos / 100 + " Billetes de 100 pesos");

                    }
                    else if (montos / 100 >= 50)
                    {
                        Console.WriteLine(0 + " Billetes de 100 pesos");

                    }
                    montos %= 100;
                }
                else
                {
                    Console.WriteLine("Usted no cuenta con los fondos suficiente para realizar esta transacción ruede durisimo");

                }

            }
            if (opcions == 3)
            {
                Environment.Exit(0);
            }
            if (opcions > 3)
            {
                Console.Clear();
                Console.WriteLine("Opcion no valida");
                Main(args);
            }
            Console.ReadKey();

        }
    }
}
