using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//f1();
			f2();

			Console.ReadKey();
		}

		private static void f2()
		{
			VeremStack<int> v1 = new VeremStack<int>();
			for (int i = 1; i < 6; i++)
			{
				v1.Push(i * 10);
			}
            Console.WriteLine(v1);
            Console.WriteLine("-------------");
            Console.WriteLine(v1.Pop());
            Console.WriteLine(v1);
			Console.WriteLine("-------------");
            Console.WriteLine(v1.Peek());
            Console.WriteLine(v1);
			VeremStack<Kacsa> v2 = new VeremStack<Kacsa>();
			v2.Push(new Kacsa(true, "Donald"));
			v2.Push(new Kacsa(true, "Csika"));
			v2.Push(new Kacsa(false, "Dagobert"));
			v2.Push(new Kacsa(false, "Daisy"));
            Console.WriteLine(v2);
			Console.WriteLine("-------------");


		}

		static void f1()
		{
			int whole = 12;
			GenericFirst<int> e1 = new GenericFirst<int>(whole);
			e1.Kiir();
			string s = "hejhoo";
			GenericFirst<string> e2 = new GenericFirst<string>(s);
			e2.Kiir();

			GenericFirst<Kacsa> e3 = new GenericFirst<Kacsa>(new Kacsa(false, "Donald"));
			e3.Kiir();

			//a listak is generikusak
		}
	}
}
