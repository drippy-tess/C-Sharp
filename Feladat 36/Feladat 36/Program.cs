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

        }
    }
}
