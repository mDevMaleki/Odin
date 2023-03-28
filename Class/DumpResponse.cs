using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{
    internal class DumpResponse : ResponsePacket
    {
        private uint dumpSize;
        public uint DumpSize { get { return dumpSize; } }
        public DumpResponse() : base(Convert.ToUInt32(kResponseType.FileTransfer))
        {
        }

        protected override bool Unpack()
        {
            if (!Unpack())
                return (false);

            dumpSize = UnpackInteger(kDataSize);

            return (true);
        }

    }
}
