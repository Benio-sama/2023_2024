using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalozos
{
    internal class Ship
    {
        private List<Pirate> crew = new List<Pirate>();
        private bool vankapitany = false;

        public bool Vankapitany { get => vankapitany; set => vankapitany = value; }
        internal List<Pirate> Crew { get => crew; set => crew = value; }

        public void FillShip()
        {
            Captain c = new Captain();
            crew.Add(c);
            Random r = new Random();
            int seged = r.Next(1, 114);
			for (int i = 0; i < seged; i++)
            {
                Pirate p = new Pirate();
                crew.Add(p);
            }
            vankapitany = true;
            for (int i = 0; i < seged*3; i++)
            {
                int seged1 = r.Next(1, crew.Count() - 1);
                crew[r.Next(1, crew.Count()-1)].DrinkSomeRum();
                crew[r.Next(1, crew.Count() - 1)].HowsItGoingMate();
                crew[r.Next(1, crew.Count() - 1)].Brawl(crew[seged1]);
            }
        }
        public int Representation1()
        {
            string seged = "";
            if (crew[0].El)
            {
                seged += "Alive";
            }
            else
            {
                seged += "Dead";
            }
            //Console.WriteLine($"State of Captain: number of rums consumed: {crew[0].Reszeg}, state: {seged}");
            return crew[0].Reszeg;
        }
        public int Representation2()
        {
            int seged1 = 0;
            if (crew[0].El)
            {
                seged1--;
            }
            foreach (var item in crew)
            {
                if (item.El)
                {
                    seged1++;
                }
            }
            //Console.WriteLine($"Number of alive pirates in the crew: {seged1}");
            return seged1;
        }
        public bool Battle(Ship s)
        {
            Random r = new Random();
            if (this.Representation1() == s.Representation1())
            {
                if (this.Representation2() > s.Representation2())
                {
					Console.WriteLine("You won! Let's get drunk!");
					int seged = r.Next(1, 11);
					foreach (var item in this.crew)
					{
						for (int i = 0; i < seged; i++)
						{
							item.DrinkSomeRum();
						}
					}
					for (int i = 0; i < 57; i++)
					{
						s.crew[r.Next(1, s.crew.Count() - 1)].Die();
					}
					return true;
				}
                else if (this.Representation2() < s.Representation2())
                {
					Console.WriteLine("You lost! Too bad, you lost a random amount of pirates!");
					foreach (var item in s.crew)
					{
						for (int i = 0; i < r.Next(1, 11); i++)
						{
							item.DrinkSomeRum();
						}
					}
					for (int i = 0; i < 57; i++)
					{
						this.crew[r.Next(1, crew.Count() - 1)].Die();
					}
					return false;
				}
                else
                {
					Console.WriteLine("Draw?");
					return false;
				}
            }
            else if (this.Representation1() > s.Representation1())
            {
                if (this.Representation2() == s.Representation2())
                {
					Console.WriteLine("You won! Let's get drunk!");
					int seged = r.Next(1, 11);
					foreach (var item in this.crew)
					{
						for (int i = 0; i < seged; i++)
						{
							item.DrinkSomeRum();
						}
					}
					for (int i = 0; i < 57; i++)
					{
						s.crew[r.Next(1, s.crew.Count() - 1)].Die();
					}
					return true;
				}
                else if (this.Representation2() < s.Representation2())
                {
                    Console.WriteLine("Draw?");
                    return false;
                }
                else
                {
                    Console.WriteLine("You won! Let's get drunk!");
                    int seged = r.Next(1, 11);
                    foreach (var item in this.crew)
                    {
                        for (int i = 0; i < seged; i++)
                        {
                            item.DrinkSomeRum();
                        }
                    }
                    for (int i = 0; i < 57; i++)
                    {
                        s.crew[r.Next(1, s.crew.Count() - 1)].Die();
                    }
                    return true;
                }
            }
            else //this.Representation1() < s.Representation1()
            {
                if (this.Representation2() == s.Representation2())
                {
                    Console.WriteLine("You lost! Too bad, you lost a random amount of pirates!");
                    foreach (var item in s.crew)
                    {
                        for (int i = 0; i < r.Next(1, 11); i++)
                        {
                            item.DrinkSomeRum();
                        }
                    }
                    for (int i = 0; i < 57; i++)
                    {
                        this.crew[r.Next(1, crew.Count() - 1)].Die();
                    }
                    return false;
                }
                else if (this.Representation2() > s.Representation2())
                {
                    Console.WriteLine("Draw?");
                    return false;
                }
                else
                {
                    Console.WriteLine("You lost! Too bad, you lost a random amount of pirates!");
                    foreach (var item in s.crew)
                    {
                        for (int i = 0; i < r.Next(1, 11); i++)
                        {
                            item.DrinkSomeRum();
                        }
                    }
                    for (int i = 0; i < 57; i++)
                    {
                        this.crew[r.Next(1, crew.Count() +- 1)].Die();
                    }
                    return false;
                }
            }
		}
	}
}
