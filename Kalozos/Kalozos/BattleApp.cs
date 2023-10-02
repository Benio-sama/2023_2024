using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalozos
{
    internal class BattleApp
    {
        public void Main()
        {
            Ship ship1 = new Ship();
            Ship ship2 = new Ship();
            ship1.FillShip();
            ship2.FillShip();
            ship1.Battle(ship2);
        }
    }
}
