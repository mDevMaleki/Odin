
namespace OdinProtocol.Class
{

    public enum kControlType
    {
        Session = 0x64,
        PitFile = 0x65,
        FileTransfer = 0x66,
        EndSession = 0x67
    };

    internal class ControlPacket : OutboundPacket
    {
        protected int kDataSize { get { return 4; } }
       
        public ControlPacket(uint controlType) : base(1024)
        {
            this.controlType = controlType;
        }

        private uint controlType;
        public uint ControlType { get { return controlType; } }



        protected virtual void Pack()
        {
            PackInteger(0, controlType);
        }


    }
}
