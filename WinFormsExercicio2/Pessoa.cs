namespace WinFormsExercicio2
{
    public class Pessoa : IComparable<Pessoa>, IEquatable<Pessoa?>
    {
        public Pessoa()
        {
        }

        public Pessoa(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public string Nome { get; set; }
        public string Email { get; set; }

        public int CompareTo(Pessoa p)
        {
            return Nome.CompareTo(p.Nome);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Pessoa);
        }

        public bool Equals(Pessoa? other)
        {
            return other is not null &&
                   Nome == other.Nome &&
                   Email == other.Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Email);
        }

        //public int CompareTo(Pessoa pessoa)
        //{
        //    return Nome.CompareTo(pessoa.Nome);
        //}


    }
}