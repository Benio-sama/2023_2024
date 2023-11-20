using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRemote
{
    internal class TV
    {
        private bool status = false;
        private int channel = 1;
        private int volume = 0;

        public bool Status { get => status; set => status = value; }
        public int Channel { get => channel; set => channel = value; }
        public int Volume { get => volume; set => volume = value; }

        public override string ToString()
        {
            return "TV: status: " + (this.status ? "ON" : "OFF") + $", channel: {this.channel}, volume: {this.volume}";
        }
    }
}
