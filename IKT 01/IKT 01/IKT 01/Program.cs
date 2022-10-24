Random vsz = new Random();
int[] kockadobasok = new int[50];
int i;
double egyesek = 0;
double kettesek = 0;
double harmasok = 0;
double negyesek = 0;
double otosok = 0;
double hatosok = 0;

for (i = 0; i < 50; i++)
{
    int random = vsz.Next(1, 6);
    kockadobasok[i] = random;
    switch(random) 
    {
        case 1:
            egyesek++;
            break;
        case 2:
            kettesek++;
            break;
        case 3:
            harmasok++;
            break;
        case 4:
            negyesek++;
            break; 
        case 5:
            otosok++;
            break;
        case 6:
            hatosok++;
            break;
        default:
            break;
    }
}

Console.WriteLine($"Egyes dobások: {egyesek}db\t{(egyesek / 50)*100}%\nKettes dobások: {kettesek}db\t{(kettesek / 50)*100}%\nHármas dobások: {harmasok}db\t{(harmasok / 50)*100}%\nNégyes dobások: {negyesek}db\t{(negyesek / 50)*100}%\nÖtös dobások: {otosok}db\t{(otosok / 50)*100}%\nHatos dobások: {hatosok}db\t{(hatosok / 50)*100}%");

