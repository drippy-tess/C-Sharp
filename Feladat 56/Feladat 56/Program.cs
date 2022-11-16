using System;

namespace Feladat_56
{
    class Program
    {
        static void Main(string[] args)
        {
            string mondat;
            Console.Write("Kérem adjon meg egy mondatot: ");
            mondat = Console.ReadLine();
            string[] szavak = mondat.Split(' ');

            for (int i = 0; i < szavak.Length; i++)
            {
                szavak[i] = szavak[i].Substring(0, 1).ToUpper() + szavak[i].Substring(1, (szavak[i].Length - 1));
            }

            for(int j = 0; j < szavak.Length; j++)
            {
                Console.Write(szavak[i] + " ");
            }
        }
    }
}
