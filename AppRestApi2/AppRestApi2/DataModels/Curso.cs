namespace AppRestApi2.DataModels
{
    public class Curso
    {
        public int id { get; set; }

        public string descricao { get; set; }

        public virtual ICollection<Aluno> listaAlunos { get; set; }
    }
}
