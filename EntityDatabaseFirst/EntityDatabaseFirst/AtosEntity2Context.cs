using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntityDatabaseFirst;

public partial class Contexto : DbContext
{
    public Contexto()
    {
    }

    public Contexto(DbContextOptions<Contexto> options)
        : base(options)
    {
    }

    public virtual DbSet<Email> Emails { get; set; }

    public virtual DbSet<Pessoa> Pessoas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=localhost;initial Catalog=AtosEntity2;User ID=AtosEntity2;password=Atos_Entity_2;language=Portuguese;Trusted_Connection=True;TrustServerCertificate=True;")
        .UseLazyLoadingProxies();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Email>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Emails__3213E83FC85F733C");

            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.email)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Pessoa).HasColumnName("fk_pessoa");

            entity.HasOne(d => d.FkPessoaNavigation).WithMany(p => p.listaEmails)
                .HasForeignKey(d => d.Pessoa)
                .HasConstraintName("FK__Emails__fk_pesso__267ABA7A");
        });

        modelBuilder.Entity<Pessoa>(entity =>
        {
            entity.HasKey(e => e.id).HasName("PK__Pessoas__3213E83FFA6D4D73");

            entity.Property(e => e.id).HasColumnName("id");
            entity.Property(e => e.nome)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nome");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
