using System;

namespace Feladat_54
{
    class Program
    {
        static void Main(string[] args)
        {
            string szo;
            Console.Write("Kérem adjon meg egy szót: ");
            szo = Console.ReadLine();

            for(int i = 0; i < szo.Length; i = i +=3)
            {
                Console.WriteLine($"{szo[i]}");
            }
        }
    }
}
