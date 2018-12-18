using Microsoft.EntityFrameworkCore.Migrations;

namespace Adagio.Data.Migrations
{
    public partial class FixedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Alumno_Alumnoid",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Clase_Claseid",
                table: "Matricula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matricula",
                table: "Matricula");

            migrationBuilder.DropIndex(
                name: "IX_Matricula_Alumnoid",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "idAlumno",
                table: "Matricula");

            migrationBuilder.DropColumn(
                name: "idClase",
                table: "Matricula");

            migrationBuilder.RenameColumn(
                name: "Claseid",
                table: "Matricula",
                newName: "ClaseId");

            migrationBuilder.RenameColumn(
                name: "Alumnoid",
                table: "Matricula",
                newName: "AlumnoId");

            migrationBuilder.RenameIndex(
                name: "IX_Matricula_Claseid",
                table: "Matricula",
                newName: "IX_Matricula_ClaseId");

            migrationBuilder.AlterColumn<int>(
                name: "ClaseId",
                table: "Matricula",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AlumnoId",
                table: "Matricula",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matricula",
                table: "Matricula",
                columns: new[] { "AlumnoId", "ClaseId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Alumno_AlumnoId",
                table: "Matricula",
                column: "AlumnoId",
                principalTable: "Alumno",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Clase_ClaseId",
                table: "Matricula",
                column: "ClaseId",
                principalTable: "Clase",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Alumno_AlumnoId",
                table: "Matricula");

            migrationBuilder.DropForeignKey(
                name: "FK_Matricula_Clase_ClaseId",
                table: "Matricula");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Matricula",
                table: "Matricula");

            migrationBuilder.RenameColumn(
                name: "ClaseId",
                table: "Matricula",
                newName: "Claseid");

            migrationBuilder.RenameColumn(
                name: "AlumnoId",
                table: "Matricula",
                newName: "Alumnoid");

            migrationBuilder.RenameIndex(
                name: "IX_Matricula_ClaseId",
                table: "Matricula",
                newName: "IX_Matricula_Claseid");

            migrationBuilder.AlterColumn<int>(
                name: "Claseid",
                table: "Matricula",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Alumnoid",
                table: "Matricula",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "idAlumno",
                table: "Matricula",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "idClase",
                table: "Matricula",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Matricula",
                table: "Matricula",
                columns: new[] { "idAlumno", "idClase" });

            migrationBuilder.CreateIndex(
                name: "IX_Matricula_Alumnoid",
                table: "Matricula",
                column: "Alumnoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Alumno_Alumnoid",
                table: "Matricula",
                column: "Alumnoid",
                principalTable: "Alumno",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Matricula_Clase_Claseid",
                table: "Matricula",
                column: "Claseid",
                principalTable: "Clase",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
