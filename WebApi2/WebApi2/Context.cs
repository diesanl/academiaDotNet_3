using Microsoft.EntityFrameworkCore;
using WebApi2.DataModels;

namespace WebApi2
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; " +
                                        "Initial Catalog=AtosEntity3; User ID=AtosEntity3 " +
                                        "password=AtosEntity3; language=Portuguese; Trusted_Connection=True; " +
                                        "TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }
    }

}
