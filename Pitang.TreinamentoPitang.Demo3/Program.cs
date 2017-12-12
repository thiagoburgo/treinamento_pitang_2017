using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitang.TreinamentoPitang.Demo3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Pessoa burgo = new Pessoa("Thiago Burgo", 33);
            Pessoa jose = new Pessoa("Thiago Burgo", 33);



            Console.WriteLine("-------------------------------");
            Console.WriteLine(jose);
            Console.WriteLine("===============================");
            Console.WriteLine(burgo);
            Console.WriteLine("-------------------------------");


            Console.WriteLine($"burgo == jose? {burgo == jose}");

            Endereco endereco = new Endereco()
            {
                Cidade = "Recife",
                Estado = "PE",
                Logradouro = "Rua do Apolo",
                Numero = "81"
            };

            jose.Nome = "José da Silva";
            jose.Endereco = endereco;
            jose.Idade = 20;


            burgo.Nome = "Thiago Burgo Lindo!";
            burgo.Endereco = endereco;

            Console.WriteLine("-------------------------------");
            Console.WriteLine(jose);
            Console.WriteLine("===============================");
            Console.WriteLine(burgo);
            Console.WriteLine("-------------------------------");


            jose = burgo;


            Console.WriteLine("----------- jose = burgo--------");
            Console.WriteLine(jose);
            Console.WriteLine("===============================");
            Console.WriteLine(burgo);
            Console.WriteLine("-------------------------------");

            jose.Nome = "Zé Lezin";

            Console.WriteLine("-----------  jose.Nome = \"Zé Lezin\";--------");
            Console.WriteLine(jose);
            Console.WriteLine("===============================");
            Console.WriteLine(burgo);
            Console.WriteLine("-------------------------------");

            Console.WriteLine($"burgo == jose? {burgo == jose}");


            Console.WriteLine("++++++++++++++++++++++++++++++++++++");

            int anos;
            burgo.IncrementerIdade(out anos);
            burgo.IncrementerIdade(out anos);
            Console.WriteLine(burgo);
            Console.WriteLine($"Anos: {anos}");


            Console.WriteLine("Digite um número: ");
            string numeroEmTexto = Console.ReadLine();
            double numero;

            if (double.TryParse(numeroEmTexto, out numero))
            {
                Console.WriteLine($"Muito bem, você é alfabetizado! {numero}");
            }
            else
            {
                Console.WriteLine($"Eu disse um NUMERO, ANIMAL! {numeroEmTexto}");

            }

        }
    }
}
