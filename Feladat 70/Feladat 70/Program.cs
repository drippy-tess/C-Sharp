int szam = 0;
int temp;

while(szam == 0)
{
    Console.Write("Kérem adjon meg egy háromjegyű számot: ");
    temp = Convert.ToInt32(Console.ReadLine());
    if(temp > 99 && temp <= 999)
    {
        szam = temp;
    }
    else
    {
        Console.WriteLine("helytelen bemenet!");
    }
}

if(szam % 7 == 0)
{
    Console.WriteLine("A megadott szám osztható héttel.");
}
else
{
    Console.WriteLine("A megadott szám nem osztható héttel.");
}