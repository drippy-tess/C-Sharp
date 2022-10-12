using System;

namespace Feladat_37
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            double atlag;
            int dbszam = 0;
            double osszeg = 0;
            double szam;
            szam = Convert.ToDouble(Console.ReadLine());
            osszeg += szam;
            dbszam++;

            while (szam != 0)
            {
                szam = Convert.ToDouble(Console.ReadLine());
                osszeg += szam;
                dbszam++;
            }
            atlag = osszeg / (dbszam -1);
            Console.WriteLine("Az átlag: {0}", Math.Round(atlag, 2));
        }
    }
}
