using System;

namespace Feladat_46
{
    class Program
    {
        static void Main(string[] args)
        {
            double fizetendo = 0;
            Console.Write("Kérem adja meg milyen távolságra utazik: ");
            int tavolsag = Convert.ToInt32(Console.ReadLine());

            switch (tavolsag)
            {
                case int n when n <= 50:
                    fizetendo = 700;
                    break;
                case int n when (n > 50) && (n <= 150):
                    fizetendo = 1300;
                    break;
                case int n when (n > 150) && (n <= 250):
                    fizetendo = 2800;
                    break;
                case int n when (n > 250) && (n <= 350):
                    fizetendo = 3200;
                    break;
                case int n when (n > 350) && (n <= 400):
                    fizetendo = 4100;
                    break;
                case int n when (n > 400) && (n <= 450):
                    fizetendo = 4800;
                    break;
                case int n when (n > 450) && (n <= 500):
                    fizetendo = 5400;
                    break;
                default:
                    Console.WriteLine("Ilyen messzire nem utazhat!");
                    break;
            }

            Console.WriteLine("Milyen kedvezményben részesül?");
            string kedvezmeny = Convert.ToString(Console.ReadLine());
            switch(kedvezmeny)
            {
                case string n when (n == "rokkantnyugdíjas" || n == "katona"):
                    fizetendo *= 0.1;
                    break;
                case string n when (n == "diák"):
                    fizetendo *= 0.325;
                    break;
                case string n when (n == "közalkalmazott"):
                    fizetendo *= 0.5;
                    break;
                case string n when (n == "26 év alatti"):
                    fizetendo *= 0.7;
                    break;
                default:
                    break;

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Az ön vonatjegye: {fizetendo}Ft-ba kerül.");
            Console.ResetColor();
        }

    }
}
