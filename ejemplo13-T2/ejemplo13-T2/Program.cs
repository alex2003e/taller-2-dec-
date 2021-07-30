using System;

namespace ejemplo13_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double iva, descuento, precio;
            Console.WriteLine("ingre el valor de su compra");
            precio = double.Parse(Console.ReadLine());

            if (precio >= 1000000)
            {

                iva = (precio * 19) / 100;
                descuento = (precio * 10) / 100;
                precio = (precio + iva) - descuento;

                System.Console.WriteLine("el valor total: " + precio);
                Console.ReadKey();

            }
            else
            {
                iva = (precio * 19) / 100;
                
                precio = precio + iva;

                System.Console.WriteLine("el valor total: " + precio);
                Console.ReadKey();
            }
        }
    }
}
