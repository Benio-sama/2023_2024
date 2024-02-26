using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbazisdoga
{
    internal class Toplista
    {
        private int helyezes;
        private int platinadb;
        private int ev;
        private string kiado;

        public Toplista(int helyezes, int platinadb, int ev, string kiado)
        {
            this.helyezes = helyezes;
            this.platinadb = platinadb;
            this.ev = ev;
            this.kiado = kiado;
        }

        public int Helyezes { get => helyezes; set => helyezes = value; }
        public int Platinadb { get => platinadb; set => platinadb = value; }
        public int Ev { get => ev; set => ev = value; }
        public string Kiado { get => kiado; set => kiado = value; }

        public override string ToString()
        {
            return $"{this.helyezes}. {this.platinadb}db {this.ev} {this.kiado}";
        }
    }
}
