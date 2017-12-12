using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitang.TreinamentoPitang.Demo4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TipoPerfil tipoPerfil = (TipoPerfil)10;

            for (TipoPerfil i = TipoPerfil.Diretor; i < TipoPerfil.Estagiario; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(tipoPerfil);
            Console.WriteLine((int)tipoPerfil);

            foreach (string name in Enum.GetNames(typeof(TipoPerfil)))
            {
                Console.WriteLine(name);
            }
            TipoPerfil tipoPerfilParsed = (TipoPerfil) Enum.Parse(typeof(TipoPerfil), "Diretor");
            Console.WriteLine($"Parsed: {tipoPerfilParsed}");

            switch (tipoPerfil)
            {
                case TipoPerfil.Diretor:
                    break;
                case TipoPerfil.Desenvolvedor:
                    Console.WriteLine("Sofredor...");
                    break;
                case TipoPerfil.Faxineiro:
                    break;
                case TipoPerfil.Estagiario:
                    Console.WriteLine("Caras legais...");
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
