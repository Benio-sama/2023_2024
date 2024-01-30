using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzafutarProjekt
{
    internal class Rendeles
    {
        private Pizza kaja;
        private Cim helyszin;
        private int db;
        private TimeSpan ido;

        public Rendeles(Pizza kaja, Cim helyszin, int db, TimeSpan ido)
        {
            this.kaja = kaja;
            this.helyszin = helyszin;
            this.db = db;
            this.ido = ido;
        }

        public int Db { get => db; set => db = value; }
        public TimeSpan Ido { get => ido; set => ido = value; }
        internal Pizza Kaja { get => kaja; set => kaja = value; }
        internal Cim Helyszin { get => helyszin; set => helyszin = value; }
        public override string ToString()
        {
            return $"{this.helyszin.Nev} {this.db} {this.kaja.Nev} {this.helyszin.Utca} {this.helyszin.Hazszam}";
        }
    }
}
