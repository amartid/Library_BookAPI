using Library_BookAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Npgsql.EntityFrameworkCore;
using System;

namespace Library_BookAPI.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Book> Books { get; set; } // SET

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var random = new Random(); // Create a Random instance
            var utcDateTime = DateTime.UtcNow; // Get the current UTC DateTime

            modelBuilder.Entity<Book>().HasData(
                new Book()
                {
                    Id = 1,
                    Title = "Harry Potter and the Philosopher's Stone",
                    Author = "J.K. Rowling",
                    ISBN = "978-0747532743",
                    YearPublished = random.Next(1997, 2000), // Random year between 1997 and 1999
                    Genre = "Fantasy",
                    ImageUrl = "https://m.media-amazon.com/images/I/91AbRwk2S0L._SL1500_.jpg", // Updated cover image URL
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)), // Random date within the last year
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)), // Random date within the last year
                    Publisher = "Bloomsbury Publishing",
                    Language = "English",
                    PageCount = random.Next(200, 400), // Random number of pages between 200 and 399
                    Description = "The first book in the Harry Potter series, where young Harry discovers his magical heritage.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1, // Randomly set to true or false
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Magic", "Wizardry", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1) // Random average rating between 0.0 and 5.0
                },
                new Book()
                {
                    Id = 2,
                    Title = "Harry Potter and the Chamber of Secrets",
                    Author = "J.K. Rowling",
                    ISBN = "978-0439064873",
                    YearPublished = random.Next(1998, 2000), // Random year between 1998 and 1999
                    Genre = "Fantasy",
                    ImageUrl = "https://static.wikia.nocookie.net/harrypotter/images/1/17/Chamberofsecrets.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)), // Random date within the last year
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)), // Random date within the last year
                    Publisher = "Bloomsbury Publishing",
                    Language = "English",
                    PageCount = random.Next(200, 400), // Random number of pages between 200 and 399
                    Description = "The second book in the Harry Potter series, where Harry returns to Hogwarts amidst mysterious attacks.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1, // Randomly set to true or false
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Magic", "Wizardry", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1) // Random average rating between 0.0 and 5.0
                },
                new Book
                {
                    Id = 3,
                    Title = "Harry Potter and the Prisoner of Azkaban",
                    Author = "J.K. Rowling",
                    ISBN = "978-0439655484",
                    YearPublished = random.Next(1999, 2001), // Random year between 1999 and 2000
                    Genre = "Fantasy",
                    ImageUrl = "https://static.wikia.nocookie.net/harrypotter/images/3/3e/Harry-Potter-And-The-Prisoner-Of-Azkaban_novel.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)), // Random date within the last year
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)), // Random date within the last year
                    Publisher = "Bloomsbury Publishing",
                    Language = "English",
                    PageCount = random.Next(200, 400), // Random number of pages between 200 and 399
                    Description = "The third book in the Harry Potter series, where Harry learns the truth about his parents' past.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1, // Randomly set to true or false
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Magic", "Wizardry", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1) // Random average rating between 0.0 and 5.0
                },
                new Book
                {
                    Id = 4,
                    Title = "The Fellowship of the Ring",
                    Author = "J.R.R. Tolkien",
                    ISBN = "978-0547928210",
                    YearPublished = random.Next(1954, 1955), // Random year between 1954 and 1954
                    Genre = "Fantasy",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/8/8e/The_Fellowship_of_the_Ring_cover.gif",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Houghton Mifflin",
                    Language = "English",
                    PageCount = random.Next(300, 500),
                    Description = "The first book in the Lord of the Rings series, where a young hobbit embarks on a perilous journey.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fantasy", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 5,
                    Title = "The Two Towers",
                    Author = "J.R.R. Tolkien",
                    ISBN = "978-0547928203",
                    YearPublished = random.Next(1954, 1955),
                    Genre = "Fantasy",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/en/a/a1/The_Two_Towers_cover.gif",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Houghton Mifflin",
                    Language = "English",
                    PageCount = random.Next(300, 500),
                    Description = "The second book in the Lord of the Rings series, where the fellowship faces new challenges.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fantasy", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 6,
                    Title = "The Return of the King",
                    Author = "J.R.R. Tolkien",
                    ISBN = "978-0547928197",
                    YearPublished = random.Next(1955, 1956),
                    Genre = "Fantasy",
                    ImageUrl = "https://en.wikipedia.org/wiki/The_Return_of_the_King#/media/File:The_Return_of_the_King_cover.gif",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Houghton Mifflin",
                    Language = "English",
                    PageCount = random.Next(300, 500),
                    Description = "The final book in the Lord of the Rings series, where the fate of Middle-earth is decided.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fantasy", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 7,
                    Title = "Pride and Prejudice",
                    Author = "Jane Austen",
                    ISBN = "978-1613823701",
                    YearPublished = random.Next(1813, 1814),
                    Genre = "Classics",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/17/PrideAndPrejudiceTitlePage.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "T. Egerton, Whitehall",
                    Language = "English",
                    PageCount = random.Next(200, 400),
                    Description = "A classic novel about love, class, and societal expectations in 19th-century England.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Classics", "Romance" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 8,
                    Title = "Moby-Dick",
                    Author = "Herman Melville",
                    ISBN = "978-0553213119",
                    YearPublished = random.Next(1851, 1852),
                    Genre = "Classics",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/3/36/Moby-Dick_FE_title_page.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Harper & Brothers, New York",
                    Language = "English",
                    PageCount = random.Next(400, 600),
                    Description = "An epic novel about Captain Ahab's relentless pursuit of the white whale, Moby-Dick.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Classics", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 9,
                    Title = "Frankenstein",
                    Author = "Mary Shelley",
                    ISBN = "978-0486282114",
                    YearPublished = random.Next(1818, 1819),
                    Genre = "Classics",
                    ImageUrl = "https://m.media-amazon.com/images/I/81F6mF9efaL._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Lackington, Hughes, Harding, Mavor & Jones",
                    Language = "English",
                    PageCount = random.Next(200, 350),
                    Description = "A Gothic novel about the creation of a creature and the consequences of playing with nature.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Classics", "Gothic" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 10,
                    Title = "The Silmarillion",
                    Author = "J.R.R. Tolkien",
                    ISBN = "978-0618391110",
                    YearPublished = random.Next(1977, 1978),
                    Genre = "Fantasy",
                    ImageUrl = "https://m.media-amazon.com/images/I/51h8UkK-w8L._SL1024_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Houghton Mifflin",
                    Language = "English",
                    PageCount = random.Next(300, 500),
                    Description = "A collection of mythopoeic tales that form the backstory to J.R.R. Tolkien's legendarium, including the creation of Middle-earth and the struggles of its inhabitants.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fantasy", "Mythology" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 11,
                    Title = "The Catcher in the Rye",
                    Author = "J.D. Salinger",
                    ISBN = "978-0316769488",
                    YearPublished = random.Next(1951, 1952),
                    Genre = "Fiction",
                    ImageUrl = "https://m.media-amazon.com/images/I/81W0hu9MrQL._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Little, Brown and Company",
                    Language = "English",
                    PageCount = random.Next(200, 300),
                    Description = "A coming-of-age novel that explores the alienation and disillusionment of a young man in New York City.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fiction", "Coming of Age" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 12,
                    Title = "Moby-Dick",
                    Author = "Herman Melville",
                    ISBN = "978-0142437247",
                    YearPublished = random.Next(1851, 1852),
                    Genre = "Classics",
                    ImageUrl = "https://m.media-amazon.com/images/I/51G2T2elJ6L._SL1000_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Harper & Brothers",
                    Language = "English",
                    PageCount = random.Next(400, 600),
                    Description = "A novel that tells the epic tale of Captain Ahab's obsession with a giant white whale, Moby-Dick.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Classics", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 13,
                    Title = "The Great Gatsby",
                    Author = "F. Scott Fitzgerald",
                    ISBN = "978-0743273565",
                    YearPublished = random.Next(1925, 1926),
                    Genre = "Fiction",
                    ImageUrl = "https://m.media-amazon.com/images/I/51o3F7CdtpL._SL1051_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Charles Scribner's Sons",
                    Language = "English",
                    PageCount = random.Next(150, 250),
                    Description = "A novel set in the Roaring Twenties, exploring themes of wealth, love, and the American Dream.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fiction", "Classic" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 14,
                    Title = "The Hobbit",
                    Author = "J.R.R. Tolkien",
                    ISBN = "978-0547928227",
                    YearPublished = random.Next(1937, 1938),
                    Genre = "Fantasy",
                    ImageUrl = "https://m.media-amazon.com/images/I/71p3j4p9a3L._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "George Allen & Unwin",
                    Language = "English",
                    PageCount = random.Next(200, 350),
                    Description = "A beloved fantasy novel about the adventures of Bilbo Baggins, a hobbit who sets out on a quest.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fantasy", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 15,
                    Title = "The Lord of the Flies",
                    Author = "William Golding",
                    ISBN = "978-0143124290",
                    YearPublished = random.Next(1954, 1955),
                    Genre = "Fiction",
                    ImageUrl = "https://m.media-amazon.com/images/I/91C0SiJ7mxL._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Faber and Faber",
                    Language = "English",
                    PageCount = random.Next(200, 300),
                    Description = "A novel about a group of boys stranded on an uninhabited island and their descent into chaos.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fiction", "Classic" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 16,
                    Title = "Brave New World",
                    Author = "Aldous Huxley",
                    ISBN = "978-0060850524",
                    YearPublished = random.Next(1932, 1933),
                    Genre = "Science Fiction",
                    ImageUrl = "https://m.media-amazon.com/images/I/51oIvzjqQrL._SL1200_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Chatto & Windus",
                    Language = "English",
                    PageCount = random.Next(200, 300),
                    Description = "A dystopian novel that explores a futuristic society driven by technological advancement and control.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Science Fiction", "Dystopian" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 17,
                    Title = "10:04",
                    Author = "Ben Lerner",
                    ISBN = "978-0571322479",
                    YearPublished = random.Next(2014, 2015),
                    Genre = "Fiction",
                    ImageUrl = "https://m.media-amazon.com/images/I/71d5aTdHy7L._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Faber & Faber",
                    Language = "English",
                    PageCount = random.Next(200, 350),
                    Description = "A novel about a writer in Brooklyn who is asked to write a book about art and time.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fiction", "Contemporary" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 18,
                    Title = "Don Quixote",
                    Author = "Miguel de Cervantes",
                    ISBN = "978-0060934347",
                    YearPublished = random.Next(1605, 1606),
                    Genre = "Classics",
                    ImageUrl = "https://m.media-amazon.com/images/I/91bPKTfBpkL._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Harper Perennial",
                    Language = "Spanish",
                    PageCount = random.Next(500, 800),
                    Description = "A satirical novel about a self-proclaimed knight, Don Quixote, and his loyal squire, Sancho Panza.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Classics", "Satire" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 19,
                    Title = "War and Peace",
                    Author = "Leo Tolstoy",
                    ISBN = "978-0143039990",
                    YearPublished = random.Next(1865, 1869),
                    Genre = "Classics",
                    ImageUrl = "https://m.media-amazon.com/images/I/51JLT0J3JTL._SL1053_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Penguin Classics",
                    Language = "Russian",
                    PageCount = random.Next(800, 1200),
                    Description = "A historical novel that explores the lives of Russian aristocrats during the Napoleonic era.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Classics", "Historical Fiction" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 20,
                    Title = "Leaving the Atocha Station",
                    Author = "Ben Lerner",
                    ISBN = "978-1566892748",
                    YearPublished = random.Next(2010, 2011),
                    Genre = "Fiction",
                    ImageUrl = "https://m.media-amazon.com/images/I/81FQ7jutv8L._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Coffee House Press",
                    Language = "English",
                    PageCount = random.Next(150, 250),
                    Description = "A novel about an American poet in Madrid, exploring themes of authenticity and alienation.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fiction", "Literary" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                }                ,
                new Book
                {
                    Id = 21,
                    Title = "The Road",
                    Author = "Cormac McCarthy",
                    ISBN = "978-0307387899",
                    YearPublished = random.Next(2006, 2007),
                    Genre = "Fiction",
                    ImageUrl = "https://m.media-amazon.com/images/I/81iB+fUN2yL._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Vintage",
                    Language = "English",
                    PageCount = random.Next(200, 300),
                    Description = "A post-apocalyptic novel following a father and son's journey in a desolate and dangerous world.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fiction", "Post-Apocalyptic" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 22,
                    Title = "The Shining",
                    Author = "Stephen King",
                    ISBN = "978-0345806789",
                    YearPublished = random.Next(1977, 1978),
                    Genre = "Horror",
                    ImageUrl = "https://m.media-amazon.com/images/I/71aRkaY7gqL._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Anchor",
                    Language = "English",
                    PageCount = random.Next(300, 500),
                    Description = "A psychological horror novel about a family's descent into madness in a haunted hotel.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Horror", "Psychological" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 23,
                    Title = "The Chronicles of Narnia: The Lion, the Witch and the Wardrobe",
                    Author = "C.S. Lewis",
                    ISBN = "978-0060764890",
                    YearPublished = random.Next(1950, 1951),
                    Genre = "Fantasy",
                    ImageUrl = "https://m.media-amazon.com/images/I/71JSzS8STJL._SL1080_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "HarperCollins",
                    Language = "English",
                    PageCount = random.Next(150, 250),
                    Description = "The first book in the classic fantasy series, where four siblings discover a magical world through a wardrobe.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fantasy", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 24,
                    Title = "To Kill a Mockingbird",
                    Author = "Harper Lee",
                    ISBN = "978-0061120084",
                    YearPublished = random.Next(1960, 1961),
                    Genre = "Classics",
                    ImageUrl = "https://m.media-amazon.com/images/I/81mc4QUQx1L._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Harper Perennial Modern Classics",
                    Language = "English",
                    PageCount = random.Next(300, 400),
                    Description = "A powerful novel that addresses issues of racism and injustice in the American South.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Classics", "Social Issues" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 25,
                    Title = "1984",
                    Author = "George Orwell",
                    ISBN = "978-0451524935",
                    YearPublished = random.Next(1949, 1950),
                    Genre = "Classics",
                    ImageUrl = "https://m.media-amazon.com/images/I/81hb+PE4PrL._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Signet Classic",
                    Language = "English",
                    PageCount = random.Next(250, 350),
                    Description = "A dystopian novel that portrays a totalitarian society and the dangers of totalitarianism.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Classics", "Dystopian" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 26,
                    Title = "Dune",
                    Author = "Frank Herbert",
                    ISBN = "978-0441013593",
                    YearPublished = random.Next(1965, 1966),
                    Genre = "Science Fiction",
                    ImageUrl = "https://m.media-amazon.com/images/I/81PbvmCKLWL._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Ace Books",
                    Language = "English",
                    PageCount = random.Next(400, 600),
                    Description = "A science fiction epic set on the desert planet of Arrakis, where a young hero rises to power.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Science Fiction", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 27,
                    Title = "The Girl with the Dragon Tattoo",
                    Author = "Stieg Larsson",
                    ISBN = "978-0307269751",
                    YearPublished = random.Next(2005, 2006),
                    Genre = "Mystery",
                    ImageUrl = "https://m.media-amazon.com/images/I/81kAd8kZvOL._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Knopf",
                    Language = "English",
                    PageCount = random.Next(400, 600),
                    Description = "A gripping mystery novel involving a journalist and a hacker in a cold case investigation.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Mystery", "Thriller" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 28,
                    Title = "All the Light We Cannot See",
                    Author = "Anthony Doerr",
                    ISBN = "978-1501173219",
                    YearPublished = random.Next(2013, 2014),
                    Genre = "Historical Fiction",
                    ImageUrl = "https://m.media-amazon.com/images/I/81RkLxFbQfL._SL1500_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Scribner",
                    Language = "English",
                    PageCount = random.Next(300, 500),
                    Description = "A beautifully written historical novel that weaves together the lives of a blind French girl and a German boy during World War II.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Historical Fiction", "World War II" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 29,
                    Title = "The Name of the Wind",
                    Author = "Patrick Rothfuss",
                    ISBN = "978-0756404741",
                    YearPublished = random.Next(2007, 2008),
                    Genre = "Fantasy",
                    ImageUrl = "https://m.media-amazon.com/images/I/71gYfSWWB6L._SL1200_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "DAW Books",
                    Language = "English",
                    PageCount = random.Next(600, 800),
                    Description = "The first book in the Kingkiller Chronicle series, following the life and adventures of the gifted musician and magician Kvothe.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Fantasy", "Adventure" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                },
                new Book
                {
                    Id = 30,
                    Title = "Sapiens: A Brief History of Humankind",
                    Author = "Yuval Noah Harari",
                    ISBN = "978-0062316097",
                    YearPublished = random.Next(2011, 2012),
                    Genre = "Non-Fiction",
                    ImageUrl = "https://m.media-amazon.com/images/I/51y5lwnN5+L._SL160_.jpg",
                    CreatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    UpdatedDate = utcDateTime.AddDays(-random.Next(1, 365)),
                    Publisher = "Harper",
                    Language = "English",
                    PageCount = random.Next(300, 500),
                    Description = "A thought-provoking exploration of the history and impact of Homo sapiens on the world.",
                    Location = $"Shelf {random.Next(1, 10)}, Row {random.Next(1, 20)}",
                    IsAvailable = random.Next(0, 2) == 1,
                    Borrower = "N/A",
                    DueDate = utcDateTime,
                    Tags = new List<string> { "Non-Fiction", "History" },
                    AverageRating = Math.Round(random.NextDouble() * 5, 1)
                }

                );
            base.OnModelCreating(modelBuilder);
        }


    }
}
