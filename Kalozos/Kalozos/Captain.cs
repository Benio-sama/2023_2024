using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalozos
{
    internal class Captain : Pirate
    {
        private bool kapitany = true;

        public bool Kapitany { get => kapitany; set => kapitany = value; }
    }
}
