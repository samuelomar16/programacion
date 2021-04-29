using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_final
{
    class Program
    {
        static void Main(string[] args)
        {
            InfoPrestamos pre = new InfoPrestamos();

            string entrada = "";
            bool menu = true;

            while (menu)
            {
                Console.WriteLine("Bienvenidos \n");
                Console.WriteLine("1-Introducir datos para el  prestamo");
                Console.WriteLine("2- para Generar una  tabla Amortizada");
                Console.WriteLine("3-Salir");
                entrada = Console.ReadLine();

                switch (entrada)
                {


                    case "1":
                    Console.Clear();
                    pre.datos();
                    break;

                    case "2":
                    Console.Clear();
                    pre.tabla();
                    break;

                    case "3":
                    menu = false;
                    break;

                }

            }




        }
    }
}


class InfoPrestamos
{


    public float pagos, InteresPagado, CapPagado, MontoPrestamo, tasaIntAnu, tasaIntMen;
    public int fil, P, i;
    public string bene;
    public void datos()
    {

        Console.Clear();
        bene = beneficiario("Intruduzca beneficiario: ");
        MontoPrestamo = Mont("Introduce el monto del prestamo: ");
        tasaIntAnu = Inte("Introduce la tasa de interes anual: ");
        P = Pla("Introduce el plazo en meses: ");



        //Calculo del interes mensual
        tasaIntMen = (tasaIntAnu / 100) / 12;


        //Calculo de la cuota mensual
        Console.WriteLine("\n");
        pagos = tasaIntMen + 1;
        pagos = (float)Math.Pow(pagos, P);
        pagos = pagos - 1;
        pagos = tasaIntMen / pagos;
        pagos = tasaIntMen + pagos;
        pagos = MontoPrestamo * pagos;

        Console.WriteLine("su pago mensual: " + Math.Round(pagos));
        Console.WriteLine(" Generar su tabla Amortizada  favor seleccionar segunda opcion");
        Console.WriteLine("\n");
        Console.WriteLine("Precione cualquier  tecla para devolverse");
        Console.ReadKey();
        Console.Clear();

    }

    public static string beneficiario(string msg)
    {
        var Nombre = "";


        Console.WriteLine(msg);

        try
        {
            Nombre = Console.ReadLine();
        }
        catch (Exception)
        {

            Nombre = beneficiario(msg);

        }

        return Nombre;
    }
    public static int Mont(string msg)
    {
        var monto = 0;

        Console.WriteLine(msg);

        try
        {
            monto = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {

            monto = Mont(msg);

        }

        return monto;
    }
    public static int Pla(string msg)
    {
        var plazos = 0;

        Console.WriteLine(msg);

        try
        {
            plazos = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {

            plazos = Mont(msg);

        }

        return plazos;
    }
    public static int Inte(string msg)
    {
        var Interes = 0;

        Console.WriteLine(msg);

        try
        {
            Interes = int.Parse(Console.ReadLine());
        }
        catch (Exception)
        {

            Interes = Mont(msg);

        }

        return Interes;
    }
    public void tabla()
    {
        Console.Clear();
        Console.WriteLine("Beneficiario: " + bene);
        Console.WriteLine("Monto: " + MontoPrestamo);
        Console.WriteLine("Tasa: " + tasaIntAnu + " %");
        Console.WriteLine("Plazo: " + P + " Meses");
        Console.WriteLine("Valor de cuota: " + Math.Round(pagos));
        Console.WriteLine("--------------------------------------");
        fil = 1;
        Console.WriteLine();
        Console.WriteLine();
        Console.Write(" Numero de pagos \t");
        Console.Write("Pagos \t\t");
        Console.Write("Intereses Pagos \t\t");
        Console.Write("Capital Pagado \t\t");
        Console.Write("Monto prestamo \t");
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("\t0");
        Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", Math.Round(MontoPrestamo));


        for (i = 1; i <= P; i++)
        {


            Console.Write("\t{0}\t\t", fil);


            Console.Write("{0}\t", pagos);


            InteresPagado = tasaIntMen * MontoPrestamo;
            Console.Write("{0}\t\t", InteresPagado);


            CapPagado = pagos - InteresPagado;
            Console.Write("\t{0}\t", CapPagado);


            MontoPrestamo = MontoPrestamo - CapPagado;
            Console.Write("\t{0}\t", Math.Round(MontoPrestamo));

            fil = fil + 1;
            Console.WriteLine();

        }

        Console.WriteLine("\n");
        Console.WriteLine("Precione una tecla para volver");
        Console.ReadKey();
        Console.Clear();

    }

}