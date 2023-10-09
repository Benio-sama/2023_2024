using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace VideoLibrary
{
    internal class Video
    {
        private string title;
        private string director;
        private int year;
        private int borrowed = 0;
        private bool isBorrowed = false;

        public Video(string title, string director, int year)
        {
            this.title = title;
            this.director = director;
            this.year = year;
        }

        public string Title { get => title; set => title = value; }
        public string Director { get => director; set => director = value; }
        public int Year { get => year; set => year = value; }
        public int Borrowed { get => borrowed; set => borrowed = value; }
        public bool IsBorrowed { get => isBorrowed; set => isBorrowed = value; }

        public override string ToString()
        {
            return $"{this.title}, {this.director} által, {this.year}-ben/ban kiadva - {this.borrowed} alkalommal kölcsönözték ki";
        }
        public virtual Video Copy()
        {
            return new Video(this.title, this.director, this.year);
        }
    }
}
