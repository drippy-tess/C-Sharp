using System;

namespace Feladat_45
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kérem az pont értékét!");
            int ponthatar = Convert.ToInt32(Console.ReadLine());
            int temp = 0;

            if ((ponthatar >= 0) && (ponthatar <= 10))  { temp = 1; }
            if ((ponthatar >= 11) && (ponthatar <= 20)) { temp = 2; }
            if ((ponthatar >= 21) && (ponthatar <= 30)) { temp = 3; }
            if ((ponthatar >= 31) && (ponthatar <= 40)) { temp = 4; }
            if ((ponthatar >= 41) && (ponthatar <= 50)) { temp = 5; }
            
            switch (temp)
            {
                case 1: Console.WriteLine("Elégtelen!");
                    break;
                case 2:
                    Console.WriteLine("Elégséges!");
                    break;
                case 3:
                    Console.WriteLine("Közepes!");
                    break;
                case 4:
                    Console.WriteLine("Jó!");
                    break;
                case 5:
                    Console.WriteLine("Kiváló!");
                    break;
                default: Console.WriteLine("Nem jó a megadott jegy!");
                    break;
            }
        }
    }
}
