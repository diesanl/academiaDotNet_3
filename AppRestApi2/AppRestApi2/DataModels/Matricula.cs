namespace AppRestApi2.DataModels
{
    public class Matricula
    {
        public int id { get; set; }

        public virtual Aluno aluno { get; set; }

        public virtual Curso curso { get; set; }

    }
}
