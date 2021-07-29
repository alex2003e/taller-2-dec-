using System;

namespace ejemplo10_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("por favor ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            if (edad >= 18) { Console.WriteLine("usted es mayor de edad"); Console.ReadKey(); } else { Console.WriteLine("usted es menor de edad"); Console.ReadKey(); }
        }
    }
}
