using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExam.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HobbyId1",
                table: "Hobbies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_HobbyId1",
                table: "Hobbies",
                column: "HobbyId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_Hobbies_HobbyId1",
                table: "Hobbies",
                column: "HobbyId1",
                principalTable: "Hobbies",
                principalColumn: "HobbyId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Hobbies_HobbyId1",
                table: "Hobbies");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_HobbyId1",
                table: "Hobbies");

            migrationBuilder.DropColumn(
                name: "HobbyId1",
                table: "Hobbies");
        }
    }
}
