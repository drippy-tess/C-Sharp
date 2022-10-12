using System;

namespace Feladat_41
{
    class Program
    {
        static void Main(string[] args)
        {
            int kezdo;
            int veg;
            int csere;
            int db = 0;
            int i;

            Console.Write("Kérem az intervallum kezdőértékét:");
            kezdo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem az intervallum végértékét:");
            veg = Convert.ToInt32(Console.ReadLine());
            if(kezdo > veg)
            {
                csere = kezdo;
                kezdo = veg;
                veg = csere;
            }
            i = kezdo;
            while(i <= veg)
            {
                if(i % 3 == 0)
                { 
                db++;
                }
                i++;
            }
            Console.WriteLine("A hárommal oszthatóak dadabszáma:{0}", db);
        }
    }
}
