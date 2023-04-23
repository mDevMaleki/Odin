using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{
    internal class FlashPartPitFilePacket : PitFilePacket
    {
        private uint partSize;

        public uint PartSize { get { return partSize; } }

        public FlashPartPitFilePacket(uint partSize) : base(Convert.ToUInt32(kRequest.Part))
        {
            this.partSize = partSize;
        }

        protected override void Pack()
        {
            base.Pack();

            PackInteger(kDataSize, partSize);
        }

    }
}
