using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seged
{
    internal class Orszag
    {
        public string Orszagnev { get; private set; }
        public int Terulet { get; private set; }
        public long Nepesseg { get; private set; }
        public string Fovaros { get; private set; }
        public int FovarosNepesseg { get; private set; }

        public Orszag(string orszagnev, int terulet, long nepesseg, string fovaros, int fovarosNepesseg)
        {
            Orszagnev = orszagnev;
            Terulet = terulet;
            Nepesseg = nepesseg;
            Fovaros = fovaros;
            FovarosNepesseg = fovarosNepesseg;
        }

        public override string ToString()
        {
            return $"{this.Orszagnev}: \nterulete: {this.Terulet}, \nnepessege: {this.Nepesseg} \nfovarosa: {this.Fovaros} \nfovaros nepessege: {this.FovarosNepesseg} \n------------------------";
        }
    }
}
