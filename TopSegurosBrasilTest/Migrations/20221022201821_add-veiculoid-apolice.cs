using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopSegurosBrasil.Migrations
{
    public partial class addveiculoidapolice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VeiculoId",
                table: "Apolice",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VeiculoId",
                table: "Apolice");
        }
    }
}
