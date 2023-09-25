using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulelo
{
	internal class Feladatok
	{
		public void Jatek(Tulelo t)
		{
			t.HatizsakTartalma();
			Akadaly1(t);
		}

		public void Akadaly1(Tulelo t)
		{
            Console.WriteLine("talalkozol egy torpevel, aki nem enged a kajahoz.\nmeg kell oldanod egy talalos kerdest, ne felj 3 kozul kell egyet.");
            Console.WriteLine("1. Mi az: drót végén van, és fekete?");
			string valasz = Console.ReadLine();
			if (valasz == "Kezdő villanyszerelő" || valasz == "kezdő villanyszerelő" || valasz == "Kezdo villanyszerelo" || valasz == "kezdo villanyszerelo")
			{
                Console.WriteLine("helyes valasz, megkapod a kajat");
				Console.WriteLine();
				t.Kaja = true;
				Akadaly2(t);
            }
			else
			{
                Console.WriteLine("nem talalt, meg 2 lehetoseged van");
                Console.WriteLine("2. Mi a különbség a vécé és a temető között?");
				string valasz2 = Console.ReadLine();
				valasz2 = valasz2.ToLower();
				if (valasz2 == "semmi. ha menni kell, hát menni kell" || valasz2 == "semmi ha menni kell hát menni kell" || valasz2 == "semmi. ha menni kell, hat menni kell" || valasz2 == "semmi ha menni kell hat menni kell")	
				{
					Console.WriteLine("helyes valasz, megkapod a kajat");
                    Console.WriteLine();
                    t.Kaja = true;
					Akadaly2(t);
				}
				else
				{
                    Console.WriteLine("rossz valasz, utolso probalkozas");
                    Console.WriteLine("3. Hogy hívják a férfi börtönőrt?");
					string valasz3 = Console.ReadLine();
					if (valasz3 == "Kancellár" || valasz3 == "Kancellar" || valasz3 == "kancellár" || valasz3 == "kancellar")
					{
						Console.WriteLine("helyes valasz, megkapod a kajat");
                        Console.WriteLine();
                        t.Kaja = true;
						Akadaly2(t);
					}
					else
					{
                        Console.WriteLine("hahaha most felnegyellek, meghaltal, nincs menekves >:D");
                        Console.WriteLine("Vege a jateknak");
                    }
                }
            }
		}
		public void Akadaly2(Tulelo t)
		{
            Console.WriteLine("gratulalok eljutottal a masodik akadalyhoz");
            Console.WriteLine("egy nagy pokhalo van elotted, meg kell oldanod egy matek feladvanyt a tovabbjutas erdekeben");
			Console.WriteLine("van 1200 penzed, veszel egy tehenet 800ert majd eladod 1000ert. megveszed ujra 1100ert es ismet eladod 1300ert. mennyi penzed van?");
			int valasz = Convert.ToInt32(Console.ReadLine());
            if (valasz == 1600)
            {
                Console.WriteLine("eszrevetlenul elsurransz a pok mellett, kapsz vizet");
                Console.WriteLine();
                t.Viz = true;
				Akadaly3(t);
            }
			else
			{
                Console.WriteLine("eszrevett a pok, meghaltal :/");
                Console.WriteLine("vege a jateknak");
            }
        }
		public void Akadaly3(Tulelo t)
		{
            Console.WriteLine("elertel egy titkos ajtohoz");
            Console.WriteLine("csak egy palindrom (visszafele is ugyan az a szo) szoval tudod kinyitni");
            Console.WriteLine("csak egy lehetoseged van:");
			string valasz = Console.ReadLine();
			valasz.ToLower(); //kerek
			string visszafele = string.Empty;
			for (int i = valasz.Length - 1; i >= 0; i--)
			{
				visszafele += valasz[i];
			}
			if (valasz == visszafele)
			{
                Console.WriteLine("gratulalok sikerult kinyitnod az ajtot, itt vannak a targyak amiket talaltal:");
                t.Alma = true;
                t.Futopad = true;
                t.Gepfegyver = true;
                t.Kiskes = true;
                t.Granat = true;
                t.Ollo = true;
                t.Kanal = true;
                Console.WriteLine("alma, futopad, gepfegyver, kiskes, granat, ollo, kanal, mindet hozzaadva a hatizsakodhoz");
                Console.WriteLine();
                Akadaly4(t);
            }
			else
			{
				Console.WriteLine("nem talalt, igy az ajto mogotti kincsek nelkul kell tovabb menned");
                Console.WriteLine();
                Akadaly4(t);
			}
		}
		public void Akadaly4(Tulelo t)
		{
			Console.WriteLine("elerted az utolso akadalyt, ami csak a szerencseden es az elobbi akadalyoknal valo teljesitmenyeden mulik");
			Console.WriteLine("csak ugy juthatsz tovabb, ha 6ost dobsz");
			Random r = new Random();
			int dobas = r.Next(1, 7);
			if (dobas == 6)
			{
				Console.WriteLine("sikeresen 6ost dobtal, ezzel elkerulted a csapdat");
                Console.WriteLine();
                Akadaly5(t);
			}
			else
			{
				Console.WriteLine("sajnos eleg szerrencsetlen voltal, itt jon kozbe az elozo akadaly vegeredmenye");
				Console.WriteLine("kotelhaloban fel lettel akasztva egy fara");
				Console.WriteLine("ha sikeresen megoldottad es van nalad kiskes akkor kiszabadulhatsz");
				if (t.Kiskes)
				{
					Console.WriteLine("kivagtad magad a halobol, tovabb tudsz menni");
                    Console.WriteLine();
                    Akadaly5(t);
				}
				else
				{
					Console.WriteLine("nincs nalad kes, itt ragadtal");
					Console.WriteLine("vege a jateknak");
				}
			}
		}
		public void Akadaly5(Tulelo t)
		{
			Console.WriteLine("meg kell kuzdened egy szornnyel azert hogy elmenekulhess a szigetrol");
			if (t.Gepfegyver)
			{
				Console.WriteLine("mazlid van, van nalad gepfegyver ezert egyszeruen legyozted a szornyet");
				Console.WriteLine("megnyerted a jatekot");
			}
			else
			{
				Random r = new Random();
				Console.WriteLine("nincs nalad fegyver, szerencsen mulik a szabadsagod");
				Console.WriteLine("a szorny is meg te is 4x fogtok dobni egy kockaval, ha nagyobbat dobsz, megmenekultel");
				int jatekos = 0;
				int szorny = 0;
				for (int i = 0; i < 4; i++)
				{
					jatekos += r.Next(1, 7);
				}
                for (int i = 0; i < 4; i++)
                {
                    szorny += r.Next(1, 7);
                }
				if (jatekos > szorny)
				{
					Console.WriteLine("nagyobbat dobtal mint a szorny, o elfutott szegyeneben");
					Console.WriteLine("megmenekultel");
					Console.WriteLine("megnyerted a jatekot");
				}
				else
				{
					Console.WriteLine("hat pehed van, a szorny nagyobbat dobott mint te, meghaltal");
					Console.WriteLine("vege a jateknak");
				}
            }
		}
	}
}
