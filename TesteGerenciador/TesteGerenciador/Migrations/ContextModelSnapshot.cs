﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TesteGerenciador;

#nullable disable

namespace TesteGerenciador.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TesteGerenciador.PessoaModel", b =>
                {
                    b.Property<int>("RefeicaoId")
                        .HasColumnType("int");

                    b.Property<int>("SonoId")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RefeicaoId", "SonoId");

                    b.ToTable("Pessoa");
                });

            modelBuilder.Entity("TesteGerenciador.RefeicaoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Hora")
                        .HasColumnType("datetime2");

                    b.Property<int>("PessoaRefeicaoId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaSonoId")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaRefeicaoId", "PessoaSonoId");

                    b.ToTable("Refeicao");
                });

            modelBuilder.Entity("TesteGerenciador.SonoModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HorarioFim")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("HorarioInicio")
                        .HasColumnType("datetime2");

                    b.Property<int>("PessoaRefeicaoId")
                        .HasColumnType("int");

                    b.Property<int>("PessoaSonoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PessoaRefeicaoId", "PessoaSonoId");

                    b.ToTable("Sono");
                });

            modelBuilder.Entity("TesteGerenciador.RefeicaoModel", b =>
                {
                    b.HasOne("TesteGerenciador.PessoaModel", "Pessoa")
                        .WithMany("ListaRefeicoes")
                        .HasForeignKey("PessoaRefeicaoId", "PessoaSonoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("TesteGerenciador.SonoModel", b =>
                {
                    b.HasOne("TesteGerenciador.PessoaModel", "Pessoa")
                        .WithMany("ListaSono")
                        .HasForeignKey("PessoaRefeicaoId", "PessoaSonoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("TesteGerenciador.PessoaModel", b =>
                {
                    b.Navigation("ListaRefeicoes");

                    b.Navigation("ListaSono");
                });
#pragma warning restore 612, 618
        }
    }
}