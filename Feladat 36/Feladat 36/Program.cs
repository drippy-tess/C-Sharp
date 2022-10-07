using System;

namespace Feladat_36
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] tomb = new int[7];
            int atlag = 0;

            Console.WriteLine("Kérem adja meg a kiadásait hétfőtől péntekig:");

            for (i = 0; i < tomb.Length; i++)
            {
                tomb[i] = Convert.ToInt32(Console.ReadLine());
                atlag = atlag + tomb[i];
                if (tomb[i] < 10000)
                {
                    Console.WriteLine("Volt 10000Ft-nál kisebb kiadás.");
                }
            }
            atlag = atlag / 7;
            Console.WriteLine("Az átlag: {0}", atlag);

            //B. feladat
            double min = tomb[0];
            int index = 0;
            for(int j = 1; j < 7; j++)
            { 
                if(tomb[j] < min)
                {
                    min = kiadas[j];
                    index = j;
                }
            }
            Console.Write("A legkisebb kiadás: {0}", min);
            Console.Write("A nap sorszáma: {0}", index +1);
        }
    }
}
