using System;

namespace Feladat_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            Random vsz = new Random();
            x = vsz.Next(-100, 100);
            Console.WriteLine("A szám:{0}", x);
            if ((-30 < x) && (40 > x))
            {
                Console.Write("A szám beleesik az intervallumba");
            }
            else
            {
                Console.Write("A szám nem esik bele az intervallumba");
            }
        }
    }
}
