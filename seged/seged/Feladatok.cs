using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seged
{
    internal class Feladatok
    {
        private List<Orszag> orszagok = new List<Orszag>();

        internal List<Orszag> Orszagok { get => orszagok; set => orszagok = value; }

        public void Beolvas(string fajl)
        {
            using (StreamReader sr = new StreamReader(fajl))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] sorok = sor.Split(';');
                    string nev = sorok[0];
                    int terulet = int.Parse(sorok[1]);
                    string nepesseg = sorok[2];
                    long nep;
                    if (nepesseg[nepesseg.Length - 1].Equals('g'))
                    {
                        sorok[2] = sorok[2].Remove(sorok[2].Length - 1);
                        nep = long.Parse(sorok[2]);
                        nep *= 10000;
                    }
                    else
                    {
                        nep = long.Parse(sorok[2]);
                    }
                    string fovaros = sorok[3];
                    int fovnep = int.Parse(sorok[4]);
                    Orszag o = new Orszag(nev, terulet, nep, fovaros, fovnep);
                    orszagok.Add(o);
                }
                foreach (var item in orszagok)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
