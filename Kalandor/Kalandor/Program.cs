using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalandor
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Kalandor k = new Kalandor("Mici");
			Feladatok f = new Feladatok();
			f.Veszelyes(k);



            Console.ReadKey();
        }
	}
}
