using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitang.TreinamentoPitang.Demo5
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();
            Console.WriteLine(ret);
            ret.Base = 10;
            ret.Altura = 10;
            Console.WriteLine(ret);
            TestarTiposPorValor(ret);
            Console.WriteLine(ret);
        }

        public static void TestarTiposPorValor(Retangulo rect)
        {
            rect.Altura = 1000;

            Console.WriteLine(rect);
        }
    }
}
