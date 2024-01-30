using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PizzafutarProjekt
{
    internal class Cim
    {
        private string nev;
        private string utca;
        private string hazszam;

        public Cim(string nev, string utca, string hazszam)
        {
            this.nev = nev;
            this.utca = utca;
            this.hazszam = hazszam;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Utca { get => utca; set => utca = value; }
        public string Hazszam { get => hazszam; set => hazszam = value; }
        public override string ToString()
        {
            return $" {this.nev} {this.utca} {this.hazszam}";
        }
    }
}
