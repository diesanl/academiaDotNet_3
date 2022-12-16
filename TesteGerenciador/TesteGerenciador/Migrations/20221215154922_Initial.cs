using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TesteGerenciador.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    RefeicaoId = table.Column<int>(type: "int", nullable: false),
                    SonoId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => new { x.RefeicaoId, x.SonoId });
                });

            migrationBuilder.CreateTable(
                name: "Refeicao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PessoaRefeicaoId = table.Column<int>(type: "int", nullable: false),
                    PessoaSonoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Refeicao", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Refeicao_Pessoa_PessoaRefeicaoId_PessoaSonoId",
                        columns: x => new { x.PessoaRefeicaoId, x.PessoaSonoId },
                        principalTable: "Pessoa",
                        principalColumns: new[] { "RefeicaoId", "SonoId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sono",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HorarioInicio = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HorarioFim = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PessoaRefeicaoId = table.Column<int>(type: "int", nullable: false),
                    PessoaSonoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sono", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sono_Pessoa_PessoaRefeicaoId_PessoaSonoId",
                        columns: x => new { x.PessoaRefeicaoId, x.PessoaSonoId },
                        principalTable: "Pessoa",
                        principalColumns: new[] { "RefeicaoId", "SonoId" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Refeicao_PessoaRefeicaoId_PessoaSonoId",
                table: "Refeicao",
                columns: new[] { "PessoaRefeicaoId", "PessoaSonoId" });

            migrationBuilder.CreateIndex(
                name: "IX_Sono_PessoaRefeicaoId_PessoaSonoId",
                table: "Sono",
                columns: new[] { "PessoaRefeicaoId", "PessoaSonoId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Refeicao");

            migrationBuilder.DropTable(
                name: "Sono");

            migrationBuilder.DropTable(
                name: "Pessoa");
        }
    }
}
