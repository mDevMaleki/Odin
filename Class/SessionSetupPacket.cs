
namespace OdinProtocol.Class
{

    public enum SessionType	{
		kBeginSession = 0,
		kDeviceType = 1, // ?
		kTotalBytes = 2,
		//kEnableSomeSortOfFlag = 3,
		kFilePartSize = 5,
		kEnableTFlash = 8
	};
    internal class SessionSetupPacket : ControlPacket
    {
        private uint request;
        protected new int kDataSize { get { return base.kDataSize + 4; } }
        public SessionSetupPacket(uint request) : base(Convert.ToUInt32(kControlType.Session))
        {
            this.request = request;
        }
        protected override  void Pack()
        {
            base.Pack();
            PackInteger(base.kDataSize, request);
        }
    }
}
