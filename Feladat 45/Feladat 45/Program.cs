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

            switch(honap)
            {
                case 01:
                    honapNeve = "Január";
                    break;
                case 02:
                    honapNeve = "Február";
                    break;
                case 03:
                    honapNeve = "Március";
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
                    break;
                case 12:
                    honapNeve = "December";
                    break;
                default:
                    Console.WriteLine("Nincs ilyen hónap!");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{ev}.{honapNeve} {nap}.");
        }
    }
}
