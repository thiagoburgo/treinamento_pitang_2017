using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitang.TreinamentoPitang.Demo7
{
    public abstract class Stream : IDisposable
    {
        protected Stream(long bufferLength) {
            this.BufferLength = bufferLength;
            this.Buffer = new byte[this.BufferLength];
        }

        public long BufferLength { get; }

        public byte[] Buffer { get; }

        public void ClearBuffer() {
            Array.Clear(this.Buffer, 0, this.Buffer.Length);
        }

        public abstract void Write(byte[] bytesToWrite);

        public abstract byte[] Read();

        public void Dispose() {
            this.ClearBuffer();
        }
    }
}
