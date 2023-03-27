
namespace OdinProtocol.Class
{
    public enum kChipType
    {
        Ram = 0,
        Nand = 1
    };

    internal class BeginDumpPacket : FileTransferPacket
    {
        private uint chipType;
        private uint chipId;

        public uint ChipType { get { return chipType; } }
        public uint ChipId { get { return chipId; } }

        public BeginDumpPacket(uint chipType, uint chipId) : base(Convert.ToUInt32(kRequest.Dump))
        {
            this.chipType = chipType;
            this.chipId = chipId;
        }


        protected override void Pack()
        {
            base.Pack();
            PackInteger(kDataSize, chipType);
            PackInteger(kDataSize + 4, chipId);
        }
    }
}
