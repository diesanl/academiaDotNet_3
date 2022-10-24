using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Exercicios
{
    internal class Agenda
    {
        public List<Pessoa> listaPessoas = new List<Pessoa>();

        /*
         * void armazenaPessoa(String nome, int idade, float altura);
            void removePessoa(String nome);
            int buscaPessoa(String nome); // informa em que posição da agenda está a pessoa
            void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
         */

        public void removePessoa(String nome)
        {
            Pessoa pessoa = buscaPessoa(nome);
            if (pessoa != null)
            {
                listaPessoas.Remove(pessoa);
                Console.WriteLine("Contato {0} removido(a) com sucesso!!!", pessoa.nome);
            }
            else
            {
                Console.WriteLine("Contato não existente");
            }
        }

        public void armazenaPessoa(String nome, int idade, float altura)
        {
            Pessoa pessoa1 = new Pessoa(nome, idade, altura);

            if (!listaPessoas.Contains(pessoa1))
            {
                listaPessoas.Add(pessoa1);
            }
            else
            {
                Console.WriteLine("Pessoa já inserida na Agenda");
            }
        }

        public Pessoa buscaPessoa(String nome)
        {
            Pessoa pessoa = new Pessoa();
            foreach (var p in listaPessoas)
            {
                if (nome == p.nome)
                {
                    pessoa = p;
                }
            }
            return pessoa;
        }

        public void imprimeAgenda()
        {
            foreach (var pessoa in listaPessoas)
            {
                Console.WriteLine("Nome: {0} \n" +
                                  "Idade: {1} \n" +
                                  "Altura: {2} \n", pessoa.nome, pessoa.idade, pessoa.altura.ToString("F"));
            }
        }

        internal void armazenaPessoa(Pessoa pessoa)
        {
            listaPessoas.Add(pessoa);
        }
    }
}
