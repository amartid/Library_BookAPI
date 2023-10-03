using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library_BookAPI.Models
{
    public class Book
    {
        public Book()
        {
            // Initialize properties with default values to ensure non-null values.

            // Basic properties of Book
            Title = "";
            Author = "";
            ISBN = "";
            YearPublished = 0;
            Genre = "";
            ImageUrl = "";

            // Not displayed properties
            CreatedDate = DateTime.MinValue.ToUniversalTime(); // Set to UTC
            UpdatedDate = DateTime.MinValue.ToUniversalTime(); // Set to UTC

            // Additional properties for library management
            Publisher = "";
            Language = "";
            PageCount = 0;
            Description = "";
            Location = "";
            IsAvailable = false;
            Borrower = "";
            DueDate = DateTime.MinValue.ToUniversalTime(); // Set to UTC
            Tags = new List<string>();
            AverageRating = 0.0;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int YearPublished { get; set; }
        public string Genre { get; set; }
        public string ImageUrl { get; set; }

        [Column(TypeName = "timestamp with time zone")]
        public DateTime CreatedDate { get; set; }

        [Column(TypeName = "timestamp with time zone")]
        public DateTime UpdatedDate { get; set; }

        public string Publisher { get; set; }
        public string Language { get; set; }
        public int PageCount { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public bool IsAvailable { get; set; }
        public string Borrower { get; set; }

        [Column(TypeName = "timestamp with time zone")]
        public DateTime DueDate { get; set; }

        public List<string> Tags { get; set; }
        public double AverageRating { get; set; }
    }
}
