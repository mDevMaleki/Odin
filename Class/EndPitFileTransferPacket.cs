using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{
    internal class EndPitFileTransferPacket:PitFilePacket
    {
        private uint fileSize;


        public uint FileSize { get { return fileSize; } }
        public EndPitFileTransferPacket(uint fileSize) : base(Convert.ToUInt32(kRequest.EndTransfer))
        {
            this.fileSize = fileSize;
        }


        protected override  void Pack()
        {
            base.Pack();

            PackInteger(kDataSize, fileSize);
        }
    }
}
