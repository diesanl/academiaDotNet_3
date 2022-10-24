namespace Lista7Exercicios
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
        public int peso;
        public Pessoa pai;
        public Pessoa mae;

        public Pessoa()
        {
        }

        public Pessoa(string nome, int idade, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
        }

        public Pessoa(string nome, int idade, double altura, int peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
        }
        public Pessoa(string nome, int idade, double altura, int peso, Pessoa pai, Pessoa mae)
        {
            this.nome = nome;
            this.idade = idade;
            this.altura = altura;
            this.peso = peso;
            this.pai = pai;
            this.mae = mae;
        }



        public override string? ToString()
        {
            return "Nome: " + nome + "\n" +
                   "Idade: " + idade + "\n" +
                   "Altura: " + altura.ToString("F") + "\n" +
                   "Peso: " + peso + "\n" +
                   "Pai: " + pai + "\n" +
                   "Mãe: " + mae + "\n";
        }
    }
}