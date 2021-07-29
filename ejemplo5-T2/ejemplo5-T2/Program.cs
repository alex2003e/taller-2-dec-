using System;

namespace ejemplo5_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor_com,descuento;
            Console.WriteLine("por favor ingresar el valor a pagar:");
            valor_com = double.Parse(Console.ReadLine());
            if (valor_com >= 100000)
            {
                descuento = (valor_com * 20) / 100;
                valor_com = valor_com - descuento;

                System.Console.WriteLine(" el valor a pagar es de : " + valor_com);
                Console.ReadKey();
            }
            else { System.Console.WriteLine(" el valor a pagar es de : " + valor_com);  Console.ReadKey(); }
        }
    }
}
