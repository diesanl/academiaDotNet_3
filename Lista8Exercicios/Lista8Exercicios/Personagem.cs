using System.Runtime.CompilerServices;

namespace Lista8Exercicios
{
    public class Personagem
    {
        private string _nome;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private int _poder;

        public int Poder
        {
            get { return _poder; }
            set { _poder = value; }
        }

        public Personagem()
        {
            Nome = "";
            Poder = 0;
        }

        public Personagem(string nome, int poder)
        {
            Nome = nome;
            Poder = poder;
        }

        public override string? ToString()
        {
            return "Nome: " + _nome+ "\n" +
                   "Poder: " + _poder + "\n";
        }
    }
}

