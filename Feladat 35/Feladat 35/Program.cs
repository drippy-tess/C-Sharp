using System;

namespace Feladat_35
{
    class Program
    {
        static void Main(string[] args)
        {
            int tombMerete = 0;
            int[] tomb = new int[tombMerete];
            Random vsz = new Random();
            int i;

            Console.Write("Kérem adja meg a tömb elemeinek számát: ");
            tombMerete = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= tomb.Length; i++)
            {
                tomb[i] = vsz.Next(-200, 200);
            }
            Console.WriteLine("A tömb elemei: {0}", tomb);

        }
    }
}
