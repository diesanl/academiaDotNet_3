namespace WinFormsApp4
{
    public class Jogador : IComparable<Jogador>
    {

        public string Nome { get; set; }
        public string Email { get; set; }

        public Jogador(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public override bool Equals(object? obj)
        {
            return obj is Jogador jogador &&
                   Nome == jogador.Nome &&
                   Email == jogador.Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Email);
        }

        public int CompareTo(Jogador jogador)
        {
            return this.Nome.CompareTo(jogador.Nome);
        }
    }
}