using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
	internal class GenericFirst<T>
	{
		private T element;

		public GenericFirst(T element)
		{
			this.element = element;
		}
		public void Kiir()
		{
            Console.WriteLine($"az adat erteke: {this.element}");
        }
	}
}
