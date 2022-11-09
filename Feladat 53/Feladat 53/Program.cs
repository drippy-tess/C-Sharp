string nev;
Console.Write("Kérem adja meg a nevét: ");
nev = Console.ReadLine();
string[] tordelt = nev.Split(" ");

Console.WriteLine("A keresztnév hossza: " + tordelt[1].Length);