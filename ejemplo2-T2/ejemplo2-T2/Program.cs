using System;

namespace ejemplo2_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 ;
            num1 = int.Parse(Console.ReadLine());
            double r = Math.Pow(num1, 3);
            if (num1 >= 10) {   System.Console.WriteLine("su triple es: "+r); }

            Console.ReadKey();
        }
        
    }
}
