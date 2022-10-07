using System;

namespace Feladat_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            Console.WriteLine("Kérem adjon meg egy számot!");
            szam = Convert.ToInt32(Console.Read());
            if (szam > 0)
            {
                Console.WriteLine("Pozitív");
            }else if (szam == 0)
            {
                Console.WriteLine("A szám 0.");
            }else
            {
                Console.WriteLine("Negatív");
            }
        }
    }
}
