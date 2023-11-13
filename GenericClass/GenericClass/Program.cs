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
            //f2();
            f3();

			Console.ReadKey();
		}

		static void f2()
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

		static void f3()
		{
			KulcsErtek<int, string> ke1 = new KulcsErtek<int, string>(12, "kata");
            KulcsErtek<int, string> ke2 = new KulcsErtek<int, string>(45, "Tomi");
            KulcsErtek<bool, string> ke3 = new KulcsErtek<bool, string>(true, "Mici");
            KulcsErtek<bool, string> ke4 = new KulcsErtek<bool, string>(false, "peti");
            KulcsErtek<string, int> ke5 = new KulcsErtek<string, int>("marton", 19);
            KulcsErtek<string, int> ke6 = new KulcsErtek<string, int>("bogi", 16);

            Parok<int, string> p1 = new Parok<int, string>();
            Parok<bool, string> p2 = new Parok<bool, string>();
            Parok<string, int> p3 = new Parok<string, int>();

            p1.Hozzaad(ke1);
            p1.Hozzaad(ke2);
            p2.Hozzaad(ke3);
            p2.Hozzaad(ke4);
            p3.Hozzaad(ke5);
            p3.Hozzaad(ke6);

            p1.Kiir();
            p2.Kiir();
            p3.Kiir();
            Console.WriteLine("-------");

            /*.Torol(ke1); //mukodik
            p2.Torol(ke3);
            p3.Torol(ke5);

            p1.Kiir();
            p2.Kiir();
            p3.Kiir();
            Console.WriteLine("-------");*/

            /*p1.TorolIndexAlapjan(0); //mukodik
            p2.TorolIndexAlapjan(0);
            p3.TorolIndexAlapjan(0);

            p1.Kiir();
            p2.Kiir();
            p3.Kiir();
            Console.WriteLine("-------");*/

            p1.Kereses(ke1.Kulcs);
            p2.Kereses(ke4.Kulcs);
            p3.Kereses(ke6.Kulcs);
        }
    }
}
