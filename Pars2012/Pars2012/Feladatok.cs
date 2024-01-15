using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012
{
    internal class Feladatok
    {
        private List<Versenyzo> versenyzoList = new List<Versenyzo>();

        internal List<Versenyzo> VersenyzoList { get => versenyzoList; set => versenyzoList = value; }

        public void Beolvasas(string fajl)
        {
            using (StreamReader sr = new StreamReader(fajl))
            {
                sr.ReadLine();
                while (!sr.EndOfStream)
                {
                    Versenyzo v = new Versenyzo(sr.ReadLine());
                    versenyzoList.Add(v);
                }
            }
            /*foreach (var item in versenyzoList)
            {
                Console.WriteLine(item);
            }*/
        }

        public void HanyDB()
        {
            Console.WriteLine("5. feladat: versenyzok szama a selejtezoben: " + versenyzoList.Count());
        }

        public void Tovabb()
        {
            int seged = 0;
            foreach (var item in versenyzoList)
            {
                if (item.D2 == -2 || item.D3 == -2)
                {
                    seged++;
                }
            }
            Console.WriteLine("6. feladat: 78,00 mjeter feletti eredmennyel tovabbjutott: " + seged + " fo");
        }
        public void Legjobb()
        {
            Versenyzo max = versenyzoList[0];
            foreach (var item in versenyzoList)
            {
                if (item.Eredmeny() > max.Eredmeny())
                {
                    max = item;
                }
            }
            Console.WriteLine($"9. feladat: A selejtezo nyertese: \n\tNev: {max.Nev} \n\tCsoport: {max.Csoport} \n\tNemzet: {max.Nemzet()} \n\tNemzet kod: {max.Kod()} \n\tSorozat: {max.D1}, {max.D2}, {max.D3} \n\tEredmeny: {max.Eredmeny()}");
        }
        public void Beiras()
        {
            List<Versenyzo> rendezettversenyzoList = versenyzoList.OrderByDescending(x => x.Eredmeny()).ToList();
            using (StreamWriter sw = new StreamWriter("Dontos2012.txt"))
            {
                sw.WriteLine("Helyezes;Nev;Csoport;Nemzet;NemzetKod;Sorozat;Eredmeny");
                for (int i = 0; i < 12; i++)
                {
                    sw.WriteLine($"{i + 1};{rendezettversenyzoList[i].Nev};{rendezettversenyzoList[i].Csoport};{rendezettversenyzoList[i].Nemzet()};{rendezettversenyzoList[i].Kod()};{Tobase(rendezettversenyzoList[i].D1)};{Tobase(rendezettversenyzoList[i].D2)};{Tobase(rendezettversenyzoList[i].D3)};{rendezettversenyzoList[i].Eredmeny()}");
                }
            }
            Console.WriteLine("beiras done");
        }
        public string Tobase(double item)
        {
            if (item == -2)
            {
                return "-";
            }
            if (item == -1)
            {
                return "X";
            }
            return item.ToString();
        }
    }
}
