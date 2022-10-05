using System;

namespace Feladat_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Random vsz = new Random();
            int i;
            int szam;
            int osszeg = 0;

            for (i = 0; i <= 9; i++)
            {
                szam = vsz.Next(10, 100);
                Console.WriteLine("{0}", szam);
                osszeg = osszeg + szam;
            }
            Console.Write("A számok összege: {0}", osszeg);
        }
    }
}
