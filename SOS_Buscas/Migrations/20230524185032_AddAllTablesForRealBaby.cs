using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SOS_Buscas.Migrations
{
    /// <inheritdoc />
    public partial class AddAllTablesForRealBaby : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Descricao",
                columns: table => new
                {
                    Roupa = table.Column<string>(type: "varchar(100)", nullable: false),
                    TamanhoCabelo = table.Column<string>(type: "varchar(10)", nullable: false),
                    CorCabelo = table.Column<string>(type: "varchar(15)", nullable: false),
                    CorPele = table.Column<string>(type: "varchar(10)", nullable: false),
                    Tatuagem = table.Column<string>(type: "varchar(400)", nullable: false),
                    Observacoes = table.Column<string>(type: "varchar(500)", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    Altura = table.Column<double>(type: "float", nullable: false),
                    DesaparecidoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Descricao_Desaparecido_DesaparecidoID",
                        column: x => x.DesaparecidoID,
                        principalTable: "Desaparecido",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    CEP = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "varchar(50)", nullable: false),
                    Numero = table.Column<int>(type: "int", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(50)", nullable: false),
                    Municipio = table.Column<string>(type: "varchar(50)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(40)", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DesaparecidoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.CEP);
                    table.ForeignKey(
                        name: "FK_Endereco_Desaparecido_DesaparecidoID",
                        column: x => x.DesaparecidoID,
                        principalTable: "Desaparecido",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Endereco_Usuario_UserID",
                        column: x => x.UserID,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Familiar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(15)", nullable: false),
                    Sobrenome = table.Column<string>(type: "varchar(40)", nullable: false),
                    Idade = table.Column<int>(type: "int", nullable: false),
                    parentesco = table.Column<string>(type: "varchar(20)", nullable: false),
                    DesaparecidoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Familiar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Familiar_Desaparecido_DesaparecidoID",
                        column: x => x.DesaparecidoID,
                        principalTable: "Desaparecido",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "HistoricoAvistamentos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataDesaparecimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DesaparecidoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoricoAvistamentos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HistoricoAvistamentos_Desaparecido_DesaparecidoID",
                        column: x => x.DesaparecidoID,
                        principalTable: "Desaparecido",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_HistoricoAvistamentos_Usuario_UserID",
                        column: x => x.UserID,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "Telefone",
                columns: table => new
                {
                    Cod_Area = table.Column<int>(type: "int", nullable: false),
                    Numero = table.Column<string>(type: "varchar(15)", nullable: false),
                    DesaparecidoID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FamiliarID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Telefone_Desaparecido_DesaparecidoID",
                        column: x => x.DesaparecidoID,
                        principalTable: "Desaparecido",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Telefone_Familiar_FamiliarID",
                        column: x => x.FamiliarID,
                        principalTable: "Familiar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Telefone_Usuario_UserID",
                        column: x => x.UserID,
                        principalTable: "Usuario",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "LocalAvistamentos",
                columns: table => new
                {
                    Rua = table.Column<string>(type: "varchar(15)", nullable: false),
                    Bairro = table.Column<string>(type: "varchar(15)", nullable: false),
                    Municipio = table.Column<string>(type: "varchar(15)", nullable: false),
                    UF = table.Column<string>(type: "varchar(2)", nullable: false),
                    PontoReferencia = table.Column<string>(type: "varchar(100)", nullable: false),
                    AvistamentoID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_LocalAvistamentos_HistoricoAvistamentos_AvistamentoID",
                        column: x => x.AvistamentoID,
                        principalTable: "HistoricoAvistamentos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Descricao_DesaparecidoID",
                table: "Descricao",
                column: "DesaparecidoID");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_DesaparecidoID",
                table: "Endereco",
                column: "DesaparecidoID");

            migrationBuilder.CreateIndex(
                name: "IX_Endereco_UserID",
                table: "Endereco",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Familiar_DesaparecidoID",
                table: "Familiar",
                column: "DesaparecidoID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoAvistamentos_DesaparecidoID",
                table: "HistoricoAvistamentos",
                column: "DesaparecidoID");

            migrationBuilder.CreateIndex(
                name: "IX_HistoricoAvistamentos_UserID",
                table: "HistoricoAvistamentos",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_LocalAvistamentos_AvistamentoID",
                table: "LocalAvistamentos",
                column: "AvistamentoID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_DesaparecidoID",
                table: "Telefone",
                column: "DesaparecidoID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_FamiliarID",
                table: "Telefone",
                column: "FamiliarID");

            migrationBuilder.CreateIndex(
                name: "IX_Telefone_UserID",
                table: "Telefone",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Descricao");

            migrationBuilder.DropTable(
                name: "Endereco");

            migrationBuilder.DropTable(
                name: "LocalAvistamentos");

            migrationBuilder.DropTable(
                name: "Telefone");

            migrationBuilder.DropTable(
                name: "HistoricoAvistamentos");

            migrationBuilder.DropTable(
                name: "Familiar");
        }
    }
}
