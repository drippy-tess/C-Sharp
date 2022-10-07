using System;

namespace Feladat_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int elsoSzog;
            int masodikSzog;
            int harmadikSzog;
            
            Console.Write("Kérem adja meg az első szöget:");
            elsoSzog = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg az második szöget:");
            masodikSzog = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a harmadik szöget:");
            harmadikSzog = Convert.ToInt32(Console.ReadLine());

            if ((elsoSzog == 90) || (masodikSzog == 90) || (harmadikSzog == 90))
            {
                Console.WriteLine("Derékszögű háromszög");
            }
            else
            {
                Console.WriteLine("Nem derékszögű");
            }
        }
    }
}
