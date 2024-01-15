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
            foreach (var item in versenyzoList)
            {
                Console.WriteLine(item);
            }
        }

        public void HanyDB()
        {
            Console.WriteLine(versenyzoList.Count());
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
            Console.WriteLine(seged);
        }
    }
}
