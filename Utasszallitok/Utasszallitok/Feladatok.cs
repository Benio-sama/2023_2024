using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Utasszallitok
{
    internal class Feladatok
    {
        List<Repulo> repulok = new List<Repulo>();

        internal List<Repulo> Repulok { get => repulok; set => repulok = value; }

        public void Beolvasas(string fajl)
        {
            using (StreamReader sr = new StreamReader(fajl))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    string[] sorok = sor.Split(';');
                    string tipus = sorok[0];
                    int ev = int.Parse(sorok[1]);
                    string utas = sorok[2];
                    string szemelyzet = sorok[3];
                    int sebesseg = int.Parse(sorok[4]);
                    int tomeg = int.Parse(sorok[5]);
                    string fesz = sorok[6];
                    double fesztav;
                    if (fesz.Contains(','))
                    {
                        fesz.Replace(',','.');
                        fesztav = double.Parse(fesz);
                    }
                    else
                    {
                        fesztav = double.Parse(fesz);
                    }
                    Repulo r = new Repulo(tipus, ev, utas, szemelyzet, sebesseg, tomeg, fesztav);
                    repulok.Add(r);
                }
            }
            foreach (var item in repulok)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------------");
            }
        }
        public void DB()
        {
            Console.WriteLine($"Adatsorok szama: {repulok.Count()}");
        }
        public void BoeingE()
        {
            int db = 0;
            foreach (var item in repulok)
            {
                if (item.Tipus.Contains("Boeing"))
                {
                    db++;
                }
            }
            Console.WriteLine($"Boeing tipusu repulok szama: {db}");
        }
        public void LegtobbUtas()
        {
            Repulo max = repulok[0];
            foreach (var item in repulok)
            {
                int maxutas;
                if (max.Utas.Contains('-'))
                {
                    string[] adatok = max.Utas.Split('-');
                    maxutas = int.Parse(adatok[1]);
                }
                else
                {
                    maxutas = int.Parse(max.Utas);
                }
                if (item.Utas.Contains('-'))
                {
                    string[] adatok = item.Utas.Split('-');
                    int adat = int.Parse(adatok[1]);
                    if (maxutas < adat)
                    {
                        max = item;
                    }
                }
                else
                {
                    int adat = int.Parse(item.Utas);
                    if (maxutas < adat)
                    {
                        max = item;
                    }
                }
            }
            Console.WriteLine($"A legtobb utast szallito repulogeptipus: \n{max}");
        }
        public void Sebessegkat()
        {
            Dictionary<string, int> list = new Dictionary<string, int>();
            list.Add("Alacsony sebességű", 0);
            list.Add("Szubszonikus", 0);
            list.Add("Transzszonikus", 0);
            list.Add("Szuperszonikus", 0);
            foreach (var item in repulok)
            {
                SebessegKategoria sk = new SebessegKategoria(item.Sebesseg);
                string kulcs = sk.Kategorianev;
                list[kulcs]++;
            }
            foreach (var item in list)
            {
                if (item.Value == 0)
                {
                    Console.WriteLine(item.Key);
                }
                
            }
        }
        public void Beiras()
        {
            using (StreamReader sr = new StreamReader("utasszallitok.txt"))
            {
                using (StreamWriter sw = new StreamWriter("utasszallitok_new.txt"))
                {
                    sw.WriteLine(sr.ReadLine());
                    while (!sr.EndOfStream)
                    {
                        string sor = sr.ReadLine();
                        string[] sorok = sor.Split(';');
                        string tipus = sorok[0];
                        string ev = sorok[1];
                        string utas = sorok[2];
                        string szemelyzet = sorok[3];
                        string sebesseg = sorok[4];
                        double tomeg = double.Parse(sorok[5]);
                        double fesztav = double.Parse(sorok[6]);
                        if (utas.Contains('-'))
                        {
                            string[] adat = utas.Split('-');
                            utas = adat[1];
                        }
                        if (szemelyzet.Contains('-'))
                        {
                            string[] adat = szemelyzet.Split('-');
                            szemelyzet = adat[1];
                        }
                        sw.WriteLine($"{tipus};{ev};{utas};{szemelyzet};{sebesseg};{Math.Round(tomeg / 1000.0, 0)};{Math.Round(fesztav * 3.2808, 0)}");
                        Console.WriteLine(fesztav);
                        Console.WriteLine(fesztav * 3.2808);
                    }
                }
                Console.WriteLine("beiras kesz");
            }
        }
    }
}
