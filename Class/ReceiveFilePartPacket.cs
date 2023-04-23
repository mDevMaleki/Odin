using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{
    internal class ReceiveFilePartPacket : InboundPacket
    {
        //ToDo
        //private uint kDataSize = 500;
      

        public ReceiveFilePartPacket() : base(500, true)
        {
        }

        protected override bool Unpack()
        {
            return (true);
        }
    }
}
