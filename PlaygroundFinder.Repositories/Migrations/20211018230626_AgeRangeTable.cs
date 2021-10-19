using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PlaygroundFinder.Repositories.Migrations
{
    public partial class AgeRangeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeRange",
                table: "Playgrounds");

            migrationBuilder.CreateTable(
                name: "AgeRanges",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    type = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeRanges", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlaygroundAgeRanges",
                columns: table => new
                {
                    PlaygroundId = table.Column<Guid>(type: "uuid", nullable: false),
                    AgeRangeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaygroundAgeRanges", x => new { x.PlaygroundId, x.AgeRangeId });
                    table.ForeignKey(
                        name: "FK_PlaygroundAgeRanges_AgeRanges_AgeRangeId",
                        column: x => x.AgeRangeId,
                        principalTable: "AgeRanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaygroundAgeRanges_Playgrounds_PlaygroundId",
                        column: x => x.PlaygroundId,
                        principalTable: "Playgrounds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AgeRanges",
                columns: new[] { "Id", "type" },
                values: new object[,]
                {
                    { 1, "Junior" },
                    { 2, "Senior" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlaygroundAgeRanges_AgeRangeId",
                table: "PlaygroundAgeRanges",
                column: "AgeRangeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaygroundAgeRanges");

            migrationBuilder.DropTable(
                name: "AgeRanges");

            migrationBuilder.AddColumn<string>(
                name: "AgeRange",
                table: "Playgrounds",
                type: "text",
                nullable: true);
        }
    }
}
