using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitang.TreinamentoPitang.Demo7
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream stream = new FileStream(500);
            using (stream)
            {
                ((FileStream)stream).Read();
                stream.Write(new[]{
                    (byte)new Random(DateTime.Now.Millisecond).Next(0, 255),
                    (byte)new Random(DateTime.Now.Millisecond).Next(0, 255),
                    (byte)new Random(DateTime.Now.Millisecond).Next(0, 255),
                    (byte)new Random(DateTime.Now.Millisecond).Next(0, 255),
                    (byte)new Random(DateTime.Now.Millisecond).Next(0, 255)
                });

                Console.WriteLine($"Buffer: [{string.Join(",", stream.Buffer)}]");

            }

            Console.WriteLine($"Buffer: [{string.Join(",", stream.Buffer)}]");



        }
    }
}
