using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieMark.Data.Migrations
{
    public partial class AtualizacaoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTemporadaEpisodio_UserSerie_UserSerieId",
                table: "UserTemporadaEpisodio");

            migrationBuilder.AlterColumn<int>(
                name: "UserSerieId",
                table: "UserTemporadaEpisodio",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTemporadaEpisodio_UserSerie_UserSerieId",
                table: "UserTemporadaEpisodio",
                column: "UserSerieId",
                principalTable: "UserSerie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTemporadaEpisodio_UserSerie_UserSerieId",
                table: "UserTemporadaEpisodio");

            migrationBuilder.AlterColumn<int>(
                name: "UserSerieId",
                table: "UserTemporadaEpisodio",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_UserTemporadaEpisodio_UserSerie_UserSerieId",
                table: "UserTemporadaEpisodio",
                column: "UserSerieId",
                principalTable: "UserSerie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
