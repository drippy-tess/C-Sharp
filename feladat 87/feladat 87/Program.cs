Random vsz = new Random();
int[,] etkezes = new int[7, 3];
int[] osszkal = {0, 0, 0, 0, 0, 0, 0};
for(int i = 0; i < 7; i++)
{
    for(int k = 0; k < 3; k++)
    {
        etkezes[i, k] = vsz.Next(500, 1500);
        Console.Write(etkezes[i, k] + "\t");
    }
    Console.WriteLine();
}
for(int i = 0; i < 7; i++)
{
    for(int k = 0; k < 3; k++)
    {
        osszkal[i] += etkezes[i, k];
    }
}
int max = osszkal.Max();
int napindex = 0;
for(int i = 0; i < 7; i++)
{
    if (osszkal[i] == max)
    {
        napindex = i;
    }
}
Console.WriteLine("A legnagyobb kalóriabevétel: " + (napindex + 1) + ". nap volt a héten");

double atlag = osszkal.Average();
Console.WriteLine("Az átlag kalória bevitel: {0}", Math.Round(atlag, 2));

int szamlalo = 0;
for(int i = 0; i < 7; i++)
{
    if (osszkal[i] > atlag)
    {
        szamlalo += 1;
    }
}
Console.WriteLine("Az átlagnál nagyobb kalória bevitelek száma: {0}", szamlalo);
int min = int.MaxValue;
for(int i = 0; i < 7; i++)
{
    if (etkezes[i, 1] < min)
    {
        min = etkezes[i, 1];
    }
}
Console.WriteLine("A legkisebb kalóriatartalmú ebéd: {0}", min);