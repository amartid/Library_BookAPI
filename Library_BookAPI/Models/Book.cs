namespace Library_BookAPI.Models
{
// first model is Book
    public class Book
    {
        // properties of Book
        public int Id { get; set; }        // Unique identifier for the book
        public string Title { get; set; }  // Title of the book
        public string Author { get; set; } // Author of the book
        public string ISBN { get; set; }   // International Standard Book Number
        public int YearPublished { get; set; } // Year the book was published
        public string Genre { get; set; }  // Genre or category of the book
        // Not displayed properties             
        public DateTime CreatedDate { get; set; }

    }
}
