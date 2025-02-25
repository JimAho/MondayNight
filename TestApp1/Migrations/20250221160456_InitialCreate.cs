using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestApp1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamListing",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Team = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mascot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfLastWin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WinningPercentage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wins = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Losses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ties = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Games = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamListing", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamListing");
        }
    }
}
