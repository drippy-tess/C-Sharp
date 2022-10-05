using System;

namespace Feladat_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Random vsz = new Random();
            x = vsz.Next(200, 800);
            Console.WriteLine("{0}", x);

            if (x % 4 == 0 && x % 6 == 0)
            {
                Console.Write("A generált szám osztható 4-el és 6-tal is!");
            }
            else
            {
                Console.Write("A generált szám nem osztható 4-el, és 6-tal is.");
            }
        }
    }
}
