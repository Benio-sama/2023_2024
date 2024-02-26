using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adatbazisdoga
{
    internal class Album
    {
        private string eloado;
        private string cim;

        public Album(string eloado, string cim)
        {
            this.eloado = eloado;
            this.cim = cim;
        }

        public string Eloado { get => eloado; set => eloado = value; }
        public string Cim { get => cim; set => cim = value; }

        public override string ToString()
        {
            return $"{this.cim} - {this.eloado}";
        }
    }
}
