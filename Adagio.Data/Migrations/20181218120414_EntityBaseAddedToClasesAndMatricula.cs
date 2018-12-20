using Microsoft.EntityFrameworkCore.Migrations;

namespace Adagio.Data.Migrations
{
    public partial class EntityBaseAddedToClasesAndMatricula : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "id",
                table: "Matricula",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "id",
                table: "Matricula");
        }
    }
}
