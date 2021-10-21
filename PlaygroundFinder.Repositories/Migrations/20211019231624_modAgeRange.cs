using Microsoft.EntityFrameworkCore.Migrations;

namespace PlaygroundFinder.Repositories.Migrations
{
    public partial class modAgeRange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "type",
                table: "AgeRanges",
                newName: "Type");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "AgeRanges",
                newName: "type");
        }
    }
}
