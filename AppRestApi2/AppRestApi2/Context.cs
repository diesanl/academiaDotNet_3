using Microsoft.EntityFrameworkCore;
using AppRestApi2.DataModels;

namespace AppRestApi2
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; " +
                                        "Initial Catalog=AtosEntity4; User ID=AtosEntity4 " +
                                        "password=AtosEntity4; language=Portuguese; Trusted_Connection=True; " +
                                        "TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //aluno tem lista de curso, e cada curso tem lista de alunos
            modelBuilder.Entity<Aluno>()
                .HasMany(a => a.listaCursos)
                .WithMany(c => c.listaAlunos);

            //cada matricula tem um aluno que, pode ter varias matriculas
            modelBuilder.Entity<Matricula>()
                .HasOne(m => m.aluno)
                .WithMany(a => a.listaMatriculas);
        }
    }
}
