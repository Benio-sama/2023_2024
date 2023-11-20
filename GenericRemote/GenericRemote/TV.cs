using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRemote
{
    internal class TV : Device
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
        public void PowerOn()
        {
            this.status = true;
            Console.WriteLine("a tv bekapcsolva");
        }
        public void PowerOff()
        {
            this.status = false;
            Console.WriteLine("a tv kikapcsolva");
        }
        public void SetChannel(int channel)
        {
            this.channel = channel;
            Console.WriteLine($"csatorna beallitva");
        }
        public void AdjustVolume(bool change)
        {
            if (change)
            {
                this.volume += 10;
                Console.WriteLine($"felhangositva, a hangero: {this.volume}");
            }
            else
            {
                this.volume -= 10;
                Console.WriteLine($"lehalkitva, a hangero: {this.volume}");
            }
        }
    }
}
