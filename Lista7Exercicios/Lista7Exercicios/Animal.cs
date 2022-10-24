using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    internal abstract class Animal
    {

        private String nome;
        private String sexo;
        private String raca;

        public Animal()
        {

        }
        public Animal(string nome, string sexo, string raca)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.raca = raca;
        }

        //+emitir som: int -> retornaria inteiro
        public abstract void EmitirSom();

        public void Dormir()
        {
            Console.WriteLine("A mimir");
        }
        public void Caminhar()
        {
            Console.WriteLine("Caminhando o individuo");
        }
    }
}
