using System;

namespace Feladat_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int elsoSzam;
            int kulonbseg;
            int i;

            Console.Write("Kérem adja meg az első elemet:");
            elsoSzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a különbséget elemet:");
            kulonbseg = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= 8; i++)
            {
                elsoSzam = elsoSzam + kulonbseg;
                Console.WriteLine("{0}", elsoSzam);

            }
        }
    }
}
