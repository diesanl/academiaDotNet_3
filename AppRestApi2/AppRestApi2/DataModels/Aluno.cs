namespace AppRestApi2.DataModels
{
    public class Aluno
    {
        public int id { get; set; }

        public virtual ICollection<Matricula> listaMatriculas { get; set; }

        public virtual ICollection<Curso> listaCursos { get; set; }


    }
}
