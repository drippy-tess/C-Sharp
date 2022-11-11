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

            for (int i = 0; i < mondat.Length; i++)
            {
                switch (mondat[i])
                {
                    case "": Console.Write($"{mondat}"); break;
                    case " ": Console.WriteLine($"\n"); break;
                    default: break;
                }
            }
        }
    }
}
