using System;

namespace Feladat_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int b;
            int c;
            Console.WriteLine("Kérem a háromszög egyik oldalának hosszát!");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a háromszög második oldalának hosszát!");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a háromszög harmadik oldalának hosszát!");
            c = Convert.ToInt32(Console.ReadLine());

            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                Console.WriteLine("Szerkeszthető");
            }
            else
            {
                Console.WriteLine("Nem szerkeszthető");
            }
        }
    }
}
