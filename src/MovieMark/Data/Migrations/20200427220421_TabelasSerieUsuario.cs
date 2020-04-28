using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieMark.Data.Migrations
{
    public partial class TabelasSerieUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodio_Temporada_TemporadaId",
                table: "Episodio");

            migrationBuilder.DropForeignKey(
                name: "FK_Temporada_Serie_SerieId",
                table: "Temporada");

            migrationBuilder.AlterColumn<int>(
                name: "SerieId",
                table: "Temporada",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TemporadaId",
                table: "Episodio",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "UserSerie",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AspNetUsersId = table.Column<string>(nullable: true),
                    SerieId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSerie", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTemporadaEpisodio",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: true),
                    TemporadaId = table.Column<int>(nullable: false),
                    EpisodioId = table.Column<int>(nullable: false),
                    UserSerieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTemporadaEpisodio", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserTemporadaEpisodio_UserSerie_UserSerieId",
                        column: x => x.UserSerieId,
                        principalTable: "UserSerie",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserTemporadaEpisodio_UserSerieId",
                table: "UserTemporadaEpisodio",
                column: "UserSerieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Episodio_Temporada_TemporadaId",
                table: "Episodio",
                column: "TemporadaId",
                principalTable: "Temporada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Temporada_Serie_SerieId",
                table: "Temporada",
                column: "SerieId",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Episodio_Temporada_TemporadaId",
                table: "Episodio");

            migrationBuilder.DropForeignKey(
                name: "FK_Temporada_Serie_SerieId",
                table: "Temporada");

            migrationBuilder.DropTable(
                name: "UserTemporadaEpisodio");

            migrationBuilder.DropTable(
                name: "UserSerie");

            migrationBuilder.AlterColumn<int>(
                name: "SerieId",
                table: "Temporada",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "TemporadaId",
                table: "Episodio",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Episodio_Temporada_TemporadaId",
                table: "Episodio",
                column: "TemporadaId",
                principalTable: "Temporada",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Temporada_Serie_SerieId",
                table: "Temporada",
                column: "SerieId",
                principalTable: "Serie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
