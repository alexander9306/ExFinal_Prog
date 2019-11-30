using Microsoft.EntityFrameworkCore.Migrations;

namespace Final.Web.Migrations
{
    public partial class ExFinal_Damaso_5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departamento_visita_visitaidvisita",
                table: "departamento");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_visita_visitaidvisita",
                table: "persona");

            migrationBuilder.RenameColumn(
                name: "visitaidvisita",
                table: "persona",
                newName: "Visitaidvisita");

            migrationBuilder.RenameIndex(
                name: "IX_persona_visitaidvisita",
                table: "persona",
                newName: "IX_persona_Visitaidvisita");

            migrationBuilder.RenameColumn(
                name: "visitaidvisita",
                table: "departamento",
                newName: "Visitaidvisita");

            migrationBuilder.RenameIndex(
                name: "IX_departamento_visitaidvisita",
                table: "departamento",
                newName: "IX_departamento_Visitaidvisita");

            migrationBuilder.AddColumn<string>(
                name: "Persona",
                table: "visita",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_departamento_visita_Visitaidvisita",
                table: "departamento",
                column: "Visitaidvisita",
                principalTable: "visita",
                principalColumn: "idvisita",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_persona_visita_Visitaidvisita",
                table: "persona",
                column: "Visitaidvisita",
                principalTable: "visita",
                principalColumn: "idvisita",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departamento_visita_Visitaidvisita",
                table: "departamento");

            migrationBuilder.DropForeignKey(
                name: "FK_persona_visita_Visitaidvisita",
                table: "persona");

            migrationBuilder.DropColumn(
                name: "Persona",
                table: "visita");

            migrationBuilder.RenameColumn(
                name: "Visitaidvisita",
                table: "persona",
                newName: "visitaidvisita");

            migrationBuilder.RenameIndex(
                name: "IX_persona_Visitaidvisita",
                table: "persona",
                newName: "IX_persona_visitaidvisita");

            migrationBuilder.RenameColumn(
                name: "Visitaidvisita",
                table: "departamento",
                newName: "visitaidvisita");

            migrationBuilder.RenameIndex(
                name: "IX_departamento_Visitaidvisita",
                table: "departamento",
                newName: "IX_departamento_visitaidvisita");

            migrationBuilder.AddForeignKey(
                name: "FK_departamento_visita_visitaidvisita",
                table: "departamento",
                column: "visitaidvisita",
                principalTable: "visita",
                principalColumn: "idvisita",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_persona_visita_visitaidvisita",
                table: "persona",
                column: "visitaidvisita",
                principalTable: "visita",
                principalColumn: "idvisita",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
