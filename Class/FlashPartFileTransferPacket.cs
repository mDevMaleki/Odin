

namespace OdinProtocol.Class
{
    internal class FlashPartFileTransferPacket: FileTransferPacket
    {
        private uint sequenceByteCount;
        public uint SequenceByteCount { get { return sequenceByteCount; } }

        public FlashPartFileTransferPacket(uint sequenceByteCount) : base(Convert.ToUInt32(kRequest.Part))
        {
            this.sequenceByteCount = sequenceByteCount;
        }


        protected override void Pack()
        {
            base.Pack();

            PackInteger(kDataSize, sequenceByteCount);
        }

    }
}
