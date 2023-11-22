using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seged
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok f = new Feladatok();
            f.Beolvas("adatok-utf8.txt");
            f.Hany();
            f.Nepsuruseg(); 
            f.KinaVsIndia();
            f.Elso3();
            f.MeghaladjaE();

            Console.ReadKey();
        }
    }
}
