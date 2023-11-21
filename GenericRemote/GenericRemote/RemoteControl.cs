using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRemote
{
    internal class RemoteControl<T> where T : Device
    {
        private T eszkoz;

        public RemoteControl(T eszkoz)
        {
            this.eszkoz = eszkoz;
        }

        public T Eszkoz { get => eszkoz; set => eszkoz = value; }

        public void Power_on()
        {
            this.eszkoz.PowerOn();
            //Console.WriteLine("az eszkoz bekapcsolt");
        }
        public void Power_off() 
        {
            this.eszkoz.PowerOff();
            //Console.WriteLine("az eszkoz kikapcsolva");
        }
        public void Change_channel(int channel)
        {
            this.eszkoz.SetChannel(channel);
            //Console.WriteLine($"a csatorna a {channel}. csatornara allitva");
        }
        public void Volume_up()
        {
            this.eszkoz.AdjustVolume(true);
            //Console.WriteLine("az eszkoz felhangositva");
        }

        public void Volume_down()
        {
            this.eszkoz.AdjustVolume(false);
            //Console.WriteLine("az eszkoz lehalkitva");
        }
    }
}
