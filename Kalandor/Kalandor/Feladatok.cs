using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalandor
{
	internal class Feladatok
	{

		public string Jatek(Kalandor k)
		{
			return "";
		}
		public void Veszelyes(Kalandor k)
		{
			Random rnd = new Random();
			int kocka = rnd.Next(1, 7);
			while (kocka == 1)
			{
                Console.WriteLine("talalkoztal egy nagy ehes tigrissel, megserultel, -8 hp");
				k.Hp -= 8;
				kocka = rnd.Next(0, 7);
			}
			while (kocka == 2)
			{
				Console.WriteLine("atkeltel egy veszelyes folyon, elragadott az aramlat, -8 hp");
				k.Hp -= 8;
				kocka = rnd.Next(0, 7);
			}
			while (kocka == 3)
			{
				Console.WriteLine("megbotlottal egy csapdaban, megserultel, -8 hp");
				k.Hp -= 8;
				kocka = rnd.Next(0, 7);
			}
			while (kocka == 4)
			{
				Console.WriteLine("eltevedtel a dzsungelban, -8 hp");
				k.Hp -= 8;
				kocka = rnd.Next(0, 7);
			}
			while (kocka == 5)
			{
				Console.WriteLine("megtamadt egy mergezo kigyo, -8 hp");
				k.Hp -= 8;
				kocka = rnd.Next(0, 7);
			}

		}
		public string Biztonsagos(Kalandor k)
		{
			return "";
		}
	}
}
