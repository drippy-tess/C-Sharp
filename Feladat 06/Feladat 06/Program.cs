using System;

namespace Feladat_06
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Random vsz = new Random();
            int elsoSzam;
            int masodikSzam;
            double harmadikSzam;
            elsoSzam = vsz.Next(1, 80);
            masodikSzam = vsz.Next(1, 80);
            Console.WriteLine("Az első szám: {0}", elsoSzam);
            Console.WriteLine("Az második szám: {0}", masodikSzam);
            Console.WriteLine("\nAz első feladat eredménye: {0}", Math.Sqrt(Math.Pow((elsoSzam), 2)) + masodikSzam);

        }
    }
}
