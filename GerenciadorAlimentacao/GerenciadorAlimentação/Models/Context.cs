using Microsoft.EntityFrameworkCore;

namespace GerenciadorAlimentacao.Models
{
    public class Context : DbContext
    {
        public DbSet<PessoaModel> Pessoa { get; set; }

        public DbSet<RefeicaoModel> Refeicao { get; set; }

        public DbSet<SonoModel> Sono { get; set; }

        public Context() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Data Source=localhost; Initial Catalog=GerenciadorAlimentacao;" +
                "User ID=GerenciadorAlimentacao; Password=GerenciadorAlimentacao; language=Portuguese; Connect Timeout=15;Encrypt=False;" +
                "Trusted_Connection=True; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RefeicaoModel>()
                .HasOne(r => r.Pessoa)
                .WithMany(p => p.ListaRefeicoes);
            //TODO?
            //.OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<SonoModel>()
                .HasOne(s => s.Pessoa)
                .WithMany(p => p.ListaSono);

        }

    }
}
