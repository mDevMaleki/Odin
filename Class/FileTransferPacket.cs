
namespace OdinProtocol.Class
{

    public enum kRequest
    {
        Flash = 0x00,
        Dump = 0x01,
        Part = 0x02,
        End = 0x03,
        EndTransfer = 0x03,
        EndSession = 0,
        RebootDevice = 1
    };


    internal class FileTransferPacket : ControlPacket
    {
        protected new int kDataSize { get { return base.kDataSize + 4; } }
        private uint request;

        public FileTransferPacket(uint request) : base(Convert.ToUInt32(kControlType.FileTransfer))
        {
            this.request = request;
        }


        protected override void Pack()
        {
            base.Pack();
            PackInteger(base.kDataSize, request);
        }
    }
}
