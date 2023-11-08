using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
	internal class VeremStack<T>
	{
		private List<T> list;

		public VeremStack()
		{
			list = new List<T>();
		}

		public int Count
		{
			get { return list.Count; }
		}
		public bool IsEmpty
		{
			get { return Count == 0; }
		}

		public void Push(T item)
		{
			list.Add(item);
		}
		public T Pop()
		{
			if (!IsEmpty)
			{
				T elem = this.list[Count - 1];
				list.Remove(elem);
				return elem;
			}
			throw new InvalidOperationException();
		}
		public T Peek()
		{
			if (!IsEmpty)
			{
				return this.list[Count - 1];
			}
			throw new InvalidOperationException();
		}
		public override string ToString()
		{
			return string.Join("\n," +
				"", this.list);
		}
	}
}
