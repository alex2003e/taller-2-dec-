using System;

namespace ejemplo3_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double valor_com,IVA, descuento;

            Console.WriteLine("por favor ingresar el valor total de su compra:");
            valor_com = double.Parse(Console.ReadLine());

            if (valor_com >= 1000000)
            {
                descuento = (valor_com * 10) / 100;

                IVA = (valor_com * 19) / 100;

                valor_com = (valor_com - descuento) + IVA;

                System.Console.WriteLine("lo total a pagar es " + valor_com);

                Console.ReadKey();
            }
            else {

                IVA = (valor_com * 19) / 100;

                valor_com = valor_com  + IVA;

                System.Console.WriteLine("lo total a pagar es " + valor_com);
                Console.ReadKey();
            }
        }
    }
}
