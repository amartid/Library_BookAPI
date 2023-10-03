using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Library_BookAPI.Models.Dto
{
    public class BookDTO
    {
        // Basic properties of Book
        public int Id { get; set; } // Unique identifier for the book

        [Required]
        [MaxLength(40)]
        public required string Title { get; set; } // Title of the book

        public string? Author { get; set; } // Author of the book (nullable)
        public string? ISBN { get; set; } // International Standard Book Number (nullable)
        public int? YearPublished { get; set; } // Year the book was published (nullable)
        public string? Genre { get; set; } // Genre or category of the book (nullable)

        // Additional properties for library management
        public string? ImageUrl { get; set; } // URL to the book's cover image (nullable)
        public string? Publisher { get; set; } // Name of the book's publisher (nullable)
        public string? Language { get; set; } // Language in which the book is written (nullable)
        public int? PageCount { get; set; } // Total number of pages in the book (nullable)
        public string? Description { get; set; } // Brief description or summary of the book (nullable)
        public bool IsAvailable { get; set; } // Flag indicating book availability

        // You can omit DueDate and Tags here since they are not typically part of DTOs.
        // If needed, you can include them in a different way, depending on your use case.
    }
}
