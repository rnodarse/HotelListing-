using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HotelListing.API.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d6e5cc7b-42b0-4e74-8101-cce09b3b90fc", "e7d3b0b4-714d-4b7d-abac-4093d0e37c05", "Administrator", "ADMINISTRATOR" },
                    { "f41f31b7-e6c8-41e0-8b16-aba83654ba12", "44c70e53-eba0-4a33-b186-c5d0bd8c2c19", "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6e5cc7b-42b0-4e74-8101-cce09b3b90fc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f41f31b7-e6c8-41e0-8b16-aba83654ba12");
        }
    }
}
