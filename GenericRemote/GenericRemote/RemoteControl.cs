using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRemote
{
    internal class RemoteControl<T>
    {
        private T eszkoz;

        public RemoteControl(T eszkoz)
        {
            this.eszkoz = eszkoz;
        }

        public T Eszkoz { get => eszkoz; set => eszkoz = value; }

        public void Power_on()
        {
            this.eszkoz.Status = true;
            Console.WriteLine("az eszkoz bekapcsolt");
        }
    }
}
