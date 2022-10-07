using System;

namespace Feladat_26
{
    class Program
    {
        static void Main(string[] args)
        {
            int kezdoErtek;
            int vegErtek;
            int i;
            int osszeg = 0;

            Console.Write("Kérem adja meg a kezdőértéket:");
            kezdoErtek = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a végértéket:");
            vegErtek = Convert.ToInt32(Console.ReadLine());

            if (kezdoErtek % 2 != 0)
            {
                for (i = kezdoErtek; i <= vegErtek; i++)
                {
                    if (i % 2 != 0)
                    {
                        osszeg = osszeg + i;
                    }
                    else
                    {
                        osszeg = osszeg - i;
                    }
                }
            }
            else
            {
                for (i = kezdoErtek; i <= vegErtek; i++)
                {
                    if (i % 2 != 0)
                    {
                        osszeg = osszeg - i;
                    }
                    else
                    {
                        osszeg = osszeg + i;
                    }
                }
            }
            Console.Write("Az összeg: {0}", osszeg);
        }
    }
}
