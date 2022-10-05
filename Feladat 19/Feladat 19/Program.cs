using System;

namespace Feladat_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int kezdoErtek;
            int vegErtek;
            int csere;
            int i;
            int dbSzam = 0;

            Console.WriteLine("Kérem az intervallum kezdőértékét");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem az intervallum végértékét");
            vegErtek = Convert.ToInt32(Console.ReadLine());

            if (kezdoErtek > vegErtek)
            {
                csere = kezdoErtek;
                kezdoErtek = vegErtek;
                vegErtek = csere;
            }
            for (i = kezdoErtek; i <= vegErtek; i++)
            {
                if (i % 5 == 0)
                {
                    dbSzam++;
                }
            }

            Console.WriteLine("Az öttel oszthatók száma: {0}", dbSzam);
        }
    }
}
