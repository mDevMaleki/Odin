
namespace OdinProtocol.Class
{
    internal class Packet
    {

        public uint Size { get { return size;} set { size = value; } }

        public char[] Data { get { return data; } set { data = value; } }

        private uint size;

        private char[] data;

        public Packet(uint size)
        {
            this.size = size;
        }
    }

}

