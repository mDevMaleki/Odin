using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{
    internal class EndModemFileTransferPacket : EndFileTransferPacket
    {
        private uint endOfFile;

        public bool IsEndOfFile { get { return (endOfFile == 1); } }
        public EndModemFileTransferPacket(uint sequenceByteCount, uint unknown1, uint chipIdentifier,  bool endOfFile) : base(Convert.ToUInt32(kDestination.Modem), sequenceByteCount, unknown1, chipIdentifier)
        {
            this.endOfFile = (uint)(endOfFile ? 1 : 0);
        }

        protected override void Pack()
        {
            base.Pack();

            PackInteger(base.kDataSize, endOfFile);
        }

    }
}
