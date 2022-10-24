using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    internal class Leao : Animal
    {
        private int peso;

        public Leao(string nome, string sexo, string raca) : base(nome, sexo, raca)
        {
        }

        public Leao(string nome, string sexo, string raca, int peso) : base(nome, sexo, raca)
        {
            this.peso = peso;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Leão Berrando");
        }

        public override string? ToString()
        {
            return "";
        }
    }
}
