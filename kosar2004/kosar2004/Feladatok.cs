using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace kosar2004
{
    internal class Feladatok
    {
        private List<Meccs> meccsek = new List<Meccs>();

        internal List<Meccs> Meccsek { get => meccsek; set => meccsek = value; }

        public void Beolvasas(string fajl)
        {
            using (StreamReader sr = new StreamReader(fajl))
            {
                sr.ReadLine();
                while (!sr.EndOfStream) 
                {
                    string sor = sr.ReadLine();
                    string[] sorok = sor.Split(';');
                    string hazai = sorok[0];
                    string idegen = sorok[1];
                    int hazaip = int.Parse(sorok[2]);
                    int idegenp = int.Parse(sorok[3]);
                    string hely = sorok[4];
                    DateTime datum = DateTime.Parse(sorok[5]);
                    Meccs m = new Meccs(hazai, idegen, hazaip, idegenp, hely, datum);
                    meccsek.Add(m);
                    /*foreach (var item in meccsek)
                    {
                        Console.WriteLine(item);
                    }*/
                }
                Console.WriteLine("sikeres beolvasas");
            }
        }
        public string HanyRM()
        {
            int db = 0;
            int db2 = 0;
            foreach (var item in meccsek)
            {
                if (item.Hazai == "Real Madrid")
                {
                    db++;
                }
                if (item.Idegen == "Real Madrid")
                {
                    db2++;
                }
            }
            return $"Real Madrid: Hazai: {db}, Idegen: {db2}";
        }
        public string Dontetlen()
        {
            foreach (var item in meccsek)
            {
                if (item.Hazaip == item.Idegenp)
                {
                    return "igen";
                }
            }
            return "nem";
        }
        public string Barcelona()
        {
            foreach (var item in meccsek)
            {
                if (item.Hazai.Contains("Barcelona"))
                {
                    return $"a barceloniai csapat neve: {item.Hazai}";
                }
                else if (item.Idegen.Contains("Barcelona"))
                {
                    return $"a barceloniai csapat neve: {item.Idegen}";
                }
            }
            return "nincs barcelonai csapat";
        }
        public void Nov() 
        {
            foreach (var item in meccsek)
            {
                if (item.Datum.Year == 2004 && item.Datum.Month == 11 && item.Datum.Day == 21)
                {
                    Console.WriteLine($"{item.Hazai} - {item.Idegen} ({item.Hazaip}:{item.Idegenp})");
                }
            }
        }
        public void Stadion()
        {
            Dictionary<string,int> list = new Dictionary<string,int>();
            foreach (var item in meccsek)
            {
                string kulcs = item.Helyszin;
                if (!list.ContainsKey(kulcs))
                {
                    list.Add(kulcs, 0);
                }
                list[kulcs]++;
            }
            foreach (var item in list)
            {
                if (item.Value > 20)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }
            }
        }
    }
}
