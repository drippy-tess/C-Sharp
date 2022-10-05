using System;

namespace Feladat_31
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] tomb = new int[8];
            int min;
            int max;
            Console.Write("Kérem a tömb elemeit:");
            tomb[0] = Convert.ToInt32(Console.ReadLine());
            min = tomb[0];
            max = tomb[0];

            for (i = 0; tomb.Length > i; i++)
            {
                tomb[i] = Convert.ToInt32(Console.ReadLine());
                if (tomb[i] < min)
                {
                    min = tomb[i];
                }
                else if (tomb[i] > max)
                {
                    max = tomb[i];
                }
            }
            Console.Write("A legkisebb érték: {0}\nA legnagyobb érték: {1}", min, max);

            
        }
    }
}
