using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalozos
{
    internal class Armada
    {
        private List<Ship> ships = new List<Ship>();

        internal List<Ship> Ships { get => ships; set => ships = value; }

        public void War(Armada a)
        {

        }
    }
}
