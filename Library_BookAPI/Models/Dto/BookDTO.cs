using System.ComponentModel.DataAnnotations;

namespace Library_BookAPI.Models.Dto
{
    public class BookDTO
    {
        // properties of Book
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int YearPublished { get; set; }
        public string Genre { get; set; }
    }
}
