using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{
    internal class FilePartSizePacket : SessionSetupPacket
    {

        private uint filePartSize;

        public uint FilePartSize { get { return filePartSize; } }
        public FilePartSizePacket(uint filePartSize) : base(Convert.ToUInt32(SessionType.kFilePartSize))
        {
            this.filePartSize = filePartSize;
        }


        protected override void Pack()
        {
            base.Pack();

            PackInteger(kDataSize, filePartSize);
        }
    }
}
