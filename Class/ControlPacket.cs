using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{

    public enum kControlType
    {
        kControlTypeSession = 0x64,
        kControlTypePitFile = 0x65,
        kControlTypeFileTransfer = 0x66,
        kControlTypeEndSession = 0x67
    };

    internal class ControlPacket : OutboundPacket
    {
        protected const int kDataSize = 4;
        public ControlPacket(uint controlType) : base(1024)
        {
            this.controlType = controlType;
        }

        private uint controlType;
        public uint ControlType { get { return controlType; } }



        protected virtual void Pack()
        {
            PackInteger(0, controlType);
        }


    }
}
