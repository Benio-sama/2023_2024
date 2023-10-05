using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalozos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Armada a = new Armada();
            Armada a2 = new Armada();
            a.FillArmada();
            a2.FillArmada();
            Console.WriteLine(a.War(a2));

            /*Ship s = new Ship();
            Ship s2 = new Ship();
            s.FillShip();
            s2.FillShip();
            Console.WriteLine(s.Battle(s2));*/




            Console.ReadKey();
        }
    }
}
