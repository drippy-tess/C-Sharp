using System;

namespace Feladat_16
{
    class Program
    {
        static void Main(string[] args)
        {
            int bekertSzam;
            Console.WriteLine("Kérem adjon meg egy számot!");
            bekertSzam = Convert.ToInt32(Console.ReadLine());

            if (bekertSzam >= 0 && bekertSzam < 10)
            {
                Console.Write("A bekért szám egyjegyű");
            }
            else if (bekertSzam >= 10 && bekertSzam < 100)
            {
                Console.Write("A bekért szám kétjegyű");
            }
            else
            {
                Console.Write("A beért szám három, vagy többjegyű");
            }
        }
    }
}
