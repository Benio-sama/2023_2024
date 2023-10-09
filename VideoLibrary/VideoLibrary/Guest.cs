using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoLibrary
{
    internal class Guest
    {
        private string name;
        private string address;
        private bool isBorrowing = false;
        private Video borrowedvideo = null;

        public Guest(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public bool IsBorrowing { get => isBorrowing; set => isBorrowing = value; }
        internal Video Borrowedvideo { get => borrowedvideo; set => borrowedvideo = value; }

        public override string ToString()
        {
            if (isBorrowing)
            {
                return $"{this.name} jelenleg a {this.borrowedvideo.Title}-ot/t kölcsönzi";
            }
            else
            {
                return $"{this.name} jelenleg nem kölcsönöz semmit";
            }
        }
        public void Steal()
        {
            if (isBorrowing)
            {
                this.borrowedvideo.Copy();
            }
            else
            {
                Console.WriteLine("Nincs elérhető videó lopásra");
            }
        }
    }
}
