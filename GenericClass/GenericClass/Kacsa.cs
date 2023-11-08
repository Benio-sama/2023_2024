using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
	internal class Kacsa
	{
		private bool kicsiE;
		private string nev;

		public Kacsa(bool kicsiE, string nev)
		{
			this.kicsiE = kicsiE;
			this.nev = nev;
		}
		public override string ToString()
		{
			return this.nev + (this.kicsiE? "kiskacsa" : " pekingi kacsa");
		}
	}
}
