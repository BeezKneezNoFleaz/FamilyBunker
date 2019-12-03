using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyBunker.Migrations
{
    public partial class addFamilyCodeNameToMembers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FamilyCodeName",
                table: "Members",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyCodeName",
                table: "groceryLists",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyCodeName",
                table: "Calendars",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FamilyCodeName",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "FamilyCodeName",
                table: "groceryLists");

            migrationBuilder.DropColumn(
                name: "FamilyCodeName",
                table: "Calendars");
        }
    }
}
