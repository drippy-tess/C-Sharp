Random vsz = new Random();
int[] lotto = new int[5];
int szamlalo = 0;
int szamlalas = 0;
int jo = 0;
int talalatokSzama = 0;
int felhasznaloiSzam;
int j;
int randomSzam;

while(szamlalo < 5)
{
    randomSzam = vsz.Next(1, 90);
    foreach (int i in lotto)
    {
        if (i != randomSzam)
        {
            szamlalas++;
            jo++;
            if ((szamlalas == 5) && (jo == 5)) {break;}
        }
        else {szamlalas++;}
    }
    lotto[szamlalo] = randomSzam;
    szamlalo++;
}

for(j = 0; j < 5; j++)
{
    Console.Write("Kérem adja meg a tippjeit:");
    felhasznaloiSzam = Convert.ToInt32(Console.ReadLine());
    foreach (int k in lotto)
    {
        if (k == felhasznaloiSzam)
        {
            talalatokSzama++;
        }
    }
}
Console.WriteLine($"A felhasználó által eltalált számok: {talalatokSzama}");
Console.WriteLine("A lottóhúzás eredményei:");
foreach (int l in lotto)
{ Console.WriteLine(l);}