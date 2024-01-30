using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzafutarProjekt
{
    internal class Pizza
    {
        private string nev;
        private int meret;
        private int ar;

        public Pizza(string nev, int meret, int ar)
        {
            this.nev = nev;
            this.meret = meret;
            this.ar = ar;
        }

        public string Nev { get => nev; set => nev = value; }
        public int Meret { get => meret; set => meret = value; }
        public int Ar { get => ar; set => ar = value; }
        public override string ToString()
        {
            return $"{this.nev} {this.meret} {this.ar}";
        }
    }
}
