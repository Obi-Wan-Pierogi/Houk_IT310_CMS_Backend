using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Houk_IT310_CMS_Backend.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a4bb6da-00d4-4bb0-adef-61006445fdb5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f5a353e-cb54-4879-aaa4-b067ec506d5c", "AQAAAAIAAYagAAAAEEOPV6hLrGWOD8xh8jEVNQ6qBO+wbexNZZy1FzFvHOZsxa/MAfgOIfAm2ch8jRSQkQ==", "3c6c1f27-4ea8-4abe-96ec-71e57ca6791e" });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 16, 16, 14, 6, 804, DateTimeKind.Local).AddTicks(9241), new DateTime(2025, 2, 16, 16, 14, 6, 804, DateTimeKind.Local).AddTicks(9298) });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "ContentId", "AuthorId", "Body", "CategoryId", "CreatedAt", "Title", "UpdatedAt", "Visibility" },
                values: new object[,]
                {
                    { 2, "9a4bb6da-00d4-4bb0-adef-61006445fdb5", "And sometimes useful", 2, new DateTime(2025, 2, 16, 16, 14, 6, 804, DateTimeKind.Local).AddTicks(9302), "AI is cool", new DateTime(2025, 2, 16, 16, 14, 6, 804, DateTimeKind.Local).AddTicks(9303), 0 },
                    { 3, "9a4bb6da-00d4-4bb0-adef-61006445fdb5", "This is my first post.", 3, new DateTime(2025, 2, 16, 16, 14, 6, 804, DateTimeKind.Local).AddTicks(9305), "Guess What?", new DateTime(2025, 2, 16, 16, 14, 6, 804, DateTimeKind.Local).AddTicks(9307), 0 },
                    { 4, "9a4bb6da-00d4-4bb0-adef-61006445fdb5", "Let's eat tacos", 4, new DateTime(2025, 2, 16, 16, 14, 6, 804, DateTimeKind.Local).AddTicks(9309), "Taco Time", new DateTime(2025, 2, 16, 16, 14, 6, 804, DateTimeKind.Local).AddTicks(9310), 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a4bb6da-00d4-4bb0-adef-61006445fdb5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0722a5c5-7359-41fa-89ff-9027169fbb0e", "AQAAAAIAAYagAAAAECpgmr56BtPUrvTF6z0iB4EiwmTnRuWhyY7Z0J5iEmD602G1ovtJyWPPDfdNsAh1+g==", "d57b2015-34ac-4306-87ec-0adebbfb1f88" });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 2, 10, 23, 37, 44, 147, DateTimeKind.Local).AddTicks(8038), new DateTime(2025, 2, 10, 23, 37, 44, 147, DateTimeKind.Local).AddTicks(8103) });
        }
    }
}
