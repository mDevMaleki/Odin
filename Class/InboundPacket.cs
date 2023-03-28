
namespace OdinProtocol.Class
{
    internal class InboundPacket : Packet
    {
        private bool sizeVariable;
        private uint receivedSize;
        public bool IsSizeVariable { get { return sizeVariable; } }
        public uint ReceivedSize { get { return receivedSize; } set { this.receivedSize = value; } }
        public InboundPacket(uint size, bool sizeVariable) : base(size)
        {
            this.sizeVariable = sizeVariable;
            this.sizeVariable = sizeVariable;
        }
        public InboundPacket(uint receivedSize) : base(receivedSize)
        {
            this.sizeVariable = false;
            this.receivedSize = receivedSize;
        }


        protected uint UnpackInteger(uint offset)
        {

            uint value = (uint)((Data[offset] << 24) | (Data[offset + 1] << 16) | (Data[offset + 2] << 8) | Data[offset + 3]);
            //unsigned int value = data[offset] | (data[offset + 1] << 8) |
            //(data[offset + 2] << 16) | (data[offset + 3] << 24);
            //#endif
            return (value);
        }

        protected virtual bool Unpack() { return false; }
    }
}
