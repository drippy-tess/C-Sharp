using System;

namespace Feladat_35
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adja meg a tömb méretét:");
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
                Console.WriteLine(tomb[i]);
                atlag = atlag + tomb[i];
                //F. feladat
                if (tomb[i] % 5 == 0)
                {
                    Console.WriteLine("Volt 0-ra, vagy 5-re végződő szám: {0}", tomb[i]);
                }
                //E. feladat
                if (tomb[i] % 2 == 0)
                {
                    parosSzamok += 1;
                }
                else
                {
                    paratlanSzamok += 1;
                }
                
            }

            //A. feladat
            int index = 0;
            int min = tomb[0];
            for (int j = 0; j < tombMerete; j++)
            {
                if (tomb[j] < min)
                {
                    min = tomb[j];
                    index = j;
                }
            }
            Console.WriteLine("A legkisebb elem: {0}\n indexe:", min);
            Console.Write(index);

            //B. feladat
            int[] forditott = new int[tombMerete];
            int temp = 0;
            for (int k = tomb.Length - 1; k >= 0; k--)
            {
                forditott[temp] = tomb[k];
                temp++;
            }
            for (int m = 0; m < tombMerete; m++)
            {
                Console.WriteLine(forditott[m]);
            }

            //C. feladat
            double atlag1;
            double osszeg = 0;
            int db = 0;
            for (int n = 0; n < tombMerete; n++)
            {
                osszeg = osszeg + tomb[n];
            }
            atlag1 = osszeg / tombMerete;
            for (int o = 0; o < tombMerete; o++)
            {
                if (tomb[o] > atlag)
                {
                    db++;
                }
            }
            Console.Write("Az átlagnál nagyobb számok: {0}", db);

            //D. feladat
            int db2 = 0;
            for (int p = 0; p < tombMerete; p++)
            {
                if ((Math.Abs(tomb[p]) < 100) && (Math.Abs(tomb[p]) > -100))
                {
                    db2++;
                }
            }

            Console.WriteLine("A tömb elemei: {0}");
            atlag = atlag / tombMerete;
            Console.WriteLine("Tömb átlaga: {0}, páros számok: {1}, páratlan számok:{2}", atlag, parosSzamok, paratlanSzamok);

        }
    }
}
