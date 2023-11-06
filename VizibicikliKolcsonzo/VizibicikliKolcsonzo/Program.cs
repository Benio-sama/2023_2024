using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VizibicikliKolcsonzo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Feladatok f = new Feladatok();
            f.Beolvas("kolcsonzesek.txt");
            //Console.WriteLine("napi kolcsonzesek szama: " + f.Hany());
            //f.Kereso();
            //f.Keresoido();
            f.NapiBev();




            //Kolcsonzo k = new Kolcsonzo("asd", "a", 7, 12, 9, 10);
            /*if (k.Eora < 10 || k.Eperc < 10)
            {
                string kieg = "0" + k.Eora;
                string kieg2 = "0" + k.Eperc;
                Console.WriteLine($"{k.Nev},{k.Azon},{kieg},{kieg2},{k.Vora},{k.Vperc}");
            }*/
            /*string ido = "10:9";
            string ido2 = "11:3";
            string ido3 = "10:30";
            DateTime idopont = DateTime.Parse(ido);
            DateTime idopont2 = DateTime.Parse(ido2);
            DateTime idopont3 = DateTime.Parse(ido3);*/

            /*if (idopont < idopont3 && idopont3 < idopont2)
            {
                Console.WriteLine(true);
            }*/
            //int penz = 300;
            //int seged = 0;
            /*Console.WriteLine(idopont2-idopont);
            TimeSpan t = new TimeSpan(0, 0, 30, 0);
            if (idopont2 - idopont > t)
            {
                Console.WriteLine(true);
            }
            */





            Console.ReadKey();
        }
    }
}
