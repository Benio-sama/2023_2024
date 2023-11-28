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
                    double fesztav = double.Parse(sorok[6]);
                    Repulo r = new Repulo(tipus, ev, utas, szemelyzet, sebesseg, tomeg, fesztav);
                    repulok.Add(r);
                }
            }
            /*foreach (var item in repulok)
            {
                Console.WriteLine(item);
                Console.WriteLine("---------------------------");
            }*/
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
    }
}
