string mondat;
string szo;
Console.Write("Kérem gépeljen be egy mondatot: ");
mondat = Console.ReadLine();
Console.Write("Kérem adjon meg egy szót: ");
szo = Console.ReadLine();

if(mondat.IndexOf(szo) != -1)
{
    Console.WriteLine("A szó szerepel a mondtaban.");
}
else
{
    Console.WriteLine("A szó nem szerepel a mondtaban.");
}