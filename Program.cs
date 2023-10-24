using Solsys;

List<Planet> planets = new List<Planet>();
using (var sr = new StreamReader(@"..\..\..\src\solsys.txt"))
{
    while (!sr.EndOfStream)
    {
        planets.Add(new Planet(sr.ReadLine()));
    }
}

Console.WriteLine($"3.1: {planets.Count} bolygó van a naprendszerben");

Console.WriteLine($"3.2: A naprendszerben egy bolygónak átlagosan {planets.Average(p => p.HoldSzam)} holdja van.");

var legnagyobbTerfogat = planets.OrderBy(p => p.TerfogatArany).Last();
Console.WriteLine($"3.3: A legnagyobb terfogatú bolygó a {legnagyobbTerfogat.Nev}.");

Console.Write("3.4: Írd be a keresett bolygó nevét: ");
string bekertNev = Console.ReadLine();

if (planets.Any(p => p.Nev == bekertNev))
    Console.WriteLine("\tVan ilyen bolygó a naprendszerben!");
else
    Console.WriteLine("\tSajnos nincs ilyen bolygó a naprendszerben!");

Console.Write("3.5: Írj be egy egész számot: ");
int holdSzam = Convert.ToInt32(Console.ReadLine());
var tobbHold = new List <string>();

foreach (var planet in planets)
{
    if (planet.HoldSzam > holdSzam)
        tobbHold.Add(planet.Nev);
}

Console.WriteLine($"\tA következő bolygóknak van {holdSzam}-nál/nél több holdja:");
foreach (var planet in tobbHold)
    Console.WriteLine($"\t{planet}");