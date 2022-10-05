using System;

namespace Feladat_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int elsoSzam;
            int masodikSzam;
            int harmadikSzam;

            Console.WriteLine("Kérem adjon meg egy számot!");
            elsoSzam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adjon meg egy számot!");
            masodikSzam = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem adjon meg egy számot!");
            harmadikSzam = Convert.ToInt32(Console.ReadLine());

            if (elsoSzam < masodikSzam && elsoSzam < harmadikSzam && harmadikSzam > masodikSzam)
            {
                Console.Write("{0}, {1}, {2}", elsoSzam, masodikSzam, harmadikSzam);
            }
            else if (elsoSzam < masodikSzam && elsoSzam < harmadikSzam && harmadikSzam < masodikSzam)
            {
                Console.Write("{0}, {1}, {2}", elsoSzam, harmadikSzam, masodikSzam);
            }
            else if (masodikSzam < elsoSzam && masodikSzam < harmadikSzam && harmadikSzam > elsoSzam)
            {
                Console.Write("{0}, {1}, {2}", masodikSzam, elsoSzam, harmadikSzam);
            }
            else if (masodikSzam < elsoSzam && masodikSzam < harmadikSzam && harmadikSzam < elsoSzam)
            {
                Console.Write("{0}, {1}, {2}", masodikSzam, harmadikSzam, elsoSzam);
            }
            else if (harmadikSzam < elsoSzam && harmadikSzam < masodikSzam && masodikSzam > elsoSzam)
            {
                Console.Write("{0}, {1}, {2}", harmadikSzam, masodikSzam, elsoSzam);
            }
            else if (harmadikSzam < elsoSzam && harmadikSzam < masodikSzam && masodikSzam < elsoSzam)
            {
                Console.Write("{0}, {1}, {2}", harmadikSzam, elsoSzam, masodikSzam);
            }
            else
            {
                Console.Write("Valamennyi szám egyenlő");
            }
        }
    }
}
