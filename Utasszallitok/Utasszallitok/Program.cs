using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utasszallitok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok f = new Feladatok();
            f.Beolvasas("utasszallitok.txt");
            f.DB();
            Console.WriteLine("--------------------------------------------------");
            f.BoeingE();
            Console.WriteLine("--------------------------------------------------");
            f.LegtobbUtas();
            Console.WriteLine("--------------------------------------------------");
            f.Sebessegkat();
            Console.WriteLine("--------------------------------------------------");
            f.Beiras();



            Console.ReadKey();
        }
    }
}
