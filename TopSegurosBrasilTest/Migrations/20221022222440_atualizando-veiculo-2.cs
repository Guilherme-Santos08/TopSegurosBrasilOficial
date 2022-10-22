using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopSegurosBrasil.Migrations
{
    public partial class atualizandoveiculo2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Veiculo");

            migrationBuilder.RenameColumn(
                name: "Modelo",
                table: "Veiculo",
                newName: "VersaoDoModelo");

            migrationBuilder.RenameColumn(
                name: "ApoliceId",
                table: "Veiculo",
                newName: "FabricanteId");

            migrationBuilder.AddColumn<int>(
                name: "AnoDosModeloId",
                table: "Veiculo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AnoDoModelo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnoModelo = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnoDoModelo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fabricante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeDoFabricante = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fabricante", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_AnoDosModeloId",
                table: "Veiculo",
                column: "AnoDosModeloId");

            migrationBuilder.CreateIndex(
                name: "IX_Veiculo_FabricanteId",
                table: "Veiculo",
                column: "FabricanteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_AnoDoModelo_AnoDosModeloId",
                table: "Veiculo",
                column: "AnoDosModeloId",
                principalTable: "AnoDoModelo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculo_Fabricante_FabricanteId",
                table: "Veiculo",
                column: "FabricanteId",
                principalTable: "Fabricante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_AnoDoModelo_AnoDosModeloId",
                table: "Veiculo");

            migrationBuilder.DropForeignKey(
                name: "FK_Veiculo_Fabricante_FabricanteId",
                table: "Veiculo");

            migrationBuilder.DropTable(
                name: "AnoDoModelo");

            migrationBuilder.DropTable(
                name: "Fabricante");

            migrationBuilder.DropIndex(
                name: "IX_Veiculo_AnoDosModeloId",
                table: "Veiculo");

            migrationBuilder.DropIndex(
                name: "IX_Veiculo_FabricanteId",
                table: "Veiculo");

            migrationBuilder.DropColumn(
                name: "AnoDosModeloId",
                table: "Veiculo");

            migrationBuilder.RenameColumn(
                name: "VersaoDoModelo",
                table: "Veiculo",
                newName: "Modelo");

            migrationBuilder.RenameColumn(
                name: "FabricanteId",
                table: "Veiculo",
                newName: "ApoliceId");

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Veiculo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
