float[] elsoUgras = new float[5];
float[] masodikUgras = new float[5];
float[] harmadikUgras = new float[5];
float[] ugrasOsszeg = new float[5];
Random vsz = new Random();
int ervenytelen = 0;
int elsoIndex = 0;
int masodikIndex = 0;
int harmadikIndex = 0;
int negyedikIndex = 0;
int otodikIndex = 0;
int kiestek = 0;

for (int i = 0; i < 5; i++)
{
    elsoUgras[i] = vsz.Next(0,5) + vsz.NextSingle();
    masodikUgras[i] = vsz.Next(0, 5) + vsz.NextSingle();
    harmadikUgras[i] = vsz.Next(0, 5) + vsz.NextSingle();
}

for (int j = 0; j < 5; j++)
{
    if (elsoUgras[j] == 0)
    {
        ervenytelen++;
        switch (j)
        {
            case 0:
                elsoIndex++;
                break;
            case 1:
                masodikIndex++;
                break;
            case 2:
                harmadikIndex++;
                break;
            case 3:
                negyedikIndex++;
                break;
            default:
                otodikIndex++;
                break;
        }

    }
    if (masodikUgras[j] == 0)
    {
        ervenytelen++;
        switch (j)
        {
            case 0:
                elsoIndex++;
                break;
            case 1:
                masodikIndex++;
                break;
            case 2:
                harmadikIndex++;
                break;
            case 3:
                negyedikIndex++;
                break;
            default:
                otodikIndex++;
                break;
        }
    }
    if (harmadikUgras[j] == 0)
    {
        ervenytelen++;
        switch (j)
        {
            case 0:
                elsoIndex++;
                break;
            case 1:
                masodikIndex++;
                break;
            case 2:
                harmadikIndex++;
                break;
            case 3:
                negyedikIndex++;
                break;
            default:
                otodikIndex++;
                break;
        }
    }
}

if(elsoIndex > 1)
{
    kiestek++;
}
if (masodikIndex > 1)
{
    kiestek++;
}
if (harmadikIndex > 1)
{
    kiestek++;
}
if (negyedikIndex > 1)
{
    kiestek++;
}
if (otodikIndex > 1)
{
    kiestek++;
}

for (int l = 0; l < 5; l++)
{
    ugrasOsszeg[l] = elsoUgras[l] + masodikUgras[l] + harmadikUgras[l];
}

for (int k = 4; k > 0; k--)
{
    for (int m = 0; m < k; m++)
    {
        if (ugrasOsszeg[m] > ugrasOsszeg[m + 1])
        {
            float temp = ugrasOsszeg[m];
            ugrasOsszeg[m] = ugrasOsszeg[m + 1];
            ugrasOsszeg[m + 1] = temp;
        }
    }
}

Console.Write($"{ervenytelen/15*100}%-ban voltak sikertelen ugrások\nA versenyből kiestek: {kiestek}\nElső helyezett ugrásai: {ugrasOsszeg[4]}");