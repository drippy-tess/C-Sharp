string mondat;
Console.Write("Kérem gépeljen be egy mondatot: ");
mondat = Console.ReadLine();

string[] tordelt = mondat.Split(' ');
int max = tordelt[0].Length;

for (int i = 1; i < tordelt.Length; i++)
{
    if (tordelt[i].Length > max)
    {
        max = tordelt[i].Length;
    }
}

Console.WriteLine($"A leghosszabb szó hossza: {max} karakter.");