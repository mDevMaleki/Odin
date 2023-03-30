using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{
    internal class EndSessionPacket : ControlPacket
    {
        private uint request;


        public uint Request { get { return request; } }

        protected new int kDataSize { get { return base.kDataSize + 4; } }

        public EndSessionPacket(uint request) : base(Convert.ToUInt32(kControlType.EndSession))
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
