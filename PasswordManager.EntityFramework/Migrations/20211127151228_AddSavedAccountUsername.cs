using Microsoft.EntityFrameworkCore.Migrations;

namespace PasswordManager.EntityFramework.Migrations
{
    public partial class AddSavedAccountUsername : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Username",
                table: "SavedAccounts",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Username",
                table: "SavedAccounts");
        }
    }
}
