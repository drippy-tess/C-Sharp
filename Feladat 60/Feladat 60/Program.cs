int kijelentodarab = 0;
int kerdojelDarab = 0;
int felszolitoDarab = 0;
Console.Write("Kérem adjon meg egy mondatot: ");
string mondat = Console.ReadLine();

for(int i = 0; i < mondat.Length; i++)
{
    switch(mondat[i])
    {
        case '.': kijelentodarab++; break;
        case '!': felszolitoDarab++; break;
        case '?': kerdojelDarab++; break;
    }
}

Console.WriteLine($"Kijelentő mondatok száma: {kijelentodarab}\nFelszólító mondatok száma: {felszolitoDarab}\nKérdő mondatok száma: {kerdojelDarab}");
