using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tulelo
{
	internal class Tulelo
	{
		private List<bool> hatizsak = new List<bool>();
		private bool kaja = false;
		private bool viz = false;
		private bool alma = false;
		private bool futopad = false;
		private bool gepfegyver = false;
		private bool kiskes = false;
		private bool granat = false;
		private bool ollo = false;
		private bool kanal = false;

		public List<bool> Hatizsak { get => hatizsak; set => hatizsak = value; }
		public bool Kaja { get => kaja; set => kaja = value; }
		public bool Viz { get => viz; set => viz = value; }
		public bool Alma { get => alma; set => alma = value; }
		public bool Futopad { get => futopad; set => futopad = value; }
		public bool Gepfegyver { get => gepfegyver; set => gepfegyver = value; }
		public bool Kiskes { get => kiskes; set => kiskes = value; }
		public bool Granat { get => granat; set => granat = value; }
		public bool Ollo { get => ollo; set => ollo = value; }
		public bool Kanal { get => kanal; set => kanal = value; }

		public void HatizsakTartalma()
		{
			//alma, futópad, gépfegyver, kiskés, gránát, olló, kanál
			hatizsak.Add(kaja);
			hatizsak.Add(viz);
			hatizsak.Add(alma);
			hatizsak.Add(futopad);
			hatizsak.Add(gepfegyver);
			hatizsak.Add(kiskes);
			hatizsak.Add(granat);
			hatizsak.Add(ollo);
			hatizsak.Add(kanal);

		}
	}
}
