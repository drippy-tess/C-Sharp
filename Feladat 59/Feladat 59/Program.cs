Console.Write("Kérem gépeljen be mondatokat: ");
string mondatok = Console.ReadLine();
int mondatSzam = 0;

for(int i = 0; i < mondatok.Length; i++)
{
    if ((mondatok[i]) == '.' || (mondatok[i] == '!') || (mondatok[i] == '?'))
    {
        mondatSzam++;
    }
}

Console.WriteLine($"A mondatok száma: {mondatSzam}db");
