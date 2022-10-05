using System;

namespace Feladat_30
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Random vsz = new Random();
            int[] tomb = new int[10];
            int osszeg = 0;
            for (i = 0; i <= 9; i++)
            {
                tomb[i] = vsz.Next(100, 200);
                Console.WriteLine(tomb[i]);
                osszeg += tomb[i];
            }
            Console.WriteLine("A tömbelemek öszege: {0}", osszeg);
        }
    }
}
