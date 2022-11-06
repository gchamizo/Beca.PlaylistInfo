using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Beca.PlaylistInfo.API.Migrations
{
    public partial class PlaylistInfoDBInitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Artist = table.Column<string>(type: "TEXT", maxLength: 300, nullable: true),
                    PlaylistId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Playlists_PlaylistId",
                        column: x => x.PlaylistId,
                        principalTable: "Playlists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 1, "Así suena internet.", "Viral España" });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 2, "Abba are back! All their essential tracks in one.", "This is ABBA" });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 3, "¡Mora, Paulo Londra & Feid, Quevedo, Rels B y más!", "Novedades Viernes" });

            migrationBuilder.InsertData(
                table: "Playlists",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[] { 4, "Lo mejor del rock de aquí (y de allá), como Andrés Calamaro.", "Rock Español" });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 1, "La Joaqui, Alan Gomez, ELNOBA", "Butakera", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 2, "Kaydy Cain, La Zowi, Kabasaki", "Ping Pong", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 3, "Rauw Alejandro, Baby Rasta", "PUNTO 40", 1 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 4, "ABBA", "Waterloo", 2 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 5, "ABBA", "Lay all your love on me", 2 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 6, "Mora, Quevedo", "APA", 3 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 7, "Paulo Londra, Feid", "A veces", 3 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 8, "Rels B", "pa quererte", 3 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 9, "Estopa", "Como Camarón", 4 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 10, "Extremoduro", "Si te vas", 4 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 11, "Loquillo", "Cadillac Solitario", 4 });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Artist", "Name", "PlaylistId" },
                values: new object[] { 12, "Celtas Cortos", "20 de abril", 4 });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_PlaylistId",
                table: "Songs",
                column: "PlaylistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Playlists");
        }
    }
}
