using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericRemote
{
    internal interface Device
    {
        void PowerOn();
        void PowerOff();
        void SetChannel(int channel);
        void AdjustVolume(bool valtozas);
    }
}
