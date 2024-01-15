using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok f = new Feladatok();
            f.Beolvasas("Selejtezo2012.txt");
            f.HanyDB();
            f.Tovabb();

            Console.ReadKey();
        }
    }
}
