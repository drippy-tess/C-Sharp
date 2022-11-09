string mondat;
string mondatford = "";
Console.WriteLine("Kérem a vizsgálandó mondatot!");
mondat = Console.ReadLine();
char[] irasjel = { '.', '!', '?', ';', ',', ' '};

mondat = mondat.Replace(" ", "");
mondat = mondat.Replace(",", "");
mondat = mondat.ToLower();
mondat = mondat.Trim(irasjel);
for(int i = mondat.Length - 1; i>=0; i--)
{
    mondatford = mondatford + mondat[i];
}
if(mondat.CompareTo(mondatford) == 0)
{
    Console.WriteLine("A mondat palindrom.");
}
else
{
    Console.WriteLine("A mondat nem palindrom");
}
