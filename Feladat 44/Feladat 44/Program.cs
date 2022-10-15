using System;

namespace Feladat_44
{
    class Program
    {
        static void Main(string[] args)
        {
            int parosszam = 0;
            int paratlanszam = 0;
            int randomszam;
            double atlag = 0;
            int i;
            int negyeloszthato = 0;
            int parosszamtol;
            int paratlanszamtol;

            while (parosszam == 0 || parosszam % 2 != 0)
            {
                Console.Write("Kérem adjon meg egy páros számot:");
                parosszam = Convert.ToInt32(Console.ReadLine());
            }

            while (paratlanszam == 0 || paratlanszam < parosszam || paratlanszam % 2 == 0)
            {
                Console.Write("Kérem adjon meg egy páratlan számot:");
                paratlanszam = Convert.ToInt32(Console.ReadLine());
            }

            Random vsz = new Random();
            randomszam = vsz.Next(parosszam, paratlanszam);
            parosszamtol = Math.Abs(parosszam - randomszam);
            paratlanszamtol = Math.Abs(paratlanszam - randomszam);
            if (paratlanszamtol > parosszamtol)
            {
                Console.WriteLine("A páros számhoz van közelebb a randomszám");
            }
            else if (parosszamtol > paratlanszamtol)
            {
                Console.WriteLine("A páratlan számhoz van közelebb a randomszám.");
            }
            else {
                Console.WriteLine("A két számtól ugyanolyan távolságra van a randomszám.");
            }
               
            atlag = (paratlanszam + parosszam) / 2;
            for (i = 0; i <= paratlanszam; i++)
            {
                if (i % 4 == 0)
                {
                    negyeloszthato++;
                }
            }
            Console.WriteLine("A két szám átlaga: {0}\nA négyel osztható számok száma: {1}\nA random szám:{2}", atlag, negyeloszthato, randomszam);
        }
    }
}
