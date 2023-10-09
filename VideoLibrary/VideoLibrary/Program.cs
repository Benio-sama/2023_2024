using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VideoLibrary v = new VideoLibrary();
            Console.WriteLine(v.ToString());
            Colored c = new Colored("Iron Man", "Shane Black", 2008);
            c.ToString();
            Colored c2 = new Colored("Guardians of the Galaxy Vol. 3", "James Gunn", 2023);
            c2.ToString();
            Graayscale g = new Graayscale("The Avengers", "Joss Whedon", 2012);
            g.ToString();
            Graayscale g2 = new Graayscale("Captain America: Civil War", "Joe Russo", 2016);
            g2.ToString();
            Guest gt = new Guest("Vida Margareta", "asd");
            gt.ToString();
            Guest gt2 = new Guest("Vago Katalin", "asd");
            gt2.ToString();

            v.AddVideo(c);
            v.AddVideo(c2);
            v.AddVideo(g);
            v.AddVideo(g2);
            v.AddGuest(gt);
            v.AddGuest(gt2);

            c.Copy();
            //g.Copy();

            v.Borrow(gt, g);
            v.Borrow(gt2, c2);

            //gt.Steal();
            gt2.Steal();

            v.ReturnVideo(gt);
            v.ReturnVideo(gt2);
            v.Borrow(gt, c2);
            v.ReturnVideo(gt);

            Console.WriteLine(v.GetMostOftenBorrowed());
            Console.WriteLine(v.ToString());

            Console.ReadKey();
        }
    }
}
