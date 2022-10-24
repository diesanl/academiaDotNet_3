using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    internal class Cachorro : Animal
    {
        public Cachorro()
        {
        }

        public Cachorro(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Latindo o vira-latas");
        }
    }
}
