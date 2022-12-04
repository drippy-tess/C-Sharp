int[,] t = new int[3, 5];
Random vsz = new Random();
Console.WriteLine("Rendezett kiíratás: ");
for (int i = 0; i < 3; i++)
{
    for(int k = 0; k < 5; k++)
    {
        t[i, k] = vsz.Next(1, 100);
        Console.Write(t[i, k] + "\t"); 
    }
    Console.WriteLine();
}
