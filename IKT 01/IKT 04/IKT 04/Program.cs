int[] kod = new int[20];
int[] ar = new int[20];
Random vsz = new Random();
int randomKod;
int randomAr;
int tartosElelmiszer = 0;
int ruhazat = 0;
int takaritoszerek = 0;
int tisztalkoddasiSzerek = 0;
int legolcsobb = 10000;
int legdragabb = 0;
int legolcsobbIndex = 0;
int legdragabbIndex = 0;
int osszesen = 0;
double atlag;
int atlagfelett = 0;

for (int i = 0; i < 20; i++)
{
    randomKod = vsz.Next(10, 49);
    kod[i] = randomKod;
    randomAr = vsz.Next(100, 10000);
    ar[i] = randomAr;
    osszesen += randomAr;

    switch (randomKod)
    {
        case int k when ((k > 9) && (k < 20)):
            tartosElelmiszer++;
            break;
        case int k when ((k > 19) && (k < 30)):
            ruhazat++;
            break;
        case int k when ((k > 29) && (k < 40)):
            takaritoszerek++;
            break;
        case int k when ((k > 39) && (k < 50)):
            tisztalkoddasiSzerek++;
            break;
        default:
            break;
    }

    if (randomAr > legdragabb)
    {
        legdragabb = randomAr;
        legdragabbIndex = i;
    }
}

atlag = osszesen / 20;

for (int j = 0; j < 20; j++)
{
    if (ar[j] < legolcsobb)
    {
        legolcsobb = ar[j];
        legolcsobbIndex = j;
    }
    if (ar[j] > atlag)
    {
        atlagfelett++;
    }
}

Console.WriteLine($"Tartós élelmiszer: {tartosElelmiszer}db\nRuházat: {ruhazat}db\nTakarítószerek: {takaritoszerek}db\nTisztálkodási szerek: {tisztalkoddasiSzerek}db");
Console.Write($"A legolcsóbb termék ára: {legolcsobb}Ft\tKategóriája: ");
switch(kod[legolcsobbIndex])
{
    case int l when ((l > 9) && (l < 20)):
        Console.WriteLine("Tartós élelmistzer");
        break;
    case int l when ((l > 19) && (l < 30)):
        Console.WriteLine("Ruházati termék");
        break;
    case int l when ((l > 29) && (l < 40)):
        Console.WriteLine("Takarítószer");
        break;
    case int l when ((l > 39) && (l < 50)):
        Console.WriteLine("Tisztálkodási szer");
        break;
    default:
        break;
}
Console.Write($"A legdrágább termék ára:{legdragabb}Ft\tKategóriája: ");
switch (kod[legdragabbIndex])
{
    case int m when ((m > 9) && (m < 20)):
        Console.WriteLine("Tartós élelmistzer");
        break;
    case int m when ((m > 19) && (m < 30)):
        Console.WriteLine("Ruházati termék");
        break;
    case int m when ((m > 29) && (m < 40)):
        Console.WriteLine("Takarítószer");
        break;
    case int m when ((m > 39) && (m < 50)):
        Console.WriteLine("Tisztálkodási szer");
        break;
    default:
        break;
}
Console.WriteLine($"A termékek átlagára: {atlag}Ft, {atlagfelett}db termék van az átlagár felett.");