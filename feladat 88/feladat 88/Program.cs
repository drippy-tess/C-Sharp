int[] ertekek = new int[2];
int[,] tomb = new int[2, 2];
Console.WriteLine("Kérem adja meg a tömb értékeit: ");
for(int i = 0; i < 2; i++)
{
    ertekek[i] = Console.ReadLine();
}
for(int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
        Console.Write(tomb[i, j] + "\t");
    }
    Console.WriteLine();
}