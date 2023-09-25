using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalandor
{
	internal class Feladatok
	{

		public void Jatek(Kalandor k)
		{
            Console.WriteLine("Valassz egy jatekstilust:");
            Console.WriteLine("rovid de veszelyes (1)");
            Console.WriteLine("hosszu de biztonsagos (2)");
			int szam = Convert.ToInt32(Console.ReadLine());
			if (szam == 1)
			{
				Veszelyes(k);
			}
			else if (szam == 2)
			{
				Biztonsagos(k);
			}
			else
			{
                Console.WriteLine("ilyen jatekmod nincs");
			}
				
        }
		public void Veszelyes(Kalandor k)
		{
			Random rnd = new Random();
			int kocka = rnd.Next(1, 7);
			while (kocka != 6 && k.Hp > 0)
			{
				while (kocka == 1)
				{
					Console.WriteLine("talalkoztal egy nagy ehes tigrissel, megserultel, -8 hp");
					k.Hp -= 8;
					kocka = rnd.Next(1, 7);
				}
				while (kocka == 2)
				{
					Console.WriteLine("atkeltel egy veszelyes folyon, elragadott az aramlat, -8 hp");
					k.Hp -= 8;
                    kocka = rnd.Next(1, 7);
				}
				while (kocka == 3)
				{
					Console.WriteLine("megbotlottal egy csapdaban, megserultel, -8 hp");
					k.Hp -= 8;
                    kocka = rnd.Next(1, 7);
				}
				while (kocka == 4)
				{
					Console.WriteLine("eltevedtel a dzsungelban, -8 hp");
					k.Hp -= 8;
                    kocka = rnd.Next(1, 7);
				}
				while (kocka == 5)
				{
					Console.WriteLine("megtamadt egy mergezo kigyo, -8 hp");
					k.Hp -= 8;
                    kocka = rnd.Next(1, 7);
				}
			}
			if (kocka == 6)
			{
				Console.WriteLine("gratulalok, eljutottal a kincshez megnyerted a jatekot, hp:" + k.Hp);
			}
            if (k.Hp <= 0)
			{
				Console.WriteLine("meghaltal");
			}
        }
        public void Biztonsagos(Kalandor k)
		{
            Console.WriteLine("a biztonsagos uton mentel, nem esett semmi bajod, megnyerted a jatekot"); 
		}
	}
}
