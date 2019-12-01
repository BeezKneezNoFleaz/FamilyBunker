using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FamilyBunker.Migrations
{
    public partial class FixFamilyBunkerLastNickNameToString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "nickName",
                table: "Members",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Members",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(DateTime),
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "nickName",
                table: "Members",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "lastName",
                table: "Members",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
