int[] elsoJatekos = new int[3];
int[] masodikJatekos = new int[3];
int[] harmadikJatekos = new int[3];
int[] negyedikJatekos = new int[3];
Random vsz = new Random();
float legnagyobbAtlag = 0;

for (int i = 0; i < 3; i++)
{
    elsoJatekos[i] = vsz.Next(1, 100);
    masodikJatekos[i] = vsz.Next(1, 100);
    harmadikJatekos[i] = vsz.Next(1, 100);
    negyedikJatekos[i] = vsz.Next(1, 100);
}
for (int k = 2; k > 0; k--)
{
    for (int m = 0; m < k; m++)
    {
    if (elsoJatekos[m] > elsoJatekos[m + 1])
    {
        int temp = elsoJatekos[m];
        masodikJatekos[m] = masodikJatekos[m + 1];
        masodikJatekos[m + 1] = temp;
    }
    }
}

for (int k = 2; k > 0; k--)
{
    for (int m = 0; m < k; m++)
    {
        if (elsoJatekos[m] > elsoJatekos[m + 1])
        {
            int temp = elsoJatekos[m];
            elsoJatekos[m] = elsoJatekos[m + 1];
            elsoJatekos[m + 1] = temp;
        }
        if (masodikJatekos[m] > masodikJatekos[m + 1])
        {
            int temp = elsoJatekos[m];
            masodikJatekos[m] = masodikJatekos[m + 1];
            masodikJatekos[m + 1] = temp;
        }
        if (harmadikJatekos[m] > harmadikJatekos[m + 1])
        {
            int temp = elsoJatekos[m];
            harmadikJatekos[m] = harmadikJatekos[m + 1];
            harmadikJatekos[m + 1] = temp;
        }
        if (negyedikJatekos[m] > negyedikJatekos[m + 1])
        {
            int temp = elsoJatekos[m];
            negyedikJatekos[m] = negyedikJatekos[m + 1];
            negyedikJatekos[m + 1] = temp;
        }
    }
}

float[] legjobb = new float[4] { elsoJatekos[2], masodikJatekos[2], harmadikJatekos[2], negyedikJatekos[2]};

for (int j = 0; j < 4; j++)
{
    legjobb[j] += legnagyobbAtlag;
}

Console.WriteLine($"A legnagyobb számok átlaga: {legnagyobbAtlag / 5}");