using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOS_Buscas_V2.Migrations
{
    /// <inheritdoc />
    public partial class teste : Migration
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
                    Nascimento = table.Column<DateTime>(type: "DateTime", nullable: false)
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
                    NomeCompleto = table.Column<string>(type: "varchar(80)", nullable: false),
                    CaminhoImagem = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    EstiloCorCabelo = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    CorPele = table.Column<string>(type: "varchar(15)", nullable: false),
                    Altura = table.Column<string>(type: "varchar(5)", nullable: false),
                    Tatoagem = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Vestimenta = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    DataHoraDesaparecimento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    Mediacacoes = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Doencas = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Transtornos = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Observacoes = table.Column<string>(type: "nvarchar(250)", nullable: true),
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

            migrationBuilder.CreateTable(
                name: "Avistamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiaHoraAvistamento = table.Column<DateTime>(type: "DateTime", nullable: false),
                    DescricaoDesaparecido = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    DesaparecidoId = table.Column<int>(type: "int", nullable: false),
                    UserEmail = table.Column<string>(type: "varchar(45)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avistamentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Avistamentos_Desaparecidos_DesaparecidoId",
                        column: x => x.DesaparecidoId,
                        principalTable: "Desaparecidos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Avistamentos_Usuarios_UserEmail",
                        column: x => x.UserEmail,
                        principalTable: "Usuarios",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "varchar(20)", nullable: false),
                    Numero = table.Column<string>(type: "varchar(6)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(30)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(20)", nullable: false),
                    Municipio = table.Column<string>(type: "varchar(15)", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    DesaparecidoId = table.Column<int>(type: "int", nullable: true),
                    UserEmail = table.Column<string>(type: "varchar(45)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Endereco_Desaparecidos_DesaparecidoId",
                        column: x => x.DesaparecidoId,
                        principalTable: "Desaparecidos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Endereco_Usuarios_UserEmail",
                        column: x => x.UserEmail,
                        principalTable: "Usuarios",
                        principalColumn: "Email");
                });

            migrationBuilder.CreateTable(
                name: "localAvistamentoModels",
                columns: table => new
                {
                    Rua = table.Column<string>(type: "varchar(20)", nullable: true),
                    Bairro = table.Column<string>(type: "varchar(20)", nullable: false),
                    Municipio = table.Column<string>(type: "varchar(15)", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    PontoReferencia = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    AvistamentoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_localAvistamentoModels_Avistamentos_AvistamentoID",
                        column: x => x.AvistamentoID,
                        principalTable: "Avistamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Avistamentos_DesaparecidoId",
                table: "Avistamentos",
                column: "DesaparecidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Avistamentos_UserEmail",
                table: "Avistamentos",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_Desaparecidos_EmailUsuario",
                table: "Desaparecidos",
                column: "EmailUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_DesaparecidoId",
                table: "Endereco",
                column: "DesaparecidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_UserEmail",
                table: "Endereco",
                column: "UserEmail");

            migrationBuilder.CreateIndex(
                name: "IX_localAvistamentoModels_AvistamentoID",
                table: "localAvistamentoModels",
                column: "AvistamentoID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "localAvistamentoModels");

            migrationBuilder.DropTable(
                name: "Avistamentos");

            migrationBuilder.DropTable(
                name: "Desaparecidos");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
