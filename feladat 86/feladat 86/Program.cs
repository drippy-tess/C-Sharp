int diakszam;
Console.WriteLine("Kérem adja meg a diákok számát: ");
diakszam = Convert.ToInt32(Console.ReadLine());
double[,] jegyek = new double[diakszam, 5];
string[] nevek = new string[diakszam];
double[] atlag = new double[diakszam];
double osszeg = 0;
Console.WriteLine("Kérem adja meg a diákok nevét: ");
for(int i = 0; i < diakszam; i++)
{
    nevek[i] = Console.ReadLine();
}
for (int i = 0; i < diakszam; i++)
{
    for (int k = 0; k < diakszam; k++)
    {
        jegyek[i, k] = Convert.ToDouble(Console.ReadLine());
        osszeg += jegyek[i, k];
    }
    atlag[i] = osszeg / 5;
    osszeg = 0;
}
for (int i = 0; i < diakszam; i++)
{
    Console.Write(nevek[i] + "\t");
    for (int k = 0; k < diakszam; k++)
    {
        Console.Write(jegyek[i, k] + "\t");
    }
    Console.WriteLine();
}
double max = atlag.Max();
string maxnev = "";
for(int i = 0;i<diakszam; i++)
{
    if (atlag[i] == max)
    {
        maxnev = nevek[i];
    }
}
Console.WriteLine("A legjobb átlagú diák:" + maxnev);
Console.WriteLine("A legjobb áltag: {0}", max);