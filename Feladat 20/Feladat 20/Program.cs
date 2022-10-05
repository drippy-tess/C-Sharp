using System;

namespace Feladat_20
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            int db = 0;
            int i;
            Console.Write("Kérem adjon meg egy számot:");
            szam = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= szam; i++)
            {
                if (szam % i == 0)
                {
                    db++;
                }
            }
            Console.Write("Az osztók száma:{0}", db);
        }
    }
}
