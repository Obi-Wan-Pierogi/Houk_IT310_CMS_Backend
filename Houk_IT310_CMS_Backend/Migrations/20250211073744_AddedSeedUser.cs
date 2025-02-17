using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Houk_IT310_CMS_Backend.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Author",
                table: "Content");

            migrationBuilder.AddColumn<string>(
                name: "AuthorId",
                table: "Content",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9a4bb6da-00d4-4bb0-adef-61006445fdb5", 0, "0722a5c5-7359-41fa-89ff-9027169fbb0e", "test@test.com", true, false, null, "TEST@TEST.COM", "TEST@TEST.COM", "AQAAAAIAAYagAAAAECpgmr56BtPUrvTF6z0iB4EiwmTnRuWhyY7Z0J5iEmD602G1ovtJyWPPDfdNsAh1+g==", null, false, "d57b2015-34ac-4306-87ec-0adebbfb1f88", false, "test@test.com" });

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedAt", "UpdatedAt" },
                values: new object[] { "9a4bb6da-00d4-4bb0-adef-61006445fdb5", new DateTime(2025, 2, 10, 23, 37, 44, 147, DateTimeKind.Local).AddTicks(8038), new DateTime(2025, 2, 10, 23, 37, 44, 147, DateTimeKind.Local).AddTicks(8103) });

            migrationBuilder.CreateIndex(
                name: "IX_Content_AuthorId",
                table: "Content",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Content_AspNetUsers_AuthorId",
                table: "Content",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Content_AspNetUsers_AuthorId",
                table: "Content");

            migrationBuilder.DropIndex(
                name: "IX_Content_AuthorId",
                table: "Content");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a4bb6da-00d4-4bb0-adef-61006445fdb5");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Content");

            migrationBuilder.AddColumn<string>(
                name: "Author",
                table: "Content",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Content",
                keyColumn: "ContentId",
                keyValue: 1,
                columns: new[] { "Author", "CreatedAt", "UpdatedAt" },
                values: new object[] { "Lee", new DateTime(2025, 2, 10, 13, 39, 21, 733, DateTimeKind.Local).AddTicks(2595), new DateTime(2025, 2, 10, 13, 39, 21, 733, DateTimeKind.Local).AddTicks(2653) });

            migrationBuilder.InsertData(
                table: "Content",
                columns: new[] { "ContentId", "Author", "Body", "CategoryId", "CreatedAt", "Title", "UpdatedAt", "Visibility" },
                values: new object[,]
                {
                    { 2, "Lee", "And sometimes useful", 2, new DateTime(2025, 2, 10, 13, 39, 21, 733, DateTimeKind.Local).AddTicks(2656), "AI is cool", new DateTime(2025, 2, 10, 13, 39, 21, 733, DateTimeKind.Local).AddTicks(2657), 0 },
                    { 3, "Lee", "This is my first post.", 3, new DateTime(2025, 2, 10, 13, 39, 21, 733, DateTimeKind.Local).AddTicks(2660), "Guess What?", new DateTime(2025, 2, 10, 13, 39, 21, 733, DateTimeKind.Local).AddTicks(2661), 0 },
                    { 4, "Lee", "Let's eat tacos", 4, new DateTime(2025, 2, 10, 13, 39, 21, 733, DateTimeKind.Local).AddTicks(2662), "Taco Time", new DateTime(2025, 2, 10, 13, 39, 21, 733, DateTimeKind.Local).AddTicks(2664), 0 }
                });
        }
    }
}
