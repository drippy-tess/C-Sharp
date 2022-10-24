Console.Write("Kérem adja meg hány fős az osztály: ");
int letszam = Convert.ToInt32(Console.ReadLine());
int[] testmagassag = new int[letszam];
Random vsz = new Random();
int i;
int j;
int k;
int temp;
int random;
double magasak = 0;

for (i = 0; i < testmagassag.Length; i++)
{
    random = vsz.Next(150, 210);
    testmagassag[i] = random;
}

for (j = letszam - 1; j > 0; j--)
{
    for (k = 0; k < j; k++)
    {
        if (testmagassag[k] < testmagassag[k + 1])
        {
            temp = testmagassag[k];
            testmagassag[k] = testmagassag[k+ 1];
            testmagassag[k + 1] = temp;
        }
    }
}
Console.WriteLine("Az osztályba járó emberek magaassága:");
foreach(int l in testmagassag)
{
    Console.WriteLine(l);
    if (l < 190)
    {
        magasak++;
    }
}

Console.WriteLine($"A 190 cm-nél magasabb emberek aránya{magasak}fő / {letszam}fő {magasak/letszam*100}%");