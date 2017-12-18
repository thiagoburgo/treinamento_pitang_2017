using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitang.TreinamentoPitang.Demo7
{
    public class FileStream : Stream
    {
        public FileStream(long bufferLength) : base(bufferLength)
        {
        }

        public override void Write(byte[] bytesToWrite)
        {

            Array.Copy(bytesToWrite, this.Buffer, bytesToWrite.Length);
            Console.WriteLine($"Escrevendo para o disco os bytes: [{string.Join(",", bytesToWrite)}]");
        }

        public override byte[] Read()
        {
            byte[] bytesToRead = {
                10,
                11,
                34,
                35
            };

            Console.WriteLine($"Lendo do disco os bytes: [{string.Join(",", bytesToRead) }]");

            return bytesToRead;
        }

        public string Read(Encoding encoding)
        {
            return encoding.GetString(this.Read());
        }
    }
}
