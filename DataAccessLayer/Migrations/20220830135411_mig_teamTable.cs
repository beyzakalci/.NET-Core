using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_teamTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterID",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WriterID1",
                table: "Messages",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    TeamID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.TeamID);
                });

            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    MatchID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HomeTeamID = table.Column<int>(type: "int", nullable: true),
                    GuestTeamID = table.Column<int>(type: "int", nullable: true),
                    MatchDate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Stadium = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.MatchID);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_GuestTeamID",
                        column: x => x.GuestTeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Matches_Teams_HomeTeamID",
                        column: x => x.HomeTeamID,
                        principalTable: "Teams",
                        principalColumn: "TeamID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Messages_WriterID",
                table: "Messages",
                column: "WriterID");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_WriterID1",
                table: "Messages",
                column: "WriterID1");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_GuestTeamID",
                table: "Matches",
                column: "GuestTeamID");

            migrationBuilder.CreateIndex(
                name: "IX_Matches_HomeTeamID",
                table: "Matches",
                column: "HomeTeamID");

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_WriterID",
                table: "Messages",
                column: "WriterID",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Messages_Writers_WriterID1",
                table: "Messages",
                column: "WriterID1",
                principalTable: "Writers",
                principalColumn: "WriterID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_WriterID",
                table: "Messages");

            migrationBuilder.DropForeignKey(
                name: "FK_Messages_Writers_WriterID1",
                table: "Messages");

            migrationBuilder.DropTable(
                name: "Matches");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Messages_WriterID",
                table: "Messages");

            migrationBuilder.DropIndex(
                name: "IX_Messages_WriterID1",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "WriterID",
                table: "Messages");

            migrationBuilder.DropColumn(
                name: "WriterID1",
                table: "Messages");
        }
    }
}
