using System;

namespace Feladat_40
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adjon meg egy számot:");
            int hatarertek = Convert.ToInt32(Console.ReadLine());
            int probalkozasokSzama = 0;
            int osszeg = 0;

            while(osszeg != hatarertek)
            {
                Console.Write("Kérem adjon meg egy számot:");
                osszeg += Convert.ToInt32(Console.ReadLine());
                probalkozasokSzama++;
            }
            Console.Write("Eltalálta a megadott határértéket: {0}, {1} próbálkozásból.", hatarertek, probalkozasokSzama);
        }
    }
}
