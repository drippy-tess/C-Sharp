int[,] t = new int[4, 6];
Random vsz = new Random();
//int[] sorosszeg = new int[4];
int[] sorosszeg = { 0, 0, 0, 0 };
for (int i = 0; i < 4; i++)
{
    for(int k = 0; k < 6; k++)
    {
        t[i, k] = vsz.Next(100, 500);
        sorosszeg[i] += t[i, k];
        Console.Write(t[i, k] + "\t");
    }
    Console.WriteLine();
}
Array.Sort(sorosszeg);
Console.WriteLine("A sorok összegei: ");
for(int j = 0; j < 4; j++)
{
    Console.WriteLine(sorosszeg[j]);
}
