using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitang.TreinamentoPitang.Demo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Cyan;
            //Console.ForegroundColor = ConsoleColor.White;
            Pessoa burgo = new Pessoa(3) {
                Nome = "Thiago Burgo",
                Idade = 33
            };

            Console.WriteLine($"Hello {burgo}!");
        }
    }

    public class Pessoa
    {
        //public const int NumeroDeAlma = 1;
        public readonly int NumeroDeAlma;

        private string nome;

        public Pessoa(int numeroAlma)
        {
            NumeroDeAlma = numeroAlma;
        }

        public int Idade { get; set; }

        public string Nome
        {
            get
            {
                Console.WriteLine("Passei no GET!");

                return nome +  " O LINDO";
            }
            set
            {
                Console.WriteLine("Passei no SET!");
                nome = value;
            }
        }

        public override string ToString()
        {
            return this.Nome;
        }
    }
}
