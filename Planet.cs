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
        public double TerfogatArany { get; set; }

        public Planet(string sor)
        {
            var darabok = sor.Split(';');
            this.Nev = darabok[0];
            this.HoldSzam = int.Parse(darabok[1]);
            this.TerfogatArany = Convert.ToDouble(darabok[2]);
        }
    }
}
