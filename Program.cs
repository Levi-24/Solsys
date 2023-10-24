using Solsys;

List<Planet> planets = new List<Planet>();
using (var sr = new StreamReader(@"..\..\..\src\solsys.txt"))
{
    sr.ReadLine();
    while (!sr.EndOfStream)
    {
        planets.Add(new Planet(sr.ReadLine()));
    }
}

Console.WriteLine(planets.Count);