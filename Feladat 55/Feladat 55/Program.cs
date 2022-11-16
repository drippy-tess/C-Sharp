using System;

namespace Feladat_55
{
    class Program
    {
        static void Main(string[] args)
        {
            string mondat;
            Console.Write("Kérem gépeljen be egy mondatot: ");
            mondat = Console.ReadLine();
            string[]szavak = mondat.Split(' ');

            for (int i = 0; i < szavak.Length; i+=2)
            {
                szavak[i] = szavak[i].ToUpper();

            }

            for(int j = 0; j < szavak.Length; j++)
            {
                Console.Write(szavak[j]);
            }
        }
    }
}
