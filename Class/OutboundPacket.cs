

namespace OdinProtocol.Class
{
    internal class OutboundPacket : Packet
    {


        public OutboundPacket(uint size) : base(size)
        {       }


        public void PackInteger(int offset, uint value)
        {

            Data[offset] = Convert.ToChar((value & 0xFF000000) >> 24);
            Data[offset + 1] = Convert.ToChar((value & 0x00FF0000) >> 16);
            Data[offset + 2] = Convert.ToChar((value & 0x0000FF00) >> 8);
            Data[offset + 3] = Convert.ToChar(value & 0x000000FF);

            //// Flip endianness
            //Data[offset] = Convert.ToChar(value & 0x000000FF);
            //Data[offset + 1] = Convert.ToChar((value & 0x0000FF00) >> 8);
            //Data[offset + 2] = Convert.ToChar((value & 0x00FF0000) >> 16);
            //Data[offset + 3] = Convert.ToChar((value & 0xFF000000) >> 24);

        }

        public void PackShort(uint offset, ushort value)
        {

            Data[offset] = Convert.ToChar((value & 0xFF00) >> 8);
            Data[offset + 1] = Convert.ToChar(value & 0x00FF);

            //// Flip endianness
            //ِata[offset] = value & 0x00FF;
            //ِata[offset + 1] = (value & 0xFF00) >> 8;

        }


       
    }
}
