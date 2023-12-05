using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utasszallitok
{
    internal class Repulo
    {
        private string tipus;
        private int ev;
        private string utas;
        private string szemelyzet;
        private int sebesseg;
        private int tomeg;
        private double fesztav;

        public Repulo(string tipus, int ev, string utas, string szemelyzet, int sebesseg, int tomeg, double fesztav)
        {
            this.tipus = tipus;
            this.ev = ev;
            this.utas = utas;
            this.szemelyzet = szemelyzet;
            this.sebesseg = sebesseg;
            this.tomeg = tomeg;
            this.fesztav = fesztav;
        }

        public string Tipus { get => tipus; set => tipus = value; }
        public int Ev { get => ev; set => ev = value; }
        public string Utas { get => utas; set => utas = value; }
        public string Szemelyzet { get => szemelyzet; set => szemelyzet = value; }
        public int Sebesseg { get => sebesseg; set => sebesseg = value; }
        public int Tomeg { get => tomeg; set => tomeg = value; }
        public double Fesztav { get => fesztav; set => fesztav = value; }
        public override string ToString()
        {
            return $"Tipus: {this.tipus} \nElso felszallas: {this.ev} \nUtasok szama: {this.utas} \nSzemelyzet: {this.szemelyzet} \nUtazosebesseg: {this.sebesseg} km/h \nFesztav: {this.fesztav}";
        }
    }
}
