using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eutazas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok f = new Feladatok();
            f.Beolvas("utasadat.txt");
            f.Felszallni();
            f.Elutasitva();
            f.Legtobb();
            f.IngyenKedv();
            f.Mikor();


            Console.ReadKey();
        }
    }
}
