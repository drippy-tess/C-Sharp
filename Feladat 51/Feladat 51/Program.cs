string szo;
string szoford = "";
Console.Write("Kérem adja meg a vizsgálandó szót: ");
szo = Console.ReadLine();
for(int i = szo.Length -1; i >= 0; i--)
{
    szoford = szoford + szo[i];
}
if(szo.CompareTo(szoford) == 0)
{
    Console.WriteLine("A szó palindrom.");
}
else
{
    Console.WriteLine("A szó nem palindrom.");
}