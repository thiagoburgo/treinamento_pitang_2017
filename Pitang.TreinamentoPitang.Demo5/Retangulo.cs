using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitang.TreinamentoPitang.Demo5
{
    public struct Retangulo : IForma
    {
        // private int teste; //deve inicializar inclusive membros privados
        //public Retangulo()
        //{
            
        //}
        public Retangulo(float basex, float altura)
        {
            this.Base = basex;
            this.Altura = altura;
            this.Area = Base * Altura;
        }

        public float Base { get; set; }
        public float Altura { get; set; }

        public override string ToString()
        {
            return $"{Base} x {Altura}";
        }

        public float Area { get; set; }
    }
}
