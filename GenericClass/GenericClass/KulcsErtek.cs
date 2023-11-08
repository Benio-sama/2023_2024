using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
	internal class KulcsErtek<K,E>
	{
		private K kulcs;
		private E ertek;

		public KulcsErtek(K kulcs, E ertek)
		{
			this.kulcs = kulcs;
			this.ertek = ertek;
		}

		public K Kulcs { get => kulcs; set => kulcs = value; }
		public E Ertek { get => ertek; set => ertek = value; }
		public override string ToString()
		{
			return $"Kulcs: {this.kulcs}, Ertek: {this.ertek}";
		}
		
	}
}
