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

            for (int i = 0; i < mondat.Length(); i++)
            {
                Console.Write(mondat[i]);
            }
        }
    }
}
