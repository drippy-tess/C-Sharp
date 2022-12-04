int[,] t = new int[10, 10];
int min = int.MaxValue;
Random vsz = new Random();
for (int i = 0; i < 10; i++)
{
    for(int k = 0; k < 10; k++)
    {
        t[i, k] = vsz.Next(50, 100);
        Console.Write(t[i, k] + "\t");
    }
    Console.WriteLine();
}
for(int i = 0; i < 10; i++)
{
    for(int k = 0; k < 10; k++)
    {
        if (t[k, i] < min)
        {
            min = t[i, k];
        }
    }
    Console.WriteLine("Minimum értékek: {0}", min + "\t");
}