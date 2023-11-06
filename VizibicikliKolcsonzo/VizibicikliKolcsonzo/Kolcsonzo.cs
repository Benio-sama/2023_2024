using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizibicikliKolcsonzo
{
    internal class Kolcsonzo
    {
        private string nev;
        private string azon;
        private int eora;
        private int eperc;
        private int vora;
        private int vperc;

        public Kolcsonzo(string nev, string azon, int eora, int eperc, int vora, int vperc)
        {
            this.nev = nev;
            this.azon = azon;
            this.eora = eora;
            this.eperc = eperc;
            this.vora = vora;
            this.vperc = vperc;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Azon { get => azon; set => azon = value; }
        public int Eora { get => eora; set => eora = value; }
        public int Eperc { get => eperc; set => eperc = value; }
        public int Vora { get => vora; set => vora = value; }
        public int Vperc { get => vperc; set => vperc = value; }
        public override string ToString()
        {
            return $"{this.nev}: ({this.azon}) {this.eora}:{this.eperc} - {this.vora}:{this.vperc}";
        }
    }
}
