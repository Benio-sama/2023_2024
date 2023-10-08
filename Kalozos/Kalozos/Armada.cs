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

        public void FillArmada()
        {
            for (int i = 0; i < 3; i++)
            {
                Ship s = new Ship();
                s.FillShip();
                ships.Add(s);
            }
		}
        public bool War(Armada a)
        {
			int thisShipIndex = 0;
			int otherShipIndex = 0;

			while (thisShipIndex < ships.Count && otherShipIndex < a.ships.Count)
			{
				Ship thisShip = ships[thisShipIndex];
				Ship otherShip = a.ships[otherShipIndex];

				bool thisShipWins = thisShip.Battle(otherShip);

				if (thisShipWins)
				{
					otherShipIndex++;
				}
				else
				{
					thisShipIndex++;
				}
			}

			return thisShipIndex == ships.Count;
		}
    }
}
