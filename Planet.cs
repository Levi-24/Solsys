using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solsys
{
    internal class Planet
    {
        public string Nev { get; set; }
        public int HoldSzam { get; set; }
        public float TerfogatArany { get; set; }

        public Planet(string sor)
        {
            sor = sor.Replace('.', ',');
            var darabok = sor.Split(';');
            this.Nev = darabok[0];
            this.HoldSzam = int.Parse(darabok[1]);
            this.TerfogatArany = float.Parse(darabok[2]);
        }
    }
}
