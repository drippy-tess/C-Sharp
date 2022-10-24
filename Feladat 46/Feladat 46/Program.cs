using System;

namespace Feladat_46
{
    class Program
    {
        static void Main(string[] args)
        {
            int fizetendo = 0;
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
            }
        }
    }
}
