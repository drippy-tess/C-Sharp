using System;

namespace Feladat_49
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem adja meg a fizetését:");
            int fizetes = Convert.ToInt32(Console.ReadLine());

            switch(fizetes)
            {
                case int n when (n < 150000):
                    Console.WriteLine("Túl alacsony.");
                    break;
                case int n when ((n < 180000) && (n >= 150000)):
                    Console.WriteLine("Alacsony.");
                    break;
                case int n when ((n < 250000) && (n >= 180000)):
                    Console.WriteLine("Megfelelő.");
                    break;
                case int n when (n >= 250000):
                    Console.WriteLine("Kiváló.");
                    break;
                default:
                    break;
            }
        }
    }
}
