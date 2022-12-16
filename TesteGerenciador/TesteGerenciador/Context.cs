
using Microsoft.EntityFrameworkCore;

namespace TesteGerenciador
{
    public class Context : DbContext
    {
        public DbSet<PessoaModel> Pessoa { get; set; }

        public DbSet<RefeicaoModel> Refeicao { get; set; }

        public DbSet<SonoModel> Sono { get; set; }
        public Context(DbContextOptions<Context> context) : base(context)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PessoaModel>()
                .HasKey(p => new
                {
                    p.RefeicaoId,
                    p.SonoId
                });
        }
    }
}
