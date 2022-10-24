namespace Lista8Exercicios
{
    internal class Animal
    {

        private string _nome;
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        private string _tipo;
        public string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        public Animal(string nome, string tipo)
        {
            _nome = nome;
            _tipo = tipo;
        }

        public override string ToString()
        {
            return "Nome: " + _nome + " - " + "Tipo: " + _tipo;
        }
    }
}