using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieMark.Data.Migrations
{
    public partial class UserSerieUnique : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AspNetUsersId",
                table: "UserSerie",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserSerie_AspNetUsersId_SerieId",
                table: "UserSerie",
                columns: new[] { "AspNetUsersId", "SerieId" },
                unique: true,
                filter: "[AspNetUsersId] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_UserSerie_AspNetUsersId_SerieId",
                table: "UserSerie");

            migrationBuilder.AlterColumn<string>(
                name: "AspNetUsersId",
                table: "UserSerie",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
