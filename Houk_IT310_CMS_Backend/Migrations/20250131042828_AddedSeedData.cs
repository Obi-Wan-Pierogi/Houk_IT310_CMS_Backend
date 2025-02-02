using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Houk_IT310_CMS_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "CategoryId", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Food" },
                    { 2, "Tech" },
                    { 3, "News" },
                    { 4, "Tacos" }
                });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "ContentId", "Author", "Body", "CategoryId", "CreatedAt", "Title", "UpdatedAt", "Visibility" },
                values: new object[,]
                {
                    { 1, "Lee", "It's toasty", 1, new DateTime(2025, 1, 30, 20, 28, 28, 434, DateTimeKind.Local).AddTicks(9126), "Toast Post", new DateTime(2025, 1, 30, 20, 28, 28, 434, DateTimeKind.Local).AddTicks(9183), 0 },
                    { 2, "Lee", "And sometimes useful", 2, new DateTime(2025, 1, 30, 20, 28, 28, 434, DateTimeKind.Local).AddTicks(9186), "AI is cool", new DateTime(2025, 1, 30, 20, 28, 28, 434, DateTimeKind.Local).AddTicks(9187), 0 },
                    { 3, "Lee", "This is my first post.", 3, new DateTime(2025, 1, 30, 20, 28, 28, 434, DateTimeKind.Local).AddTicks(9190), "Guess What?", new DateTime(2025, 1, 30, 20, 28, 28, 434, DateTimeKind.Local).AddTicks(9191), 0 },
                    { 4, "Lee", "Let's eat tacos", 4, new DateTime(2025, 1, 30, 20, 28, 28, 434, DateTimeKind.Local).AddTicks(9193), "Taco Time", new DateTime(2025, 1, 30, 20, 28, 28, 434, DateTimeKind.Local).AddTicks(9194), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
