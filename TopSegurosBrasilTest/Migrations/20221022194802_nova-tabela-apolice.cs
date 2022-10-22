using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopSegurosBrasil.Migrations
{
    public partial class novatabelaapolice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VeiculoId",
                table: "Apolice",
                newName: "PlanoDoSeguroId");

            migrationBuilder.CreateTable(
                name: "PlanoDoSeguro",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDoPlano = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<double>(type: "float", nullable: false),
                    AnexoPdf = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanoDoSeguro", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Apolice_PlanoDoSeguroId",
                table: "Apolice",
                column: "PlanoDoSeguroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Apolice_PlanoDoSeguro_PlanoDoSeguroId",
                table: "Apolice",
                column: "PlanoDoSeguroId",
                principalTable: "PlanoDoSeguro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Apolice_PlanoDoSeguro_PlanoDoSeguroId",
                table: "Apolice");

            migrationBuilder.DropTable(
                name: "PlanoDoSeguro");

            migrationBuilder.DropIndex(
                name: "IX_Apolice_PlanoDoSeguroId",
                table: "Apolice");

            migrationBuilder.RenameColumn(
                name: "PlanoDoSeguroId",
                table: "Apolice",
                newName: "VeiculoId");
        }
    }
}
