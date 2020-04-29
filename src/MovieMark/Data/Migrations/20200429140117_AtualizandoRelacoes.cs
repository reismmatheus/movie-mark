using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieMark.Data.Migrations
{
    public partial class AtualizandoRelacoes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_UserTemporadaEpisodio_EpisodioId",
                table: "UserTemporadaEpisodio",
                column: "EpisodioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserTemporadaEpisodio_TemporadaId",
                table: "UserTemporadaEpisodio",
                column: "TemporadaId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_UserTemporadaEpisodio_Episodio_EpisodioId",
                table: "UserTemporadaEpisodio",
                column: "EpisodioId",
                principalTable: "Episodio",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserTemporadaEpisodio_Temporada_TemporadaId",
                table: "UserTemporadaEpisodio",
                column: "TemporadaId",
                principalTable: "Temporada",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserTemporadaEpisodio_Episodio_EpisodioId",
                table: "UserTemporadaEpisodio");

            migrationBuilder.DropForeignKey(
                name: "FK_UserTemporadaEpisodio_Temporada_TemporadaId",
                table: "UserTemporadaEpisodio");

            migrationBuilder.DropIndex(
                name: "IX_UserTemporadaEpisodio_EpisodioId",
                table: "UserTemporadaEpisodio");

            migrationBuilder.DropIndex(
                name: "IX_UserTemporadaEpisodio_TemporadaId",
                table: "UserTemporadaEpisodio");
        }
    }
}
