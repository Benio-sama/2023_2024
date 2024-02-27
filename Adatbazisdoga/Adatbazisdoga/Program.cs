using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbazisdoga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Adatbazis adatbazis = new Adatbazis();
            Console.WriteLine("masodik feladat");
            adatbazis.Fekete();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("harmadik feladat");
            adatbazis.Statisztika();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("negyedik feladat");
            adatbazis.EloadoPlat();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("otodik feladat");
            adatbazis.SzereplesDB();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("hatodik feladat");
            adatbazis.NevCim();
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("hetedik feladat");
            adatbazis.PalyaBea();


            Console.ReadKey();
        }
    }
}
