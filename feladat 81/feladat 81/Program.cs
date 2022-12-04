int sor;
int oszlop;
Random vsz = new Random();
int osszeg = 0;
Console.WriteLine("Kére ajda meg hogy hány sor legyen: ");
sor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kére ajda meg hogy hány oszlop legyen: ");
oszlop = Convert.ToInt32(Console.ReadLine());
int[,] t = new int[sor, oszlop];
for(int i = 0;i < sor; i++)
{
    for(int k = 0; k < oszlop; k++)
    {
        t[i, k] = vsz.Next(100, 500);
        osszeg += t[i, k];
        Console.Write(t[i, k] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Összeg: {0}", osszeg);