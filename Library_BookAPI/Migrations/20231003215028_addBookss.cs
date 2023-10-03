using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library_BookAPI.Migrations
{
    /// <inheritdoc />
    public partial class addBookss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 1.5, new DateTime(2023, 2, 21, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 8, Row 2", 299, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2022, 11, 28, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1998 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.59999999999999998, new DateTime(2023, 10, 2, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 4, Row 9", 258, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2023, 2, 19, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 4.5, new DateTime(2023, 2, 21, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), false, "Shelf 2, Row 2", 387, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2023, 3, 11, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 2000 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.80000000000000004, new DateTime(2023, 6, 22, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 2, Row 9", 363, new List<string> { "Fantasy", "Adventure" }, new DateTime(2023, 8, 25, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.8, new DateTime(2023, 9, 29, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 2, Row 10", 357, new List<string> { "Fantasy", "Adventure" }, new DateTime(2023, 3, 13, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 3.2000000000000002, new DateTime(2023, 6, 17, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 5, Row 5", 392, new List<string> { "Fantasy", "Adventure" }, new DateTime(2022, 12, 29, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.1000000000000001, new DateTime(2023, 6, 7, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Shelf 6, Row 10", 372, new List<string> { "Classics", "Romance" }, new DateTime(2023, 5, 15, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.2, new DateTime(2023, 1, 7, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), false, "Shelf 5, Row 11", 570, new List<string> { "Classics", "Adventure" }, new DateTime(2023, 7, 12, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.69999999999999996, new DateTime(2022, 10, 5, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), true, "Shelf 2, Row 15", 255, new List<string> { "Classics", "Gothic" }, new DateTime(2023, 3, 14, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448) });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "AverageRating", "Borrower", "CreatedDate", "Description", "DueDate", "Genre", "ISBN", "ImageUrl", "IsAvailable", "Language", "Location", "PageCount", "Publisher", "Tags", "Title", "UpdatedDate", "YearPublished" },
                values: new object[,]
                {
                    { 10, "J.R.R. Tolkien", 2.1000000000000001, "N/A", new DateTime(2023, 1, 30, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A collection of mythopoeic tales that form the backstory to J.R.R. Tolkien's legendarium, including the creation of Middle-earth and the struggles of its inhabitants.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Fantasy", "978-0618391110", "https://m.media-amazon.com/images/I/51h8UkK-w8L._SL1024_.jpg", true, "English", "Shelf 6, Row 13", 393, "Houghton Mifflin", new List<string> { "Fantasy", "Mythology" }, "The Silmarillion", new DateTime(2023, 7, 2, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1977 },
                    { 11, "J.D. Salinger", 0.69999999999999996, "N/A", new DateTime(2023, 2, 25, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A coming-of-age novel that explores the alienation and disillusionment of a young man in New York City.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Fiction", "978-0316769488", "https://m.media-amazon.com/images/I/81W0hu9MrQL._SL1500_.jpg", true, "English", "Shelf 1, Row 9", 268, "Little, Brown and Company", new List<string> { "Fiction", "Coming of Age" }, "The Catcher in the Rye", new DateTime(2023, 4, 18, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1951 },
                    { 12, "Herman Melville", 4.9000000000000004, "N/A", new DateTime(2022, 11, 6, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A novel that tells the epic tale of Captain Ahab's obsession with a giant white whale, Moby-Dick.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Classics", "978-0142437247", "https://m.media-amazon.com/images/I/51G2T2elJ6L._SL1000_.jpg", true, "English", "Shelf 2, Row 15", 404, "Harper & Brothers", new List<string> { "Classics", "Adventure" }, "Moby-Dick", new DateTime(2023, 9, 10, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1851 },
                    { 13, "F. Scott Fitzgerald", 4.5999999999999996, "N/A", new DateTime(2023, 1, 2, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A novel set in the Roaring Twenties, exploring themes of wealth, love, and the American Dream.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Fiction", "978-0743273565", "https://m.media-amazon.com/images/I/51o3F7CdtpL._SL1051_.jpg", true, "English", "Shelf 9, Row 15", 241, "Charles Scribner's Sons", new List<string> { "Fiction", "Classic" }, "The Great Gatsby", new DateTime(2023, 6, 11, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1925 },
                    { 14, "J.R.R. Tolkien", 2.2000000000000002, "N/A", new DateTime(2023, 9, 2, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A beloved fantasy novel about the adventures of Bilbo Baggins, a hobbit who sets out on a quest.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Fantasy", "978-0547928227", "https://m.media-amazon.com/images/I/71p3j4p9a3L._SL1500_.jpg", false, "English", "Shelf 1, Row 14", 228, "George Allen & Unwin", new List<string> { "Fantasy", "Adventure" }, "The Hobbit", new DateTime(2023, 2, 11, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1937 },
                    { 15, "William Golding", 1.5, "N/A", new DateTime(2023, 2, 10, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A novel about a group of boys stranded on an uninhabited island and their descent into chaos.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Fiction", "978-0143124290", "https://m.media-amazon.com/images/I/91C0SiJ7mxL._SL1500_.jpg", true, "English", "Shelf 1, Row 16", 245, "Faber and Faber", new List<string> { "Fiction", "Classic" }, "The Lord of the Flies", new DateTime(2023, 8, 24, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1954 },
                    { 16, "Aldous Huxley", 2.2000000000000002, "N/A", new DateTime(2023, 8, 16, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A dystopian novel that explores a futuristic society driven by technological advancement and control.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Science Fiction", "978-0060850524", "https://m.media-amazon.com/images/I/51oIvzjqQrL._SL1200_.jpg", true, "English", "Shelf 8, Row 4", 222, "Chatto & Windus", new List<string> { "Science Fiction", "Dystopian" }, "Brave New World", new DateTime(2023, 6, 16, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1932 },
                    { 17, "Ben Lerner", 1.8, "N/A", new DateTime(2022, 12, 27, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A novel about a writer in Brooklyn who is asked to write a book about art and time.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Fiction", "978-0571322479", "https://m.media-amazon.com/images/I/71d5aTdHy7L._SL1500_.jpg", false, "English", "Shelf 8, Row 1", 233, "Faber & Faber", new List<string> { "Fiction", "Contemporary" }, "10:04", new DateTime(2023, 4, 27, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 2014 },
                    { 18, "Miguel de Cervantes", 2.8999999999999999, "N/A", new DateTime(2023, 9, 16, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A satirical novel about a self-proclaimed knight, Don Quixote, and his loyal squire, Sancho Panza.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Classics", "978-0060934347", "https://m.media-amazon.com/images/I/91bPKTfBpkL._SL1500_.jpg", false, "Spanish", "Shelf 7, Row 18", 626, "Harper Perennial", new List<string> { "Classics", "Satire" }, "Don Quixote", new DateTime(2023, 5, 1, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1605 },
                    { 19, "Leo Tolstoy", 3.5, "N/A", new DateTime(2023, 9, 14, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A historical novel that explores the lives of Russian aristocrats during the Napoleonic era.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Classics", "978-0143039990", "https://m.media-amazon.com/images/I/51JLT0J3JTL._SL1053_.jpg", false, "Russian", "Shelf 8, Row 17", 825, "Penguin Classics", new List<string> { "Classics", "Historical Fiction" }, "War and Peace", new DateTime(2023, 1, 23, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1866 },
                    { 20, "Ben Lerner", 0.90000000000000002, "N/A", new DateTime(2023, 2, 10, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A novel about an American poet in Madrid, exploring themes of authenticity and alienation.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Fiction", "978-1566892748", "https://m.media-amazon.com/images/I/81FQ7jutv8L._SL1500_.jpg", false, "English", "Shelf 9, Row 11", 176, "Coffee House Press", new List<string> { "Fiction", "Literary" }, "Leaving the Atocha Station", new DateTime(2022, 11, 10, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 2010 },
                    { 21, "Cormac McCarthy", 3.7000000000000002, "N/A", new DateTime(2023, 4, 14, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A post-apocalyptic novel following a father and son's journey in a desolate and dangerous world.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Fiction", "978-0307387899", "https://m.media-amazon.com/images/I/81iB+fUN2yL._SL1500_.jpg", false, "English", "Shelf 4, Row 19", 271, "Vintage", new List<string> { "Fiction", "Post-Apocalyptic" }, "The Road", new DateTime(2022, 12, 19, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 2006 },
                    { 22, "Stephen King", 0.90000000000000002, "N/A", new DateTime(2023, 4, 19, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A psychological horror novel about a family's descent into madness in a haunted hotel.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Horror", "978-0345806789", "https://m.media-amazon.com/images/I/71aRkaY7gqL._SL1500_.jpg", false, "English", "Shelf 3, Row 3", 490, "Anchor", new List<string> { "Horror", "Psychological" }, "The Shining", new DateTime(2023, 5, 10, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1977 },
                    { 23, "C.S. Lewis", 0.0, "N/A", new DateTime(2023, 4, 26, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "The first book in the classic fantasy series, where four siblings discover a magical world through a wardrobe.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Fantasy", "978-0060764890", "https://m.media-amazon.com/images/I/71JSzS8STJL._SL1080_.jpg", true, "English", "Shelf 8, Row 14", 223, "HarperCollins", new List<string> { "Fantasy", "Adventure" }, "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe", new DateTime(2022, 10, 17, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1950 },
                    { 24, "Harper Lee", 0.69999999999999996, "N/A", new DateTime(2023, 4, 18, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A powerful novel that addresses issues of racism and injustice in the American South.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Classics", "978-0061120084", "https://m.media-amazon.com/images/I/81mc4QUQx1L._SL1500_.jpg", true, "English", "Shelf 4, Row 7", 371, "Harper Perennial Modern Classics", new List<string> { "Classics", "Social Issues" }, "To Kill a Mockingbird", new DateTime(2023, 6, 15, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1960 },
                    { 25, "George Orwell", 1.3, "N/A", new DateTime(2023, 7, 4, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A dystopian novel that portrays a totalitarian society and the dangers of totalitarianism.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Classics", "978-0451524935", "https://m.media-amazon.com/images/I/81hb+PE4PrL._SL1500_.jpg", true, "English", "Shelf 6, Row 12", 303, "Signet Classic", new List<string> { "Classics", "Dystopian" }, "1984", new DateTime(2023, 2, 9, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1949 },
                    { 26, "Frank Herbert", 2.7999999999999998, "N/A", new DateTime(2023, 6, 21, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A science fiction epic set on the desert planet of Arrakis, where a young hero rises to power.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Science Fiction", "978-0441013593", "https://m.media-amazon.com/images/I/81PbvmCKLWL._SL1500_.jpg", false, "English", "Shelf 8, Row 13", 523, "Ace Books", new List<string> { "Science Fiction", "Adventure" }, "Dune", new DateTime(2023, 6, 15, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 1965 },
                    { 27, "Stieg Larsson", 2.2000000000000002, "N/A", new DateTime(2023, 6, 22, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A gripping mystery novel involving a journalist and a hacker in a cold case investigation.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Mystery", "978-0307269751", "https://m.media-amazon.com/images/I/81kAd8kZvOL._SL1500_.jpg", true, "English", "Shelf 8, Row 15", 414, "Knopf", new List<string> { "Mystery", "Thriller" }, "The Girl with the Dragon Tattoo", new DateTime(2022, 11, 16, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 2005 },
                    { 28, "Anthony Doerr", 3.5, "N/A", new DateTime(2023, 3, 31, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A beautifully written historical novel that weaves together the lives of a blind French girl and a German boy during World War II.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Historical Fiction", "978-1501173219", "https://m.media-amazon.com/images/I/81RkLxFbQfL._SL1500_.jpg", true, "English", "Shelf 8, Row 16", 351, "Scribner", new List<string> { "Historical Fiction", "World War II" }, "All the Light We Cannot See", new DateTime(2023, 4, 1, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 2013 },
                    { 29, "Patrick Rothfuss", 1.6000000000000001, "N/A", new DateTime(2023, 1, 31, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "The first book in the Kingkiller Chronicle series, following the life and adventures of the gifted musician and magician Kvothe.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Fantasy", "978-0756404741", "https://m.media-amazon.com/images/I/71gYfSWWB6L._SL1200_.jpg", false, "English", "Shelf 4, Row 7", 768, "DAW Books", new List<string> { "Fantasy", "Adventure" }, "The Name of the Wind", new DateTime(2023, 7, 9, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 2007 },
                    { 30, "Yuval Noah Harari", 2.6000000000000001, "N/A", new DateTime(2023, 9, 24, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "A thought-provoking exploration of the history and impact of Homo sapiens on the world.", new DateTime(2023, 10, 3, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), "Non-Fiction", "978-0062316097", "https://m.media-amazon.com/images/I/51y5lwnN5+L._SL160_.jpg", true, "English", "Shelf 1, Row 16", 474, "Harper", new List<string> { "Non-Fiction", "History" }, "Sapiens: A Brief History of Humankind", new DateTime(2022, 10, 12, 21, 50, 28, 597, DateTimeKind.Utc).AddTicks(8448), 2011 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 4.5, new DateTime(2023, 9, 25, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Shelf 9, Row 19", 251, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2022, 12, 8, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1997 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.6000000000000001, new DateTime(2023, 5, 4, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Shelf 6, Row 15", 389, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2023, 3, 6, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate", "YearPublished" },
                values: new object[] { 0.80000000000000004, new DateTime(2023, 1, 21, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), true, "Shelf 3, Row 14", 352, new List<string> { "Magic", "Wizardry", "Adventure" }, new DateTime(2022, 12, 20, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), 1999 });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 3.1000000000000001, new DateTime(2023, 7, 12, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Shelf 3, Row 10", 400, new List<string> { "Fantasy", "Adventure" }, new DateTime(2023, 5, 19, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.5, new DateTime(2022, 10, 26, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), false, "Shelf 1, Row 18", 380, new List<string> { "Fantasy", "Adventure" }, new DateTime(2022, 12, 8, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 2.5, new DateTime(2022, 12, 22, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Shelf 5, Row 4", 305, new List<string> { "Fantasy", "Adventure" }, new DateTime(2022, 11, 11, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 4.5999999999999996, new DateTime(2022, 12, 6, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), "Shelf 9, Row 8", 261, new List<string> { "Classics", "Romance" }, new DateTime(2022, 12, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 0.5, new DateTime(2022, 12, 20, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), true, "Shelf 6, Row 5", 419, new List<string> { "Classics", "Adventure" }, new DateTime(2023, 8, 30, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AverageRating", "CreatedDate", "DueDate", "IsAvailable", "Location", "PageCount", "Tags", "UpdatedDate" },
                values: new object[] { 1.2, new DateTime(2023, 9, 2, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), new DateTime(2023, 10, 3, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944), false, "Shelf 3, Row 5", 342, new List<string> { "Classics", "Gothic" }, new DateTime(2023, 2, 21, 20, 40, 56, 951, DateTimeKind.Utc).AddTicks(6944) });
        }
    }
}
