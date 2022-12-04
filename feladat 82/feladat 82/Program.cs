Random vsz = new Random();
int sor;
int oszlop;
Console.WriteLine("Kérem adja meg a sorok számát: ");
sor = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Kérem adja meg az oszlopok számát: ");
oszlop = Convert.ToInt32(Console.ReadLine());
int[,] t = new int[sor, oszlop];
for(int i = 0; i < sor; i++)
{
    for(int k = 0; k < sor; k++)
    {
        if(i == k)
        {
            t[i, k] = vsz.Next(1, 20);
        }
        else
        {
            t[i, k] = vsz.Next(100, 500);
        }
        Console.Write(t[i, k] + "\t");
    }
    Console.WriteLine();
}