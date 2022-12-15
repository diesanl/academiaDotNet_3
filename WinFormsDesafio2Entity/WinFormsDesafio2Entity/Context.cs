using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsDesafio2Entity.Objects;

namespace WinFormsDesafio2Entity
{
    public class Context : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=localhost; " +
                                        "Initial Catalog=Desafio2Entity; Use ID=Desafio2Entity " +
                                        "password=Desafio2Entity; language=Portuguese; Trusted_Connection=True; " +
                                        "TrustServerCertificate=True;");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pedido>()
                .HasOne(p => p.cliente)
                .WithMany(c => c.listapedidos)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Produto>()
                .HasOne(p => p.fornecedor)
                .WithMany(f => f.listaProdutos)
                .OnDelete(DeleteBehavior.ClientCascade);

            modelBuilder.Entity<Pedido>()
                .HasMany(c => c.listaProdutos)
                .WithOne(p => p.pedido)
                .OnDelete(DeleteBehavior.ClientCascade);
        }

    }
}
