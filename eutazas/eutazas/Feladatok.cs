using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace eutazas
{
    internal class Feladatok
    {
        private List<Utas> utasok = new List<Utas>();

        internal List<Utas> Utasok { get => utasok; set => utasok = value; }

        public void Beolvas(string fajl)
        {
            using (StreamReader sr = new StreamReader(fajl))
            {
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] sorok = sor.Split(' ');
                    int megallo = int.Parse(sorok[0]);
                    DateTime felsz = DateTime.ParseExact(sorok[1], "yyyyMMdd-HHmm", CultureInfo.InvariantCulture);
                    int azon = int.Parse(sorok[2]);
                    string tipus = sorok[3];
                    string utolso = sorok[4];
                    Utas u = new Utas(megallo, felsz, azon, tipus, utolso); 
                    utasok.Add(u);
                }
            }
            /*foreach (var item in utasok)
            {
                Console.WriteLine(item);
            }*/
        }

        public void Felszallni()
        {
            Console.WriteLine("2. feladat");
            Console.WriteLine($"A buszra {utasok.Count()} utas akart felszallni.");
        }

        public void Elutasitva()
        {
            int help = 0;
            foreach (var item in utasok)
            {
                if (item.Erv != null)
                {
                    if (item.Felszallas.Date > item.Erv)
                    {
                        help++;
                    }
                }
            }
            Console.WriteLine("3.feladat");
            Console.WriteLine($"A buszra {help} utas nem szallhatott fel.");
        }

        public void Legtobb()
        {
            Dictionary<int,int> list = new Dictionary<int,int>();
            foreach (var item in utasok)
            {
                int kulcs = item.Megallo;
                if (!list.ContainsKey(kulcs))
                {
                    list.Add(kulcs, 0);
                }
                list[kulcs]++;
            }
            /*foreach (var item in list)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }*/
            var max = list.Where(needed => needed.Value == list.Values.Max())
                .OrderBy(needed => needed.Key)
                .First();
            Console.WriteLine("4. feladat");
            Console.WriteLine($"A legtobb utas ({max.Value} fo) a {max.Key}. megalloban probalt felszallni.");
        }

        public void IngyenKedv()
        {
            int ingy = 0;
            int kedv = 0;
            foreach (var item in utasok)
            {
                if (item.Erv != null)
                {
                    if (item.Felszallas.Date <= item.Erv)
                    {
                        if (item.Tipus == "TAB" || item.Tipus == "NYB")
                        {
                            kedv++;
                        }
                        if (item.Tipus == "NYP" || item.Tipus == "RVS" || item.Tipus == "GYK")
                        {
                            ingy++;
                        }
                    }
                }
            }
            Console.WriteLine("5. feladat");
            Console.WriteLine($"Ingyenesen utazok szaama: {ingy} fo");
            Console.WriteLine($"A kedvezmenyesen utazok szama: {kedv} fo");
        }

        public int Napokszama(Utas u)
        {
            int ev1 = u.Felszallas.Year;
            int ho1 = u.Felszallas.Month;
            int n1 = u.Felszallas.Day;
            int ev2 = u.Erv.Value.Year;
            int ho2 = u.Erv.Value.Month;
            int n2 = u.Erv.Value.Day;
            ho1 = (ho1 + 9) % 12;
            ev1 = ev1 - ho1 / 10;
            int d1 = 365 * ev1 + ev1 / 4 - ev1 / 100 + ev1 / 400 + (ho1 * 306 + 5) / 10 + n1 - 1;
            ho2 = (ho2 + 9) % 12;
            ev2 = ev2 - ho2 / 10;
            int d2 = 365 * ev2 + ev2 / 4 - ev2 / 100 + ev2 / 400 + (ho2 * 306 + 5) / 10 + n2 - 1;
            return d2 - d1;
        }

        public void Mikor()
        {
            using (StreamWriter sw = new StreamWriter("figyelmeztetes.txt"))
            {
                foreach (var item in utasok)
                {
                    if (item.Erv != null)
                    {
                        if (Napokszama(item) <= 3 && Napokszama(item) >= 0)
                        {
                            sw.Write(item.Azon.ToString() + " " + item.Erv.Value.Year.ToString() + "-" + item.Erv.Value.Month.ToString() + "-" + item.Erv.Value.Day.ToString());
                            sw.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
