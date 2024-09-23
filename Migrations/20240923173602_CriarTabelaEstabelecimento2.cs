using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IHCFormsFatecSO.Migrations
{
    /// <inheritdoc />
    public partial class CriarTabelaEstabelecimento2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Estabelecimento",
                columns: table => new
                {
                    CnpjBasico = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    CnpjOrdem = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CnpjDv = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NomeFantasia = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    DataSituacaoCadastral = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CnaePrincipal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TpLogradouro = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Logradouro = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Bairro = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UF = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estabelecimento", x => new { x.CnpjBasico, x.CnpjOrdem, x.CnpjDv });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Estabelecimento");
        }
    }
}
