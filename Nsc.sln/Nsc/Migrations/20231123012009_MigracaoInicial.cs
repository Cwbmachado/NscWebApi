using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nsc.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    PagamentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CadastroId = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    ReservaId = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataReservaId = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DataEscolhidaId = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ValorId = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    ValorPagoId = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    ValorRestanteId = table.Column<int>(type: "int", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.PagamentoId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Reservas",
                columns: table => new
                {
                    ReservaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataReservaId = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataEscolhidaId = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    QtdePessoas = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    ValorId = table.Column<int>(type: "int", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reservas", x => x.ReservaId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Cadastros",
                columns: table => new
                {
                    CadastroId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ReservaId = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    Nome = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DataCadastro = table.Column<DateTime>(type: "datetime(6)", maxLength: 300, nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IdRG = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    IdCPF = table.Column<int>(type: "int", maxLength: 80, nullable: false),
                    Endereco = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Cidade = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Estado = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Pais = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EstadoCivil = table.Column<string>(type: "varchar(80)", maxLength: 80, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Profissao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cadastros", x => x.CadastroId);
                    table.ForeignKey(
                        name: "FK_Cadastros_Reservas_ReservaId",
                        column: x => x.ReservaId,
                        principalTable: "Reservas",
                        principalColumn: "ReservaId",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Cadastros_ReservaId",
                table: "Cadastros",
                column: "ReservaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cadastros");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "Reservas");
        }
    }
}
