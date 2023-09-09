using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalandor
{
	internal class Kalandor
	{
		private string name;
		private int hp = 100;

		public Kalandor(string name)
		{
			this.name = name;
		}

		public string Name { get => name; set => name = value; }
		public int Hp { get => hp; set => hp = value; }
	}
}
