using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szamtoszoveg
{
    internal class Program
    {
        static string[] egyesek = { "", "egy", "ketto", "harom", "negy", "ot", "hat", "het", "nyolc", "kilenc" };
        static string[] tizesek = { "", "tiz", "husz", "harminc", "negyven", "otven", "hatvan", "hetven", "nyolcvan", "kilencven" };
        static string[] tizenek = { "tiz", "tizenegy", "tizenketto", "tizenharom", "tizennegy", "tizenot", "tizenhat", "tizenhet", "tizennyolc", "tizenkilenc" };
        static string[] egysegek = { "", "ezer"};

        static void Main(string[] args)
        {
            Console.Write("kerek egy szamot max 6jegyu: ");
            int szam = int.Parse(Console.ReadLine());
            if (Math.Abs(szam) < 1000000)
            {
                string szoveg = Toszoveg(szam);
                Console.WriteLine(szoveg);
            }
            else
            {
                Console.WriteLine("rossz szam :(");
            }
            Console.ReadKey();
        }
        static string Toszoveg(int szam)
        {
            if (szam == 0)
            {
                return "nulla";
            }
            string szoveg = "";
            string neg = "minusz ";
            int seged = 0;
            while (Math.Abs(szam) > 0)
            {
                int jegy = szam % 1000;
                if (jegy != 0)
                {
                    szoveg = JegyToSzoveg(jegy) + egysegek[seged] + "-" + szoveg;
                }

                szam /= 1000;
                seged++;
            }
            string final = neg + szoveg;
            return final.Trim('-');
        }

        static string JegyToSzoveg(int jegy)
        {
            string szoveg = "";

            int tizes = Math.Abs(jegy % 100);
            int szazas = Math.Abs(jegy / 100);

            if (szazas > 0)
            {
                szoveg += egyesek[szazas] + "szaz";
            }

            if (tizes > 0)
            {
                if (tizes < 10)
                {
                    szoveg += egyesek[tizes];
                }
                else if (tizes < 20)
                {
                    szoveg += tizenek[tizes - 10];
                }
                else
                {
                    szoveg += tizesek[tizes / 10] + egyesek[  tizes % 10];
                }
            }
            return szoveg;
        }
    }
}
