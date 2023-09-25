using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulelo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Feladatok f = new Feladatok();
			Tulelo t = new Tulelo();
			f.Jatek(t);


			Console.ReadKey();
        }
	}
}
