using System;

namespace Feladat_18
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            int faktorialis = 1;
            int i;

            Console.Write("Kérem adjon meg egy számot:");
            szam = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= szam; i++)
            {

                faktorialis = faktorialis * i;
            }
            Console.WriteLine("A szám faktoriálisa: {0}", faktorialis);
        }
    }
}
