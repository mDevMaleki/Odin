
namespace OdinProtocol.Class
{
    internal class EndFileTransferPacket : FileTransferPacket
    {
        public enum kDestination
        {
            Phone = 0x00,
            Modem = 0x01
        };
        protected new int kDataSize { get { return base.kDataSize + 16; } }

        private uint destination;           // PDA / Modem
        private uint sequenceByteCount;
        private uint unknown1; // EFS?
        private uint deviceType;


        public uint Destination { get { return destination; } }
        public uint SequenceByteCount { get { return sequenceByteCount; } }
        public uint Unknown1 { get { return unknown1; } }
        public uint DeviceType { get { return deviceType; } }




        public EndFileTransferPacket(uint destination, uint sequenceByteCount, uint unknown1, uint deviceType) : base(Convert.ToUInt32(kRequest.End))
        {
            this.destination = destination;
            this.sequenceByteCount = sequenceByteCount;
            this.unknown1 = unknown1;
            this.deviceType = deviceType;
        }
        protected override void Pack()
        {
            base.Pack();

            PackInteger(base.kDataSize, destination);
            PackInteger(base.kDataSize + 4, sequenceByteCount);
            PackInteger(base.kDataSize + 8, unknown1);
            PackInteger(base.kDataSize + 12, deviceType);
        }
    }
}
