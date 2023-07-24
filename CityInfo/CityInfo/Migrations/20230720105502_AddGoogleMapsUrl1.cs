using Microsoft.EntityFrameworkCore.Migrations;

namespace CityInfo.Migrations
{
    public partial class AddGoogleMapsUrl1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GoogleMapsUrl",
                table: "PointsOfInterest",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GoogleMapsUrl",
                table: "Cities",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "GoogleMapsUrl",
                value: "https://goo.gl/maps/6CzStBQzmS46u6Z69");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "GoogleMapsUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "GoogleMapsUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 1,
                column: "GoogleMapsUrl",
                value: "https://goo.gl/maps/iWzWAr2jXvehXVTJ6");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 2,
                column: "GoogleMapsUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 3,
                column: "GoogleMapsUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 4,
                column: "GoogleMapsUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 5,
                column: "GoogleMapsUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 6,
                column: "GoogleMapsUrl",
                value: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoogleMapsUrl",
                table: "PointsOfInterest");

            migrationBuilder.DropColumn(
                name: "GoogleMapsUrl",
                table: "Cities");
        }
    }
}
