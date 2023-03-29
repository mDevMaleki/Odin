
namespace OdinProtocol.Class
{
    internal class DumpResponse : ResponsePacket
    {
        private uint dumpSize;
        public uint DumpSize { get { return dumpSize; } }
        public DumpResponse() : base(Convert.ToUInt32(kResponseType.FileTransfer))
        {
        }

        protected override bool Unpack()
        {
            if (!Unpack())
                return (false);

            dumpSize = UnpackInteger(kDataSize);

            return (true);
        }

    }
}
