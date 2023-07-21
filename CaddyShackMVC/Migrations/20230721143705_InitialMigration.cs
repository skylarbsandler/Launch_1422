using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CaddyShackMVC.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "golf_bags",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    player = table.Column<string>(type: "text", nullable: false),
                    capacity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_golf_bags", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "clubs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "text", nullable: false),
                    golf_bag_id = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_clubs", x => x.id);
                    table.ForeignKey(
                        name: "fk_clubs_golf_bags_golf_bag_id",
                        column: x => x.golf_bag_id,
                        principalTable: "golf_bags",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "golf_bags",
                columns: new[] { "id", "capacity", "player" },
                values: new object[,]
                {
                    { 1, 18, "Sung-jae Im" },
                    { 2, 14, "Lydia Ko" }
                });

            migrationBuilder.InsertData(
                table: "clubs",
                columns: new[] { "id", "golf_bag_id", "name" },
                values: new object[,]
                {
                    { 1, 1, "Driver" },
                    { 2, 1, "Putter" },
                    { 3, 1, "5 Iron" },
                    { 4, 2, "Driver" },
                    { 5, 2, "Putter" },
                    { 6, 2, "9 Iron" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_clubs_golf_bag_id",
                table: "clubs",
                column: "golf_bag_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "clubs");

            migrationBuilder.DropTable(
                name: "golf_bags");
        }
    }
}
