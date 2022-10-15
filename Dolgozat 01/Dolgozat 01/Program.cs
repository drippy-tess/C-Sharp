using System;

namespace Dolgozat_01
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Feladat 01
            double teglafalTerulet = 0;
            Console.Write("Kérem adja meg a külső ív sugarát:");
            int r1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a belső ív sugarát:");
            int r2 = Convert.ToInt32(Console.ReadLine());

            teglafalTerulet = Math.PI * (Math.Pow(r1, 2) - Math.Pow(r2, 2)) / 2;
            Console.WriteLine("A téglafal területe: {0}", teglafalTerulet);
            */


            /*  Feladat 02
            Console.Write("Kérem adja meg a víz hőmérsékletét:");
            int vizHomerseklet = Convert.ToInt32(Console.ReadLine());

            if (vizHomerseklet < 0)
            {
                Console.WriteLine("A megadott hőmérsékleten jég halmazállapotú.");
            }
            else if (vizHomerseklet >= 0 && vizHomerseklet <= 100)
            {
                Console.WriteLine("A megadott hőmérsékleten folyékony halmazállapotú.");
            }
            else
            {
                Console.WriteLine("A megadott hőmérsékleten gőz halmazállapotú.");
            }
            */
            

            /*Feladat 03
            Console.Write("Kérem adja meg a hatványalapot:");
            int hatvanyAlap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a hatványkitevőt:");
            int hatvanyKitevo = Convert.ToInt32(Console.ReadLine());
            double hatvanyErtek = 0;
            int i;

            for (i = 1; i < hatvanyKitevo; i++)
            {
                if (hatvanyErtek == 0)
                {
                    hatvanyErtek = hatvanyAlap;
                }
                hatvanyErtek *= hatvanyAlap;
            }

            Console.WriteLine("A megadott számok hatványértéke: {0}", hatvanyErtek);
            */


            /*Feladat 04*/
            Random vsz = new Random();
            int veletlenSzam;
            int[] veletlen = new int[20];
            int i;
            int nincsParos = 0;

            Console.WriteLine("Véletlen számok:");
            for (i = 0; i < veletlen.Length; i++)
            {
                veletlenSzam = vsz.Next(-50, 50);
                veletlen[i] = veletlenSzam;
                Console.WriteLine(veletlen[i]);
            }

            Console.WriteLine("A tömbben lévő páros számok:");
            for (i = 0; i < veletlen.Length; i++)
            {
                if (veletlen[i] % 2 == 0)
                {
                    Console.WriteLine(veletlen[i]);
                }
                else
                {
                    nincsParos ++;
                }
            }

            if (nincsParos == 20)
            {
                Console.WriteLine("A tömbben lévő számok között nincsen páros szám.");
            }
        }
    }
}
