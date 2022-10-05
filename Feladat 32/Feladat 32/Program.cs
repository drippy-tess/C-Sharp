using System;

namespace Feladat_32
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int[] tomb = new int[7];
            Random vsz = new Random();
            //bool vane = false;
            int darabszam = 0;

            for (i = 0; i < tomb.Length; i++)
            {
                tomb[i] = vsz.Next(0, 500);
                Console.WriteLine(tomb[i]);
                if(tomb[i] % 5 == 0)
                {
                    //vane = true;
                    darabszam++;
                }
            }
            Console.WriteLine("Az öttel oszthatóak száma: {0}", darabszam);
            /*if (vane == true)
            {
                Console.WriteLine("Van öttel oszható érték");
            }
            else {
                Console.WriteLine("Van öttel osztható érték");*/
            }
        }
    }

