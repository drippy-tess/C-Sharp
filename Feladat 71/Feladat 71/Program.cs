
int szam = 1;
int negativ = 0;
int pozitiv = 0;

while(szam != 0)
{
    Console.Write("Kérem adjon meg egy számot: ");
    szam = Convert.ToInt32(Console.ReadLine());
    if (szam < 0)
    {
        negativ++;
    }

    else
    {
        pozitiv++;
    }
}

Console.WriteLine($"A megadott szám elérte a nullát!\n{negativ}db negatív számot, és {pozitiv}db pozitív számot adott meg.");
