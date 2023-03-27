using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{
    internal class BeginSessionPacket : SessionSetupPacket
    {
        public BeginSessionPacket() : base(Convert.ToUInt32(SessionType.kBeginSession))
        {
        }
    }
}
