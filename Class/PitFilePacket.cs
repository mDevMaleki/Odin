using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{
  

	internal class PitFilePacket:ControlPacket
    {
        private uint request;


        public uint Request { get { return request; } }

        protected new int kDataSize { get { return base.kDataSize + 4; } }

        public PitFilePacket(uint request) : base(Convert.ToUInt32(kControlType.PitFile))
        {
            this.request = request;
        }

     


        protected override void Pack()
        {
            base.Pack();

            PackInteger(base.kDataSize, request);
        }

    }
}
