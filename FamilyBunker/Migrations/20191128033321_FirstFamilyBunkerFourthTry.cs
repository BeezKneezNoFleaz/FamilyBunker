using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyBunker.Migrations
{
    public partial class FirstFamilyBunkerFourthTry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "quantity",
                table: "groceryLists",
                nullable: false,
                oldClrType: typeof(decimal));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "quantity",
                table: "groceryLists",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
