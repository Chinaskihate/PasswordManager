using Microsoft.EntityFrameworkCore.Migrations;

namespace PasswordManager.EntityFramework.Migrations
{
    public partial class AddNamePropAndChangedPassToPassHash : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PasswordOfGroup",
                table: "PasswordGroups",
                newName: "PasswordOfGroupHash");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "PasswordGroups",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "PasswordGroups");

            migrationBuilder.RenameColumn(
                name: "PasswordOfGroupHash",
                table: "PasswordGroups",
                newName: "PasswordOfGroup");
        }
    }
}
