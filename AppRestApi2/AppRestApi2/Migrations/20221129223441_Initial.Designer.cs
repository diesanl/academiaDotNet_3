// <auto-generated />
using AppRestApi2;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppRestApi2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221129223441_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AlunoCurso", b =>
                {
                    b.Property<int>("listaAlunosid")
                        .HasColumnType("int");

                    b.Property<int>("listaCursosid")
                        .HasColumnType("int");

                    b.HasKey("listaAlunosid", "listaCursosid");

                    b.HasIndex("listaCursosid");

                    b.ToTable("AlunoCurso");
                });

            modelBuilder.Entity("AppRestApi2.DataModels.Aluno", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.HasKey("id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("AppRestApi2.DataModels.Curso", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("AppRestApi2.DataModels.Matricula", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("alunoid")
                        .HasColumnType("int");

                    b.Property<int>("cursoid")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("alunoid");

                    b.HasIndex("cursoid");

                    b.ToTable("Matriculas");
                });

            modelBuilder.Entity("AlunoCurso", b =>
                {
                    b.HasOne("AppRestApi2.DataModels.Aluno", null)
                        .WithMany()
                        .HasForeignKey("listaAlunosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppRestApi2.DataModels.Curso", null)
                        .WithMany()
                        .HasForeignKey("listaCursosid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AppRestApi2.DataModels.Matricula", b =>
                {
                    b.HasOne("AppRestApi2.DataModels.Aluno", "aluno")
                        .WithMany("listaMatriculas")
                        .HasForeignKey("alunoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AppRestApi2.DataModels.Curso", "curso")
                        .WithMany()
                        .HasForeignKey("cursoid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("curso");
                });

            modelBuilder.Entity("AppRestApi2.DataModels.Aluno", b =>
                {
                    b.Navigation("listaMatriculas");
                });
#pragma warning restore 612, 618
        }
    }
}
