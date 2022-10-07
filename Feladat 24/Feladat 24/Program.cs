using System;

namespace Feladat_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int oszthatoHarommal = 0;
            int random;
            Random vsz = new Random();

            for(i = 0; i <= 10; i ++)
            {
                random = vsz.Next(100, 1000);
                if (random % 3 == 0)
                {
                    oszthatoHarommal++;
                }
            }
            Console.Write("A hárromal osztható számok száma: {0}", oszthatoHarommal);
        }
    }
}
