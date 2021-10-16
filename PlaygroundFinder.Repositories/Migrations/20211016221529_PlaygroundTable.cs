using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

namespace PlaygroundFinder.Repositories.Migrations
{
    public partial class PlaygroundTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Playgrounds",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<bool>(
                name: "Accessible",
                table: "Playgrounds",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "AgeRange",
                table: "Playgrounds",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<Point>(
                name: "GeoLocation",
                table: "Playgrounds",
                type: "geography (point)",
                nullable: false);

            migrationBuilder.AddColumn<string>(
                name: "Quadrant",
                table: "Playgrounds",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Size",
                table: "Playgrounds",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accessible",
                table: "Playgrounds");

            migrationBuilder.DropColumn(
                name: "AgeRange",
                table: "Playgrounds");

            migrationBuilder.DropColumn(
                name: "GeoLocation",
                table: "Playgrounds");

            migrationBuilder.DropColumn(
                name: "Quadrant",
                table: "Playgrounds");

            migrationBuilder.DropColumn(
                name: "Size",
                table: "Playgrounds");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Playgrounds",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);
        }
    }
}
