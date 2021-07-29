using System;

namespace ejemplo12_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura;
            Console.WriteLine("ingresar su altura");
            altura = double.Parse(Console.ReadLine());

            if (altura > 1.70) { Console.WriteLine("usted es una persona alta "); Console.ReadKey(); } else { Console.WriteLine("eres bajo"); Console.ReadKey(); }
        }
    }
}
