using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdinProtocol.Class
{
    internal class Packet
    {

        public uint Size { get { return size;} set { size = value; } }

        public char[] Data { get { return data; } set { data = value; } }

        private uint size;

        private char[] data;

        public Packet(uint size) => this.size = size;

    }

}

