using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pars2012
{
    internal class Versenyzo
    {
        private string nev;
        private string csoport;
        private string nemzet_kod;
        private double d1;
        private double d2;
        private double d3;

        public Versenyzo(string sor)
        {
            string[] sorok = sor.Split(';');
            this.nev = sorok[0];
            this.csoport = sorok[1];
            this.nemzet_kod = sorok[2];
            double d1;
            double d2;
            double d3;
            if (sorok[3] == "X")
            {
                d1 = -1.0;
            }
            else if (sorok[3] == "-")
            {
                d1 = -2.0;
            }
            else
            {
                string seged = sorok[3].Replace(',', '.');
                d1 = double.Parse(seged);
            }

            if (sorok[4] == "X")
            {
                d2 = -1.0;
            }
            else if (sorok[4] == "-")
            {
                d2 = -2.0;
            }
            else
            {
                string seged = sorok[4].Replace(',', '.');
                d2 = double.Parse(seged);
            }

            if (sorok[5] == "X")
            {
                d3 = -1.0;
            }
            else if (sorok[5] == "-")
            {
                d3 = -2.0;
            }
            else
            {
                string seged = sorok[5].Replace(',', '.');
                d3 = double.Parse(seged);
            }
            this.d1 = d1;
            this.d2 = d2;
            this.d3 = d3;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Csoport { get => csoport; set => csoport = value; }
        public string Nemzet_kod { get => nemzet_kod; set => nemzet_kod = value; }
        public double D1 { get => d1; set => d1 = value; }
        public double D2 { get => d2; set => d2 = value; }
        public double D3 { get => d3; set => d3 = value; }

        public override string ToString()
        {
            return $"{this.nev} ({Nemzet()} ({Kod()})): {this.csoport}, 1: {this.d1}, 2: {this.d2}, 3: {this.d3}, legnagyobb: {Eredmeny()}";
        }

        public double Eredmeny()
        {
            if (this.d1 == -1 && this.d2 == -1 && this.d3 == -1)
            {
                return -1;
            }
            else if (this.d1 > this.d2)
            {
                if (this.d1 > this.d3)
                {
                    return this.d1;
                }
                else
                {
                    return this.d3;
                }
            }
            else if (this.d2 > this.d3)
            {
                return this.d2;
            }
            else
            {
                return this.d3;
            }
        }
        public string Nemzet()
        {
            string[] seged = this.nemzet_kod.Split(' ');
            if (seged.Length < 3)
            {
                return seged[0];
            }
            else
            {
                return seged[0] + ' ' + seged[1];
            }
            
        }
        public string Kod()
        {
            string[] seged = this.nemzet_kod.Split(' ');
            if (seged.Length < 3)
            {
                return seged[1].Trim('(').Trim(')');
            }
            else
            {
                return seged[2].Trim('(').Trim(')');
            }
        }
    }
}
