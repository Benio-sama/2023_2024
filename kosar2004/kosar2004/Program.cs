using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kosar2004
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok f = new Feladatok();
            f.Beolvasas();
            Console.WriteLine(f.HanyRM());
            Console.WriteLine(f.Dontetlen());
            Console.WriteLine(f.Barcelona());
            Console.WriteLine("6. feladat");
            f.Nov();
            Console.WriteLine("7. feladat");
            f.Stadion();

            Console.ReadKey();
        }
    }
}
