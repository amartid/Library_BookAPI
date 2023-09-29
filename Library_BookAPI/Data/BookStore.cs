using Library_BookAPI.Models.Dto;

namespace Library_BookAPI.Data
{
    public static class BookStore
    {
        public static List<BookDTO> bookList = new List<BookDTO>
        {
            new BookDTO
            {
                Id = 1,
                Title = "Don Quixote",
                Author = "Miguel de Cervantes",
                ISBN = "978-0142437230",
                YearPublished = 1605,
                Genre = "Fiction"
            },
            new BookDTO
            {
                Id = 2,
                Title = "Moby Dick",
                Author = "Herman Melville",
                ISBN = "978-1853260087",
                YearPublished = 1851,
                Genre = "Adventure"
            }
        };
    }
}
