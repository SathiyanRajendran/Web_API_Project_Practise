using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LibraryManagement.API.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Borrows",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[,]
                {
                    { 1, null, "Ahmed Khaled Tawfik" },
                    { 2, null, "Naguib Mahfouz" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Email", "Name" },
                values: new object[,]
                {
                    { 1, "mohamed@example.com", "Mohamed Samy" },
                    { 2, "sara@example.com", "Sara Ali" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "IsAvailable", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Utopia" },
                    { 2, 2, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Coffee Trader" }
                });

            migrationBuilder.InsertData(
                table: "Borrows",
                columns: new[] { "Id", "BookId", "BorrowDate", "MemberId", "ReturnDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 8, 5, 15, 43, 26, 49, DateTimeKind.Local).AddTicks(6236), 1, null },
                    { 2, 2, new DateTime(2025, 8, 10, 15, 43, 26, 49, DateTimeKind.Local).AddTicks(6275), 2, new DateTime(2025, 8, 15, 15, 43, 26, 49, DateTimeKind.Local).AddTicks(6277) }
                });
        }
    }
}
