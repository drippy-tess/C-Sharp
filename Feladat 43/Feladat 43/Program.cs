using System;

namespace Feladat_43
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam = 0;
            int tizenegyel = 0;
            int i;
            int otteloszthatok = 0;

            while(szam == 0 || szam > 99)
            {
                Console.WriteLine("Kérem adjon meg egy maximum 2 jegyű számot:");
                szam = Convert.ToInt32(Console.ReadLine());
            }
            for(i = 0; i <= szam; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("A kettővel ostható számok:{0}", i);
                }

                if (i % 7 == 3)
                {
                    Console.WriteLine("Héttel osztva 3-at ad maradékul:{0}", i);
                }

                if(i % 5 == 0)
                {
                    otteloszthatok += i;
                }

                if(i % 11 == 0) 
                {
                    tizenegyel++;
                }
            }

            Console.WriteLine("Az öttel osztható számok összege: {0}\nA tizenegyel osztható számok száma: {1}", otteloszthatok, tizenegyel);

        }
    }
}
