using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalozos
{
    internal class Pirate
    {
        private int reszeg = 0;
        private bool el = true;
        private bool papagaj = false;

        public int Reszeg { get => reszeg; set => reszeg = value; }
        public bool El { get => el; set => el = value; }
        public bool Papagaj { get => papagaj; set => papagaj = value; }

        public void DrinkSomeRum()
        {
            if (this.el)
            {
                this.reszeg++;
            }
            else 
            {
                Console.WriteLine("he's dead");
            }
        }
        public void HowsItGoingMate()
        {
            if (this.el) 
            {
                if (this.reszeg < 4)
                {
                    Console.WriteLine("Pour me anudder!");
                }
                else
                {
                    Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                    Console.WriteLine("*passed out*");
                    this.reszeg = 0;
                }
            }
            else 
            {
                Console.WriteLine("he's dead");
            }
        }
        public void Die()
        {
            this.el = false;
        }
        public void Brawl(Pirate p)
        {
            if (this.el && p.el)
            {
                Random r = new Random();
                int chance = r.Next(1, 4);
                if (chance == 1)
                {
                    this.Die();

                }
                else if (chance == 2)
                {
                    p.Die();
                }
                else
                {
                    Console.WriteLine("*both of them passed out*");
                }
            }
            else
            {
                Console.WriteLine("one of them or both are dead");
            }
        }
        public void Parrot()
        {
            this.papagaj = true;
            Console.WriteLine("you got a parrot");
        }
    }
}
