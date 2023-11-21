using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDatabase
{
    internal class Book
    {
        private int id;
        private string title;
        private string author;

        public Book(int id, string title, string author)
        {
            this.id = id;
            this.title = title;
            this.author = author;
        }

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Author { get => author; set => author = value; }
        public override string ToString()
        {
            return $"{this.title}, id: {this.id}, iro: {this.author}";
        }
    }
}
