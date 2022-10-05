using System;

namespace Feladat_34
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] t = new int[10];
            int[] ps = new int[10];
            int[] ptl = new int[10];
            int index1 = 0;
            int index2 = 0;

            Console.WriteLine("Kérek 10 számot!");
            for (int i = 0; i < 10; i++)
            {
                t[i] = Convert.ToInt32(Console.ReadLine());
                if (t[i] % 2 == 0)
                {
                    ps[index1] = t[i];
                    index1++;
                }
                else {
                    ptl[index2] = t[i];
                    index2++;
                }
            }
            for (int j = 0; j < index1; j++)
            {
                Console.WriteLine(ps[j]);
            }
            Console.WriteLine("Páratlan elemek:");
            for (int j = 0; j < index2; j++)
            {
                Console.WriteLine(ptl[j]);
            }
        }
    }
}
