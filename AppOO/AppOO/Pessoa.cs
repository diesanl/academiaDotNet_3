using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppOO
{
    internal class Pessoa
    {
        private String sexo;
        private String nome;
        private int idade;
        private String timeCoracao;
        private double altura;
        private double peso;

        public Pessoa()
        {

        }

        public Pessoa(string sexo, string nome, int idade, string timeCoracao, double altura, double peso)
        {
            this.sexo = sexo ?? throw new ArgumentNullException(nameof(sexo));
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.idade = idade;
            this.timeCoracao = timeCoracao ?? throw new ArgumentNullException(nameof(timeCoracao));
            this.altura = altura;
            this.peso = peso;
        }

        public override string ToString()
        {
            return "Sexo: " + sexo + "\n" +
                   "Nome: " + nome + "\n" +
                   "Idade: " + idade + " anos\n" +
                   "Time do Coração: " + timeCoracao + "\n" +
                   "Altura: " + altura.ToString("F") + "\n" +
                   "Peso: " + peso.ToString("F") + "\n";

        }
    }
}
