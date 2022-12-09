Console.Write("Kérem adjon meg egy nevet: ");
string nev = Console.ReadLine();
string[] kettos = { "Cs", "Dz", "Gy", "Sz", "Zs" };
string[] nevek = nev.Split(' ');
string monogram = nevek[0].Substring(0, 1);
if (kettos.Contains(nevek[1].Substring(0, 2)))
{
    monogram += nevek[1].Substring(0, 2);
}
else
{
    monogram += nevek[1].Substring(0, 1); 
}

Console.WriteLine($"A monogram: {monogram}");