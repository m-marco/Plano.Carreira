using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Plano.Carreira.Infra.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Departamentos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Referencias",
                columns: table => new
                {
                    Codigo = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<decimal>(type: "decimal(8,2)", precision: 8, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Referencias", x => x.Codigo);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Setores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DepartamentoId = table.Column<int>(type: "int", nullable: false),
                    Nome = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Setores_Departamentos_DepartamentoId",
                        column: x => x.DepartamentoId,
                        principalTable: "Departamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Gabinete Presidência" },
                    { 2, "Procuradoria Legislativa" },
                    { 3, "Comunicação Social" },
                    { 4, "Administrativo e de Documentação" },
                    { 5, "Financeiro" },
                    { 6, "Legislativo" },
                    { 7, "Tecnologia da Informação" },
                    { 8, "Controladoria Interna" }
                });

            migrationBuilder.InsertData(
                table: "Setores",
                columns: new[] { "Id", "DepartamentoId", "Nome" },
                values: new object[,]
                {
                    { 1, 3, "Jornalismo" },
                    { 2, 3, "Produção" },
                    { 3, 3, "Cerimonial" },
                    { 4, 4, "Compras e Contratos" },
                    { 5, 4, "Infraestrutura e Logística" },
                    { 6, 4, "Recursos Humanos" },
                    { 7, 4, "Gestão de Documentação e Arquivo" },
                    { 8, 5, "Finanças" },
                    { 9, 5, "Contabilidade e de Patrimônio" },
                    { 10, 6, "Gestão de Projetos Legislativos" },
                    { 11, 6, "Gestão de Instrumentos Legislativos" },
                    { 12, 6, "Atividades Plenárias" },
                    { 13, 6, "Escola do Legislativo" },
                    { 14, 6, "Escola do Legislativo" },
                    { 15, 7, "Suporte de Tecnologia da Informação" },
                    { 16, 7, "Desenvolvimento de Sistemas" },
                    { 17, 7, "Infraestrutura de Tecnologia da Informação" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Setores_DepartamentoId",
                table: "Setores",
                column: "DepartamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Referencias");

            migrationBuilder.DropTable(
                name: "Setores");

            migrationBuilder.DropTable(
                name: "Departamentos");
        }
    }
}
