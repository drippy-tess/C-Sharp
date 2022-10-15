using System;

namespace Feladat_39
{
    class Program
    {
        static void Main(string[] args)
        {
            Random vsz = new Random();
            int randomSzam = vsz.Next(1,20);
            int felhasznaloiSzam = 0;

            while(felhasznaloiSzam != randomSzam)
            {
                Console.Write("Kérem adjon meg egy számot:");
                felhasznaloiSzam = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Eltalálta a random generált számot, ami: {0}", randomSzam);
            
        }
    }
}
