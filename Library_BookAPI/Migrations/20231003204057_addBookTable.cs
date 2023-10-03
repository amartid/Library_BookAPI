using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library_BookAPI.Migrations
{
    /// <inheritdoc />
    public partial class addBookTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Author = table.Column<string>(type: "text", nullable: false),
                    ISBN = table.Column<string>(type: "text", nullable: false),
                    YearPublished = table.Column<int>(type: "integer", nullable: false),
                    Genre = table.Column<string>(type: "text", nullable: false),
                    ImageUrl = table.Column<string>(type: "text", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Publisher = table.Column<string>(type: "text", nullable: false),
                    Language = table.Column<string>(type: "text", nullable: false),
                    PageCount = table.Column<int>(type: "integer", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    IsAvailable = table.Column<bool>(type: "boolean", nullable: false),
                    Borrower = table.Column<string>(type: "text", nullable: false),
                    DueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Tags = table.Column<List<string>>(type: "text[]", nullable: false),
                    AverageRating = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "AverageRating", "Borrower", "CreatedDate", "Description", "DueDate", "Genre", "ISBN", "ImageUrl", "IsAvailable", "Language", "Location", "PageCount", "Publisher", "Tags", "Title", "UpdatedDate", "YearPublished" },
                values: new object[,]
                {
                    { 1, "J.K. Rowling", 4.5, "N/A", new DateTime(2023, 9, 25, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "The first book in the Harry Potter series, where young Harry discovers his magical heritage.", new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Fantasy", "978-0747532743", "https://m.media-amazon.com/images/I/91AbRwk2S0L._SL1500_.jpg", false, "English", "Shelf 9, Row 19", 251, "Bloomsbury Publishing", new List<string> { "Magic", "Wizardry", "Adventure" }, "Harry Potter and the Philosopher's Stone", new DateTime(2022, 12, 8, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1997 },
                    { 2, "J.K. Rowling", 1.6000000000000001, "N/A", new DateTime(2023, 5, 4, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "The second book in the Harry Potter series, where Harry returns to Hogwarts amidst mysterious attacks.", new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Fantasy", "978-0439064873", "https://static.wikia.nocookie.net/harrypotter/images/1/17/Chamberofsecrets.jpg", true, "English", "Shelf 6, Row 15", 389, "Bloomsbury Publishing", new List<string> { "Magic", "Wizardry", "Adventure" }, "Harry Potter and the Chamber of Secrets", new DateTime(2023, 3, 6, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1999 },
                    { 3, "J.K. Rowling", 0.80000000000000004, "N/A", new DateTime(2023, 1, 21, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "The third book in the Harry Potter series, where Harry learns the truth about his parents' past.", new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Fantasy", "978-0439655484", "https://static.wikia.nocookie.net/harrypotter/images/3/3e/Harry-Potter-And-The-Prisoner-Of-Azkaban_novel.jpg", true, "English", "Shelf 3, Row 14", 352, "Bloomsbury Publishing", new List<string> { "Magic", "Wizardry", "Adventure" }, "Harry Potter and the Prisoner of Azkaban", new DateTime(2022, 12, 20, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1999 },
                    { 4, "J.R.R. Tolkien", 3.1000000000000001, "N/A", new DateTime(2023, 7, 12, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "The first book in the Lord of the Rings series, where a young hobbit embarks on a perilous journey.", new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Fantasy", "978-0547928210", "https://upload.wikimedia.org/wikipedia/en/8/8e/The_Fellowship_of_the_Ring_cover.gif", true, "English", "Shelf 3, Row 10", 400, "Houghton Mifflin", new List<string> { "Fantasy", "Adventure" }, "The Fellowship of the Ring", new DateTime(2023, 5, 19, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1954 },
                    { 5, "J.R.R. Tolkien", 1.5, "N/A", new DateTime(2022, 10, 26, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "The second book in the Lord of the Rings series, where the fellowship faces new challenges.", new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Fantasy", "978-0547928203", "https://upload.wikimedia.org/wikipedia/en/a/a1/The_Two_Towers_cover.gif", false, "English", "Shelf 1, Row 18", 380, "Houghton Mifflin", new List<string> { "Fantasy", "Adventure" }, "The Two Towers", new DateTime(2022, 12, 8, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1954 },
                    { 6, "J.R.R. Tolkien", 2.5, "N/A", new DateTime(2022, 12, 22, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "The final book in the Lord of the Rings series, where the fate of Middle-earth is decided.", new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Fantasy", "978-0547928197", "https://en.wikipedia.org/wiki/The_Return_of_the_King#/media/File:The_Return_of_the_King_cover.gif", true, "English", "Shelf 5, Row 4", 305, "Houghton Mifflin", new List<string> { "Fantasy", "Adventure" }, "The Return of the King", new DateTime(2022, 11, 11, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1955 },
                    { 7, "Jane Austen", 4.5999999999999996, "N/A", new DateTime(2022, 12, 6, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "A classic novel about love, class, and societal expectations in 19th-century England.", new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Classics", "978-1613823701", "https://upload.wikimedia.org/wikipedia/commons/1/17/PrideAndPrejudiceTitlePage.jpg", true, "English", "Shelf 9, Row 8", 261, "T. Egerton, Whitehall", new List<string> { "Classics", "Romance" }, "Pride and Prejudice", new DateTime(2022, 12, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1813 },
                    { 8, "Herman Melville", 0.5, "N/A", new DateTime(2022, 12, 20, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "An epic novel about Captain Ahab's relentless pursuit of the white whale, Moby-Dick.", new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Classics", "978-0553213119", "https://upload.wikimedia.org/wikipedia/commons/3/36/Moby-Dick_FE_title_page.jpg", true, "English", "Shelf 6, Row 5", 419, "Harper & Brothers, New York", new List<string> { "Classics", "Adventure" }, "Moby-Dick", new DateTime(2023, 8, 30, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1851 },
                    { 9, "Mary Shelley", 1.2, "N/A", new DateTime(2023, 9, 2, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "A Gothic novel about the creation of a creature and the consequences of playing with nature.", new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Classics", "978-0486282114", "https://m.media-amazon.com/images/I/81F6mF9efaL._SL1500_.jpg", false, "English", "Shelf 3, Row 5", 342, "Lackington, Hughes, Harding, Mavor & Jones", new List<string> { "Classics", "Gothic" }, "Frankenstein", new DateTime(2023, 2, 21, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1818 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
