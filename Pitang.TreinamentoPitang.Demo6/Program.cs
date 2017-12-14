using System;
using System.CodeDom;
using System.Collections.Generic;

namespace Pitang.TreinamentoPitang.Demo6 {
    internal class Program {
        private static void Main(string[] args) {

            Animal a1 = new Cachorro("Poodle");
            Animal a2 = new Pato("Patolino");
            Animal a3 = new Cachorro("Vira-Lata");

            List<Animal> animais = new List<Animal>() {
                a1, a2, a3
            };

            VacinarAnimais(animais);
            
        }

        public static void VacinarAnimais(List<Animal> animais) {
            foreach (Animal animal in animais) {
                Console.WriteLine("Vacinando animal: " + animal.Raca);
                animal.Respirar();
            }
        }
    }

    public class Animal {
        
        public Animal(string raca) {
            Raca = raca;
        }

        public string Raca { get; set; }

        public virtual void Respirar() {
            Console.WriteLine("Animal preparando para respirar...");
        }
    }

    public class Cachorro : Animal {
        //public Cachorro(string raca) : base(raca) {
        //}
        public Cachorro(string raca) : base(raca)
        {
            
        }
        public override void Respirar() {
            base.Respirar();
            Console.WriteLine("Cachorro está respirando...");
        }
    }

    public class Pato : Animal {
        public override void Respirar() {
            base.Respirar();
            Console.WriteLine("Pato respirando...");
        }

        public Pato(string raca) : base(raca) {
        }
    }
}