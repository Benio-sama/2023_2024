using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLibrary
{
    internal class Graayscale : Video
    {
        private double price = 6.99;
        public Graayscale(string title, string director, int year) : base(title, director, year)
        {
        }

        public double Price { get => price; set => price = value; }

        public override string ToString()
        {
            return base.ToString() + $", {this.price}-be/ba kerül";
        }
        public override Video Copy()
        {
            throw new Exception("A rendőrség hamarosan megtalál téged");
        }
    }
}
