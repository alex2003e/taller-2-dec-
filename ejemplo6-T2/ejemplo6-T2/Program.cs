using System;

namespace ejemplo6_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorbruto, retencion;
            Console.WriteLine("ingrese el valor bruto del empleado:");
            valorbruto = double.Parse(Console.ReadLine());
            if (valorbruto >= 2000000)
            {
                retencion = (valorbruto * 10) / 100;
                valorbruto = valorbruto - retencion;

                System.Console.WriteLine("el valor a total que puede sacar es: " + valorbruto);

                Console.ReadKey();
            }
            else {
                System.Console.WriteLine("el valor a total que puede sacar es: " + valorbruto);

                Console.ReadKey();
            }
        }
    }
}
