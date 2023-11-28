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
            f.BoeingE();

            Console.ReadKey();
        }
    }
}
