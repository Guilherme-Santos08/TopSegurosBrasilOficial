using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TopSegurosBrasil.Migrations
{
    public partial class removendocolunasapolice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescApolice",
                table: "Apolice");

            migrationBuilder.DropColumn(
                name: "ValorApolice",
                table: "Apolice");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DescApolice",
                table: "Apolice",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "ValorApolice",
                table: "Apolice",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
