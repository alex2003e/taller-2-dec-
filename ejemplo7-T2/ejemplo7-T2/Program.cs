using System;

namespace ejemplo7_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, resul;
            num = int.Parse(Console.ReadLine());
            if (num < 0) { Console.WriteLine("el numero es negativo"); Console.ReadKey(); }
        }
    }
}
