using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOS_Buscas_V2.Migrations
{
    /// <inheritdoc />
    public partial class alterandoTabelaDesaparecido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Email = table.Column<string>(type: "varchar(45)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false),
                    CPF = table.Column<string>(type: "varchar(11)", nullable: false),
                    Nome = table.Column<string>(type: "varchar(35)", nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(45)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(45)", nullable: false),
                    Nascimento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Endereco = table.Column<string>(type: "varchar(100)", nullable: false),
                    Contato = table.Column<string>(type: "varchar(45)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "Desaparecidos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CPF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NomeCompleto = table.Column<string>(type: "varchar(80)", nullable: false),
                    CaminhoImagem = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EstiloCorCabelo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CorPele = table.Column<string>(type: "varchar(15)", nullable: false),
                    Altura = table.Column<string>(type: "varchar(5)", nullable: false),
                    Tatuagem = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    Vestimenta = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    DataHoraDesaparecimento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Medicacoes = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Doencas = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Transtornos = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    NomeFamiliar = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    ContatoFamiliar = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    GrauParentesco = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    NomeFamiliar2 = table.Column<string>(type: "nvarchar(80)", nullable: true),
                    ContatoFamiliar2 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    GrauParentesco2 = table.Column<string>(type: "nvarchar(20)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Avistamento = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    Observacoes = table.Column<string>(type: "nvarchar(300)", nullable: true),
                    EmailUsuario = table.Column<string>(type: "varchar(45)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desaparecidos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Desaparecidos_Usuarios_EmailUsuario",
                        column: x => x.EmailUsuario,
                        principalTable: "Usuarios",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Desaparecidos_EmailUsuario",
                table: "Desaparecidos",
                column: "EmailUsuario");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Desaparecidos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
