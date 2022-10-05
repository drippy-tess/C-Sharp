using System;

namespace Feladat_07
{
    class Program
    {
        static void Main(string[] args)
        {
            double elsoSzam;
            elsoSzam = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("A feladat eredménye: {0}", Math.Pow((elsoSzam), 4) / Math.PI);
        }
    }
}
