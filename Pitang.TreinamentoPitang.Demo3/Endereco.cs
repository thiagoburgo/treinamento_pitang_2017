namespace Pitang.TreinamentoPitang.Demo3
{
    public class Endereco
    {
        public string Logradouro { get; set; }

        public string Numero { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public override string ToString()
        {
            return $"Logradouro: {Logradouro}, Numero: {Numero}, Cidade: {Cidade}, Estado: {Estado}";
        }
    }
}