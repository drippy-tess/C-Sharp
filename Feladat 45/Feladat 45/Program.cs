using System;

namespace Feladat_45
{
    class Program
    {
        static void Main(string[] args)
        {
            string honapNeve = "";
            Console.Write("Kérem adja meg az évet: ");
            int ev = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a hónapot: ");
            int honap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem adja meg a napot: ");
            int nap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kérem az pont értékét!");
            int ponthatar = Convert.ToInt32(Console.ReadLine());
            int temp = 0;

            switch(honap)
            if ((ponthatar >= 0) && (ponthatar <= 10))  { temp = 1; }
            if ((ponthatar >= 11) && (ponthatar <= 20)) { temp = 2; }
            if ((ponthatar >= 21) && (ponthatar <= 30)) { temp = 3; }
            if ((ponthatar >= 31) && (ponthatar <= 40)) { temp = 4; }
            if ((ponthatar >= 41) && (ponthatar <= 50)) { temp = 5; }
            
            switch (temp)
            {
                case 01:
                    honapNeve = "Január";
                case 1: Console.WriteLine("Elégtelen!");
                    break;
                case 02:
                    honapNeve = "Február";
                case 2:
                    Console.WriteLine("Elégséges!");
                    break;
                case 03:
                    honapNeve = "Március";
                case 3:
                    Console.WriteLine("Közepes!");
                    break;
                case 04:
                    honapNeve = "Április";
                    break;
                case 05:
                    honapNeve= "Május";
                    break;
                case 06:
                    honapNeve = "Június";
                    break;
                case 07:
                    honapNeve = "Július";
                    break;
                case 08:
                    honapNeve = "Augusztus";
                    break;
                case 09:
                    honapNeve = "Szeptember";
                    break;
                case 10:
                    honapNeve = "Október";
                    break;
                case 11:
                    honapNeve = "November";
                case 4:
                    Console.WriteLine("Jó!");
                    break;
                case 12:
                    honapNeve = "December";
                case 5:
                    Console.WriteLine("Kiváló!");
                    break;
                default:
                    Console.WriteLine("Nincs ilyen hónap!");
                default: Console.WriteLine("Nem jó a megadott jegy!");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ev}.{honapNeve} {nap}.");
        }
    }
}
