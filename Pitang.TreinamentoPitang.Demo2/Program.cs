using System;
using System.Diagnostics;
using System.Text;

namespace Pitang.TreinamentoPitang.Demo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Stopwatch stopwatch = new Stopwatch();
            Stopwatch stopwatch = Stopwatch.StartNew();
            FazerOperacoesComStringBuilder();
            stopwatch.Stop();
            Console.WriteLine($"Tempo de execução: {stopwatch.ElapsedMilliseconds}ms");

        }

        public static void FazerOperacoesComString()
        {
            string inicial = "Thiago Burgo é lindo!";
            for (int i = 0; i < 1000000; i++)
            {
                //inicial += $"{i}vezes\n";
                inicial = inicial + $"{i}vezes\n";
            }
            
        }
        public static void FazerOperacoesComStringBuilder()
        {
            StringBuilder inicial = new StringBuilder("Thiago Burgo é lindo!");
            for (int i = 0; i < 10000000; i++)
            {
                //inicial += $"{i}vezes\n";
                //inicial = inicial + $"{i}vezes\n";
                inicial.AppendLine($"{i}vezes");
            }
            //Console.WriteLine(inicial.ToString());
            string final = inicial.ToString();
           
        }
    }
}
