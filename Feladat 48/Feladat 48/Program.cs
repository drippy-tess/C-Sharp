using System;

namespace Feladat_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem dobjon kétszer: ");
            int elsoDobas = Convert.ToInt32(Console.ReadLine());
            int masodikDobas = Convert.ToInt32(Console.ReadLine());
            int osszes = 0;
            switch(elsoDobas)
            {
                case int n when (n == 1):
                    osszes += 1000;
                    break;
                case int n when (n == 2):
                    osszes -= 1000;
                    break;
                case int n when (n == 3):
                    osszes += 500;
                    break;
                case int n when (n == 4):
                    osszes -= 4000;
                    break;
                case int n when (n == 5):
                    osszes += 5000;
                    break;
                case int n when (n == 6):
                    osszes += 10000;
                    break;
                default:
                    break;
            }

            switch (masodikDobas)
            {
                case int n when (n == 1):
                    osszes += 1000;
                    break;
                case int n when (n == 2):
                    osszes -= 1000;
                    break;
                case int n when (n == 3):
                    osszes += 500;
                    break;
                case int n when (n == 4):
                    osszes -= 4000;
                    break;
                case int n when (n == 5):
                    osszes += 5000;
                    break;
                case int n when (n == 6):
                    osszes += 10000;
                    break;
                default:
                    break;
            }

            Console.WriteLine($"Összesen {osszes}Ft-ot nyert.");
        }
    }
}
