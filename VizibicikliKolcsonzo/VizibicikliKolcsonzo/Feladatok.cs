using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting.Messaging;

namespace VizibicikliKolcsonzo
{
    internal class Feladatok
    {
        private List<Kolcsonzo> kolcson = new List<Kolcsonzo>();

        internal List<Kolcsonzo> Kolcson { get => kolcson; set => kolcson = value; }

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
                    string azon = sorok[1];
                    int ora1 = int.Parse(sorok[2]);
                    int perc1 = int.Parse(sorok[3]);
                    int ora2 = int.Parse(sorok[4]);
                    int perc2 = int.Parse(sorok[5]);
                    Kolcsonzo k = new Kolcsonzo(nev, azon, ora1, perc1, ora2, perc2);
                    kolcson.Add(k);
                }
                foreach (var item in kolcson)
                {
                    Console.WriteLine(item);
                }
            }
        }

        public int Hany()
        {
            return kolcson.Count();
        }

        public void Kereso()
        {
            Console.WriteLine("kerek egy nevet: ");
            string nev = Console.ReadLine();
            Console.WriteLine($"{nev} kolcsonzesei: ");
            int seged = 0;
            foreach (var item in kolcson)
            {
                if (item.Nev.ToLower() == nev.ToLower())
                {
                    seged++;
                    Console.WriteLine($"{Nullas(item.Eora)}:{Nullas(item.Eperc)} - {Nullas(item.Vora)}:{Nullas(item.Vperc)}");
                }
            }
            if (seged == 0)
            {
                Console.WriteLine("nem volt ilyen nevu kolcsonzo");
            }
        }

        public void Keresoido()
        {
            Console.WriteLine("kerek egy idopontot ora:prec formatumban: ");
            string szoveg = Console.ReadLine();
            DateTime keresendo = DateTime.Parse(szoveg);
            Console.WriteLine("a vizen levo jarmuvek: ");
            int help = 0;
            foreach (var item in kolcson)
            {
                string seged1 = $"{item.Eora}:{item.Eperc}";
                DateTime idoseged1 = DateTime.Parse(seged1);
                string seged2 = $"{item.Vora}:{item.Vperc}";
                DateTime idoseged2 = DateTime.Parse(seged2);
                if (idoseged1 < keresendo && idoseged2 > keresendo)
                {
                    help++;
                    Console.WriteLine($"{Nullas(item.Eora)}:{Nullas(item.Eperc)} - {Nullas(item.Vora)}:{Nullas(item.Vperc)} : {item.Nev}");
                }
            }
            if (help == 0)
            {
                Console.WriteLine("ebben az idopontban nem volt egyetlen bicikli sem vizen");
            }
        }

        public void NapiBev()
        {
            int bev = 0;
            foreach (var item in kolcson)
            {
                string seged1 = $"{item.Eora}:{item.Eperc}";
                DateTime kezdoseged = DateTime.Parse(seged1);
                string seged2 = $"{item.Vora}:{item.Vperc}";
                DateTime vegseged = DateTime.Parse(seged2);
                TimeSpan kulonbseg = vegseged - kezdoseged;
                int tartam = (int)kulonbseg.TotalMinutes;
                int db = tartam / 30;
                bev += db * 2400;
            }
            Console.WriteLine("a napi bevetel: " + bev);
        }

        public string Nullas(int szam)
        {
            if (szam < 10)
            {
                string kieg = "0" + szam;
                return kieg;
            }
            return szam.ToString();
        }
    }
}
