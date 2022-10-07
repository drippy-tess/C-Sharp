using System;

namespace Feladat_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int elsoSzam;
            int masodikSzam;
            int harmadikSzam;
            
            Console.Write("Kérem az első számot:");
            elsoSzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem az második számot:");
            masodikSzam = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem az harmadik számot:");
            harmadikSzam = Convert.ToInt32(Console.ReadLine());

            if ((elsoSzam > masodikSzam) && (masodikSzam > harmadikSzam))
            {
                Console.WriteLine("A legkisebb {0}", harmadikSzam);
            }
            else if ((elsoSzam > masodikSzam) && (harmadikSzam > masodikSzam))
            {
                Console.WriteLine("A legkisebb {0}", masodikSzam);
            }
            else
            {
                Console.Write("A legkisebb {0}", elsoSzam);
            }
        }
    }
}
