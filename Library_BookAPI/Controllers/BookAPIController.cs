using Microsoft.AspNetCore.Mvc;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Numerics;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System;
using Library_BookAPI.Models;
using Library_BookAPI.Models.Dto;
using Library_BookAPI.Data;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.JsonPatch;


namespace Library_BookAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("api/BookAPI")]
    [ApiController]
    // Automatic Model Validation: When a controller is marked with [ApiController], it enables automatic model validation.
    // This means that the framework will automatically validate incoming model data (e.g., from request bodies)
    // and return appropriate validation error responses without the need for explicit validation code.

    // Binding Source: It specifies that the controller should use the[FromBody] attribute as the default binding source
    // for complex types in action parameters.This means that complex objects are expected to be part of the request body by default.

    // Error Handling: It also configures the controller to return problem details in response to common error scenarios,
    // such as 400 Bad Request for model validation errors and 500 Internal Server Error for unhandled exceptions.
    public class BookAPIController : ControllerBase
    // ControllerBase: provides a set of methods and properties that
    // simplify the implementation of controller actions.
    {
        //private readonly ILogger<BookAPIController> _logger; //SeriLog
        // Constructor that receives an ILogger<BookAPIController> as a dependency
        //public BookAPIController(ILogger<BookAPIController> logger) //SeriLog
        //public BookAPIController(ILogger<BookAPIController> logger)
        //{
        //    _logger = logger; // Assign the provided logger to the private _logger field
        //}

        private readonly ApplicationDbContext _db;
        public BookAPIController(ApplicationDbContext db)
        {
            _db = db;
        }




        [HttpGet] // GET endpoint ! RETURNS 1 RECORD
        public ActionResult<IEnumerable<BookDTO>> GetBooks()
        {
            //_logger.LogInformation("Getting all books"); //SeriLog

            return Ok(_db.Books.ToList());
        }
        
        [HttpGet("{id:int}", Name = "GetBook")] // GET endpoint ! RETURNS MULTIPLE RECORD
        [ProducesResponseType(StatusCodes.Status200OK)] // DEFINE RESPONSES
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        // [ProducesResponseType(200, Type = typeof(BookDTO))] 
        public ActionResult<BookDTO> GetBook(int id)
        {
            if(id==0)
            {
                //_logger.LogError("Get Book Error with Id" + id); //SeriLog

                return BadRequest(); // response status is 400 = BAD REQUEST
            }
            var book = _db.Books.FirstOrDefault(u => u.Id == id);//link operation
            if (book == null)
                return NotFound(); // response status is 404 = NOT FOUND

            return Ok(book);
        }
        
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)] // DEFINE RESPONSES
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<BookDTO> CreateBook([FromBody] BookDTO bookDTO)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            // how to add custom validation:
            if (_db.Books.FirstOrDefault(u => u.Title.ToLower() == bookDTO.Title.ToLower()) != null)
            {
                ModelState.AddModelError("Custom Error", "Book already exists !");
                return BadRequest(ModelState);
            }
                
            if (bookDTO == null)  // valid bookDTO object is provided in the request body
            {
                return BadRequest(bookDTO);
            }
            if (bookDTO.Id < 0) // ID less than or equal to zero. When creating the id should be zero
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
            Book model = new()
            {
                Title = bookDTO.Title,
                Author = bookDTO.Author ?? string.Empty,
                ISBN = bookDTO.ISBN ?? string.Empty,
                YearPublished = (bookDTO.YearPublished != null) ? (int)bookDTO.YearPublished : 0,
                Genre = bookDTO.Genre ?? string.Empty,
                ImageUrl = bookDTO.ImageUrl ?? string.Empty,
                Publisher = bookDTO.Publisher ?? string.Empty,
                Language = bookDTO.Language ?? string.Empty,
                PageCount = (bookDTO.PageCount != null) ? (int)bookDTO.PageCount : 0,
                Description = bookDTO.Description ?? string.Empty,
                IsAvailable = bookDTO.IsAvailable
            };
            _db.Books.Add(model);
            _db.SaveChanges();
            return CreatedAtRoute("GetBook", new { id = bookDTO.Id },bookDTO);
        }
        [HttpDelete("{id:int}", Name = "DeleteBook")]
        [ProducesResponseType(StatusCodes.Status204NoContent)] // DEFINE RESPONSES
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult DeleteBook(int id) //with IActionResult you do not define the action type !
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var book = _db.Books.FirstOrDefault(u => u.Id == id);
            if (book == null)  // valid book object is provided in the request body
            {
                return NotFound();
            }
            _db.Books.Remove(book);
            _db.SaveChanges();
            return NoContent();
        }
        [HttpPut("{id:int}", Name = "UpdateBook")]
        [ProducesResponseType(StatusCodes.Status204NoContent)] // DEFINE RESPONSES
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateBook(int id, [FromBody] BookDTO bookDTO)
        {
            if (bookDTO == null || id != bookDTO.Id)
            {
                return BadRequest();
            }
            Book model = new()
            {
                Id = bookDTO.Id,
                Title = bookDTO.Title,
                Author = bookDTO.Author ?? string.Empty,
                ISBN = bookDTO.ISBN ?? string.Empty,
                YearPublished = (bookDTO.YearPublished != null) ? (int)bookDTO.YearPublished : 0,
                Genre = bookDTO.Genre ?? string.Empty,
                ImageUrl = bookDTO.ImageUrl ?? string.Empty,
                Publisher = bookDTO.Publisher ?? string.Empty,
                Language = bookDTO.Language ?? string.Empty,
                PageCount = (bookDTO.PageCount != null) ? (int)bookDTO.PageCount : 0,
                Description = bookDTO.Description ?? string.Empty,
                IsAvailable = bookDTO.IsAvailable
            };
            _db.Books.Update(model);
            _db.SaveChanges();
            //var book = BookStore.bookList.FirstOrDefault(u => u.Id == id);
            //book.Title = bookDTO.Title;
            //book.Author = bookDTO.Author;
            //book.ISBN = bookDTO.ISBN;
            //book.YearPublished = bookDTO.YearPublished;
            //book.Genre = bookDTO.Genre;
            return NoContent();


        }

        [HttpPatch("{id:int}", Name = "UpdatePartialBook")]
        [ProducesResponseType(StatusCodes.Status204NoContent)] // DEFINE RESPONSES
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePartialBook(int id, JsonPatchDocument<BookDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }

            var book = _db.Books.FirstOrDefault(u => u.Id == id);

            if (book == null)
            {
                return NotFound(); // Return a 404 status if the book with the given ID is not found.
            }

            // Create a new BookDTO instance and populate it with the existing book's data.
            var bookDTO = new BookDTO
            {
                Title = book.Title,
                Author = book.Author ?? string.Empty,
                ISBN = book.ISBN ?? string.Empty,
                YearPublished = book.YearPublished,
                Genre = book.Genre ?? string.Empty,
                ImageUrl = book.ImageUrl ?? string.Empty,
                Publisher = book.Publisher ?? string.Empty,
                Language = book.Language ?? string.Empty,
                PageCount = book.PageCount,
                Description = book.Description ?? string.Empty,
                IsAvailable = book.IsAvailable
            };

            // Apply the patch operations to the bookDTO.
            patchDTO.ApplyTo(bookDTO, ModelState);

            // Check if the ModelState is valid after applying the patch.
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            // Update the database with the modified bookDTO data.
            book.Title = bookDTO.Title;
            book.Author = bookDTO.Author;
            book.ISBN = bookDTO.ISBN;
            book.YearPublished = (int)bookDTO.YearPublished;
            book.Genre = bookDTO.Genre;
            book.ImageUrl = bookDTO.ImageUrl;
            book.Publisher = bookDTO.Publisher;
            book.Language = bookDTO.Language;
            book.PageCount = (int)bookDTO.PageCount;
            book.Description = bookDTO.Description;
            book.IsAvailable = bookDTO.IsAvailable;

            _db.Books.Update(book);
            _db.SaveChanges();

            return NoContent();
        }

    }
}
