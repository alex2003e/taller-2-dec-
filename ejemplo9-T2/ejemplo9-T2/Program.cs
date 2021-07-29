using System;

namespace ejemplo9_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("por favor ingresar un numero");
            num = int.Parse(Console.ReadLine());
            

            if (num%5 == 0) { Console.WriteLine("el numero es  multiplo de 5"); Console.ReadKey(); }
            Console.ReadKey();
        }
    }
}
