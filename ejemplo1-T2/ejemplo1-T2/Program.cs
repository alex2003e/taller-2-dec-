using System;

namespace ejemplo1_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nu;
            nu = int.Parse(Console.ReadLine());
            
            if ((nu % 2) == 0) { 
                Console.WriteLine("Es Par");
            }
            Console.ReadKey();

        }
    }
}
