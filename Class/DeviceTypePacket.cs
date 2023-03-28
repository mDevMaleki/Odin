
namespace OdinProtocol.Class
{
    internal class DeviceTypePacket : SessionSetupPacket
    {
        public DeviceTypePacket() : base(Convert.ToUInt32(SessionType.kDeviceType))
        {
        }
    }
}
