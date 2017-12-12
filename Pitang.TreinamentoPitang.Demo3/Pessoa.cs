using System;

namespace Pitang.TreinamentoPitang.Demo3
{
    public class Pessoa
    {
        public Pessoa()
        {
        }

        public Pessoa(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;
        }

        public string Nome { get; set; }

        public int Idade { get; set; }

        public Endereco Endereco { get; set; }

        //public void IncrementerIdade(ref int anos)
        //{
        //    this.Idade += anos;
        //    anos += 1000;
        //}
        public void IncrementerIdade(int anos)
        {
            this.Idade += anos;
            anos = 1000;
        }

        public int IncrementerIdade(out int anos)
        {
            anos = 1000;

            this.Idade += anos;
            return Idade;
        }

        public override string ToString()
        {
            return $"Nome: {Nome}, Idade: {Idade}, Endereço: {Endereco} ";
        }
    }
}
