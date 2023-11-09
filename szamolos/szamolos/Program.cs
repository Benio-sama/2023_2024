using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamolos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			f1();
			f2();
			Console.ReadKey();
		}
		static void f1()
		{
            Console.WriteLine("Ha felcserélném a testvérem jelenlegi életkorában (két számjegyű életkor) a számokat, akkor egy évvel idősebb korának kétszeresét kapnám. Mennyi idős lehet most?");
            for (int i = 10; i < 100; i++)
			{
				int tizedes = i / 10;
				int egyes = i % 10;
				int forditott = Convert.ToInt32($"{egyes}{tizedes}");
				int ertek = (i + 1) * 2;
				if (forditott == ertek)
				{
                    Console.WriteLine(i);
                }
			}
		}
		static void f2()
		{
            Console.WriteLine("csiga beleesik egy 5 meter mely kutba, nappal 3m-t megy fel viszont ejszaka 2m-t visszacsuszik, hany nap alatt er ki?");
			int kut = 5;
			double napok = 0;
			while (kut > 0)
			{
				kut -= 3;
				napok += 0.5;
				if (kut == 0)
				{
                    Console.WriteLine(napok);
					break;
                }
				kut += 2;
				napok += 0.5;
			}
        }
	}
}
