
namespace OdinProtocol.Class
{
    internal class DumpPartFileTransferPacket : FileTransferPacket
    {
        private uint partIndex;
        public uint PartIndex { get { return partIndex; } }
        public DumpPartFileTransferPacket(uint partIndex) : base(Convert.ToUInt32(kRequest.Part))
        {
            this.partIndex = partIndex;
        }

        protected override void Pack()
        {
            base.Pack();
            PackInteger(kDataSize, partIndex);
        }
    }
}

