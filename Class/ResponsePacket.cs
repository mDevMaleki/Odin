using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{

    public enum kResponseType
	{
		SendFilePart = 0x00,
		SessionSetup = 0x64,
		PitFile = 0x65,
		FileTransfer = 0x66,
		EndSession = 0x67
	};

	


	internal class ResponsePacket : InboundPacket
    {


		private uint responseType;
        public uint ResponseType { get { return responseType; } }

        protected uint kDataSize { get { return 4; } }
		public ResponsePacket(uint responseType) : base(8)
        {
			this.responseType = responseType;
		}



		protected override bool Unpack()
		{
			uint receivedResponseType = UnpackInteger(0);
			if (receivedResponseType != responseType)
			{
				responseType = receivedResponseType;
				return (false);
			}

			return (true);
		}
	}
}
