using System;

namespace Feladat_47
{
    class Program
    {
        static void Main(string[] args)
        {
            int mennyiseg = 0;
            while (mennyiseg == 0)
            {
                Console.Write("Kérem adja meg hány csomaggal szeretne vásárolni: ");
                int temp = Convert.ToInt32(Console.ReadLine());
                if(temp > 0)
                {
                    mennyiseg = temp;
                }
                else 
                {
                    Console.WriteLine("A megadott szám nem megfelelő!");
                }
            }

            double ar = 5000 * mennyiseg;
            switch (mennyiseg)
            {
                case int n when ((n > 5) && (n <= 10)):
                        ar *= 0.95;
                        break;
                case int n when ((n > 10) && (n <= 20)):
                    ar *= 0.92;
                    break;
                case int n when ((n > 20)):
                    ar *= 0.905;
                    break;
                default:
                    Console.WriteLine("Nincs kedvezmény!");
                    break;
            }
            Console.WriteLine($"A fizetendő összeg: {ar}Ft.");
        }
    }
}
