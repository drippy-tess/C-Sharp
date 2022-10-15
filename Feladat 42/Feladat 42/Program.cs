using System;

namespace Feladat_42
{
    class Program
    {
        static void Main(string[] args)
        {
            int temp;
            int eletkor = 0;

            while(eletkor == 0)
            {
                Console.WriteLine("Kérem adja meg az életkorát!");
                temp = Convert.ToInt32(Console.ReadLine());
                if((temp >= 0) && (temp <= 99))
                {
                    eletkor = temp;
                }
            }
            if((eletkor >= 0) && (eletkor <=6))
            {
                Console.Write("A felhasználó gyermek!");
            }
            else if(eletkor >= 7 && eletkor <= 18)
            {
                Console.Write("A felhasználó iskolás!");
            }
            else if(eletkor >= 19 && eletkor <= 65)
            {
                Console.Write("A felhasználó dolgozó!");
            }
            else if(eletkor >= 66)
            {
                Console.Write("A felhasználó nyugdíjas!");
            }
        }
    }
}
