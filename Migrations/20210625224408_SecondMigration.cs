using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeltExam.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryOfHobbyCategoryId",
                table: "Hobbies",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.CategoryId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_CategoryOfHobbyCategoryId",
                table: "Hobbies",
                column: "CategoryOfHobbyCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Hobbies_Category_CategoryOfHobbyCategoryId",
                table: "Hobbies",
                column: "CategoryOfHobbyCategoryId",
                principalTable: "Category",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Hobbies_Category_CategoryOfHobbyCategoryId",
                table: "Hobbies");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Hobbies_CategoryOfHobbyCategoryId",
                table: "Hobbies");

            migrationBuilder.DropColumn(
                name: "CategoryOfHobbyCategoryId",
                table: "Hobbies");
        }
    }
}
