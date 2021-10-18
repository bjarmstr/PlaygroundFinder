using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PlaygroundFinder.Repositories.Migrations
{
    public partial class GroundCoverTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GroundCovers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Material = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroundCovers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaygroundGroundCovers",
                columns: table => new
                {
                    PlaygroundId = table.Column<Guid>(type: "uuid", nullable: false),
                    GroundCoverId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaygroundGroundCovers", x => new { x.PlaygroundId, x.GroundCoverId });
                    table.ForeignKey(
                        name: "FK_PlaygroundGroundCovers_GroundCovers_GroundCoverId",
                        column: x => x.GroundCoverId,
                        principalTable: "GroundCovers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaygroundGroundCovers_Playgrounds_PlaygroundId",
                        column: x => x.PlaygroundId,
                        principalTable: "Playgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "GroundCovers",
                columns: new[] { "Id", "Material" },
                values: new object[,]
                {
                    { 1, "Natural Round Rock" },
                    { 2, "Sand" },
                    { 3, "Wood Chips" },
                    { 4, "Poured In Place Rubber" },
                    { 5, "Crumb Rubber" },
                    { 6, "Other" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlaygroundGroundCovers_GroundCoverId",
                table: "PlaygroundGroundCovers",
                column: "GroundCoverId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaygroundGroundCovers");

            migrationBuilder.DropTable(
                name: "GroundCovers");
        }
    }
}
