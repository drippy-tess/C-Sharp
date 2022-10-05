using System;

namespace Feladat_33
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] kar = new char[5];
            int i;
            int db = 0;

            Console.WriteLine("Kérek 5 karaktert!");
            for (i = 0; i < 5; i++)
            {
                kar[i] = Convert.ToChar(Console.ReadLine());
                if (kar[i] == 'a' || kar[i] == 'A')
                {
                    db++;
                }
            }
            Console.WriteLine("A darabszám: {0}", db);
            if (db > 0)
            {
                Console.WriteLine("Van a vizsgált karakter a tömbben.");
            }
            else
            {
                Console.WriteLine("Nincs a vizsgált karakter a tömbben.");
            }
        }
    }
}
