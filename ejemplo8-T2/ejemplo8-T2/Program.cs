using System;

namespace ejemplo8_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, interes,valorXinteres;
            Console.WriteLine("dinero a invertir:");
            valor = double.Parse(Console.ReadLine());

            do
            {
                interes = (valor * 9) / 100;
                valorXinteres = valor + interes;
            } while (interes > 700000);

            System.Console.WriteLine("la cantidad total de dinero que tiene es: "+valorXinteres);
            Console.ReadKey();

        }
    }
}
