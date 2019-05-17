using Microsoft.EntityFrameworkCore.Migrations;

namespace BhadreshDudhat.VimeoApp.Migrations
{
    public partial class ChangeUserNoteModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "UserNotes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "UserNotes",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 2000);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserEmail",
                table: "UserNotes",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "UserNotes",
                maxLength: 2000,
                nullable: false,
                oldClrType: typeof(string));
        }
    }
}
