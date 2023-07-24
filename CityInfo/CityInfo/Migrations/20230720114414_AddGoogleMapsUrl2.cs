using Microsoft.EntityFrameworkCore.Migrations;

namespace CityInfo.Migrations
{
    public partial class AddGoogleMapsUrl2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "GoogleMapsUrl",
                value: "https://goo.gl/maps/eGrxrSKEyMb1H9Lm7");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "GoogleMapsUrl",
                value: "https://goo.gl/maps/SLHYQd8Vu1U2Xv8M6");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 2,
                column: "GoogleMapsUrl",
                value: "https://goo.gl/maps/9zkBjJfY3wgjcX488");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 3,
                column: "GoogleMapsUrl",
                value: "https://goo.gl/maps/8fdVULE4Diss8uHq6");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 4,
                column: "GoogleMapsUrl",
                value: "https://goo.gl/maps/5a558knHtLdXeRSW6");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 5,
                column: "GoogleMapsUrl",
                value: "https://goo.gl/maps/UCY5ATXU2hig95ZR9");

            migrationBuilder.UpdateData(
                table: "PointsOfInterest",
                keyColumn: "Id",
                keyValue: 6,
                column: "GoogleMapsUrl",
                value: "https://goo.gl/maps/6SUECXNRKev1K9aL8");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
