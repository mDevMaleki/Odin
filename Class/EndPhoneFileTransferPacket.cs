using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{

	/*public enum kFile
		{
			PrimaryBootloader			= 0x00,
			Pit						= 0x01, // New 1.1 - Don't flash the pit this way!
			SecondaryBootloader		= 0x03,
			SecondaryBootloaderBackup	= 0x04,	// New 1.1
			Kernel						= 0x06,
			Recovery					= 0x07,	// New 1.1

			TabletModem				= 0x08, // New 1.2

			Efs						= 0x14, // New 1.1
			ParamLfs					= 0x15,
			FactoryFilesystem			= 0x16,
			DatabaseData				= 0x17,
			Cache						= 0x18,

			Modem						= 0x0B	// New 1.1 - Kies flashes the modem this way rather than using the EndModemFileTransferPacket.
		};*/
	internal class EndPhoneFileTransferPacket: EndFileTransferPacket
    {
		private uint fileIdentifier;
		private uint endOfFile;

		public bool IsEndOfFile { get { return (endOfFile == 1); } }
        public uint FileIdentifier { get { return fileIdentifier; } }
        public EndPhoneFileTransferPacket(uint sequenceByteCount, uint unknown1, uint chipIdentifier,uint fileIdentifier, bool endOfFile) : base(Convert.ToUInt32(kDestination.Phone), sequenceByteCount, unknown1, chipIdentifier)
		{
			this.fileIdentifier = fileIdentifier;
			this.endOfFile = (uint)(endOfFile ? 1 : 0);
		}

		protected override void Pack()
		{
			base.Pack();

			PackInteger(kDataSize, fileIdentifier);
			PackInteger(kDataSize + 4, endOfFile);
		}
	}
}
