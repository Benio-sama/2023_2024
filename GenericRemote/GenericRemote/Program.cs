using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRemote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            RemoteControl<TV> tvremote = new RemoteControl<TV>(tv);
            tvremote.Power_on();
            tvremote.Volume_up();
            tvremote.Volume_up();
            tvremote.Volume_up();
            tvremote.Volume_up();
            tvremote.Volume_down();
            tvremote.Power_off();

            Console.ReadKey();
        }
    }
}
