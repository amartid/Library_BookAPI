using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_BookAPI.Migrations
{
    /// <inheritdoc />
    public partial class addBooksss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 1.3, new DateTime(2023, 9, 11, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), true, "Shelf 3, Row 8", 344, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2023, 3, 9, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), 1997 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 0.40000000000000002, new DateTime(2023, 5, 26, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), false, "Shelf 5, Row 11", 292, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2022, 12, 16, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), 1998 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 3.6000000000000001, new DateTime(2022, 10, 11, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 8, Row 11", 280, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2022, 12, 27, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), 1999 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.90000000000000002, new DateTime(2023, 7, 23, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), false, "Shelf 9, Row 4", 364, new List<string> { "Fantasy", "Adventure" }, new DateTime(2022, 10, 26, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.0, new DateTime(2022, 12, 14, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 3, Row 10", 458, new List<string> { "Fantasy", "Adventure" }, new DateTime(2023, 1, 23, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 3, 7, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 9, Row 19", 439, new List<string> { "Fantasy", "Adventure" }, new DateTime(2022, 12, 11, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.20000000000000001, new DateTime(2023, 8, 16, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), false, "Shelf 1, Row 2", 310, new List<string> { "Classics", "Romance" }, new DateTime(2022, 10, 11, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.20000000000000001, new DateTime(2023, 4, 19, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 9, Row 19", 401, new List<string> { "Classics", "Adventure" }, new DateTime(2023, 7, 12, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.5, new DateTime(2023, 6, 23, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 2, Row 9", 318, new List<string> { "Classics", "Gothic" }, new DateTime(2023, 9, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.90000000000000002, new DateTime(2022, 11, 9, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), false, "Shelf 6, Row 7", 312, new List<string> { "Fantasy", "Mythology" }, new DateTime(2023, 5, 22, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.7999999999999998, new DateTime(2023, 10, 1, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), false, "Shelf 5, Row 10", 243, new List<string> { "Fiction", "Coming of Age" }, new DateTime(2023, 1, 6, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.7999999999999998, new DateTime(2022, 11, 13, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), false, "Shelf 3, Row 17", 429, new List<string> { "Classics", "Adventure" }, new DateTime(2022, 12, 27, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 4.9000000000000004, new DateTime(2023, 1, 13, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), false, "Shelf 1, Row 10", 184, new List<string> { "Fiction", "Classic" }, new DateTime(2023, 8, 8, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 4.2000000000000002, new DateTime(2022, 10, 12, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 4, Row 5", 312, new List<string> { "Fantasy", "Adventure" }, new DateTime(2023, 9, 22, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.6000000000000001, new DateTime(2023, 8, 2, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), false, "Shelf 9, Row 3", 226, new List<string> { "Fiction", "Classic" }, new DateTime(2023, 7, 15, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 3.2999999999999998, new DateTime(2023, 8, 9, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 8, Row 15", 214, new List<string> { "Science Fiction", "Dystopian" }, new DateTime(2023, 9, 1, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.1000000000000001, new DateTime(2023, 4, 22, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 9, Row 15", 271, new List<string> { "Fiction", "Contemporary" }, new DateTime(2023, 1, 9, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 4.2999999999999998, new DateTime(2023, 6, 18, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 4, Row 15", 702, new List<string> { "Classics", "Satire" }, new DateTime(2022, 10, 31, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 4.9000000000000004, new DateTime(2022, 12, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 4, Row 6", 879, new List<string> { "Classics", "Historical Fiction" }, new DateTime(2023, 8, 21, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), 1865 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 3.3999999999999999, new DateTime(2023, 5, 17, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), true, "Shelf 5, Row 16", 249, new List<string> { "Fiction", "Literary" }, new DateTime(2022, 10, 28, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 4.5999999999999996, new DateTime(2023, 3, 19, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 8, Row 4", 245, new List<string> { "Fiction", "Post-Apocalyptic" }, new DateTime(2023, 3, 24, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.2999999999999998, new DateTime(2022, 11, 14, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 1, Row 11", 419, new List<string> { "Horror", "Psychological" }, new DateTime(2023, 9, 9, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.29999999999999999, new DateTime(2023, 8, 29, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), false, "Shelf 3, Row 18", 216, new List<string> { "Fantasy", "Adventure" }, new DateTime(2022, 10, 14, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 4.2000000000000002, new DateTime(2023, 2, 11, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 6, Row 9", 386, new List<string> { "Classics", "Social Issues" }, new DateTime(2022, 11, 13, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.7000000000000002, new DateTime(2022, 12, 7, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 1, Row 10", 318, new List<string> { "Classics", "Dystopian" }, new DateTime(2023, 9, 10, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.5, new DateTime(2023, 3, 15, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), true, "Shelf 7, Row 8", 436, new List<string> { "Science Fiction", "Adventure" }, new DateTime(2023, 4, 22, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 4.0999999999999996, new DateTime(2022, 12, 4, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 7, Row 8", 456, new List<string> { "Mystery", "Thriller" }, new DateTime(2023, 7, 22, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 3.1000000000000001, new DateTime(2023, 9, 24, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), "Shelf 4, Row 5", 497, new List<string> { "Historical Fiction", "World War II" }, new DateTime(2023, 4, 19, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.3999999999999999, new DateTime(2023, 4, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), true, "Shelf 6, Row 15", 601, new List<string> { "Fantasy", "Adventure" }, new DateTime(2023, 5, 30, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 3.8999999999999999, new DateTime(2022, 11, 12, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), new DateTime(2023, 10, 3, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120), false, "Shelf 6, Row 1", 448, new List<string> { "Non-Fiction", "History" }, new DateTime(2022, 12, 6, 21, 50, 41, 551, DateTimeKind.Utc).AddTicks(7120) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 1.5, new DateTime(2023, 2, 21, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), false, "Shelf 8, Row 2", 299, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2022, 11, 28, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1998 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 0.59999999999999998, new DateTime(2023, 10, 2, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 4, Row 9", 258, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2023, 2, 19, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1999 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 4.5, new DateTime(2023, 2, 21, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 2, Row 2", 387, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2023, 3, 11, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 2000 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.80000000000000004, new DateTime(2023, 6, 22, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 2, Row 9", 363, new List<string> { "Fantasy", "Adventure" }, new DateTime(2023, 8, 25, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.8, new DateTime(2023, 9, 29, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 2, Row 10", 357, new List<string> { "Fantasy", "Adventure" }, new DateTime(2023, 3, 13, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 6, 17, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 5, Row 5", 392, new List<string> { "Fantasy", "Adventure" }, new DateTime(2022, 12, 29, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.1000000000000001, new DateTime(2023, 6, 7, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 6, Row 10", 372, new List<string> { "Classics", "Romance" }, new DateTime(2023, 5, 15, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.2, new DateTime(2023, 1, 7, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 5, Row 11", 570, new List<string> { "Classics", "Adventure" }, new DateTime(2023, 7, 12, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.69999999999999996, new DateTime(2022, 10, 5, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 2, Row 15", 255, new List<string> { "Classics", "Gothic" }, new DateTime(2023, 3, 14, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.1000000000000001, new DateTime(2023, 1, 30, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 6, Row 13", 393, new List<string> { "Fantasy", "Mythology" }, new DateTime(2023, 7, 2, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.69999999999999996, new DateTime(2023, 2, 25, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 1, Row 9", 268, new List<string> { "Fiction", "Coming of Age" }, new DateTime(2023, 4, 18, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 4.9000000000000004, new DateTime(2022, 11, 6, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 2, Row 15", 404, new List<string> { "Classics", "Adventure" }, new DateTime(2023, 9, 10, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 4.5999999999999996, new DateTime(2023, 1, 2, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 9, Row 15", 241, new List<string> { "Fiction", "Classic" }, new DateTime(2023, 6, 11, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.2000000000000002, new DateTime(2023, 9, 2, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 1, Row 14", 228, new List<string> { "Fantasy", "Adventure" }, new DateTime(2023, 2, 11, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.5, new DateTime(2023, 2, 10, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 1, Row 16", 245, new List<string> { "Fiction", "Classic" }, new DateTime(2023, 8, 24, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.2000000000000002, new DateTime(2023, 8, 16, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 8, Row 4", 222, new List<string> { "Science Fiction", "Dystopian" }, new DateTime(2023, 6, 16, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.8, new DateTime(2022, 12, 27, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 8, Row 1", 233, new List<string> { "Fiction", "Contemporary" }, new DateTime(2023, 4, 27, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.8999999999999999, new DateTime(2023, 9, 16, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 7, Row 18", 626, new List<string> { "Classics", "Satire" }, new DateTime(2023, 5, 1, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 3.5, new DateTime(2023, 9, 14, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 8, Row 17", 825, new List<string> { "Classics", "Historical Fiction" }, new DateTime(2023, 1, 23, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1866 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.90000000000000002, new DateTime(2023, 2, 10, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), false, "Shelf 9, Row 11", 176, new List<string> { "Fiction", "Literary" }, new DateTime(2022, 11, 10, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 3.7000000000000002, new DateTime(2023, 4, 14, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 4, Row 19", 271, new List<string> { "Fiction", "Post-Apocalyptic" }, new DateTime(2022, 12, 19, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.90000000000000002, new DateTime(2023, 4, 19, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 3, Row 3", 490, new List<string> { "Horror", "Psychological" }, new DateTime(2023, 5, 10, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.0, new DateTime(2023, 4, 26, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 8, Row 14", 223, new List<string> { "Fantasy", "Adventure" }, new DateTime(2022, 10, 17, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.69999999999999996, new DateTime(2023, 4, 18, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 4, Row 7", 371, new List<string> { "Classics", "Social Issues" }, new DateTime(2023, 6, 15, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.3, new DateTime(2023, 7, 4, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 6, Row 12", 303, new List<string> { "Classics", "Dystopian" }, new DateTime(2023, 2, 9, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.7999999999999998, new DateTime(2023, 6, 21, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), false, "Shelf 8, Row 13", 523, new List<string> { "Science Fiction", "Adventure" }, new DateTime(2023, 6, 15, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.2000000000000002, new DateTime(2023, 6, 22, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 8, Row 15", 414, new List<string> { "Mystery", "Thriller" }, new DateTime(2022, 11, 16, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 3.5, new DateTime(2023, 3, 31, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 8, Row 16", 351, new List<string> { "Historical Fiction", "World War II" }, new DateTime(2023, 4, 1, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.6000000000000001, new DateTime(2023, 1, 31, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), false, "Shelf 4, Row 7", 768, new List<string> { "Fantasy", "Adventure" }, new DateTime(2023, 7, 9, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.6000000000000001, new DateTime(2023, 9, 24, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 1, Row 16", 474, new List<string> { "Non-Fiction", "History" }, new DateTime(2022, 10, 12, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });
        }
    }
}
