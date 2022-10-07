using System;

namespace Feladat_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int tombMerete = Convert.ToInt32(Console.ReadLine());
            int[] tomb = new int[tombMerete];
            Random vsz = new Random();
            int i;
            int parosSzamok = 0;
            int paratlanSzamok = 0;
            int atlag = 0;

            for (i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(-200, 200);
                atlag = atlag + tomb[i];
                if (tomb[i] % 5 == 0)
                {
                    Console.WriteLine("Volt 0-ra, vagy 5-r végződő szám");
                }
                if (tomb[i] % 2 == 0)
                {
                    parosSzamok += 1;
                }
                else
                {
                    paratlanSzamok += 1;
                }
                
            }
            Console.WriteLine("A tömb elemei: {0}", tomb[i]);
            atlag = atlag / tombMerete;
            Console.WriteLine("Tömb átlaga: {0}, páros számok: {1}, páratlan számok{2}", atlag, parosSzamok, paratlanSzamok);

        }
    }
}
