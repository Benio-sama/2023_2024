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
            Console.WriteLine("2. feladat");
            f.Beolvasas("eredmenyek.csv");
            Console.WriteLine("3. feladat");
            Console.WriteLine(f.HanyRM());
            Console.WriteLine("4. feladat");
            Console.WriteLine("volt dontetlen meccs?");
            Console.WriteLine(f.Dontetlen());
            Console.WriteLine("5. feladat");
            Console.WriteLine(f.Barcelona());
            Console.WriteLine("6. feladat");
            f.Nov();
            Console.WriteLine("7. feladat");
            f.Stadion();

            Console.ReadKey();
        }
    }
}
