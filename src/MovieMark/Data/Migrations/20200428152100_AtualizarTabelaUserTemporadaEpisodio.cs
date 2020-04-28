using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieMark.Data.Migrations
{
    public partial class AtualizarTabelaUserTemporadaEpisodio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserId",
                table: "UserTemporadaEpisodio");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "UserTemporadaEpisodio",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
