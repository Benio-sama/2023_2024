using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
	internal class Parok<K,E>
	{
		private List<KulcsErtek<K,E>> lista = new List<KulcsErtek<K,E>>();

		internal List<KulcsErtek<K, E>> Lista { get => lista; set => lista = value; }

		public void Hozzaad(KulcsErtek<K,E> adat)
		{
			lista.Add(adat);
		}
		public void Torol(KulcsErtek <K,E> adat)
		{
			if (lista.Count() > 0)
			{
				lista.Remove(adat);
			}
			else
			{
				throw new InsufficientExecutionStackException();
			}
		}
		public void TorolIndexAlapjan(int index)
		{
			if (lista.Count() > 0)
			{
				if (index <= lista.Count())
				{
					lista.RemoveAt(index);
				}
				else
				{
					throw new IndexOutOfRangeException();
				}
			}
			else
			{
				throw new InsufficientExecutionStackException();
			}
		}
		public void Kereses(K kulcs)
		{

		}
	}
}
