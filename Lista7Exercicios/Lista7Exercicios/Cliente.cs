using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    public class Cliente
    {
        public int id;
        public string nome;
        public int idade;
        public string timeCoracao;

        public Cliente()
        {
        }

        public Cliente(int id, string nome, int idade, string timeCoracao)
        {
            this.id = id;
            this.nome = nome;
            this.idade = idade;
            this.timeCoracao = timeCoracao;
        }
    }
}
