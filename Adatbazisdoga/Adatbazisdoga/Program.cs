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
            Console.WriteLine("harmadik feladat");
            adatbazis.Statisztika();
            Console.WriteLine("hatodik feladat");
            adatbazis.NevCim();


            Console.ReadKey();
        }
    }
}
