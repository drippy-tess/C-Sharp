int diak;
Console.WriteLine("Kérem adja meg a diákok számát: ");
diak = Convert.ToInt32(Console.ReadLine());
char[,] valaszok = new char[diak, 5];
char[] helyes = { 'a', 'b', 'c', 'a', 'c' };
int[] helyesdb = new int[diak];
Console.WriteLine("Kérem a diákok válaszait!");
for(int i = 0; i < diak; i++)
{
    for(int k = 0 ; k < 5 ; k++)
    {
        valaszok[i, k] = Convert.ToChar(Console.ReadLine());
    }
}
for (int i = 0; i < diak; i++)
{
    for (int k = 0; k < 5; k++)
    {
        Console.WriteLine(valaszok[i, k] + "\t");
    }
    Console.WriteLine();
}
for (int i = 0; i < diak; i++)
{
    for(int k = 0; k < 5; k++)
    {
        if (valaszok[i, k] == helyes[k])
        {
            helyesdb[k]++;
        }
    }
}
int max = helyesdb.Max();
int maxindex = 0;
for(int i = 0; i < diak; i++)
{
    if (helyesdb[i] == max)
    {
        maxindex = i;
    }
}
Console.WriteLine("A legtöbb helyes válasz: {0}", max);
Console.WriteLine("A legtöbb helyes választ adó diák indexe: {0}", maxindex + 1);