using System;

namespace Feladat_38
{
    class Program
    {
        static void Main(string[] args)
        {
            long szorzat = 1;
            int i = 0;
            int szam;
            while (i < 5)
            {
                szam = Convert.ToInt32(Console.ReadLine());
                szorzat *= szam;
                i++;
            }
            Console.Write("A szorzat értéke: {0}", szorzat);
        }
    }
}
