using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizibicikliKolcsonzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok f = new Feladatok();
            f.Beolvas("kolcsonzesek.txt");
            /*Console.WriteLine("napi kolcsonzesek szama: " + f.Hany());
            f.Kereso();
            f.Keresoido();
            f.NapiBev();*/


            Console.ReadKey();
        }
    }
}
