using System;

namespace ejemplo4_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resul;
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) { resul = num1 + num2; System.Console.WriteLine("la suma es: "+resul); } else { Console.WriteLine("no se pueden sumar"); }
            Console.ReadKey();
        }
    }
}
