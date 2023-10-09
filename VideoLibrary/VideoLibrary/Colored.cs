using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLibrary
{
    internal class Colored : Video
    {
        private double price = 3.99;
        public Colored(string title, string director, int year) : base(title, director, year)
        {
        }

        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return base.ToString() + $", {this.price}-be/ba kerül";
        }
        public override Video Copy()
        {
            Console.WriteLine("sikeres a masolas");
            return new Colored(Title = this.Title, Director = this.Director, Year = this.Year );
        }
    }
}
